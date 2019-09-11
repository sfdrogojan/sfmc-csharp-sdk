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
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.Test
{
    /// <summary>
    ///  Class for testing TransactionalMessagingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionalMessagingApiTests
    {
        private TransactionalMessagingApi transactionalMessagingApiClient;
        private AssetApi assetApiClient;
        private ConfigProvider configProvider;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            transactionalMessagingApiClient = ClientFactory.Create().TransactionalMessagingApi;
            assetApiClient = ClientFactory.Create().AssetApi;

            configProvider = new ConfigProvider();
        }

        [Test]
        public void GetEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailDefinitionToRetrieveKey = createEmailDefinitionResult.DefinitionKey;

            var getEmailDefinitionResult = transactionalMessagingApiClient.GetEmailDefinition(emailDefinitionToRetrieveKey);

            try
            {
                Assert.AreEqual(emailDefinition.DefinitionKey, getEmailDefinitionResult.DefinitionKey);
                Assert.AreEqual(emailDefinition.Name, getEmailDefinitionResult.Name);
                Assert.AreEqual(emailDefinition.Content.CustomerKey, getEmailDefinitionResult.Content.CustomerKey);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailDefinitionToRetrieveKey);
            }
        }

        [Test]
        public void CreateEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);

            try
            {
                Assert.AreEqual(emailDefinition.DefinitionKey, createEmailDefinitionResult.DefinitionKey);
                Assert.AreEqual(emailDefinition.Name, createEmailDefinitionResult.Name);
                Assert.AreEqual(emailDefinition.Content.CustomerKey, createEmailDefinitionResult.Content.CustomerKey);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(createEmailDefinitionResult.DefinitionKey);
            }
        }

        [Test]
        public void PartiallyUpdateEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailDefinitionToPartiallyUpdateKey = createEmailDefinitionResult.DefinitionKey;

            var updatedDefinitionDescription = new UpdateEmailDefinitionRequest(description: "Updated email definition description");

            var partiallyUpdateEmailDefinitionResult = transactionalMessagingApiClient.PartiallyUpdateEmailDefinition(emailDefinitionToPartiallyUpdateKey, updatedDefinitionDescription);

            try
            {
                Assert.AreEqual(updatedDefinitionDescription.Description, partiallyUpdateEmailDefinitionResult.Description);

                Assert.AreEqual(emailDefinition.DefinitionKey, partiallyUpdateEmailDefinitionResult.DefinitionKey);
                Assert.AreEqual(emailDefinition.Name, partiallyUpdateEmailDefinitionResult.Name);
                Assert.AreEqual(emailDefinition.Content.CustomerKey, partiallyUpdateEmailDefinitionResult.Content.CustomerKey);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailDefinitionToPartiallyUpdateKey);
            }
        }

        [Test]
        public void DeleteEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailDefinitionToDeleteKey = createEmailDefinitionResult.DefinitionKey;

            var deleteEmailDefinitionResult = transactionalMessagingApiClient.DeleteEmailDefinition(emailDefinitionToDeleteKey);

            Assert.NotNull(deleteEmailDefinitionResult.RequestId);
            Assert.NotNull(deleteEmailDefinitionResult.DeletedDefinitionKey);
            Assert.AreEqual("Success", deleteEmailDefinitionResult.Message);
        }

        [Test]
        public void DeleteNonExistingEmailDefinitionTest()
        {
            var emailDefinitionToDeleteKey = "NonExistingEmailDefinitionKey";

            try
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailDefinitionToDeleteKey);
            }
            catch (ApiException e)
            {
                var deserializedException = JsonConvert.DeserializeObject<ApiError>(e.ErrorContent);
                Assert.AreEqual($"FuelRuntime_ObjectNotFound: Unable to find Definition {emailDefinitionToDeleteKey}", deserializedException.Message);
            }
        }

        [Test]
        public void GetEmailDefinitionsTest()
        {
            var getEmailDefinitionsResult = transactionalMessagingApiClient.GetEmailDefinitions();

            Assert.IsNotNull(getEmailDefinitionsResult.RequestId);
            Assert.IsNotNull(getEmailDefinitionsResult.Definitions);
            Assert.IsNotNull(getEmailDefinitionsResult.Count);
            Assert.IsNotNull(getEmailDefinitionsResult.Page);
            Assert.IsNotNull(getEmailDefinitionsResult.PageSize);
        }

        [Test]
        public void GetQueueMetricsForEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailDefinitionQueueMetricsToReceiveKey = createEmailDefinitionResult.DefinitionKey;
            
            var getQueueMetricsForEmailDefinitionResult = transactionalMessagingApiClient.GetQueueMetricsForEmailDefinition(emailDefinitionQueueMetricsToReceiveKey);

            try
            {
                Assert.IsNotNull(getQueueMetricsForEmailDefinitionResult.RequestId);
                Assert.IsNotNull(getQueueMetricsForEmailDefinitionResult.Count);
                Assert.IsNotNull(getQueueMetricsForEmailDefinitionResult.AgeSeconds);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailDefinitionQueueMetricsToReceiveKey);
            }
        }

        [Test]
        public void DeleteQueuedMessagesForEmailDefinitionTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            emailDefinition.Status = "inactive"; // Definition status must be inactive to delete queue

            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);

            var emailDefinitionQueToDeleteKey = createEmailDefinitionResult.DefinitionKey;
            var deleteQueuedMessagesForEmailDefinitionResult = transactionalMessagingApiClient.DeleteQueuedMessagesForEmailDefinition(emailDefinitionQueToDeleteKey);

            Assert.NotNull(deleteQueuedMessagesForEmailDefinitionResult.RequestId);
        }

        [Test]
        public void SendEmailToMultipleRecipientsTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailToSendToRecipientsKey = createEmailDefinitionResult.DefinitionKey;

            var recipientsList = new List<Recipient>()
            {
                new Recipient("johnDoe@gmail.com"),
                new Recipient("johannaDoe@yahoo.com")
            };

            var batchMessageRequestBody = new SendEmailToMultipleRecipientsRequest(emailToSendToRecipientsKey, recipientsList);
            var sendEmailToMultipleRecipientsResult =
                transactionalMessagingApiClient.SendEmailToMultipleRecipients(batchMessageRequestBody);

            try
            {
                Assert.NotNull(sendEmailToMultipleRecipientsResult.RequestId);
                Assert.NotNull(sendEmailToMultipleRecipientsResult.Errorcode);
                Assert.NotNull(sendEmailToMultipleRecipientsResult.Responses);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailToSendToRecipientsKey);
            }
        }

        [Test]
        public void SendEmailToSingleRecipientTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailToSendToRecipientKey = createEmailDefinitionResult.DefinitionKey;

            var recipient = new Recipient("johnDoe@gmail.com");
            var messageKey = Guid.NewGuid().ToString();

            var messageRequestBody = new SendEmailToSingleRecipientRequest(emailToSendToRecipientKey, recipient);
            var sendEmailToSingleRecipientResult =
                transactionalMessagingApiClient.SendEmailToSingleRecipient(messageKey, messageRequestBody);

            try
            {
                Assert.NotNull(sendEmailToSingleRecipientResult.RequestId);
                Assert.NotNull(sendEmailToSingleRecipientResult.Errorcode);
                Assert.NotNull(sendEmailToSingleRecipientResult.Responses);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailToSendToRecipientKey);
            }
        }

        [Test]
        public void GetEmailSendStatusForRecipientTest()
        {
            var emailDefinition = CreateEmailDefinitionObject();
            var createEmailDefinitionResult = transactionalMessagingApiClient.CreateEmailDefinition(emailDefinition);
            var emailToSendToRecipientKey = createEmailDefinitionResult.DefinitionKey;

            var recipient = new Recipient("johnDoe@gmail.com");
            var messageKey = Guid.NewGuid().ToString();

            var messageRequestBody = new SendEmailToSingleRecipientRequest(emailToSendToRecipientKey, recipient);
            transactionalMessagingApiClient.SendEmailToSingleRecipient(messageKey, messageRequestBody);

            var getEmailSendStatusForRecipientResult =
                transactionalMessagingApiClient.GetEmailSendStatusForRecipient(messageKey);

            try
            {
                Assert.NotNull(getEmailSendStatusForRecipientResult.RequestId);
                Assert.NotNull(getEmailSendStatusForRecipientResult.Timestamp);

                var eventCategoryTypes = new Collection<string>()
                {
                    "TransactionalSendEvents.EmailSent",
                    "TransactionalSendEvents.EmailQueued",
                    "TransactionalSendEvents.EmailNotSent"
                };

                CollectionAssert.Contains(eventCategoryTypes, getEmailSendStatusForRecipientResult.EventCategoryType);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteEmailDefinition(emailToSendToRecipientKey);
            }
        }

        [Test]
        public void GetEmailsNotSentToRecipientsTest()
        {
            var getEmailsNotSentToRecipientsResponse = transactionalMessagingApiClient.GetEmailsNotSentToRecipients("notSent");

            Assert.IsNotNull(getEmailsNotSentToRecipientsResponse.RequestId);
            Assert.IsNotNull(getEmailsNotSentToRecipientsResponse.LastEventID);
            Assert.IsNotNull(getEmailsNotSentToRecipientsResponse.Messages);
            Assert.IsNotNull(getEmailsNotSentToRecipientsResponse.Count);
            Assert.IsNotNull(getEmailsNotSentToRecipientsResponse.PageSize);
        }

        [Test]
        public void GetSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsDefinitionToRetrieveKey = createSmsDefinitionResult.DefinitionKey;

            var getSmsDefinitionResult = transactionalMessagingApiClient.GetSmsDefinition(smsDefinitionToRetrieveKey);

            try
            {
                Assert.AreEqual(smsDefinition.DefinitionKey, getSmsDefinitionResult.DefinitionKey);
                Assert.AreEqual(smsDefinition.Name, getSmsDefinitionResult.Name);
                Assert.AreEqual(smsDefinition.Subscriptions.ShortCode, getSmsDefinitionResult.Subscriptions.ShortCode);
                Assert.AreEqual(smsDefinition.Subscriptions.CountryCode, getSmsDefinitionResult.Subscriptions.CountryCode);
                Assert.AreEqual(smsDefinition.Content, getSmsDefinitionResult.Content);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsDefinitionToRetrieveKey);
            }
        }

        [Test]
        public void CreateSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);

            try
            {
                Assert.AreEqual(smsDefinition.DefinitionKey, createSmsDefinitionResult.DefinitionKey);
                Assert.AreEqual(smsDefinition.Name, createSmsDefinitionResult.Name);
                Assert.AreEqual(smsDefinition.Subscriptions.ShortCode, createSmsDefinitionResult.Subscriptions.ShortCode);
                Assert.AreEqual(smsDefinition.Subscriptions.CountryCode, createSmsDefinitionResult.Subscriptions.CountryCode);
                Assert.AreEqual(smsDefinition.Content, createSmsDefinitionResult.Content);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(createSmsDefinitionResult.DefinitionKey);
            }
        }

        [Test]
        public void PartiallyUpdateSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsDefinitionToPartiallyUpdateKey = createSmsDefinitionResult.DefinitionKey;

            var updatedDefinitionDescription =
                new UpdateSmsDefinitionRequest(description: "Updated SMS definition description");

            var partiallyUpdateSmsDefinitionResult =
                transactionalMessagingApiClient.PartiallyUpdateSmsDefinition(smsDefinitionToPartiallyUpdateKey,
                    updatedDefinitionDescription);

            try
            {
                Assert.AreEqual(updatedDefinitionDescription.Description, partiallyUpdateSmsDefinitionResult.Description);

                Assert.AreEqual(smsDefinition.DefinitionKey, partiallyUpdateSmsDefinitionResult.DefinitionKey);
                Assert.AreEqual(smsDefinition.Name, partiallyUpdateSmsDefinitionResult.Name);
                Assert.AreEqual(smsDefinition.Content.Message, partiallyUpdateSmsDefinitionResult.Content.Message);
                Assert.AreEqual(smsDefinition.Subscriptions.CountryCode, partiallyUpdateSmsDefinitionResult.Subscriptions.CountryCode);
                Assert.AreEqual(smsDefinition.Subscriptions.ShortCode, partiallyUpdateSmsDefinitionResult.Subscriptions.ShortCode);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsDefinitionToPartiallyUpdateKey);
            }
        }

        [Test]
        public void DeleteSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsDefinitionToDeleteKey = createSmsDefinitionResult.DefinitionKey;

            var deleteSmsDefinitionResult = transactionalMessagingApiClient.DeleteSmsDefinition(smsDefinitionToDeleteKey);

            Assert.NotNull(deleteSmsDefinitionResult.RequestId);
            Assert.NotNull(deleteSmsDefinitionResult.DeletedDefinitionKey);
            Assert.AreEqual("Success", deleteSmsDefinitionResult.Message);
        }

        [Test]
        public void DeleteNonExistingSmsDefinitionTest()
        {
            var smsDefinitionToDeleteKey = "NonExistingSmsDefinitionKey";

            try
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsDefinitionToDeleteKey);
            }
            catch (ApiException e)
            {
                var deserializedException = JsonConvert.DeserializeObject<ApiError>(e.ErrorContent);
                Assert.AreEqual($"FuelRuntime_ObjectNotFound: Unable to find Definition {smsDefinitionToDeleteKey}", deserializedException.Message);
            }
        }

        [Test]
        public void GetSmsDefinitionsTest()
        {
            var getSmsDefinitionsResult = transactionalMessagingApiClient.GetSmsDefinitions();

            Assert.IsNotNull(getSmsDefinitionsResult.RequestId);
            Assert.IsNotNull(getSmsDefinitionsResult.Definitions);
            Assert.IsNotNull(getSmsDefinitionsResult.Count);
            Assert.IsNotNull(getSmsDefinitionsResult.Page);
            Assert.IsNotNull(getSmsDefinitionsResult.PageSize);
        }

        [Test]
        public void GetQueueMetricsForSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsDefinitionQueueMetricsToReceiveKey = createSmsDefinitionResult.DefinitionKey;

            var getQueueMetricsForSmsDefinitionResult = transactionalMessagingApiClient.GetQueueMetricsForSmsDefinition(smsDefinitionQueueMetricsToReceiveKey);

            try
            {
                Assert.IsNotNull(getQueueMetricsForSmsDefinitionResult.RequestId);
                Assert.IsNotNull(getQueueMetricsForSmsDefinitionResult.Count);
                Assert.IsNotNull(getQueueMetricsForSmsDefinitionResult.AgeSeconds);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsDefinitionQueueMetricsToReceiveKey);
            }
        }

        [Test]
        public void DeleteQueuedMessagesForSmsDefinitionTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            smsDefinition.Status = "inactive"; // Definition status must be inactive to delete queue

            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);

            var smsDefinitionQueToDeleteKey = createSmsDefinitionResult.DefinitionKey;
            var deleteQueuedMessagesForSmsDefinitionResult = transactionalMessagingApiClient.DeleteQueuedMessagesForSmsDefinition(smsDefinitionQueToDeleteKey);

            Assert.NotNull(deleteQueuedMessagesForSmsDefinitionResult.RequestId);
        }

        [Test]
        public void SendSmsToMultipleRecipientsTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsToSendToRecipientsKey = createSmsDefinitionResult.DefinitionKey;

            var recipientsList = new List<Recipient>()
            {
                new Recipient("johnDoe@gmail.com"),
                new Recipient("johannaDoe@yahoo.com")
            };

            var batchMessageRequestBody = new SendSmsToMultipleRecipientsRequest(smsToSendToRecipientsKey, recipientsList);
            var sendSmsToMultipleRecipientsResult =
                transactionalMessagingApiClient.SendSmsToMultipleRecipients(batchMessageRequestBody);

            try
            {
                Assert.NotNull(sendSmsToMultipleRecipientsResult.RequestId);
                Assert.NotNull(sendSmsToMultipleRecipientsResult.Errorcode);
                Assert.NotNull(sendSmsToMultipleRecipientsResult.Responses);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsToSendToRecipientsKey);
            }
        }

        [Test]
        public void SendSmsToSingleRecipientTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsToSendToRecipientKey = createSmsDefinitionResult.DefinitionKey;

            var recipient = new Recipient("johnDoe@gmail.com");
            var messageKey = Guid.NewGuid().ToString();

            var messageRequestBody = new SendSmsToSingleRecipientRequest(smsToSendToRecipientKey, recipient);
            var sendSmsToSingleRecipientResult =
                transactionalMessagingApiClient.SendSmsToSingleRecipient(messageKey, messageRequestBody);

            try
            {
                Assert.NotNull(sendSmsToSingleRecipientResult.RequestId);
                Assert.NotNull(sendSmsToSingleRecipientResult.Errorcode);
                Assert.NotNull(sendSmsToSingleRecipientResult.Responses);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsToSendToRecipientKey);
            }
        }

        [Test]
        public void GetSmsSendStatusForRecipientTest()
        {
            var smsDefinition = CreateSmsDefinitionObject();
            var createSmsDefinitionResult = transactionalMessagingApiClient.CreateSmsDefinition(smsDefinition);
            var smsToSendToRecipientKey = createSmsDefinitionResult.DefinitionKey;

            var recipient = new Recipient("johnDoe@gmail.com");
            var messageKey = Guid.NewGuid().ToString();

            var messageRequestBody = new SendSmsToSingleRecipientRequest(smsToSendToRecipientKey, recipient);
            transactionalMessagingApiClient.SendSmsToSingleRecipient(messageKey, messageRequestBody);

            var getSmsSendStatusForRecipientResult =
                transactionalMessagingApiClient.GetSmsSendStatusForRecipient(messageKey);

            try
            {
                Assert.NotNull(getSmsSendStatusForRecipientResult.RequestId);
                Assert.NotNull(getSmsSendStatusForRecipientResult.Timestamp);

                var eventCategoryTypes = new Collection<string>()
                {
                    "TransactionalSendEvents.SMSSent",
                    "TransactionalSendEvents.SMSQueued",
                    "TransactionalSendEvents.SMSNotSent"
                };

                CollectionAssert.Contains(eventCategoryTypes, getSmsSendStatusForRecipientResult.EventCategoryType);
            }
            finally
            {
                transactionalMessagingApiClient.DeleteSmsDefinition(smsToSendToRecipientKey);
            }
        }

        [Test]
        public void GetSMSsNotSentToRecipientsTest()
        {
            var getSMSsNotSentToRecipientsResponse = transactionalMessagingApiClient.GetSMSsNotSentToRecipients("notSent");

            Assert.IsNotNull(getSMSsNotSentToRecipientsResponse.RequestId);
            Assert.IsNotNull(getSMSsNotSentToRecipientsResponse.LastEventID);
            Assert.IsNotNull(getSMSsNotSentToRecipientsResponse.Messages);
            Assert.IsNotNull(getSMSsNotSentToRecipientsResponse.Count);
            Assert.IsNotNull(getSMSsNotSentToRecipientsResponse.PageSize);
        }

        private CreateEmailDefinitionRequest CreateEmailDefinitionObject()
        {
            var emailDefinitionKey = $"{Guid.NewGuid()}";
            var emailDefinitionName = $"{Guid.NewGuid()}";

            var emailAsset = CreateAssetObject();

            try
            {
                var createAssetResult = assetApiClient.CreateAsset(emailAsset);
                var customerKey = createAssetResult.CustomerKey;

                var content = new CreateEmailDefinitionContent(customerKey);

                const string subscribersListKey = "All Subscribers";
                var subscriptions = new CreateEmailDefinitionSubscriptions(subscribersListKey);
                var emailDefinition = new CreateEmailDefinitionRequest(emailDefinitionName, emailDefinitionKey, content: content, subscriptions: subscriptions);

                return emailDefinition;
            }
            catch (ApiException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private CreateSmsDefinitionRequest CreateSmsDefinitionObject()
        {
            var smsDefinitionKey = $"{Guid.NewGuid()}";
            var smsDefinitionName = $"{Guid.NewGuid()}";

            var shortCode = configProvider.ShortCode;
            var keyword = configProvider.Keyword;
            var countryCode = "US";

            var subscriptions = new CreateSmsDefinitionSubscriptions(shortCode, countryCode, keyword);
            var content = new CreateSmsDefinitionContent("Content message");

            var smsDefinition = new CreateSmsDefinitionRequest(smsDefinitionKey, smsDefinitionName, content, subscriptions: subscriptions);

            return smsDefinition;
        }

        private Asset CreateAssetObject()
        {
            var customerKey = $"{Guid.NewGuid()}";

            var assetName = $"{Guid.NewGuid()}"; // Asset names within a category and asset type must be unique
            var assetDescription = "AssetDescription";
            var assetType = new AssetType(208, "htmlemail", "htmlemail");

            /* The views object is not a required parameter of the Asset constructor.
             Still, we create it and injected into the asset object in order to be able to
             set the email subject. The email subject has to be != null in order to be able
             to trigger the send definition. */

            JObject views = JObject.Parse(@"{
                'subjectline': {
                    'content' : 'New TS Subject Line'
                }
            }");

            var asset = new Asset(customerKey: customerKey, assetType: assetType, name: assetName, description: assetDescription, views: views);

            return asset;
        }
    }
}
