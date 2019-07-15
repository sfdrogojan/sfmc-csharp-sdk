# Salesforce.MarketingCloud.Api.TransactionalMessagingApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailDefinition**](TransactionalMessagingApi.md#createemaildefinition) | **POST** /messaging/v1/email/definitions/ | createEmailDefinition
[**CreateSmsDefinition**](TransactionalMessagingApi.md#createsmsdefinition) | **POST** /messaging/v1/sms/definitions | createSmsDefinition
[**DeleteEmailDefinition**](TransactionalMessagingApi.md#deleteemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey} | deleteEmailDefinition
[**DeleteQueuedMessagesForEmailDefinition**](TransactionalMessagingApi.md#deletequeuedmessagesforemaildefinition) | **DELETE** /messaging/v1/email/definitions/{definitionKey}/queue | deleteQueuedMessagesForEmailDefinition
[**DeleteQueuedMessagesForSmsDefinition**](TransactionalMessagingApi.md#deletequeuedmessagesforsmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey}/queue | deleteQueuedMessagesForSmsDefinition
[**DeleteSmsDefinition**](TransactionalMessagingApi.md#deletesmsdefinition) | **DELETE** /messaging/v1/sms/definitions/{definitionKey} | deleteSmsDefinition
[**GetEmailDefinition**](TransactionalMessagingApi.md#getemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey} | getEmailDefinition
[**GetEmailDefinitions**](TransactionalMessagingApi.md#getemaildefinitions) | **GET** /messaging/v1/email/definitions/ | getEmailDefinitions
[**GetEmailSendStatusForRecipient**](TransactionalMessagingApi.md#getemailsendstatusforrecipient) | **GET** /messaging/v1/email/messages/{messageKey} | getEmailSendStatusForRecipient
[**GetEmailsNotSentToRecipients**](TransactionalMessagingApi.md#getemailsnotsenttorecipients) | **GET** /messaging/v1/email/messages/ | getEmailsNotSentToRecipients
[**GetQueueMetricsForEmailDefinition**](TransactionalMessagingApi.md#getqueuemetricsforemaildefinition) | **GET** /messaging/v1/email/definitions/{definitionKey}/queue | getQueueMetricsForEmailDefinition
[**GetQueueMetricsForSmsDefinition**](TransactionalMessagingApi.md#getqueuemetricsforsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey}/queue | getQueueMetricsForSmsDefinition
[**GetSMSsNotSentToRecipients**](TransactionalMessagingApi.md#getsmssnotsenttorecipients) | **GET** /messaging/v1/sms/messages/ | getSMSsNotSentToRecipients
[**GetSmsDefinition**](TransactionalMessagingApi.md#getsmsdefinition) | **GET** /messaging/v1/sms/definitions/{definitionKey} | getSmsDefinition
[**GetSmsDefinitions**](TransactionalMessagingApi.md#getsmsdefinitions) | **GET** /messaging/v1/sms/definitions | getSmsDefinitions
[**GetSmsSendStatusForRecipient**](TransactionalMessagingApi.md#getsmssendstatusforrecipient) | **GET** /messaging/v1/sms/messages/{messageKey} | getSmsSendStatusForRecipient
[**PartiallyUpdateEmailDefinition**](TransactionalMessagingApi.md#partiallyupdateemaildefinition) | **PATCH** /messaging/v1/email/definitions/{definitionKey} | partiallyUpdateEmailDefinition
[**PartiallyUpdateSmsDefinition**](TransactionalMessagingApi.md#partiallyupdatesmsdefinition) | **PATCH** /messaging/v1/sms/definitions/{definitionKey} | partiallyUpdateSmsDefinition
[**SendEmailToMultipleRecipients**](TransactionalMessagingApi.md#sendemailtomultiplerecipients) | **POST** /messaging/v1/email/messages/ | sendEmailToMultipleRecipients
[**SendEmailToSingleRecipient**](TransactionalMessagingApi.md#sendemailtosinglerecipient) | **POST** /messaging/v1/email/messages/{messageKey} | sendEmailToSingleRecipient
[**SendSmsToMultipleRecipients**](TransactionalMessagingApi.md#sendsmstomultiplerecipients) | **POST** /messaging/v1/sms/messages/ | sendSmsToMultipleRecipients
[**SendSmsToSingleRecipient**](TransactionalMessagingApi.md#sendsmstosinglerecipient) | **POST** /messaging/v1/sms/messages/{messageKey} | sendSmsToSingleRecipient


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
            var apiInstance = new TransactionalMessagingApi();
            var body = new RequestCreateEmailDefinition(); // RequestCreateEmailDefinition | JSON Parameters (optional) 

            try
            {
                // createEmailDefinition
                RequestCreateEmailDefinition result = apiInstance.CreateEmailDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.CreateEmailDefinition: " + e.Message );
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

<a name="createsmsdefinition"></a>
# **CreateSmsDefinition**
> RequestCreateSmsDefinition CreateSmsDefinition (RequestCreateSmsDefinition body = null)

createSmsDefinition

Creates the definition for an SMS.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new RequestCreateSmsDefinition(); // RequestCreateSmsDefinition | JSON Parameters (optional) 

            try
            {
                // createSmsDefinition
                RequestCreateSmsDefinition result = apiInstance.CreateSmsDefinition(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.CreateSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreateSmsDefinition**](RequestCreateSmsDefinition.md)| JSON Parameters | [optional] 

### Return type

[**RequestCreateSmsDefinition**](RequestCreateSmsDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaildefinition"></a>
# **DeleteEmailDefinition**
> ResponseDeleteSendDefinition DeleteEmailDefinition (string definitionKey)

deleteEmailDefinition

Deletes an email definition. You can't restore a deleted definition. The deleted definition is archived, and a delete location of the definition key is provided in the response for reference. You can reuse a deleted definition key because the information associated with it is copied to a new unique identifier.

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
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteEmailDefinition
                ResponseDeleteSendDefinition result = apiInstance.DeleteEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteEmailDefinition: " + e.Message );
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

[**ResponseDeleteSendDefinition**](ResponseDeleteSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedmessagesforemaildefinition"></a>
# **DeleteQueuedMessagesForEmailDefinition**
> ResponseDeleteQueuedMessagesForSendDefinition DeleteQueuedMessagesForEmailDefinition (string definitionKey)

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
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // deleteQueuedMessagesForEmailDefinition
                ResponseDeleteQueuedMessagesForSendDefinition result = apiInstance.DeleteQueuedMessagesForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteQueuedMessagesForEmailDefinition: " + e.Message );
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

[**ResponseDeleteQueuedMessagesForSendDefinition**](ResponseDeleteQueuedMessagesForSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequeuedmessagesforsmsdefinition"></a>
# **DeleteQueuedMessagesForSmsDefinition**
> ResponseDeleteQueuedMessagesForSendDefinition DeleteQueuedMessagesForSmsDefinition (string definitionKey)

deleteQueuedMessagesForSmsDefinition

Deletes the queue for a SMS definition. The SMS definition must be in inactive status.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteQueuedMessagesForSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the SMS definition

            try
            {
                // deleteQueuedMessagesForSmsDefinition
                ResponseDeleteQueuedMessagesForSendDefinition result = apiInstance.DeleteQueuedMessagesForSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteQueuedMessagesForSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the SMS definition | 

### Return type

[**ResponseDeleteQueuedMessagesForSendDefinition**](ResponseDeleteQueuedMessagesForSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesmsdefinition"></a>
# **DeleteSmsDefinition**
> ResponseDeleteSendDefinition DeleteSmsDefinition (string definitionKey)

deleteSmsDefinition

Deletes an sms definition. You can't restore a deleted definition. The deleted definition is archived, and a delete location of the definition key is provided in the response for reference. You can reuse a deleted definition key because the information associated with it is copied to a new unique identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteSmsDefinition
                ResponseDeleteSendDefinition result = apiInstance.DeleteSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.DeleteSmsDefinition: " + e.Message );
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

[**ResponseDeleteSendDefinition**](ResponseDeleteSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinition"></a>
# **GetEmailDefinition**
> RequestCreateEmailDefinition GetEmailDefinition (string definitionKey)

getEmailDefinition

Gets email definition configuration details for a definition key.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetEmailDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to get

            try
            {
                // getEmailDefinition
                RequestCreateEmailDefinition result = apiInstance.GetEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailDefinition: " + e.Message );
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
            var apiInstance = new TransactionalMessagingApi();
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
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailDefinitions: " + e.Message );
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
> ResponseGetDefinitionSendStatusForRecipient GetEmailSendStatusForRecipient (string messageKey)

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
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide it in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response.

            try
            {
                // getEmailSendStatusForRecipient
                ResponseGetDefinitionSendStatusForRecipient result = apiInstance.GetEmailSendStatusForRecipient(messageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailSendStatusForRecipient: " + e.Message );
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

[**ResponseGetDefinitionSendStatusForRecipient**](ResponseGetDefinitionSendStatusForRecipient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsnotsenttorecipients"></a>
# **GetEmailsNotSentToRecipients**
> ResponseGetDefinitionsNotSentToRecipients GetEmailsNotSentToRecipients (string type, int? pageSize = null, int? lastEventId = null)

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
            var apiInstance = new TransactionalMessagingApi();
            var type = type_example;  // string | Only notSent is supported.
            var pageSize = 56;  // int? | Number of messageKeys (array elements) to return per response page. (optional) 
            var lastEventId = 56;  // int? | Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. (optional) 

            try
            {
                // getEmailsNotSentToRecipients
                ResponseGetDefinitionsNotSentToRecipients result = apiInstance.GetEmailsNotSentToRecipients(type, pageSize, lastEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetEmailsNotSentToRecipients: " + e.Message );
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

[**ResponseGetDefinitionsNotSentToRecipients**](ResponseGetDefinitionsNotSentToRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueuemetricsforemaildefinition"></a>
# **GetQueueMetricsForEmailDefinition**
> ResponseGetQueueMetricsForSendDefinition GetQueueMetricsForEmailDefinition (string definitionKey)

getQueueMetricsForEmailDefinition

Gets metrics for the messages of an email definition. Applies to messages that are accepted but not yet processed.

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
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the email definition

            try
            {
                // getQueueMetricsForEmailDefinition
                ResponseGetQueueMetricsForSendDefinition result = apiInstance.GetQueueMetricsForEmailDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetQueueMetricsForEmailDefinition: " + e.Message );
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

[**ResponseGetQueueMetricsForSendDefinition**](ResponseGetQueueMetricsForSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueuemetricsforsmsdefinition"></a>
# **GetQueueMetricsForSmsDefinition**
> ResponseGetQueueMetricsForSendDefinition GetQueueMetricsForSmsDefinition (string definitionKey)

getQueueMetricsForSmsDefinition

Gets metrics for the messages of a SMS definition. Applies to messages that are accepted but not yet processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetQueueMetricsForSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the SMS definition

            try
            {
                // getQueueMetricsForSmsDefinition
                ResponseGetQueueMetricsForSendDefinition result = apiInstance.GetQueueMetricsForSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetQueueMetricsForSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the SMS definition | 

### Return type

[**ResponseGetQueueMetricsForSendDefinition**](ResponseGetQueueMetricsForSendDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmssnotsenttorecipients"></a>
# **GetSMSsNotSentToRecipients**
> ResponseGetDefinitionsNotSentToRecipients GetSMSsNotSentToRecipients (string type, int? pageSize = null, int? lastEventId = null)

getSMSsNotSentToRecipients

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
    public class GetSMSsNotSentToRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var type = type_example;  // string | Only notSent is supported.
            var pageSize = 56;  // int? | Number of messageKeys (array elements) to return per response page. (optional) 
            var lastEventId = 56;  // int? | Event ID from which you want the response to start. To obtain the initial event ID, submit a request without a lastEventId. The events in the response are listed top to bottom from oldest to newest. (optional) 

            try
            {
                // getSMSsNotSentToRecipients
                ResponseGetDefinitionsNotSentToRecipients result = apiInstance.GetSMSsNotSentToRecipients(type, pageSize, lastEventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSMSsNotSentToRecipients: " + e.Message );
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

[**ResponseGetDefinitionsNotSentToRecipients**](ResponseGetDefinitionsNotSentToRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsdefinition"></a>
# **GetSmsDefinition**
> RequestCreateSmsDefinition GetSmsDefinition (string definitionKey)

getSmsDefinition

Gets SMS definition configuration details for a definition key.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to get

            try
            {
                // getSmsDefinition
                RequestCreateSmsDefinition result = apiInstance.GetSmsDefinition(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsDefinition: " + e.Message );
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

[**RequestCreateSmsDefinition**](RequestCreateSmsDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmsdefinitions"></a>
# **GetSmsDefinitions**
> ResponseGetSmsDefinitions GetSmsDefinitions (string status = null, decimal? pageSize = null, decimal? page = null, string orderBy = null)

getSmsDefinitions

Gets a list of SMS definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetSmsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var status = status_example;  // string | Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. (optional) 
            var pageSize = 8.14;  // decimal? | Number of definitions, which are array elements, to return per paged response. (optional) 
            var page = 8.14;  // decimal? | Page number to return. (optional) 
            var orderBy = orderBy_example;  // string | Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. (optional) 

            try
            {
                // getSmsDefinitions
                ResponseGetSmsDefinitions result = apiInstance.GetSmsDefinitions(status, pageSize, page, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsDefinitions: " + e.Message );
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

[**ResponseGetSmsDefinitions**](ResponseGetSmsDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmssendstatusforrecipient"></a>
# **GetSmsSendStatusForRecipient**
> ResponseGetDefinitionSendStatusForRecipient GetSmsSendStatusForRecipient (string messageKey)

getSmsSendStatusForRecipient

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
    public class GetSmsSendStatusForRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide message key in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response.

            try
            {
                // getSmsSendStatusForRecipient
                ResponseGetDefinitionSendStatusForRecipient result = apiInstance.GetSmsSendStatusForRecipient(messageKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.GetSmsSendStatusForRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier to track message send status. You must provide it in singleton requests using the recipient attribute. To provide message key in batch requests, use the recipients array attribute. If you don’t provide the message key for recipients, it’s generated in the response. | 

### Return type

[**ResponseGetDefinitionSendStatusForRecipient**](ResponseGetDefinitionSendStatusForRecipient.md)

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
            var apiInstance = new TransactionalMessagingApi();
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
                Debug.Print("Exception when calling TransactionalMessagingApi.PartiallyUpdateEmailDefinition: " + e.Message );
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

<a name="partiallyupdatesmsdefinition"></a>
# **PartiallyUpdateSmsDefinition**
> RequestCreateSmsDefinition PartiallyUpdateSmsDefinition (string definitionKey, RequestUpdateSmsDefinition body = null)

partiallyUpdateSmsDefinition

Updates a specific SMS definition.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class PartiallyUpdateSmsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition.
            var body = new RequestUpdateSmsDefinition(); // RequestUpdateSmsDefinition | JSON Parameters (optional) 

            try
            {
                // partiallyUpdateSmsDefinition
                RequestCreateSmsDefinition result = apiInstance.PartiallyUpdateSmsDefinition(definitionKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.PartiallyUpdateSmsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitionKey** | **string**| Unique identifier of the definition. | 
 **body** | [**RequestUpdateSmsDefinition**](RequestUpdateSmsDefinition.md)| JSON Parameters | [optional] 

### Return type

[**RequestCreateSmsDefinition**](RequestCreateSmsDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtomultiplerecipients"></a>
# **SendEmailToMultipleRecipients**
> ResponseSendDefinitionToMultipleRecipients SendEmailToMultipleRecipients (RequestSendEmailToMultipleRecipients body = null)

sendEmailToMultipleRecipients

Sends a message to multiple recipients using an email definition. You can provide a messageKey in the request; otherwise, the messageKey is automatically generated in the response.

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
            var apiInstance = new TransactionalMessagingApi();
            var body = new RequestSendEmailToMultipleRecipients(); // RequestSendEmailToMultipleRecipients | JSON Parameters (optional) 

            try
            {
                // sendEmailToMultipleRecipients
                ResponseSendDefinitionToMultipleRecipients result = apiInstance.SendEmailToMultipleRecipients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendEmailToMultipleRecipients: " + e.Message );
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

[**ResponseSendDefinitionToMultipleRecipients**](ResponseSendDefinitionToMultipleRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailtosinglerecipient"></a>
# **SendEmailToSingleRecipient**
> ResponseSendDefinitionToSingleRecipient SendEmailToSingleRecipient (string messageKey, RequestSendEmailToSingleRecipient body = null)

sendEmailToSingleRecipient

Sends a message to a single recipient via an email definition using a messageKey path parameter.

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
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected.
            var body = new RequestSendEmailToSingleRecipient(); // RequestSendEmailToSingleRecipient | JSON Parameters (optional) 

            try
            {
                // sendEmailToSingleRecipient
                ResponseSendDefinitionToSingleRecipient result = apiInstance.SendEmailToSingleRecipient(messageKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendEmailToSingleRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier used to track message status. Can be automatically created when you create a message or provided as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | 
 **body** | [**RequestSendEmailToSingleRecipient**](RequestSendEmailToSingleRecipient.md)| JSON Parameters | [optional] 

### Return type

[**ResponseSendDefinitionToSingleRecipient**](ResponseSendDefinitionToSingleRecipient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmstomultiplerecipients"></a>
# **SendSmsToMultipleRecipients**
> ResponseSendDefinitionToMultipleRecipients SendSmsToMultipleRecipients (RequestSendSmsToMultipleRecipients body = null)

sendSmsToMultipleRecipients

Sends a message to multiple recipients using an email definition. You can provide a messageKey in the request; otherwise, the messageKey is automatically generated in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendSmsToMultipleRecipientsExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var body = new RequestSendSmsToMultipleRecipients(); // RequestSendSmsToMultipleRecipients | JSON Parameters (optional) 

            try
            {
                // sendSmsToMultipleRecipients
                ResponseSendDefinitionToMultipleRecipients result = apiInstance.SendSmsToMultipleRecipients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendSmsToMultipleRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestSendSmsToMultipleRecipients**](RequestSendSmsToMultipleRecipients.md)| JSON Parameters | [optional] 

### Return type

[**ResponseSendDefinitionToMultipleRecipients**](ResponseSendDefinitionToMultipleRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendsmstosinglerecipient"></a>
# **SendSmsToSingleRecipient**
> ResponseSendDefinitionToSingleRecipient SendSmsToSingleRecipient (string messageKey, RequestSendSmsToSingleRecipient body = null)

sendSmsToSingleRecipient

Sends a message to a single recipient via a SMS definition using a messageKey path parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class SendSmsToSingleRecipientExample
    {
        public void main()
        {
            var apiInstance = new TransactionalMessagingApi();
            var messageKey = messageKey_example;  // string | Unique identifier of the definition used to track message status. The messageKey can be created automatically when you create a message, or you can provide it as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected.
            var body = new RequestSendSmsToSingleRecipient(); // RequestSendSmsToSingleRecipient | JSON Parameters (optional) 

            try
            {
                // sendSmsToSingleRecipient
                ResponseSendDefinitionToSingleRecipient result = apiInstance.SendSmsToSingleRecipient(messageKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalMessagingApi.SendSmsToSingleRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageKey** | **string**| Unique identifier of the definition used to track message status. The messageKey can be created automatically when you create a message, or you can provide it as part of the request. Each recipient in a request must have a unique messageKey. If you use a duplicate messageKey in the same send request, the message is rejected. | 
 **body** | [**RequestSendSmsToSingleRecipient**](RequestSendSmsToSingleRecipient.md)| JSON Parameters | [optional] 

### Return type

[**ResponseSendDefinitionToSingleRecipient**](ResponseSendDefinitionToSingleRecipient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

