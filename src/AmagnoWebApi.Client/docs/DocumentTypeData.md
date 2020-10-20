
# AmagnoWebApi.Client.Model.DocumentTypeData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentTypeId** | **Guid** | GUID of the document type | 
**SingleLineStrings** | [**List&lt;SingleLineStringTagValue&gt;**](SingleLineStringTagValue.md) | Single-line text strings | [optional] 
**Dates** | [**List&lt;DateTagValue&gt;**](DateTagValue.md) | UTCs in ISO 8601 format | [optional] 
**Numbers** | [**List&lt;NumberTagValue&gt;**](NumberTagValue.md) | Long values, where last X numbers are decimal part.  X is DecimalNumbers field from appropriated tag definition | [optional] 
**Selections** | [**List&lt;SelectionTagValue&gt;**](SelectionTagValue.md) | Selection values | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

