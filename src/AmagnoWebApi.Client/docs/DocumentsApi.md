# AmagnoWebApi.Client.Api.DocumentsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsAssign**](DocumentsApi.md#documentsassign) | **POST** /documents/assignments | Creates assignment between two documents
[**DocumentsCheckOut**](DocumentsApi.md#documentscheckout) | **POST** /documents/{documentId}/check-out | Creates new version of the document to edit (check-out) only by the requested user.  All changes made to the document can be once applied or reverted
[**DocumentsCreateHighlightAnnotation**](DocumentsApi.md#documentscreatehighlightannotation) | **POST** /documents/{documentId}/annotations/highlights | Creates highlight annotation
[**DocumentsCreateInkAnnotation**](DocumentsApi.md#documentscreateinkannotation) | **POST** /documents/{documentId}/annotations/inks | Creates ink annotation
[**DocumentsCreateMarkLineAnnotation**](DocumentsApi.md#documentscreatemarklineannotation) | **POST** /documents/{documentId}/annotations/mark-lines | Creates mark-line annotation
[**DocumentsCreateNoteAnnotation**](DocumentsApi.md#documentscreatenoteannotation) | **POST** /documents/{documentId}/annotations/notes | Creates note annotation
[**DocumentsCreateSignatureAnnotation**](DocumentsApi.md#documentscreatesignatureannotation) | **POST** /documents/{documentId}/annotations/signatures | Creates signature annotation
[**DocumentsCreateTagGroup**](DocumentsApi.md#documentscreatetaggroup) | **POST** /documents/{documentId}/tag-groups | Creates multi tag group
[**DocumentsGet**](DocumentsApi.md#documentsget) | **GET** /documents/{documentId} | Returns information about the document
[**DocumentsGetAccessibleStamps**](DocumentsApi.md#documentsgetaccessiblestamps) | **GET** /documents/{documentId}/accessible-stamps | Returns accessible stamps for a document
[**DocumentsGetAdvancedSearchInformation**](DocumentsApi.md#documentsgetadvancedsearchinformation) | **GET** /documents/advanced-search/{searchId} | Returns document search information
[**DocumentsGetAdvancedSearchResults**](DocumentsApi.md#documentsgetadvancedsearchresults) | **GET** /documents/advanced-search/{searchId}/results | Returns document search results
[**DocumentsGetAnnotations**](DocumentsApi.md#documentsgetannotations) | **GET** /documents/{documentId}/annotations | Returns document annotations
[**DocumentsGetAssigns**](DocumentsApi.md#documentsgetassigns) | **GET** /documents/{documentId}/assignments | Returns document assignments
[**DocumentsGetOriginalFormat**](DocumentsApi.md#documentsgetoriginalformat) | **GET** /documents/{documentId}/file | Returns the document in its original format
[**DocumentsGetPDFFormat**](DocumentsApi.md#documentsgetpdfformat) | **GET** /documents/{documentId}/pdf | Returns the document as PDF
[**DocumentsGetPDFFormatWithAnnotations**](DocumentsApi.md#documentsgetpdfformatwithannotations) | **GET** /documents/{documentId}/annotated-pdf | Returns the document including any annotations as a PDF
[**DocumentsGetPreviewImage**](DocumentsApi.md#documentsgetpreviewimage) | **GET** /documents/{documentId}/preview | Returns a preview of the document
[**DocumentsGetSearchInformation**](DocumentsApi.md#documentsgetsearchinformation) | **GET** /documents/search/{searchId} | Returns document search information
[**DocumentsGetSearchResults**](DocumentsApi.md#documentsgetsearchresults) | **GET** /documents/search/{searchId}/results | Returns document search results
[**DocumentsGetTagDefinitions**](DocumentsApi.md#documentsgettagdefinitions) | **GET** /documents/tag-definitions | Returns all document tag definitions
[**DocumentsGetTagGroups**](DocumentsApi.md#documentsgettaggroups) | **GET** /documents/{documentId}/tag-groups | Returns document tag groups
[**DocumentsGetTags**](DocumentsApi.md#documentsgettags) | **GET** /documents/{documentId}/tags | Returns document tags
[**DocumentsInitAdvancedSearch**](DocumentsApi.md#documentsinitadvancedsearch) | **POST** /documents/advanced-search | Initializes document search for the given search condition and saves results on the server. These results are available for 2 hours from the last access
[**DocumentsInitSearch**](DocumentsApi.md#documentsinitsearch) | **POST** /documents/search | Initializes document search for the given search string and saves results on the server. These results are available for 2 hours from the last access
[**DocumentsPutStream**](DocumentsApi.md#documentsputstream) | **PUT** /documents/{documentId}/file | Sets file content
[**DocumentsStampDocument**](DocumentsApi.md#documentsstampdocument) | **PUT** /documents/{documentId}/stamp | Stamps a document
[**DocumentsTrash**](DocumentsApi.md#documentstrash) | **POST** /documents/{documentId}/trash | Throws the selected document into the trash
[**DocumentsUpdate**](DocumentsApi.md#documentsupdate) | **PUT** /documents/{documentId} | Updates a document



## DocumentsAssign

> Object DocumentsAssign (string authorization, AssignmentCreationData assignment)

Creates assignment between two documents

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsAssignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var assignment = new AssignmentCreationData(); // AssignmentCreationData | Assignment parameters

            try
            {
                // Creates assignment between two documents
                Object result = apiInstance.DocumentsAssign(authorization, assignment);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsAssign: " + e.Message );
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
 **assignment** | [**AssignmentCreationData**](AssignmentCreationData.md)| Assignment parameters | 

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


## DocumentsCheckOut

> Object DocumentsCheckOut (Guid documentId, string authorization)

Creates new version of the document to edit (check-out) only by the requested user.  All changes made to the document can be once applied or reverted

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCheckOutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Creates new version of the document to edit (check-out) only by the requested user.  All changes made to the document can be once applied or reverted
                Object result = apiInstance.DocumentsCheckOut(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCheckOut: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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


## DocumentsCreateHighlightAnnotation

> Object DocumentsCreateHighlightAnnotation (Guid documentId, string authorization, HighlightAnnotationCreationData model)

Creates highlight annotation

The document has to be checked out beforehand.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateHighlightAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new HighlightAnnotationCreationData(); // HighlightAnnotationCreationData | Annotation information

            try
            {
                // Creates highlight annotation
                Object result = apiInstance.DocumentsCreateHighlightAnnotation(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateHighlightAnnotation: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**HighlightAnnotationCreationData**](HighlightAnnotationCreationData.md)| Annotation information | 

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


## DocumentsCreateInkAnnotation

> Object DocumentsCreateInkAnnotation (Guid documentId, string authorization, InkAnnotationCreationData model)

Creates ink annotation

The document has to be checked out beforehand.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateInkAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new InkAnnotationCreationData(); // InkAnnotationCreationData | Annotation information

            try
            {
                // Creates ink annotation
                Object result = apiInstance.DocumentsCreateInkAnnotation(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateInkAnnotation: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**InkAnnotationCreationData**](InkAnnotationCreationData.md)| Annotation information | 

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


## DocumentsCreateMarkLineAnnotation

> Object DocumentsCreateMarkLineAnnotation (Guid documentId, string authorization, MarkLineAnnotationCreationData model)

Creates mark-line annotation

The document has to be checked out beforehand.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateMarkLineAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new MarkLineAnnotationCreationData(); // MarkLineAnnotationCreationData | Annotation information

            try
            {
                // Creates mark-line annotation
                Object result = apiInstance.DocumentsCreateMarkLineAnnotation(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateMarkLineAnnotation: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**MarkLineAnnotationCreationData**](MarkLineAnnotationCreationData.md)| Annotation information | 

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


## DocumentsCreateNoteAnnotation

> Object DocumentsCreateNoteAnnotation (Guid documentId, string authorization, NoteAnnotationCreationData model)

Creates note annotation

The document has to be checked out beforehand.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateNoteAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new NoteAnnotationCreationData(); // NoteAnnotationCreationData | Annotation information

            try
            {
                // Creates note annotation
                Object result = apiInstance.DocumentsCreateNoteAnnotation(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateNoteAnnotation: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**NoteAnnotationCreationData**](NoteAnnotationCreationData.md)| Annotation information | 

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


## DocumentsCreateSignatureAnnotation

> Object DocumentsCreateSignatureAnnotation (Guid documentId, string authorization, SignatureAnnotationCreationData model)

Creates signature annotation

The document has to be checked out beforehand.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateSignatureAnnotationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new SignatureAnnotationCreationData(); // SignatureAnnotationCreationData | Annotation information

            try
            {
                // Creates signature annotation
                Object result = apiInstance.DocumentsCreateSignatureAnnotation(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateSignatureAnnotation: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**SignatureAnnotationCreationData**](SignatureAnnotationCreationData.md)| Annotation information | 

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


## DocumentsCreateTagGroup

> Object DocumentsCreateTagGroup (Guid documentId, string authorization, TagGroupCreationData model)

Creates multi tag group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsCreateTagGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new TagGroupCreationData(); // TagGroupCreationData | Tag group information

            try
            {
                // Creates multi tag group
                Object result = apiInstance.DocumentsCreateTagGroup(documentId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreateTagGroup: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**TagGroupCreationData**](TagGroupCreationData.md)| Tag group information | 

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


## DocumentsGet

> Document DocumentsGet (Guid documentId, string authorization, bool? includeTags = null)

Returns information about the document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags should be included (optional - default false) (optional) 

            try
            {
                // Returns information about the document
                Document result = apiInstance.DocumentsGet(documentId, authorization, includeTags);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGet: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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


## DocumentsGetAccessibleStamps

> List&lt;Stamp&gt; DocumentsGetAccessibleStamps (Guid documentId, string authorization)

Returns accessible stamps for a document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetAccessibleStampsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns accessible stamps for a document
                List<Stamp> result = apiInstance.DocumentsGetAccessibleStamps(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetAccessibleStamps: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;Stamp&gt;**](Stamp.md)

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


## DocumentsGetAdvancedSearchInformation

> SearchInformation DocumentsGetAdvancedSearchInformation (Guid searchId, string authorization)

Returns document search information

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetAdvancedSearchInformationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var searchId = new Guid(); // Guid | GUID of search results
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document search information
                SearchInformation result = apiInstance.DocumentsGetAdvancedSearchInformation(searchId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetAdvancedSearchInformation: " + e.Message );
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
 **searchId** | [**Guid**](Guid.md)| GUID of search results | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**SearchInformation**](SearchInformation.md)

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


## DocumentsGetAdvancedSearchResults

> List&lt;Document&gt; DocumentsGetAdvancedSearchResults (Guid searchId, string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns document search results

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetAdvancedSearchResultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var searchId = new Guid(); // Guid | GUID of search results
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns document search results
                List<Document> result = apiInstance.DocumentsGetAdvancedSearchResults(searchId, authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetAdvancedSearchResults: " + e.Message );
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
 **searchId** | [**Guid**](Guid.md)| GUID of search results | 
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


## DocumentsGetAnnotations

> AnnotationCollections DocumentsGetAnnotations (Guid documentId, string authorization)

Returns document annotations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetAnnotationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document annotations
                AnnotationCollections result = apiInstance.DocumentsGetAnnotations(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetAnnotations: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**AnnotationCollections**](AnnotationCollections.md)

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


## DocumentsGetAssigns

> AssignmentCollections DocumentsGetAssigns (Guid documentId, string authorization)

Returns document assignments

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetAssignsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document assignments
                AssignmentCollections result = apiInstance.DocumentsGetAssigns(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetAssigns: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**AssignmentCollections**](AssignmentCollections.md)

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


## DocumentsGetOriginalFormat

> Object DocumentsGetOriginalFormat (Guid documentId, string authorization)

Returns the document in its original format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetOriginalFormatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the document in its original format
                Object result = apiInstance.DocumentsGetOriginalFormat(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetOriginalFormat: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsGetPDFFormat

> Object DocumentsGetPDFFormat (Guid documentId, string authorization)

Returns the document as PDF

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetPDFFormatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the document as PDF
                Object result = apiInstance.DocumentsGetPDFFormat(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetPDFFormat: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsGetPDFFormatWithAnnotations

> Object DocumentsGetPDFFormatWithAnnotations (Guid documentId, string authorization)

Returns the document including any annotations as a PDF

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetPDFFormatWithAnnotationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the document including any annotations as a PDF
                Object result = apiInstance.DocumentsGetPDFFormatWithAnnotations(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetPDFFormatWithAnnotations: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsGetPreviewImage

> Object DocumentsGetPreviewImage (Guid documentId, int page, string size, string authorization)

Returns a preview of the document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetPreviewImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var page = 56;  // int | The desired page number (starts at 1)
            var size = size_example;  // string | The desired size of the preview image
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns a preview of the document
                Object result = apiInstance.DocumentsGetPreviewImage(documentId, page, size, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetPreviewImage: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **page** | **int**| The desired page number (starts at 1) | 
 **size** | **string**| The desired size of the preview image | 
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
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsGetSearchInformation

> SearchInformation DocumentsGetSearchInformation (Guid searchId, string authorization)

Returns document search information

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetSearchInformationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var searchId = new Guid(); // Guid | GUID of search results
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document search information
                SearchInformation result = apiInstance.DocumentsGetSearchInformation(searchId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetSearchInformation: " + e.Message );
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
 **searchId** | [**Guid**](Guid.md)| GUID of search results | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**SearchInformation**](SearchInformation.md)

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


## DocumentsGetSearchResults

> List&lt;Document&gt; DocumentsGetSearchResults (Guid searchId, string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns document search results

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetSearchResultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var searchId = new Guid(); // Guid | GUID of search results
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns document search results
                List<Document> result = apiInstance.DocumentsGetSearchResults(searchId, authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetSearchResults: " + e.Message );
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
 **searchId** | [**Guid**](Guid.md)| GUID of search results | 
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


## DocumentsGetTagDefinitions

> TagDefinitionCollections DocumentsGetTagDefinitions (string authorization)

Returns all document tag definitions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetTagDefinitionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all document tag definitions
                TagDefinitionCollections result = apiInstance.DocumentsGetTagDefinitions(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetTagDefinitions: " + e.Message );
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


## DocumentsGetTagGroups

> List&lt;TagGroup&gt; DocumentsGetTagGroups (Guid documentId, string authorization)

Returns document tag groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetTagGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document tag groups
                List<TagGroup> result = apiInstance.DocumentsGetTagGroups(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetTagGroups: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;TagGroup&gt;**](TagGroup.md)

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


## DocumentsGetTags

> TagCollections DocumentsGetTags (Guid documentId, string authorization)

Returns document tags

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsGetTagsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns document tags
                TagCollections result = apiInstance.DocumentsGetTags(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetTags: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**TagCollections**](TagCollections.md)

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


## DocumentsInitAdvancedSearch

> Object DocumentsInitAdvancedSearch (string authorization, AdvancedDocumentSearchFilter filter)

Initializes document search for the given search condition and saves results on the server. These results are available for 2 hours from the last access

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsInitAdvancedSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var filter = new AdvancedDocumentSearchFilter(); // AdvancedDocumentSearchFilter | Filter information

            try
            {
                // Initializes document search for the given search condition and saves results on the server. These results are available for 2 hours from the last access
                Object result = apiInstance.DocumentsInitAdvancedSearch(authorization, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsInitAdvancedSearch: " + e.Message );
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
 **filter** | [**AdvancedDocumentSearchFilter**](AdvancedDocumentSearchFilter.md)| Filter information | 

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


## DocumentsInitSearch

> Object DocumentsInitSearch (string authorization, DocumentSearchFilter filter)

Initializes document search for the given search string and saves results on the server. These results are available for 2 hours from the last access

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsInitSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var filter = new DocumentSearchFilter(); // DocumentSearchFilter | Filter information

            try
            {
                // Initializes document search for the given search string and saves results on the server. These results are available for 2 hours from the last access
                Object result = apiInstance.DocumentsInitSearch(authorization, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsInitSearch: " + e.Message );
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
 **filter** | [**DocumentSearchFilter**](DocumentSearchFilter.md)| Filter information | 

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


## DocumentsPutStream

> Object DocumentsPutStream (Guid documentId, string authorization, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE, string amagnoFileCreateDate = null, string amagnoFileChangeDate = null)

Sets file content

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsPutStreamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
            var amagnoFileCreateDate = amagnoFileCreateDate_example;  // string | File create UTC in ISO 8601 format. Required if the document already has a file (optional) 
            var amagnoFileChangeDate = amagnoFileChangeDate_example;  // string | Last file change UTC in ISO 8601 format. Required if the document already has a file (optional) 

            try
            {
                // Sets file content
                Object result = apiInstance.DocumentsPutStream(documentId, authorization, UNKNOWN_BASE_TYPE, amagnoFileCreateDate, amagnoFileChangeDate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsPutStream: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 
 **amagnoFileCreateDate** | **string**| File create UTC in ISO 8601 format. Required if the document already has a file | [optional] 
 **amagnoFileChangeDate** | **string**| Last file change UTC in ISO 8601 format. Required if the document already has a file | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/form-data
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | NoContent |  -  |
| **413** | File is too large! |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsStampDocument

> Object DocumentsStampDocument (Guid documentId, string authorization, StampingData stampingData)

Stamps a document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsStampDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var stampingData = new StampingData(); // StampingData | Stamp parameters

            try
            {
                // Stamps a document
                Object result = apiInstance.DocumentsStampDocument(documentId, authorization, stampingData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsStampDocument: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **stampingData** | [**StampingData**](StampingData.md)| Stamp parameters | 

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
| **204** | NoContent |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DocumentsTrash

> Object DocumentsTrash (Guid documentId, string authorization)

Throws the selected document into the trash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsTrashExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Throws the selected document into the trash
                Object result = apiInstance.DocumentsTrash(documentId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsTrash: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
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


## DocumentsUpdate

> Object DocumentsUpdate (Guid documentId, string authorization, DocumentUpdateData data)

Updates a document

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class DocumentsUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new DocumentsApi(Configuration.Default);
            var documentId = new Guid(); // Guid | GUID of the document
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var data = new DocumentUpdateData(); // DocumentUpdateData | Document data

            try
            {
                // Updates a document
                Object result = apiInstance.DocumentsUpdate(documentId, authorization, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsUpdate: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| GUID of the document | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **data** | [**DocumentUpdateData**](DocumentUpdateData.md)| Document data | 

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
| **204** | NoContent |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

