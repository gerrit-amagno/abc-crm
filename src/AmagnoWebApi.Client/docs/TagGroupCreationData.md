
# AmagnoWebApi.Client.Model.TagGroupCreationData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagGroupDefinitionId** | **Guid** | GUID of the tag group definition | [optional] 
**SingleLineStrings** | [**List&lt;SingleLineStringTagCreationData&gt;**](SingleLineStringTagCreationData.md) | Single-line text strings | [optional] 
**Dates** | [**List&lt;DateTagCreationData&gt;**](DateTagCreationData.md) | UTCs in ISO 8601 format | [optional] 
**Numbers** | [**List&lt;NumberTagCreationData&gt;**](NumberTagCreationData.md) | Long values, where last X numbers are decimal part.  X is DecimalNumber field from appropriated tag definition | [optional] 
**Selections** | [**List&lt;SelectionTagCreationData&gt;**](SelectionTagCreationData.md) | Selection values | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

