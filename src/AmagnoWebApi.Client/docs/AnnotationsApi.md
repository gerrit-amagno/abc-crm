# AmagnoWebApi.Client.Api.AnnotationsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnnotationsGetHighlightAnnotation**](AnnotationsApi.md#annotationsgethighlightannotation) | **GET** /annotations/highlights/{annotationId} | Returns the requested highlight annotation
[**AnnotationsGetInkAnnotation**](AnnotationsApi.md#annotationsgetinkannotation) | **GET** /annotations/inks/{annotationId} | Returns the requested ink annotation
[**AnnotationsGetMarkLineAnnotation**](AnnotationsApi.md#annotationsgetmarklineannotation) | **GET** /annotations/mark-lines/{annotationId} | Returns the requested mark-line annotation
[**AnnotationsGetNoteAnnotation**](AnnotationsApi.md#annotationsgetnoteannotation) | **GET** /annotations/notes/{annotationId} | Returns the requested note annotation
[**AnnotationsGetSignatureAnnotation**](AnnotationsApi.md#annotationsgetsignatureannotation) | **GET** /annotations/signatures/{annotationId} | Returns the requested signature annotation
[**AnnotationsGetStampAnnotation**](AnnotationsApi.md#annotationsgetstampannotation) | **GET** /annotations/stamps/{annotationId} | Returns the requested stamp annotation



## AnnotationsGetHighlightAnnotation

> HighlightAnnotation AnnotationsGetHighlightAnnotation (Guid annotationId, string authorization)

Returns the requested highlight annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetHighlightAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested highlight annotation
                HighlightAnnotation result = apiInstance.AnnotationsGetHighlightAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetHighlightAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**HighlightAnnotation**](HighlightAnnotation.md)

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


## AnnotationsGetInkAnnotation

> InkAnnotation AnnotationsGetInkAnnotation (Guid annotationId, string authorization)

Returns the requested ink annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetInkAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested ink annotation
                InkAnnotation result = apiInstance.AnnotationsGetInkAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetInkAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**InkAnnotation**](InkAnnotation.md)

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


## AnnotationsGetMarkLineAnnotation

> MarkLineAnnotation AnnotationsGetMarkLineAnnotation (Guid annotationId, string authorization)

Returns the requested mark-line annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetMarkLineAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested mark-line annotation
                MarkLineAnnotation result = apiInstance.AnnotationsGetMarkLineAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetMarkLineAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**MarkLineAnnotation**](MarkLineAnnotation.md)

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


## AnnotationsGetNoteAnnotation

> NoteAnnotation AnnotationsGetNoteAnnotation (Guid annotationId, string authorization)

Returns the requested note annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetNoteAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested note annotation
                NoteAnnotation result = apiInstance.AnnotationsGetNoteAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetNoteAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**NoteAnnotation**](NoteAnnotation.md)

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


## AnnotationsGetSignatureAnnotation

> SignatureAnnotation AnnotationsGetSignatureAnnotation (Guid annotationId, string authorization)

Returns the requested signature annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetSignatureAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested signature annotation
                SignatureAnnotation result = apiInstance.AnnotationsGetSignatureAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetSignatureAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**SignatureAnnotation**](SignatureAnnotation.md)

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


## AnnotationsGetStampAnnotation

> StampAnnotation AnnotationsGetStampAnnotation (Guid annotationId, string authorization)

Returns the requested stamp annotation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class AnnotationsGetStampAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new AnnotationsApi(Configuration.Default);
            var annotationId = new Guid(); // Guid | GUID of the annotation
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested stamp annotation
                StampAnnotation result = apiInstance.AnnotationsGetStampAnnotation(annotationId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnotationsApi.AnnotationsGetStampAnnotation: " + e.Message );
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
 **annotationId** | [**Guid**](Guid.md)| GUID of the annotation | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**StampAnnotation**](StampAnnotation.md)

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

