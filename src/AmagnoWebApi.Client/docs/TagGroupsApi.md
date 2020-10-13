# AmagnoWebApi.Client.Api.TagGroupsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagGroupsGetTagGroup**](TagGroupsApi.md#taggroupsgettaggroup) | **GET** /tag-groups/{tagGroupId} | Returns information about the tag group
[**TagGroupsGetTagGroupTags**](TagGroupsApi.md#taggroupsgettaggrouptags) | **GET** /tag-groups/{tagGroupId}/tags | Returns all tags in the tag group



## TagGroupsGetTagGroup

> TagGroup TagGroupsGetTagGroup (Guid tagGroupId, string authorization)

Returns information about the tag group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagGroupsGetTagGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagGroupsApi(Configuration.Default);
            var tagGroupId = new Guid(); // Guid | GUID of the tag group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns information about the tag group
                TagGroup result = apiInstance.TagGroupsGetTagGroup(tagGroupId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagGroupsApi.TagGroupsGetTagGroup: " + e.Message );
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
 **tagGroupId** | [**Guid**](Guid.md)| GUID of the tag group | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**TagGroup**](TagGroup.md)

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


## TagGroupsGetTagGroupTags

> TagCollections TagGroupsGetTagGroupTags (Guid tagGroupId, string authorization)

Returns all tags in the tag group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TagGroupsGetTagGroupTagsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TagGroupsApi(Configuration.Default);
            var tagGroupId = new Guid(); // Guid | GUID of the tag group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all tags in the tag group
                TagCollections result = apiInstance.TagGroupsGetTagGroupTags(tagGroupId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TagGroupsApi.TagGroupsGetTagGroupTags: " + e.Message );
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
 **tagGroupId** | [**Guid**](Guid.md)| GUID of the tag group | 
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

