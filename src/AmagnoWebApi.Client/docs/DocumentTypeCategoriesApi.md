# AmagnoWebApi.Client.Api.DocumentTypeCategoriesApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTypeCategoriesGetDocumentTypes**](DocumentTypeCategoriesApi.md#documenttypecategoriesgetdocumenttypes) | **GET** /document-type-categories/{documentTypeCategoryId}/document-types | Returns all of the document types in the category



## DocumentTypeCategoriesGetDocumentTypes

> List&lt;DocumentType&gt; DocumentTypeCategoriesGetDocumentTypes (Guid documentTypeCategoryId, string authorization)

Returns all of the document types in the category

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentTypeCategoriesGetDocumentTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentTypeCategoriesApi(Configuration.Default);
            var documentTypeCategoryId = new Guid(); // Guid | GUID of the document type category
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the document types in the category
                List<DocumentType> result = apiInstance.DocumentTypeCategoriesGetDocumentTypes(documentTypeCategoryId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentTypeCategoriesApi.DocumentTypeCategoriesGetDocumentTypes: " + e.Message );
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
 **documentTypeCategoryId** | [**Guid**](Guid.md)| GUID of the document type category | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;DocumentType&gt;**](DocumentType.md)

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

