using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;
using RestSharp;

namespace Salesforce.MarketingCloud.Authentication
{
    internal class AuthService : IAuthService
    {
        private readonly Configuration configuration;
        private readonly IApiClient apiClient;
        private readonly ICacheService cacheService;

        internal AuthService(Configuration configuration, IApiClient apiClient, ICacheService cacheService)
        {
            this.configuration = configuration;
            this.apiClient = apiClient;
            this.cacheService = cacheService;
        }
        public AuthorizationToken GetAuthorizationToken()
        {
            var cacheKey = GetCacheKey();
            var cachedValue = cacheService.Get(cacheKey);

            if (cachedValue == null)
            {
                apiClient.Configuration = configuration;

                var response = GetAccessTokenResponse();

                SetConfigParameters(response);
                cacheService.AddOrUpdate(cacheKey, response);

                return new AuthorizationToken(response.AccessToken, response.TokenType);
            }
            else
            {
                SetConfigParameters(cachedValue);
                return new AuthorizationToken(cachedValue.AccessToken, cachedValue.TokenType);
            }
        }

        private AccessTokenResponse GetAccessTokenResponse()
        {
            var accessTokenRequest = new AccessTokenRequest(configuration.ClientId, configuration.ClientSecret, configuration.AccountId, configuration.Scope);
            var authRequestBody = GetAuthRequestBody(accessTokenRequest);

            var serializedAuthRequestBody =
                apiClient.Serialize(authRequestBody);

            IRestResponse authRequestResponse = (IRestResponse) apiClient.CallApi("/v2/token",
                Method.POST,
                new List<KeyValuePair<string, string>>(),
                serializedAuthRequestBody,
                RuntimeInformationProvider.ClientEnvironmentRuntimeInformation,
                new Dictionary<string, string>(),
                new Dictionary<string, FileParameter>(),
                new Dictionary<string, string>(),
                "application/json");

            var exceptionFactory = Configuration.DefaultExceptionFactory;
            if (exceptionFactory != null)
            {
                Exception exception = exceptionFactory("GetAuthorizationToken", authRequestResponse);
                if (exception != null) throw exception;
            }

            var response =
                (AccessTokenResponse) configuration.ApiClient.Deserialize(authRequestResponse,
                    typeof(AccessTokenResponse));
            return response;
        }

        private JObject GetAuthRequestBody(AccessTokenRequest accessTokenRequest)
        {
            JObject authRequestBody = new JObject();

            authRequestBody.Add("client_id", accessTokenRequest.ClientId);
            authRequestBody.Add("client_secret", accessTokenRequest.ClientSecret);
            authRequestBody.Add("grant_type", accessTokenRequest.GrantType);
            authRequestBody.Add("account_id", accessTokenRequest.AccountId);

            if (!string.IsNullOrEmpty(accessTokenRequest.Scope))
            {
                authRequestBody.Add("scope", accessTokenRequest.Scope);
            }

            return authRequestBody;
        }

        private void SetConfigParameters(AccessTokenResponse response)
        {
            configuration.RestInstanceUrl = response.RestInstanceUrl;
            configuration.SoapInstanceUrl = response.SoapInstanceUrl;
            configuration.BasePath = response.RestInstanceUrl;
        }

        private string GetCacheKey()
        {
            return configuration.ClientId + "-" + configuration.AccountId;
        }
    }
}