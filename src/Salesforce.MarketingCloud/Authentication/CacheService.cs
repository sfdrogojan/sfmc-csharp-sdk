﻿using System;
using System.Collections.Concurrent;
using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.Authentication
{
    internal class CacheService : ICacheService
    {
        internal static ConcurrentDictionary<string, Tuple<TokenResponse, DateTime>> cache;
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly int invalidCacheWindowInSeconds = 5 * 60;

        static CacheService()
        {
            cache = new ConcurrentDictionary<string, Tuple<TokenResponse, DateTime>>();
        }

        public CacheService(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public TokenResponse Get(string key)
        {
            Tuple<TokenResponse, DateTime> value;
            if (cache.TryGetValue(key, out value))
            {
                if (value.Item2 > dateTimeProvider.Now)
                    return value.Item1;
            }
            return null;
        }

        public void AddOrUpdate(string key, TokenResponse value)
        {

            var expirationTime = dateTimeProvider.Now.AddSeconds(value.ExpiresIn).Subtract(TimeSpan.FromSeconds(invalidCacheWindowInSeconds));
            var valueToAdd = new Tuple<TokenResponse, DateTime>(value, expirationTime);
            cache.AddOrUpdate(key, (cacheKey) => valueToAdd, (cacheKey, existingCacheValue) => valueToAdd);
        }
    }
}