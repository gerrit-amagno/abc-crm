# AmagnoWebApi.Client.Api.CheckedOutDocumentsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckedOutDocumentsCheckIn**](CheckedOutDocumentsApi.md#checkedoutdocumentscheckin) | **POST** /checked-out-documents/{documentId}/check-in | Applies changes made to the checked-out version of document. Checked-out version will be deleted
[**CheckedOutDocumentsDelete**](CheckedOutDocumentsApi.md#checkedoutdocumentsdelete) | **DELETE** /checked-out-documents/{documentId} | Reverts changes made to the checked-out version of document. Checked-out version will be deleted
[**CheckedOutDocumentsGet**](CheckedOutDocumentsApi.md#checkedoutdocumentsget) | **GET** /checked-out-documents/{documentId} | Returns information about the checked-out document
[**CheckedOutDocumentsGetAll**](CheckedOutDocumentsApi.md#checkedoutdocumentsgetall) | **GET** /checked-out-documents | Returns information about the checked-out documents



## CheckedOutDocumentsCheckIn

> Object CheckedOutDocumentsCheckIn (Guid documentId, string authorization)

Applies changes made to the checked-out version of document. Checked-out version will be deleted

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class CheckedOutDocumentsCheckInExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new CheckedOutDocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the checked-out document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Applies changes made to the checked-out version of document. Checked-out version will be deleted
                Object result = apiInstance.CheckedOutDocumentsCheckIn(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CheckedOutDocumentsApi.CheckedOutDocumentsCheckIn: " + e.Message );
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
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CheckedOutDocumentsDelete

> Object CheckedOutDocumentsDelete (Guid documentId, string authorization)

Reverts changes made to the checked-out version of document. Checked-out version will be deleted

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class CheckedOutDocumentsDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new CheckedOutDocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the checked-out document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Reverts changes made to the checked-out version of document. Checked-out version will be deleted
                Object result = apiInstance.CheckedOutDocumentsDelete(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CheckedOutDocumentsApi.CheckedOutDocumentsDelete: " + e.Message );
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


## CheckedOutDocumentsGet

> Document CheckedOutDocumentsGet (Guid documentId, string authorization, bool? includeTags = null)

Returns information about the checked-out document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class CheckedOutDocumentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new CheckedOutDocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the checked-out document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags should be included (optional - default false) (optional) 

            try
            {
                // Returns information about the checked-out document
                Document result = apiInstance.CheckedOutDocumentsGet(documentId, authorization, includeTags);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CheckedOutDocumentsApi.CheckedOutDocumentsGet: " + e.Message );
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


## CheckedOutDocumentsGetAll

> List&lt;Document&gt; CheckedOutDocumentsGetAll (string authorization, bool? includeTags = null)

Returns information about the checked-out documents

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class CheckedOutDocumentsGetAllExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new CheckedOutDocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 

            try
            {
                // Returns information about the checked-out documents
                List<Document> result = apiInstance.CheckedOutDocumentsGetAll(authorization, includeTags);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CheckedOutDocumentsApi.CheckedOutDocumentsGetAll: " + e.Message );
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
 **includeTags** | **bool?**| Decides if tags for each document in response should be included (optional - default false) | [optional] 

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

