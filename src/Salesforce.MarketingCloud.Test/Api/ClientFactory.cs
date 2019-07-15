using System;

namespace Salesforce.MarketingCloud.Test
{
    public static class ClientFactory
    {
        private static ConfigProvider configProvider;
        private static string authBasePath;
        private static string clientId;
        private static string clientSecret;
        private static string accountId;
        private static string scope;

        static ClientFactory()
        {
            configProvider = new ConfigProvider();

            authBasePath = configProvider.AuthBasePath;
            clientId = configProvider.ClientId;
            clientSecret = configProvider.ClientSecret;
            accountId = configProvider.AccountId;
            scope = configProvider.Scope;
        }

        internal static Api.Client Create()
        {
            return new Api.Client(authBasePath, clientId, clientSecret, accountId, scope);
        }
    }
}