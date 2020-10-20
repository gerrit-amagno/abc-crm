# AmagnoWebApi.Client.Api.SelectionDefinitionsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SelectionDefinitionsCreateNode**](SelectionDefinitionsApi.md#selectiondefinitionscreatenode) | **POST** /selection-definitions/{tagDefinitionId}/nodes | Creates selection definition node
[**SelectionDefinitionsGetNodes**](SelectionDefinitionsApi.md#selectiondefinitionsgetnodes) | **GET** /selection-definitions/{tagDefinitionId}/nodes | Returns top level nodes of the selection definition
[**SelectionDefinitionsGetTree**](SelectionDefinitionsApi.md#selectiondefinitionsgettree) | **GET** /selection-definitions/{tagDefinitionId}/tree | Returns complete node tree of the selection definition



## SelectionDefinitionsCreateNode

> Object SelectionDefinitionsCreateNode (Guid tagDefinitionId, string authorization, SelectionTagDefinitionNodeCreationData model)

Creates selection definition node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionsCreateNodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionsApi(Configuration.Default);
            var tagDefinitionId = new Guid(); // Guid | GUID of the selection definition
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new SelectionTagDefinitionNodeCreationData(); // SelectionTagDefinitionNodeCreationData | Selection definition node information

            try
            {
                // Creates selection definition node
                Object result = apiInstance.SelectionDefinitionsCreateNode(tagDefinitionId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionsApi.SelectionDefinitionsCreateNode: " + e.Message );
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
 **tagDefinitionId** | [**Guid**](Guid.md)| GUID of the selection definition | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**SelectionTagDefinitionNodeCreationData**](SelectionTagDefinitionNodeCreationData.md)| Selection definition node information | 

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


## SelectionDefinitionsGetNodes

> List&lt;SelectionTagDefinitionNode&gt; SelectionDefinitionsGetNodes (Guid tagDefinitionId, string authorization)

Returns top level nodes of the selection definition

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionsGetNodesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionsApi(Configuration.Default);
            var tagDefinitionId = new Guid(); // Guid | GUID of the selection definition
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns top level nodes of the selection definition
                List<SelectionTagDefinitionNode> result = apiInstance.SelectionDefinitionsGetNodes(tagDefinitionId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionsApi.SelectionDefinitionsGetNodes: " + e.Message );
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
 **tagDefinitionId** | [**Guid**](Guid.md)| GUID of the selection definition | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;SelectionTagDefinitionNode&gt;**](SelectionTagDefinitionNode.md)

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


## SelectionDefinitionsGetTree

> SelectionTagDefinitionTree SelectionDefinitionsGetTree (Guid tagDefinitionId, string authorization)

Returns complete node tree of the selection definition

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionsGetTreeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionsApi(Configuration.Default);
            var tagDefinitionId = new Guid(); // Guid | GUID of the selection definition
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns complete node tree of the selection definition
                SelectionTagDefinitionTree result = apiInstance.SelectionDefinitionsGetTree(tagDefinitionId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionsApi.SelectionDefinitionsGetTree: " + e.Message );
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
 **tagDefinitionId** | [**Guid**](Guid.md)| GUID of the selection definition | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**SelectionTagDefinitionTree**](SelectionTagDefinitionTree.md)

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

