# Salesforce.MarketingCloud - the C# library for the Marketing Cloud REST API

Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Salesforce.MarketingCloud.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AssetApi();
            var body = new Asset(); // Asset | JSON Parameters (optional) 

            try
            {
                // createAsset
                Asset result = apiInstance.CreateAsset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.CreateAsset: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.exacttargetapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssetApi* | [**CreateAsset**](docs/AssetApi.md#createasset) | **POST** /asset/v1/content/assets | createAsset
*AssetApi* | [**DeleteAssetById**](docs/AssetApi.md#deleteassetbyid) | **DELETE** /asset/v1/content/assets/{id} | deleteAssetById
*AssetApi* | [**GetAssetById**](docs/AssetApi.md#getassetbyid) | **GET** /asset/v1/content/assets/{id} | getAssetById
*AssetApi* | [**PartiallyUpdateAssetById**](docs/AssetApi.md#partiallyupdateassetbyid) | **PATCH** /asset/v1/content/assets/{id} | partiallyUpdateAssetById
*CampaignApi* | [**CreateCampaign**](docs/CampaignApi.md#createcampaign) | **POST** /hub/v1/campaigns | createCampaign
*CampaignApi* | [**DeleteCampaignById**](docs/CampaignApi.md#deletecampaignbyid) | **DELETE** /hub/v1/campaigns/{id} | deleteCampaignById
*CampaignApi* | [**GetCampaignById**](docs/CampaignApi.md#getcampaignbyid) | **GET** /hub/v1/campaigns/{id} | getCampaignById
*TransactionalMessagingApi* | [**CreateEmailDefinition**](docs/TransactionalMessagingApi.md#createemaildefinition) | **POST** /messaging/v1/email/definitions/ | createEmailDefinition
*TransactionalMessagingApi* | [**CreateSMSDefinition**](docs/TransactionalMessagingApi.md#createsmsdefinition) | **POST** /messaging/v1/sms/definitions | createSMSDefinition
*TransactionalMessagingApi* | [**DeleteEmailDefinition**](docs/TransactionalMessagingApi.md#deleteemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey} | deleteEmailDefinition
*TransactionalMessagingApi* | [**DeleteQueuedMessagesForEmailDefinition**](docs/TransactionalMessagingApi.md#deletequeuedmessagesforemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey}/queue | deleteQueuedMessagesForEmailDefinition
*TransactionalMessagingApi* | [**DeleteQueuedMessagesForSMSDefinition**](docs/TransactionalMessagingApi.md#deletequeuedmessagesforsmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey}/queue | deleteQueuedMessagesForSMSDefinition
*TransactionalMessagingApi* | [**DeleteSMSDefinition**](docs/TransactionalMessagingApi.md#deletesmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey} | deleteSMSDefinition
*TransactionalMessagingApi* | [**GetEmailDefinition**](docs/TransactionalMessagingApi.md#getemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey} | getEmailDefinition
*TransactionalMessagingApi* | [**GetEmailDefinitions**](docs/TransactionalMessagingApi.md#getemaildefinitions) | **GET** /messaging/v1/email/definitions/ | getEmailDefinitions
*TransactionalMessagingApi* | [**GetEmailSendStatusForRecipient**](docs/TransactionalMessagingApi.md#getemailsendstatusforrecipient) | **GET** /messaging/v1/email/messages/{messageKey} | getEmailSendStatusForRecipient
*TransactionalMessagingApi* | [**GetEmailsNotSentToRecipients**](docs/TransactionalMessagingApi.md#getemailsnotsenttorecipients) | **GET** /messaging/v1/email/messages/ | getEmailsNotSentToRecipients
*TransactionalMessagingApi* | [**GetQueueMetricsForEmailDefinition**](docs/TransactionalMessagingApi.md#getqueuemetricsforemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey}/queue | getQueueMetricsForEmailDefinition
*TransactionalMessagingApi* | [**GetQueueMetricsForSMSDefinition**](docs/TransactionalMessagingApi.md#getqueuemetricsforsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey}/queue | getQueueMetricsForSMSDefinition
*TransactionalMessagingApi* | [**GetSMSDefinition**](docs/TransactionalMessagingApi.md#getsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey} | getSMSDefinition
*TransactionalMessagingApi* | [**GetSMSDefinitions**](docs/TransactionalMessagingApi.md#getsmsdefinitions) | **GET** /messaging/v1/sms/definitions | getSMSDefinitions
*TransactionalMessagingApi* | [**PartiallyUpdateEmailDefinition**](docs/TransactionalMessagingApi.md#partiallyupdateemaildefinition) | **PATCH** /messaging/v1/email/definitions/{definitionKey} | partiallyUpdateEmailDefinition
*TransactionalMessagingApi* | [**PartiallyUpdateSMSDefinition**](docs/TransactionalMessagingApi.md#partiallyupdatesmsdefinition) | **PATCH** /messaging/v1/sms/definitions/{definitionKey} | partiallyUpdateSMSDefinition
*TransactionalMessagingApi* | [**SendEmailToMultipleRecipients**](docs/TransactionalMessagingApi.md#sendemailtomultiplerecipients) | **POST** /messaging/v1/email/messages/ | sendEmailToMultipleRecipients
*TransactionalMessagingApi* | [**SendEmailToSingleRecipient**](docs/TransactionalMessagingApi.md#sendemailtosinglerecipient) | **POST** /messaging/v1/email/messages/{messageKey} | sendEmailToSingleRecipient


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiError](docs/ApiError.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetType](docs/AssetType.md)
 - [Model.Campaign](docs/Campaign.md)
 - [Model.Recipient](docs/Recipient.md)
 - [Model.RequestCreateEmailDefinition](docs/RequestCreateEmailDefinition.md)
 - [Model.RequestCreateEmailDefinitionContent](docs/RequestCreateEmailDefinitionContent.md)
 - [Model.RequestCreateEmailDefinitionOptions](docs/RequestCreateEmailDefinitionOptions.md)
 - [Model.RequestCreateEmailDefinitionSubscriptions](docs/RequestCreateEmailDefinitionSubscriptions.md)
 - [Model.RequestCreateSMSDefinition](docs/RequestCreateSMSDefinition.md)
 - [Model.RequestCreateSMSDefinitionContent](docs/RequestCreateSMSDefinitionContent.md)
 - [Model.RequestCreateSMSDefinitionSubscriptions](docs/RequestCreateSMSDefinitionSubscriptions.md)
 - [Model.RequestSendEmailToMultipleRecipients](docs/RequestSendEmailToMultipleRecipients.md)
 - [Model.RequestSendMessageSingleRecipient](docs/RequestSendMessageSingleRecipient.md)
 - [Model.RequestUpdateEmailDefinition](docs/RequestUpdateEmailDefinition.md)
 - [Model.ResponseDeleteQueuedMessagesForSendDefinition](docs/ResponseDeleteQueuedMessagesForSendDefinition.md)
 - [Model.ResponseDeleteSendDefinition](docs/ResponseDeleteSendDefinition.md)
 - [Model.ResponseGetEmailDefinitions](docs/ResponseGetEmailDefinitions.md)
 - [Model.ResponseGetEmailSendStatusForRecipient](docs/ResponseGetEmailSendStatusForRecipient.md)
 - [Model.ResponseGetEmailSendStatusForRecipientInfo](docs/ResponseGetEmailSendStatusForRecipientInfo.md)
 - [Model.ResponseGetEmailsNotSentToRecipients](docs/ResponseGetEmailsNotSentToRecipients.md)
 - [Model.ResponseGetEmailsNotSentToRecipientsMessage](docs/ResponseGetEmailsNotSentToRecipientsMessage.md)
 - [Model.ResponseGetEmailsNotSentToRecipientsMessageInfo](docs/ResponseGetEmailsNotSentToRecipientsMessageInfo.md)
 - [Model.ResponseGetQueueMetricsForSendDefinition](docs/ResponseGetQueueMetricsForSendDefinition.md)
 - [Model.ResponseGetSMSDefinitions](docs/ResponseGetSMSDefinitions.md)
 - [Model.ResponseSendEmailToMultipleRecipients](docs/ResponseSendEmailToMultipleRecipients.md)
 - [Model.ResponseSendEmailToMultipleRecipientsInnerResponse](docs/ResponseSendEmailToMultipleRecipientsInnerResponse.md)
 - [Model.ResponseSendEmailToSingleRecipient](docs/ResponseSendEmailToSingleRecipient.md)
 - [Model.SharingProperties](docs/SharingProperties.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
