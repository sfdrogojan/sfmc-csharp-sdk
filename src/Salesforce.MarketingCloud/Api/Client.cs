namespace Salesforce.MarketingCloud.Api
{
    public class Client
    {
        private readonly string authBasePath;
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string accountId;
        private readonly string scope;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="authBasePath">Your tenant-specific Authentication Base URI.</param>
        /// <param name="clientId">Client ID issued when you create the API integration in Installed Packages.</param>
        /// <param name="clientSecret">Client secret issued when you create the API integration in Installed Packages.</param>
        /// <param name="accountId">Account identifier, or MID, of the target business unit. Use to switch between business units.</param>
        /// <param name="scope">Space-separated list of data-access permissions for your application.</param>
        public Client(string authBasePath, string clientId, string clientSecret, string accountId, string scope = null)
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
        private TransactionalMessagingApi transactionalMessagingApi;
        public TransactionalMessagingApi TransactionalMessagingApi
        {
            get => this.transactionalMessagingApi ?? (this.transactionalMessagingApi = new TransactionalMessagingApi(this.authBasePath, this.clientId, this.clientSecret, this.accountId, this.scope));
            internal set => this.transactionalMessagingApi = value;
        }
    }
}