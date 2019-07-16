using System;
using System.Reflection.Metadata.Ecma335;

namespace Salesforce.MarketingCloud.Test
{
    public class ConfigProvider
    {
        private static readonly string authBasePath;
        private static readonly string clientId;
        private static readonly string clientSecret;
        private static readonly string accountId;
        private static readonly string scope;
        private static readonly string shortCode;
        private static readonly string keyword;

        static ConfigProvider()
        {
            authBasePath = GetAccountDetailsEnvironmentVariableValue("SFMC_AUTH_BASE_PATH");
            clientId = GetAccountDetailsEnvironmentVariableValue("SFMC_CLIENT_ID");
            clientSecret = GetAccountDetailsEnvironmentVariableValue("SFMC_CLIENT_SECRET");
            accountId = GetAccountDetailsEnvironmentVariableValue("SFMC_ACCOUNT_ID");
            scope = GetAccountDetailsEnvironmentVariableValue("SFMC_SCOPE", false);
            shortCode = GetAccountDetailsEnvironmentVariableValue("SFMC_SHORT_CODE");
            keyword = GetAccountDetailsEnvironmentVariableValue("SFMC_KEYWORD");
        }

        public string AuthBasePath => authBasePath;
        public string ClientId => clientId;
        public string ClientSecret => clientSecret;
        public string AccountId => accountId;
        public string Scope => scope;
        public string ShortCode => shortCode;
        public string Keyword => keyword;


        private static string GetAccountDetailsEnvironmentVariableValue(string envVariableName, bool mandatory = true)
        {
            var accountDetailsEnvironmentVariableValue =
                Environment.GetEnvironmentVariable(envVariableName,
                    EnvironmentVariableTarget.Machine);
            if (accountDetailsEnvironmentVariableValue != null)
            {
                return accountDetailsEnvironmentVariableValue;
            }

            accountDetailsEnvironmentVariableValue =
                Environment.GetEnvironmentVariable(envVariableName,
                    EnvironmentVariableTarget.User);
            if (accountDetailsEnvironmentVariableValue != null)
            {
                return accountDetailsEnvironmentVariableValue;
            }

            accountDetailsEnvironmentVariableValue =
                Environment.GetEnvironmentVariable(envVariableName,
                    EnvironmentVariableTarget.Process);
            if (accountDetailsEnvironmentVariableValue != null)
            {
                return accountDetailsEnvironmentVariableValue;
            }

            if (mandatory)
            {
                throw new NullReferenceException($"Env variable {envVariableName} missing.");
            }

            return string.Empty;
        }
    }
}