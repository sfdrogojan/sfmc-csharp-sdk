# Salesforce.MarketingCloud.Model.EmailDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | The ID of the request | [optional] 
**DefinitionKey** | **string** | Unique, user-generated key to access the definition object. | 
**Name** | **string** | Name of the definition. Must be unique. | 
**Content** | [**Content**](Content.md) |  | 
**Subscriptions** | [**Subscriptions**](Subscriptions.md) |  | 
**Status** | **string** | Operational state of the definition: active, inactive, or deleted. A message sent to an active definition is processed and delivered. A message sent to an inactive definition isn’t processed or delivered. Instead, the message is queued for later processing for up to three days. | [optional] 
**Description** | **string** | User-provided description of the send definition. | [optional] 
**Classification** | **string** | Marketing Cloud external key of a sending classification defined in Email Studio Administration. Only transactional classifications are permitted. Default is default transactional. | [optional] 
**Options** | [**Options**](Options.md) |  | [optional] 
**CreatedDate** | **DateTime?** | The date the object was created. | [optional] 
**ModifiedDate** | **DateTime?** | The date the object was modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

