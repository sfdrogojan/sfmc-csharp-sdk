# Salesforce.MarketingCloud.Api.CampaignApi

All URIs are relative to *https://www.exacttargetapis.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaign**](CampaignApi.md#createcampaign) | **POST** /hub/v1/campaigns | createCampaign
[**DeleteCampaignById**](CampaignApi.md#deletecampaignbyid) | **DELETE** /hub/v1/campaigns/{id} | deleteCampaign
[**GetCampaignById**](CampaignApi.md#getcampaignbyid) | **GET** /hub/v1/campaigns/{id} | getCampaign


<a name="createcampaign"></a>
# **CreateCampaign**
> Campaign CreateCampaign (Campaign body = null)

createCampaign

Creates a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class CreateCampaignExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var body = new Campaign(); // Campaign | JSON Parameters (optional) 

            try
            {
                // createCampaign
                Campaign result = apiInstance.CreateCampaign(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CreateCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Campaign**](Campaign.md)| JSON Parameters | [optional] 

### Return type

[**Campaign**](Campaign.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaignbyid"></a>
# **DeleteCampaignById**
> void DeleteCampaignById (decimal? id)

deleteCampaign

Deletes a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class DeleteCampaignByIdExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var id = 8.14;  // decimal? | The ID of the campaign to delete

            try
            {
                // deleteCampaign
                apiInstance.DeleteCampaignById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.DeleteCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The ID of the campaign to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignbyid"></a>
# **GetCampaignById**
> Campaign GetCampaignById (decimal? id)

getCampaign

Retrieves a campaign.

### Example
```csharp
using System;
using System.Diagnostics;
using Salesforce.MarketingCloud.Api;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Example
{
    public class GetCampaignByIdExample
    {
        public void main()
        {
            var apiInstance = new CampaignApi();
            var id = 8.14;  // decimal? | Campaign ID

            try
            {
                // getCampaign
                Campaign result = apiInstance.GetCampaignById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.GetCampaignById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| Campaign ID | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

