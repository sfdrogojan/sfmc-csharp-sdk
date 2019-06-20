using System;
using System.Collections.Generic;

namespace Salesforce.MarketingCloud.Api
{
    public class ApiFactory
    {
        private static readonly Dictionary<string, Dictionary<Type, object>> apiInstancesByCredentials = new Dictionary<string, Dictionary<Type, object>>();
        private readonly string authBasePath;
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string accountId;
        private readonly string scope;
        private readonly string apiInstanceKey;
        private Dictionary<Type, object> clientApiIntances;

        public ApiFactory(string authBasePath, string clientId, string clientSecret, string accountId, string scope)
        {
            this.authBasePath = authBasePath;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.accountId = accountId;
            this.scope = scope;
            this.apiInstanceKey = $"{clientId}-{accountId}-{scope}";
            if (!apiInstancesByCredentials.ContainsKey(this.apiInstanceKey))
            {
                apiInstancesByCredentials.Add(apiInstanceKey, new Dictionary<Type, object>());
            }
        }

        public T Create<T>()
        {
            clientApiIntances = apiInstancesByCredentials[apiInstanceKey];

            if (clientApiIntances.ContainsKey(typeof(T)))
            {
                return (T)clientApiIntances[typeof(T)];
            }

            var apiInstance = (T)Activator.CreateInstance(
                typeof(T), 
                authBasePath, 
                clientId, 
                clientSecret, 
                accountId, 
                scope
            );

            clientApiIntances.Add(typeof(T), apiInstance);

            return apiInstance;
        }
    }
}