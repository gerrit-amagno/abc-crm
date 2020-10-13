# AmagnoWebApi.Client.Api.UserGroupsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserGroupsAddMember**](UserGroupsApi.md#usergroupsaddmember) | **POST** /user-groups/{userGroupId}/members | Starts user membership in a user group
[**UserGroupsDelete**](UserGroupsApi.md#usergroupsdelete) | **DELETE** /user-groups/{userGroupId} | Deletes a user group
[**UserGroupsGet**](UserGroupsApi.md#usergroupsget) | **GET** /user-groups/{userGroupId} | Returns a user group
[**UserGroupsGetMembers**](UserGroupsApi.md#usergroupsgetmembers) | **GET** /user-groups/{userGroupId}/members | Returns user group members
[**UserGroupsUpdate**](UserGroupsApi.md#usergroupsupdate) | **PUT** /user-groups/{userGroupId} | Updates a user group



## UserGroupsAddMember

> Object UserGroupsAddMember (Guid userGroupId, string authorization, UserGroupMemberCreationData data)

Starts user membership in a user group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class UserGroupsAddMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new UserGroupsApi(Configuration.Default);
            var userGroupId = new Guid(); // Guid | GUID of the user group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var data = new UserGroupMemberCreationData(); // UserGroupMemberCreationData | GUID of the user

            try
            {
                // Starts user membership in a user group
                Object result = apiInstance.UserGroupsAddMember(userGroupId, authorization, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserGroupsApi.UserGroupsAddMember: " + e.Message );
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
 **userGroupId** | [**Guid**](Guid.md)| GUID of the user group | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **data** | [**UserGroupMemberCreationData**](UserGroupMemberCreationData.md)| GUID of the user | 

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


## UserGroupsDelete

> Object UserGroupsDelete (Guid userGroupId, string authorization)

Deletes a user group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class UserGroupsDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new UserGroupsApi(Configuration.Default);
            var userGroupId = new Guid(); // Guid | GUID of the user group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Deletes a user group
                Object result = apiInstance.UserGroupsDelete(userGroupId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserGroupsApi.UserGroupsDelete: " + e.Message );
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
 **userGroupId** | [**Guid**](Guid.md)| GUID of the user group | 
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


## UserGroupsGet

> UserGroup UserGroupsGet (Guid userGroupId, string authorization)

Returns a user group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class UserGroupsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new UserGroupsApi(Configuration.Default);
            var userGroupId = new Guid(); // Guid | GUID of the user group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns a user group
                UserGroup result = apiInstance.UserGroupsGet(userGroupId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserGroupsApi.UserGroupsGet: " + e.Message );
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
 **userGroupId** | [**Guid**](Guid.md)| GUID of the user group | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**UserGroup**](UserGroup.md)

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


## UserGroupsGetMembers

> List&lt;UserGroupMember&gt; UserGroupsGetMembers (Guid userGroupId, string authorization)

Returns user group members

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class UserGroupsGetMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new UserGroupsApi(Configuration.Default);
            var userGroupId = new Guid(); // Guid | GUID of the user group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns user group members
                List<UserGroupMember> result = apiInstance.UserGroupsGetMembers(userGroupId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserGroupsApi.UserGroupsGetMembers: " + e.Message );
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
 **userGroupId** | [**Guid**](Guid.md)| GUID of the user group | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;UserGroupMember&gt;**](UserGroupMember.md)

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


## UserGroupsUpdate

> Object UserGroupsUpdate (Guid userGroupId, string authorization, UserGroupUpdateData data)

Updates a user group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class UserGroupsUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new UserGroupsApi(Configuration.Default);
            var userGroupId = new Guid(); // Guid | GUID of the user group
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var data = new UserGroupUpdateData(); // UserGroupUpdateData | User group data

            try
            {
                // Updates a user group
                Object result = apiInstance.UserGroupsUpdate(userGroupId, authorization, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserGroupsApi.UserGroupsUpdate: " + e.Message );
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
 **userGroupId** | [**Guid**](Guid.md)| GUID of the user group | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **data** | [**UserGroupUpdateData**](UserGroupUpdateData.md)| User group data | 

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

