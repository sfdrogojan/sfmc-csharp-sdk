# Salesforce.MarketingCloud.Api.EmailDefinitionApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailDefinition**](EmailDefinitionApi.md#createemaildefinition) | **POST** /messaging/v1/email/definitions/ | createEmailDefinition
[**DeleteEmailDefinition**](EmailDefinitionApi.md#deleteemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey} | deleteEmailDefinition
[**DeleteQueuedMessagesForEmailDefinition**](EmailDefinitionApi.md#deletequeuedmessagesforemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey}/queue | deleteQueuedMessagesForEmailDefinition
[**GetEmailDefinitionByDefinitionKey**](EmailDefinitionApi.md#getemaildefinitionbydefinitionkey) | **GET** /messaging/v1/email/definitions/{definitionKey} | getEmailDefinitionByDefinitionKey
[**GetEmailDefinitions**](EmailDefinitionApi.md#getemaildefinitions) | **GET** /messaging/v1/email/definitions/ | getEmailDefinitions
[**GetEmailSendStatusForRecipient**](EmailDefinitionApi.md#getemailsendstatusforrecipient) | **GET** /messaging/v1/email/messages/{messageKey} | getEmailSendStatusForRecipient
[**GetEmailsNotSentToRecipients**](EmailDefinitionApi.md#getemailsnotsenttorecipients) | **GET** /messaging/v1/email/messages/ | getEmailsNotSentToRecipients
[**GetQueueMetricsForEmailDefinition**](EmailDefinitionApi.md#getqueuemetricsforemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey}/queue | getQueueMetricsForEmailDefinition
[**PartiallyUpdateEmailDefinition**](EmailDefinitionApi.md#partiallyupdateemaildefinition) | **PATCH** /messaging/v1/email/definitions/{definitionKey} | partiallyUpdateEmailDefinition
[**SendEmailToMultipleRecipients**](EmailDefinitionApi.md#sendemailtomultiplerecipients) | **POST** /messaging/v1/email/messages/ | sendEmailToMultipleRecipients
[**SendEmailToSingleRecipient**](EmailDefinitionApi.md#sendemailtosinglerecipient) | **POST** /messaging/v1/email/messages/{messageKey} | sendEmailToSingleRecipient


<a name="createemaildefinition"></a>
# **CreateEmailDefinition**
> RequestCreateEmailDefinition CreateEmailDefinition (RequestCreateEmailDefinition body = null)

createEmailDefinition

Creates the definition for an email.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var body = new RequestCreateEmailDefinition(); // RequestCreateEmailDefinition | JSON Parameters (optional) 

            try
            {
                // createEmailDefinition
                RequestCreateEmailDefinition result = apiInstance.CreateEmailDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.CreateEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreateEmailDefinition**](RequestCreateEmailDefinition.md)| JSON Parameters | [optional] 

### Return type

[**RequestCreateEmailDefinition**](RequestCreateEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaildefinition"></a>
# **DeleteEmailDefinition**
> ResponseDeleteEmailDefinition DeleteEmailDefinition (string definitionKey)

deleteEmailDefinition

Deletes a email definition. You can't restore a deleted definition. The deleted definition is archived, and a delete location of the definition key is provided in the response for reference. You can reuse a deleted definition key because the information associated with it is copied to a new unique identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteEmailDefinition
                ResponseDeleteEmailDefinition result = apiInstance.DeleteEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.DeleteEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to delete | 

### Return type

[**ResponseDeleteEmailDefinition**](ResponseDeleteEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedmessagesforemaildefinition"></a>
# **DeleteQueuedMessagesForEmailDefinition**
> ResponseDeleteQueuedMessagesForEmailDefinition DeleteQueuedMessagesForEmailDefinition (string definitionKey)

deleteQueuedMessagesForEmailDefinition

Deletes the queue for an email definition. The email definition must be in inactive status.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteQueuedMessagesForEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // deleteQueuedMessagesForEmailDefinition
                ResponseDeleteQueuedMessagesForEmailDefinition result = apiInstance.DeleteQueuedMessagesForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.DeleteQueuedMessagesForEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the email definition | 

### Return type

[**ResponseDeleteQueuedMessagesForEmailDefinition**](ResponseDeleteQueuedMessagesForEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinitionbydefinitionkey"></a>
# **GetEmailDefinitionByDefinitionKey**
> RequestCreateEmailDefinition GetEmailDefinitionByDefinitionKey (string definitionKey)

getEmailDefinitionByDefinitionKey

Gets send definition configuration details for a definition key.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailDefinitionByDefinitionKeyExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to get

            try
            {
                // getEmailDefinitionByDefinitionKey
                RequestCreateEmailDefinition result = apiInstance.GetEmailDefinitionByDefinitionKey(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.GetEmailDefinitionByDefinitionKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition to get | 

### Return type

[**RequestCreateEmailDefinition**](RequestCreateEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinitions"></a>
# **GetEmailDefinitions**
> ResponseGetEmailDefinitions GetEmailDefinitions (string status = null, decimal? pageSize = null, decimal? page = null, string orderBy = null)

getEmailDefinitions

Gets a list of email definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var status = status_example;  // string | Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. (optional) 
            var pageSize = 8.14;  // decimal? | Number of definitions, which are array elements, to return per paged response. (optional) 
            var page = 8.14;  // decimal? | Page number to return. (optional) 
            var orderBy = orderBy_example;  // string | Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. (optional) 

            try
            {
                // getEmailDefinitions
                ResponseGetEmailDefinitions result = apiInstance.GetEmailDefinitions(status, pageSize, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.GetEmailDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. | [optional] 
 **pageSize** | **decimal?**| Number of definitions, which are array elements, to return per paged response. | [optional] 
 **page** | **decimal?**| Page number to return. | [optional] 
 **orderBy** | **string**| Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. | [optional] 

### Return type

[**ResponseGetEmailDefinitions**](ResponseGetEmailDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsendstatusforrecipient"></a>
# **GetEmailSendStatusForRecipient**
> ResponseGetEmailSendStatusForRecipient GetEmailSendStatusForRecipient (string messageKey)

getEmailSendStatusForRecipient

Gets the send status for a message. Because this route is rate-limited, use it for infrequent verification of a messageKey. To collect send status at scale, subscribe to transactional send events using the Event Notification Service.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailSendStatusForRecipientExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var messageKey = messageKey_example;  // string | Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide it in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response.

            try
            {
                // getEmailSendStatusForRecipient
                ResponseGetEmailSendStatusForRecipient result = apiInstance.GetEmailSendStatusForRecipient(messageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.GetEmailSendStatusForRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide it in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response. | 

### Return type

[**ResponseGetEmailSendStatusForRecipient**](ResponseGetEmailSendStatusForRecipient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsnotsenttorecipients"></a>
# **GetEmailsNotSentToRecipients**
> ResponseGetEmailsNotSentToRecipients GetEmailsNotSentToRecipients (string type, int? pageSize = null, int? lastEventId = null)

getEmailsNotSentToRecipients

Gets a paginated list of messages that were not sent, ordered from oldest to newest.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailsNotSentToRecipientsExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var type = type_example;  // string | Only notSent is supported.
            var pageSize = 56;  // int? | Number of messageKeys (array elements) to return per response page. (optional) 
            var lastEventId = 56;  // int? | Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. (optional) 

            try
            {
                // getEmailsNotSentToRecipients
                ResponseGetEmailsNotSentToRecipients result = apiInstance.GetEmailsNotSentToRecipients(type, pageSize, lastEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.GetEmailsNotSentToRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Only notSent is supported. | 
 **pageSize** | **int?**| Number of messageKeys (array elements) to return per response page. | [optional] 
 **lastEventId** | **int?**| Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. | [optional] 

### Return type

[**ResponseGetEmailsNotSentToRecipients**](ResponseGetEmailsNotSentToRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueuemetricsforemaildefinition"></a>
# **GetQueueMetricsForEmailDefinition**
> ResponseGetQueueMetricsForEmailDefinition GetQueueMetricsForEmailDefinition (string definitionKey)

getQueueMetricsForEmailDefinition

Gets metrics for the messages of a email definition. Applies to messages that are accepted but not yet processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetQueueMetricsForEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // getQueueMetricsForEmailDefinition
                ResponseGetQueueMetricsForEmailDefinition result = apiInstance.GetQueueMetricsForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.GetQueueMetricsForEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the email definition | 

### Return type

[**ResponseGetQueueMetricsForEmailDefinition**](ResponseGetQueueMetricsForEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdateemaildefinition"></a>
# **PartiallyUpdateEmailDefinition**
> RequestCreateEmailDefinition PartiallyUpdateEmailDefinition (string definitionKey, RequestUpdateEmailDefinition body = null)

partiallyUpdateEmailDefinition

Updates a specific email definition.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class PartiallyUpdateEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition.
            var body = new RequestUpdateEmailDefinition(); // RequestUpdateEmailDefinition | JSON Parameters (optional) 

            try
            {
                // partiallyUpdateEmailDefinition
                RequestCreateEmailDefinition result = apiInstance.PartiallyUpdateEmailDefinition(definitionKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.PartiallyUpdateEmailDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition. | 
 **body** | [**RequestUpdateEmailDefinition**](RequestUpdateEmailDefinition.md)| JSON Parameters | [optional] 

### Return type

[**RequestCreateEmailDefinition**](RequestCreateEmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtomultiplerecipients"></a>
# **SendEmailToMultipleRecipients**
> ResponseSendEmailToMultipleRecipients SendEmailToMultipleRecipients (RequestSendEmailToMultipleRecipients body = null)

sendEmailToMultipleRecipients

Sends a message to multiple recipients using a send definition. You can provide a messageKey in the request; otherwise, the messageKey is automatically generated in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendEmailToMultipleRecipientsExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var body = new RequestSendEmailToMultipleRecipients(); // RequestSendEmailToMultipleRecipients | JSON Parameters (optional) 

            try
            {
                // sendEmailToMultipleRecipients
                ResponseSendEmailToMultipleRecipients result = apiInstance.SendEmailToMultipleRecipients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.SendEmailToMultipleRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestSendEmailToMultipleRecipients**](RequestSendEmailToMultipleRecipients.md)| JSON Parameters | [optional] 

### Return type

[**ResponseSendEmailToMultipleRecipients**](ResponseSendEmailToMultipleRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtosinglerecipient"></a>
# **SendEmailToSingleRecipient**
> ResponseSendEmailToSingleRecipient SendEmailToSingleRecipient (string messageKey, RequestSendMessageSingleRecipient body = null)

sendEmailToSingleRecipient

Sends a message to a single recipient via a email definition using a messageKey path parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendEmailToSingleRecipientExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var messageKey = messageKey_example;  // string | Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected.
            var body = new RequestSendMessageSingleRecipient(); // RequestSendMessageSingleRecipient | JSON Parameters (optional) 

            try
            {
                // sendEmailToSingleRecipient
                ResponseSendEmailToSingleRecipient result = apiInstance.SendEmailToSingleRecipient(messageKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.SendEmailToSingleRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | 
 **body** | [**RequestSendMessageSingleRecipient**](RequestSendMessageSingleRecipient.md)| JSON Parameters | [optional] 

### Return type

[**ResponseSendEmailToSingleRecipient**](ResponseSendEmailToSingleRecipient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

