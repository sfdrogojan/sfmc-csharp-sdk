using System;

namespace Salesforce.MarketingCloud.Test
{
    public static class ApiTestSutFactory<T>
    {
        private static ConfigProvider configProvider;
        private static string authBasePath;
        private static string clientId;
        private static string clientSecret;
        private static string accountId;
        private static string scope;


        static ApiTestSutFactory()
        {
            configProvider = new ConfigProvider();

            authBasePath = configProvider.AuthBasePath;
            clientId = configProvider.ClientId;
            clientSecret = configProvider.ClientSecret;
            accountId = configProvider.AccountId;
            scope = configProvider.Scope;
        }

        internal static T Create()
        {
            return (T)Activator.CreateInstance(typeof(T), authBasePath, clientId, clientSecret, accountId, scope);
        }
    }
}