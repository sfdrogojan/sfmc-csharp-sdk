using System;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;
using Salesforce.MarketingCloud.Validation;

namespace Salesforce.MarketingCloud.UnitTests
{
    [TestFixture]
    public class ApiClientTests
    {
        [Test]
        public void Serialize_WhenModelIsInvalid_ThrowsModelValidationException()
        {
            ApiClient apiClient = new ApiClient();
            var asset = CreateAsset("N", "D");
            try
            {
                apiClient.Serialize(asset);
            }
            catch (ModelValidationException e)
            {
                Console.WriteLine(e);
                return;
            }
            Assert.Fail("ModelValidationException was not thrown");
        }

        private Asset CreateAsset(string name, string description = "Description")
        {
            var customerKey = Guid.NewGuid().ToString();
            var assetType = new AssetType(196, "textblock", "Text Block");

            var asset = new Asset(null, customerKey, null, null, assetType, null, null, null, name, description);

            return asset;
        }
    }
}