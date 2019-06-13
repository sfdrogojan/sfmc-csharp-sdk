# Salesforce.MarketingCloud.Api.EmailDefinitionApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailDefinition**](EmailDefinitionApi.md#createemaildefinition) | **POST** /messaging/v1/email/definitions/ | createEmailDefinition
[**DeleteEmailDefinitionByDefinitionKey**](EmailDefinitionApi.md#deleteemaildefinitionbydefinitionkey) | **DELETE** /messaging/v1/email/definitions/{definitionKey} | deleteEmailDefinition
[**GetEmailDefinitionByDefinitionKey**](EmailDefinitionApi.md#getemaildefinitionbydefinitionkey) | **GET** /messaging/v1/email/definitions/{definitionKey} | getEmailDefinition
[**GetEmailDefinitions**](EmailDefinitionApi.md#getemaildefinitions) | **GET** /messaging/v1/email/definitions/ | getEmailDefinitions
[**PartiallyUpdateEmailDefinition**](EmailDefinitionApi.md#partiallyupdateemaildefinition) | **PATCH** /messaging/v1/email/definitions/{definitionKey} | patchEmailDefinition


<a name="createemaildefinition"></a>
# **CreateEmailDefinition**
> EmailDefinition CreateEmailDefinition (EmailDefinition body = null)

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
            var body = new EmailDefinition(); // EmailDefinition | JSON Parameters (optional) 

            try
            {
                // createEmailDefinition
                EmailDefinition result = apiInstance.CreateEmailDefinition(body);
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
 **body** | [**EmailDefinition**](EmailDefinition.md)| JSON Parameters | [optional] 

### Return type

[**EmailDefinition**](EmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemaildefinitionbydefinitionkey"></a>
# **DeleteEmailDefinitionByDefinitionKey**
> SuccessfulEmailDefinitionDelete DeleteEmailDefinitionByDefinitionKey (string definitionKey)

deleteEmailDefinition

Deletes the definition for an email.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteEmailDefinitionByDefinitionKeyExample
    {
        public void main()
        {
            var apiInstance = new EmailDefinitionApi();
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to delete

            try
            {
                // deleteEmailDefinition
                SuccessfulEmailDefinitionDelete result = apiInstance.DeleteEmailDefinitionByDefinitionKey(definitionKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailDefinitionApi.DeleteEmailDefinitionByDefinitionKey: " + e.Message );
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

[**SuccessfulEmailDefinitionDelete**](SuccessfulEmailDefinitionDelete.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinitionbydefinitionkey"></a>
# **GetEmailDefinitionByDefinitionKey**
> EmailDefinition GetEmailDefinitionByDefinitionKey (string definitionKey)

getEmailDefinition

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
                // getEmailDefinition
                EmailDefinition result = apiInstance.GetEmailDefinitionByDefinitionKey(definitionKey);
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

[**EmailDefinition**](EmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildefinitions"></a>
# **GetEmailDefinitions**
> EmailDefinitionsResponse GetEmailDefinitions (string filter = null, decimal? pageSize = null, decimal? page = null, string orderBy = null)

getEmailDefinitions

Gets a list of send definitions.

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
            var filter = filter_example;  // string | Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. (optional) 
            var pageSize = 8.14;  // decimal? | Number of definitions, which are array elements, to return per paged response. (optional) 
            var page = 8.14;  // decimal? | Page number to return. (optional) 
            var orderBy = orderBy_example;  // string | Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. (optional) 

            try
            {
                // getEmailDefinitions
                EmailDefinitionsResponse result = apiInstance.GetEmailDefinitions(filter, pageSize, page, orderBy);
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
 **filter** | **string**| Filter by status type. Accepted values are active, inactive, or deleted. Valid operations are eq and neq. | [optional] 
 **pageSize** | **decimal?**| Number of definitions, which are array elements, to return per paged response. | [optional] 
 **page** | **decimal?**| Page number to return. | [optional] 
 **orderBy** | **string**| Sort by a dimension. You can sort by only one dimension. Accepted values are definitionKey, name, createdDate, modifiedDate, and status. | [optional] 

### Return type

[**EmailDefinitionsResponse**](EmailDefinitionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdateemaildefinition"></a>
# **PartiallyUpdateEmailDefinition**
> EmailDefinition PartiallyUpdateEmailDefinition (string definitionKey, EmailDefinitionDescription body = null)

patchEmailDefinition

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
            var definitionKey = definitionKey_example;  // string | Unique identifier of the definition to update
            var body = new EmailDefinitionDescription(); // EmailDefinitionDescription | JSON Parameters (optional) 

            try
            {
                // patchEmailDefinition
                EmailDefinition result = apiInstance.PartiallyUpdateEmailDefinition(definitionKey, body);
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
 **definitionKey** | **string**| Unique identifier of the definition to update | 
 **body** | [**EmailDefinitionDescription**](EmailDefinitionDescription.md)| JSON Parameters | [optional] 

### Return type

[**EmailDefinition**](EmailDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

