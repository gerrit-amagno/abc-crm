# AmagnoWebApi.Client.Api.DocumentTypesApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTypesGet**](DocumentTypesApi.md#documenttypesget) | **GET** /document-types/{documentTypeId} | Returns the requested document type
[**DocumentTypesGetTagGroupDefinitions**](DocumentTypesApi.md#documenttypesgettaggroupdefinitions) | **GET** /document-types/{documentTypeId}/tag-group-definitions | Returns all of the tag groups related to the document type



## DocumentTypesGet

> List&lt;TagGroupDefinition&gt; DocumentTypesGet (Guid documentTypeId, string authorization)

Returns the requested document type

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentTypesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentTypesApi(Configuration.Default);
            var documentTypeId = new Guid(); // Guid | GUID of the document type
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested document type
                List<TagGroupDefinition> result = apiInstance.DocumentTypesGet(documentTypeId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGet: " + e.Message );
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
 **documentTypeId** | [**Guid**](Guid.md)| GUID of the document type | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;TagGroupDefinition&gt;**](TagGroupDefinition.md)

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


## DocumentTypesGetTagGroupDefinitions

> List&lt;TagGroupDefinition&gt; DocumentTypesGetTagGroupDefinitions (Guid documentTypeId, string authorization)

Returns all of the tag groups related to the document type

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentTypesGetTagGroupDefinitionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentTypesApi(Configuration.Default);
            var documentTypeId = new Guid(); // Guid | GUID of the document type
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the tag groups related to the document type
                List<TagGroupDefinition> result = apiInstance.DocumentTypesGetTagGroupDefinitions(documentTypeId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGetTagGroupDefinitions: " + e.Message );
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
 **documentTypeId** | [**Guid**](Guid.md)| GUID of the document type | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;TagGroupDefinition&gt;**](TagGroupDefinition.md)

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

