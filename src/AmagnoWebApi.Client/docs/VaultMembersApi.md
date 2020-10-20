# AmagnoWebApi.Client.Api.VaultMembersApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VaultMembersGetVaultMember**](VaultMembersApi.md#vaultmembersgetvaultmember) | **GET** /vault-members/{memberId} | Returns the requested vault member
[**VaultMembersRemoveVaultMember**](VaultMembersApi.md#vaultmembersremovevaultmember) | **DELETE** /vault-members/{memberId} | Finishes user membership in the vault



## VaultMembersGetVaultMember

> VaultMember VaultMembersGetVaultMember (Guid memberId, string authorization)

Returns the requested vault member

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultMembersGetVaultMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultMembersApi(Configuration.Default);
            var memberId = new Guid(); // Guid | GUID of the vault member
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested vault member
                VaultMember result = apiInstance.VaultMembersGetVaultMember(memberId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultMembersApi.VaultMembersGetVaultMember: " + e.Message );
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
 **memberId** | [**Guid**](Guid.md)| GUID of the vault member | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**VaultMember**](VaultMember.md)

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


## VaultMembersRemoveVaultMember

> Object VaultMembersRemoveVaultMember (Guid memberId, string authorization)

Finishes user membership in the vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultMembersRemoveVaultMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultMembersApi(Configuration.Default);
            var memberId = new Guid(); // Guid | GUID of the vault member
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Finishes user membership in the vault
                Object result = apiInstance.VaultMembersRemoveVaultMember(memberId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultMembersApi.VaultMembersRemoveVaultMember: " + e.Message );
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
 **memberId** | [**Guid**](Guid.md)| GUID of the vault member | 
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

