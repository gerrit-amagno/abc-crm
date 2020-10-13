# AmagnoWebApi.Client.Api.MagnetsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MagnetsCreateDocument**](MagnetsApi.md#magnetscreatedocument) | **POST** /magnets/{magnetId}/documents | Creates a document
[**MagnetsCreateMagnet**](MagnetsApi.md#magnetscreatemagnet) | **POST** /magnets/{magnetId}/magnets | Creates a sub-magnet
[**MagnetsGetMagnet**](MagnetsApi.md#magnetsgetmagnet) | **GET** /magnets/{magnetId} | Returns the requested magnet
[**MagnetsGetMagnetDocuments**](MagnetsApi.md#magnetsgetmagnetdocuments) | **GET** /magnets/{magnetId}/documents | Returns all documents attached to the magnet
[**MagnetsGetSubMagnets**](MagnetsApi.md#magnetsgetsubmagnets) | **GET** /magnets/{magnetId}/magnets | Returns all sub-magnets under the magnet



## MagnetsCreateDocument

> Object MagnetsCreateDocument (Guid magnetId, string authorization, NewDocument document)

Creates a document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class MagnetsCreateDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new MagnetsApi(Configuration.Default);
            var magnetId = new Guid(); // Guid | GUID of the magnet
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var document = new NewDocument(); // NewDocument | Model of the new document

            try
            {
                // Creates a document
                Object result = apiInstance.MagnetsCreateDocument(magnetId, authorization, document);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MagnetsApi.MagnetsCreateDocument: " + e.Message );
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
 **magnetId** | [**Guid**](Guid.md)| GUID of the magnet | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **document** | [**NewDocument**](NewDocument.md)| Model of the new document | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MagnetsCreateMagnet

> Object MagnetsCreateMagnet (Guid magnetId, string authorization, MagnetCreationData magnetCreationData)

Creates a sub-magnet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class MagnetsCreateMagnetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new MagnetsApi(Configuration.Default);
            var magnetId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var magnetCreationData = new MagnetCreationData(); // MagnetCreationData | 

            try
            {
                // Creates a sub-magnet
                Object result = apiInstance.MagnetsCreateMagnet(magnetId, authorization, magnetCreationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MagnetsApi.MagnetsCreateMagnet: " + e.Message );
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
 **magnetId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **magnetCreationData** | [**MagnetCreationData**](MagnetCreationData.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MagnetsGetMagnet

> Magnet MagnetsGetMagnet (Guid magnetId, string authorization)

Returns the requested magnet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class MagnetsGetMagnetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new MagnetsApi(Configuration.Default);
            var magnetId = new Guid(); // Guid | GUID of the magnet
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested magnet
                Magnet result = apiInstance.MagnetsGetMagnet(magnetId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MagnetsApi.MagnetsGetMagnet: " + e.Message );
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
 **magnetId** | [**Guid**](Guid.md)| GUID of the magnet | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**Magnet**](Magnet.md)

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


## MagnetsGetMagnetDocuments

> List&lt;Document&gt; MagnetsGetMagnetDocuments (Guid magnetId, string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns all documents attached to the magnet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class MagnetsGetMagnetDocumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new MagnetsApi(Configuration.Default);
            var magnetId = new Guid(); // Guid | GUID of the magnet
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns all documents attached to the magnet
                List<Document> result = apiInstance.MagnetsGetMagnetDocuments(magnetId, authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MagnetsApi.MagnetsGetMagnetDocuments: " + e.Message );
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
 **magnetId** | [**Guid**](Guid.md)| GUID of the magnet | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **includeTags** | **bool?**| Decides if tags for each document in response should be included (optional - default false) | [optional] 
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


## MagnetsGetSubMagnets

> List&lt;Magnet&gt; MagnetsGetSubMagnets (Guid magnetId, string authorization)

Returns all sub-magnets under the magnet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class MagnetsGetSubMagnetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new MagnetsApi(Configuration.Default);
            var magnetId = new Guid(); // Guid | GUID of the parent magnet
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all sub-magnets under the magnet
                List<Magnet> result = apiInstance.MagnetsGetSubMagnets(magnetId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MagnetsApi.MagnetsGetSubMagnets: " + e.Message );
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
 **magnetId** | [**Guid**](Guid.md)| GUID of the parent magnet | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;Magnet&gt;**](Magnet.md)

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

