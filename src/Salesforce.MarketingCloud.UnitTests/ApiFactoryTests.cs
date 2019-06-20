using NUnit.Framework;
using Salesforce.MarketingCloud.Api;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class ApiFactoryTests
    {
        [Test]
        public void Create_CalledMultipleTimeOnSameInstance_ReturnsSameApiInstance()
        {
            ApiFactory apiFactory = CreateApiFactory();

            var instance1 = apiFactory.Create<AssetApi>();
            var instance2 = apiFactory.Create<AssetApi>();

            Assert.AreSame(instance1, instance2);
        }

        [Test]
        public void Create_CalledOnDifferentInstancesWithSameParameters_ReturnsSameApiInstance()
        {
            ApiFactory apiFactory1 = CreateApiFactory();
            ApiFactory apiFactory2 = CreateApiFactory();

            var instance1 = apiFactory1.Create<AssetApi>();
            var instance2 = apiFactory2.Create<AssetApi>();

            Assert.AreSame(instance1, instance2);
        }

        [Test]
        public void Create_CalledOnDifferentInstancesWithDifferentClientIds_ReturnsDifferentApiInstances()
        {
            ApiFactory apiFactory1 = CreateApiFactory("http://auth.com", "clientId1");
            ApiFactory apiFactory2 = CreateApiFactory("http://auth.com", "clientId2");

            var instance1 = apiFactory1.Create<AssetApi>();
            var instance2 = apiFactory2.Create<AssetApi>();

            Assert.AreNotSame(instance1, instance2);
        }

        [Test]
        public void Create_CalledOnDifferentInstancesWithDifferentAccountIds_ReturnsDifferentApiInstances()
        {
            ApiFactory apiFactory1 = CreateApiFactory("http://auth.com", "clientId", "clientSecret", "12345");
            ApiFactory apiFactory2 = CreateApiFactory("http://auth.com", "clientId", "clientSecret", "67890");

            var instance1 = apiFactory1.Create<AssetApi>();
            var instance2 = apiFactory2.Create<AssetApi>();

            Assert.AreNotSame(instance1, instance2);
        }

        [Test]
        public void Create_CalledOnDifferentInstancesWithDifferentScopes_ReturnsDifferentApiInstances()
        {
            ApiFactory apiFactory1 = CreateApiFactory("http://auth.com", "clientId", "clientSecret", "12345", "scope1");
            ApiFactory apiFactory2 = CreateApiFactory("http://auth.com", "clientId", "clientSecret", "12345", "scope2");

            var instance1 = apiFactory1.Create<AssetApi>();
            var instance2 = apiFactory2.Create<AssetApi>();

            Assert.AreNotSame(instance1, instance2);
        }

        private static ApiFactory CreateApiFactory(
            string authBasePath = "https://auth.com",
            string clientId = "clientId",
            string clientSecret = "clientSecret",
            string accountId = "12345",
            string scope = "")
        {
            return new ApiFactory(authBasePath, clientId, clientSecret, accountId, scope);
        }
    }
}