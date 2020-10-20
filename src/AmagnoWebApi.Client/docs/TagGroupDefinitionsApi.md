# AmagnoWebApi.Client.Api.TagGroupDefinitionsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagGroupDefinitionsGetTagDefinitions**](TagGroupDefinitionsApi.md#taggroupdefinitionsgettagdefinitions) | **GET** /tag-group-definitions/{tagGroupDefinitionId}/tag-definitions | Returns all definitions of tags in the tag group definition



## TagGroupDefinitionsGetTagDefinitions

> TagDefinitionCollections TagGroupDefinitionsGetTagDefinitions (Guid tagGroupDefinitionId, string authorization)

Returns all definitions of tags in the tag group definition

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagGroupDefinitionsGetTagDefinitionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagGroupDefinitionsApi(Configuration.Default);
            var tagGroupDefinitionId = new Guid(); // Guid | GUID of the tag group definition
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all definitions of tags in the tag group definition
                TagDefinitionCollections result = apiInstance.TagGroupDefinitionsGetTagDefinitions(tagGroupDefinitionId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagGroupDefinitionsApi.TagGroupDefinitionsGetTagDefinitions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupDefinitionId** | [**Guid**](Guid.md)| GUID of the tag group definition | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**TagDefinitionCollections**](TagDefinitionCollections.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

