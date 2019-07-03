/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Model;
using Newtonsoft.Json;

namespace Salesforce.MarketingCloud.Test
{
    /// <summary>
    ///  Class for testing CampaignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CampaignApiTests //: ApiTests
    {
        private CampaignApi instance;

        /// <summary>
        /// Setup only once before all the tests
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            //instance = new CampaignApi(authBasePath, clientId, clientSecret, accountId);
            instance = ClientFactory.Create().CampaignApi;
        }

        [Test]
        public void GetCampaignByIdTest()
        {
            var campaign = CreateCampaign();
            var createCampaignResult = instance.CreateCampaign(campaign);
            var campaignToRetrieveId = createCampaignResult.Id;

            var getCampaignResult = instance.GetCampaignById(campaignToRetrieveId);

            try
            {
                Assert.AreEqual(campaign.Name, getCampaignResult.Name);
                Assert.AreEqual(campaign.Description, getCampaignResult.Description);
                Assert.AreEqual(campaign.CampaignCode, getCampaignResult.CampaignCode);
                Assert.AreEqual(campaign.Color, getCampaignResult.Color);
                Assert.AreEqual(campaign.Favorite, getCampaignResult.Favorite);
        }
            finally
            {
                instance.DeleteCampaignById(campaignToRetrieveId);
            }
        }

        [Test]
        public void CreateCampaignTest()
        {
            var campaign = CreateCampaign();
            var createCampaignResult = instance.CreateCampaign(campaign);

            try
            {
            Assert.AreEqual(campaign.Name, createCampaignResult.Name);
            Assert.AreEqual(campaign.Description, createCampaignResult.Description);
            Assert.AreEqual(campaign.CampaignCode, createCampaignResult.CampaignCode);
            Assert.AreEqual(campaign.Color, createCampaignResult.Color);
            Assert.AreEqual(campaign.Favorite, createCampaignResult.Favorite);
        }
            finally
            {
                var createCampaignResultId = createCampaignResult.Id;
                instance.DeleteCampaignById(createCampaignResultId);
            }
        }

        [Test]
        public void DeleteCampaignByIdTest()
        {
            var campaign = CreateCampaign();
            var createCampaignResult = instance.CreateCampaign(campaign);

            var campaignToDeleteId = createCampaignResult.Id;
            instance.DeleteCampaignById(campaignToDeleteId);

            try
            {
                instance.GetCampaignById(campaignToDeleteId);
                Assert.Fail("No exception thrown");
        }
            catch (ApiException e)
            {
                var deserializedException = JsonConvert.DeserializeObject<ApiError>(e.ErrorContent);

                Assert.AreEqual(400, e.ErrorCode);
                Assert.AreEqual("Campaign does not exist", deserializedException.Message);
            }
        }

        private Campaign CreateCampaign()
        {
            var name = "CampaignName";
            var description = "CampaignDescription";
            var campaignCode = "CampaignCode";
            var color = "0000ff";
            var favorite = false;

            var campaign = new Campaign(name, description, campaignCode, color, favorite);

            return campaign;
        }
    }
}
