# Salesforce.MarketingCloud.Api.AddressApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressV1ValidateEmailPost**](AddressApi.md#addressv1validateemailpost) | **POST** /address/v1/validateEmail | validateEmail


<a name="addressv1validateemailpost"></a>
# **AddressV1ValidateEmailPost**
> ResponseValidateEmail200 AddressV1ValidateEmailPost (RequestValidateEmail body = null)

validateEmail

Validates an email by specifying the email address and validators to be used in the request body of the HTTP POST. You can use more than one validator in the same call.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class AddressV1ValidateEmailPostExample
    {
        public void main()
        {
            var apiInstance = new AddressApi();
            var body = new RequestValidateEmail(); // RequestValidateEmail | JSON parameters (optional) 

            try
            {
                // validateEmail
                ResponseValidateEmail200 result = apiInstance.AddressV1ValidateEmailPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressV1ValidateEmailPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestValidateEmail**](RequestValidateEmail.md)| JSON parameters | [optional] 

### Return type

[**ResponseValidateEmail200**](ResponseValidateEmail200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

