# AmagnoWebApi.Client.Api.SelectionDefinitionNodesApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SelectionDefinitionNodesCreate**](SelectionDefinitionNodesApi.md#selectiondefinitionnodescreate) | **POST** /selection-definition-nodes/{nodeId}/nodes | Creates sub-node under the selection definition node
[**SelectionDefinitionNodesGetNode**](SelectionDefinitionNodesApi.md#selectiondefinitionnodesgetnode) | **GET** /selection-definition-nodes/{nodeId} | Returns information about the selection definition node
[**SelectionDefinitionNodesGetNodes**](SelectionDefinitionNodesApi.md#selectiondefinitionnodesgetnodes) | **GET** /selection-definition-nodes/{nodeId}/nodes | Returns sub-nodes under the selection definition node
[**SelectionDefinitionNodesUpdate**](SelectionDefinitionNodesApi.md#selectiondefinitionnodesupdate) | **PUT** /selection-definition-nodes/{nodeId} | Updates the selection definition node



## SelectionDefinitionNodesCreate

> Object SelectionDefinitionNodesCreate (Guid nodeId, string authorization, SelectionTagDefinitionNodeCreationData model)

Creates sub-node under the selection definition node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionNodesCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionNodesApi(Configuration.Default);
            var nodeId = new Guid(); // Guid | GUID of the selection definition node
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new SelectionTagDefinitionNodeCreationData(); // SelectionTagDefinitionNodeCreationData | Selection definition node information

            try
            {
                // Creates sub-node under the selection definition node
                Object result = apiInstance.SelectionDefinitionNodesCreate(nodeId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionNodesApi.SelectionDefinitionNodesCreate: " + e.Message );
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
 **nodeId** | [**Guid**](Guid.md)| GUID of the selection definition node | 
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


## SelectionDefinitionNodesGetNode

> SelectionTagDefinitionNode SelectionDefinitionNodesGetNode (Guid nodeId, string authorization)

Returns information about the selection definition node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionNodesGetNodeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionNodesApi(Configuration.Default);
            var nodeId = new Guid(); // Guid | GUID of the selection definition node
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns information about the selection definition node
                SelectionTagDefinitionNode result = apiInstance.SelectionDefinitionNodesGetNode(nodeId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionNodesApi.SelectionDefinitionNodesGetNode: " + e.Message );
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
 **nodeId** | [**Guid**](Guid.md)| GUID of the selection definition node | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**SelectionTagDefinitionNode**](SelectionTagDefinitionNode.md)

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


## SelectionDefinitionNodesGetNodes

> List&lt;SelectionTagDefinitionNode&gt; SelectionDefinitionNodesGetNodes (Guid nodeId, string authorization)

Returns sub-nodes under the selection definition node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionNodesGetNodesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionNodesApi(Configuration.Default);
            var nodeId = new Guid(); // Guid | GUID of the selection definition node
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns sub-nodes under the selection definition node
                List<SelectionTagDefinitionNode> result = apiInstance.SelectionDefinitionNodesGetNodes(nodeId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionNodesApi.SelectionDefinitionNodesGetNodes: " + e.Message );
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
 **nodeId** | [**Guid**](Guid.md)| GUID of the selection definition node | 
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


## SelectionDefinitionNodesUpdate

> Object SelectionDefinitionNodesUpdate (Guid nodeId, string authorization, SelectionTagDefinitionNodeUpdateData model)

Updates the selection definition node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class SelectionDefinitionNodesUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new SelectionDefinitionNodesApi(Configuration.Default);
            var nodeId = new Guid(); // Guid | GUID of the selection definition node
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var model = new SelectionTagDefinitionNodeUpdateData(); // SelectionTagDefinitionNodeUpdateData | Selection definition node information

            try
            {
                // Updates the selection definition node
                Object result = apiInstance.SelectionDefinitionNodesUpdate(nodeId, authorization, model);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SelectionDefinitionNodesApi.SelectionDefinitionNodesUpdate: " + e.Message );
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
 **nodeId** | [**Guid**](Guid.md)| GUID of the selection definition node | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **model** | [**SelectionTagDefinitionNodeUpdateData**](SelectionTagDefinitionNodeUpdateData.md)| Selection definition node information | 

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

