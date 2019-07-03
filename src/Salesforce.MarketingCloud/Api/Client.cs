namespace Salesforce.MarketingCloud.Api
{
    public class Client
    {
        private readonly string authBasePath;
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string accountId;
        private readonly string scope;

        public Client(string authBasePath, string clientId, string clientSecret, string accountId, string scope)
        {
            this.authBasePath = authBasePath;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.accountId = accountId;
            this.scope = scope;
        }

        private AssetApi assetApi;
        public AssetApi AssetApi
        {
            get => this.assetApi ?? (this.assetApi = new AssetApi(this.authBasePath, this.clientId, this.clientSecret, this.accountId, this.scope));
            internal set => this.assetApi = value;
        }
        private CampaignApi campaignApi;
        public CampaignApi CampaignApi
        {
            get => this.campaignApi ?? (this.campaignApi = new CampaignApi(this.authBasePath, this.clientId, this.clientSecret, this.accountId, this.scope));
            internal set => this.campaignApi = value;
        }
        private EmailDefinitionApi emailDefinitionApi;
        public EmailDefinitionApi EmailDefinitionApi
        {
            get => this.emailDefinitionApi ?? (this.emailDefinitionApi = new EmailDefinitionApi(this.authBasePath, this.clientId, this.clientSecret, this.accountId, this.scope));
            internal set => this.emailDefinitionApi = value;
        }
    }
}