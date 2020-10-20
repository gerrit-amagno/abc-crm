# AmagnoWebApi.Client.Api.TrashedDocumentsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrashedDocumentsDelete**](TrashedDocumentsApi.md#trasheddocumentsdelete) | **DELETE** /trashed-documents/{documentId} | Delete the chosen document permanently
[**TrashedDocumentsGet**](TrashedDocumentsApi.md#trasheddocumentsget) | **GET** /trashed-documents/{documentId} | Returns information about the document in the recycle bin
[**TrashedDocumentsGetAll**](TrashedDocumentsApi.md#trasheddocumentsgetall) | **GET** /trashed-documents | Returns information about all documents in the recycle bin



## TrashedDocumentsDelete

> Object TrashedDocumentsDelete (Guid documentId, string authorization)

Delete the chosen document permanently

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TrashedDocumentsDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TrashedDocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the checked-out document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Delete the chosen document permanently
                Object result = apiInstance.TrashedDocumentsDelete(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TrashedDocumentsApi.TrashedDocumentsDelete: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the checked-out document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | NoContent |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TrashedDocumentsGet

> Document TrashedDocumentsGet (Guid documentId, string authorization, bool? includeTags = null)

Returns information about the document in the recycle bin

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TrashedDocumentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TrashedDocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the trashed document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags should be included (optional - default false) (optional) 

            try
            {
                // Returns information about the document in the recycle bin
                Document result = apiInstance.TrashedDocumentsGet(documentId, authorization, includeTags);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TrashedDocumentsApi.TrashedDocumentsGet: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the trashed document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **includeTags** | **bool?**| Decides if tags should be included (optional - default false) | [optional] 

### Return type

[**Document**](Document.md)

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


## TrashedDocumentsGetAll

> List&lt;Document&gt; TrashedDocumentsGetAll (string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns information about all documents in the recycle bin

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TrashedDocumentsGetAllExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TrashedDocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns information about all documents in the recycle bin
                List<Document> result = apiInstance.TrashedDocumentsGetAll(authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TrashedDocumentsApi.TrashedDocumentsGetAll: " + e.Message );
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
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **includeTags** | **bool?**| Decides if tags should be included (optional - default false) | [optional] 
 **count** | **int?**| Count of returned documents (optional - default 50) | [optional] 
 **offset** | **int?**| Offset of the first returned documents (optional - default 0) | [optional] 

### Return type

[**List&lt;Document&gt;**](Document.md)

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

