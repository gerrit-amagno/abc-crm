# AmagnoWebApi.Client.Api.TagsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagsPutDate**](TagsApi.md#tagsputdate) | **PUT** /tags/dates/{tagId} | Sets a new value for the date tag
[**TagsPutNumber**](TagsApi.md#tagsputnumber) | **PUT** /tags/numbers/{tagId} | Sets a new value for the number tag
[**TagsPutSelection**](TagsApi.md#tagsputselection) | **PUT** /tags/selections/{tagId} | Sets a new value for the selection tag
[**TagsPutSingleLineString**](TagsApi.md#tagsputsinglelinestring) | **PUT** /tags/single-line-strings/{tagId} | Sets a new value for the single line string tag



## TagsPutDate

> Object TagsPutDate (Guid tagId, string authorization, DateTime value)

Sets a new value for the date tag

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagsPutDateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagsApi(Configuration.Default);
            var tagId = new Guid(); // Guid | GUID of tag
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var value = 2013-10-20T19:20:30+01:00;  // DateTime | UTC in ISO 8601 format

            try
            {
                // Sets a new value for the date tag
                Object result = apiInstance.TagsPutDate(tagId, authorization, value);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagsApi.TagsPutDate: " + e.Message );
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
 **tagId** | [**Guid**](Guid.md)| GUID of tag | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **value** | **DateTime**| UTC in ISO 8601 format | 

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


## TagsPutNumber

> Object TagsPutNumber (Guid tagId, string authorization, long? value = null)

Sets a new value for the number tag

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagsPutNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagsApi(Configuration.Default);
            var tagId = new Guid(); // Guid | GUID of tag
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var value = 789;  // long? | Long value, where last X numbers will be set as a decimal part. X is DecimalNumbers field from appropriated tag definition (optional) 

            try
            {
                // Sets a new value for the number tag
                Object result = apiInstance.TagsPutNumber(tagId, authorization, value);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagsApi.TagsPutNumber: " + e.Message );
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
 **tagId** | [**Guid**](Guid.md)| GUID of tag | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **value** | **long?**| Long value, where last X numbers will be set as a decimal part. X is DecimalNumbers field from appropriated tag definition | [optional] 

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


## TagsPutSelection

> Object TagsPutSelection (Guid tagId, string authorization, List<Guid> selectedNodeIds = null)

Sets a new value for the selection tag

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagsPutSelectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagsApi(Configuration.Default);
            var tagId = new Guid(); // Guid | GUID of tag
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var selectedNodeIds = new List<Guid>(); // List<Guid> | Selected node GUIDs (optional) 

            try
            {
                // Sets a new value for the selection tag
                Object result = apiInstance.TagsPutSelection(tagId, authorization, selectedNodeIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagsApi.TagsPutSelection: " + e.Message );
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
 **tagId** | [**Guid**](Guid.md)| GUID of tag | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **selectedNodeIds** | [**List&lt;Guid&gt;**](Guid.md)| Selected node GUIDs | [optional] 

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


## TagsPutSingleLineString

> Object TagsPutSingleLineString (Guid tagId, string authorization, string value = null)

Sets a new value for the single line string tag

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagsPutSingleLineStringExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagsApi(Configuration.Default);
            var tagId = new Guid(); // Guid | GUID of tag
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var value = value_example;  // string | String value (optional) 

            try
            {
                // Sets a new value for the single line string tag
                Object result = apiInstance.TagsPutSingleLineString(tagId, authorization, value);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagsApi.TagsPutSingleLineString: " + e.Message );
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
 **tagId** | [**Guid**](Guid.md)| GUID of tag | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **value** | **string**| String value | [optional] 

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

