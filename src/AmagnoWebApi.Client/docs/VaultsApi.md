# AmagnoWebApi.Client.Api.VaultsApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VaultsAddMember**](VaultsApi.md#vaultsaddmember) | **POST** /vaults/{vaultId}/members | Starts membership of a user in a vault
[**VaultsAddUserGroup**](VaultsApi.md#vaultsaddusergroup) | **POST** /vaults/{vaultId}/user-groups | Create a new user group in a vault
[**VaultsCopyVault**](VaultsApi.md#vaultscopyvault) | **POST** /vaults/{vaultId}/copy | Copies a vault
[**VaultsCreateMagnet**](VaultsApi.md#vaultscreatemagnet) | **POST** /vaults/{vaultId}/magnets | Creates a magnet
[**VaultsCreateVault**](VaultsApi.md#vaultscreatevault) | **POST** /vaults | Creates a new vault
[**VaultsGetCheckedOutDocuments**](VaultsApi.md#vaultsgetcheckedoutdocuments) | **GET** /vaults/{vaultId}/checked-out-documents | Returns all checked-out documents in the vault
[**VaultsGetDocumentTagDefinitions**](VaultsApi.md#vaultsgetdocumenttagdefinitions) | **GET** /vaults/{vaultId}/documents/tag-definitions | Returns all of the vault&#39;s document tag definitions
[**VaultsGetDocumentTagGroupDefinitions**](VaultsApi.md#vaultsgetdocumenttaggroupdefinitions) | **GET** /vaults/{vaultId}/documents/tag-group-definitions | Returns all of the vault&#39;s document tag group definitions
[**VaultsGetDocumentTypeCategories**](VaultsApi.md#vaultsgetdocumenttypecategories) | **GET** /vaults/{vaultId}/document-type-categories | Returns all of the vault&#39;s document type categories
[**VaultsGetDocuments**](VaultsApi.md#vaultsgetdocuments) | **GET** /vaults/{vaultId}/documents | Returns all documents in the vault
[**VaultsGetMagnets**](VaultsApi.md#vaultsgetmagnets) | **GET** /vaults/{vaultId}/magnets | Returns all of the vault&#39;s magnets
[**VaultsGetMembers**](VaultsApi.md#vaultsgetmembers) | **GET** /vaults/{vaultId}/members | Returns all of the vault&#39;s members
[**VaultsGetStamps**](VaultsApi.md#vaultsgetstamps) | **GET** /vaults/{vaultId}/stamps | Returns stamps of a vault
[**VaultsGetTrashedDocuments**](VaultsApi.md#vaultsgettrasheddocuments) | **GET** /vaults/{vaultId}/trashed-documents | Returns information about all documents that are in the recycle bin of the vault
[**VaultsGetUserGroups**](VaultsApi.md#vaultsgetusergroups) | **GET** /vaults/{vaultId}/user-groups | Returns user groups of a vault
[**VaultsGetVault**](VaultsApi.md#vaultsgetvault) | **GET** /vaults/{vaultId} | Returns the requested vault
[**VaultsGetVaults**](VaultsApi.md#vaultsgetvaults) | **GET** /vaults | Returns all of the user&#39;s vaults
[**VaultsPostDocument**](VaultsApi.md#vaultspostdocument) | **POST** /vaults/{vaultId}/documents | Creates a document



## VaultsAddMember

> Object VaultsAddMember (Guid vaultId, string authorization, VaultMemberCreationData creationData)

Starts membership of a user in a vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsAddMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var creationData = new VaultMemberCreationData(); // VaultMemberCreationData | Vault member data

            try
            {
                // Starts membership of a user in a vault
                Object result = apiInstance.VaultsAddMember(vaultId, authorization, creationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsAddMember: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **creationData** | [**VaultMemberCreationData**](VaultMemberCreationData.md)| Vault member data | 

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


## VaultsAddUserGroup

> Object VaultsAddUserGroup (Guid vaultId, string authorization, UserGroupCreationData creationData)

Create a new user group in a vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsAddUserGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var creationData = new UserGroupCreationData(); // UserGroupCreationData | User group data

            try
            {
                // Create a new user group in a vault
                Object result = apiInstance.VaultsAddUserGroup(vaultId, authorization, creationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsAddUserGroup: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **creationData** | [**UserGroupCreationData**](UserGroupCreationData.md)| User group data | 

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


## VaultsCopyVault

> Object VaultsCopyVault (Guid vaultId, string authorization, VaultCopyData vaultCopyData)

Copies a vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsCopyVaultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var vaultCopyData = new VaultCopyData(); // VaultCopyData | 

            try
            {
                // Copies a vault
                Object result = apiInstance.VaultsCopyVault(vaultId, authorization, vaultCopyData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsCopyVault: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)|  | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **vaultCopyData** | [**VaultCopyData**](VaultCopyData.md)|  | 

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


## VaultsCreateMagnet

> Object VaultsCreateMagnet (Guid vaultId, string authorization, MagnetCreationData magnetCreationData)

Creates a magnet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsCreateMagnetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | 
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var magnetCreationData = new MagnetCreationData(); // MagnetCreationData | 

            try
            {
                // Creates a magnet
                Object result = apiInstance.VaultsCreateMagnet(vaultId, authorization, magnetCreationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsCreateMagnet: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)|  | 
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


## VaultsCreateVault

> Object VaultsCreateVault (string authorization, VaultCreationData vaultCreationData)

Creates a new vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsCreateVaultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var vaultCreationData = new VaultCreationData(); // VaultCreationData | 

            try
            {
                // Creates a new vault
                Object result = apiInstance.VaultsCreateVault(authorization, vaultCreationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsCreateVault: " + e.Message );
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
 **vaultCreationData** | [**VaultCreationData**](VaultCreationData.md)|  | 

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


## VaultsGetCheckedOutDocuments

> List&lt;Document&gt; VaultsGetCheckedOutDocuments (Guid vaultId, string authorization, bool? includeTags = null)

Returns all checked-out documents in the vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetCheckedOutDocumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 

            try
            {
                // Returns all checked-out documents in the vault
                List<Document> result = apiInstance.VaultsGetCheckedOutDocuments(vaultId, authorization, includeTags);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetCheckedOutDocuments: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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


## VaultsGetDocumentTagDefinitions

> TagDefinitionCollections VaultsGetDocumentTagDefinitions (Guid vaultId, string authorization)

Returns all of the vault's document tag definitions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetDocumentTagDefinitionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the vault's document tag definitions
                TagDefinitionCollections result = apiInstance.VaultsGetDocumentTagDefinitions(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetDocumentTagDefinitions: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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


## VaultsGetDocumentTagGroupDefinitions

> List&lt;TagGroupDefinition&gt; VaultsGetDocumentTagGroupDefinitions (Guid vaultId, string authorization)

Returns all of the vault's document tag group definitions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetDocumentTagGroupDefinitionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the vault's document tag group definitions
                List<TagGroupDefinition> result = apiInstance.VaultsGetDocumentTagGroupDefinitions(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetDocumentTagGroupDefinitions: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;TagGroupDefinition&gt;**](TagGroupDefinition.md)

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


## VaultsGetDocumentTypeCategories

> List&lt;DocumentTypeCategory&gt; VaultsGetDocumentTypeCategories (Guid vaultId, string authorization)

Returns all of the vault's document type categories

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetDocumentTypeCategoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the vault's document type categories
                List<DocumentTypeCategory> result = apiInstance.VaultsGetDocumentTypeCategories(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetDocumentTypeCategories: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;DocumentTypeCategory&gt;**](DocumentTypeCategory.md)

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


## VaultsGetDocuments

> List&lt;Document&gt; VaultsGetDocuments (Guid vaultId, string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns all documents in the vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetDocumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags for each document in response should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns all documents in the vault
                List<Document> result = apiInstance.VaultsGetDocuments(vaultId, authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetDocuments: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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


## VaultsGetMagnets

> List&lt;Magnet&gt; VaultsGetMagnets (Guid vaultId, string authorization)

Returns all of the vault's magnets

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetMagnetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the vault's magnets
                List<Magnet> result = apiInstance.VaultsGetMagnets(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetMagnets: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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


## VaultsGetMembers

> List&lt;VaultMember&gt; VaultsGetMembers (Guid vaultId, string authorization)

Returns all of the vault's members

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the vault's members
                List<VaultMember> result = apiInstance.VaultsGetMembers(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetMembers: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;VaultMember&gt;**](VaultMember.md)

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


## VaultsGetStamps

> List&lt;Stamp&gt; VaultsGetStamps (Guid vaultId, string authorization)

Returns stamps of a vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetStampsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns stamps of a vault
                List<Stamp> result = apiInstance.VaultsGetStamps(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetStamps: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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


## VaultsGetTrashedDocuments

> List&lt;Document&gt; VaultsGetTrashedDocuments (Guid vaultId, string authorization, bool? includeTags = null, int? count = null, int? offset = null)

Returns information about all documents that are in the recycle bin of the vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetTrashedDocumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var includeTags = true;  // bool? | Decides if tags should be included (optional - default false) (optional) 
            var count = 56;  // int? | Count of returned documents (optional - default 50) (optional) 
            var offset = 56;  // int? | Offset of the first returned documents (optional - default 0) (optional) 

            try
            {
                // Returns information about all documents that are in the recycle bin of the vault
                List<Document> result = apiInstance.VaultsGetTrashedDocuments(vaultId, authorization, includeTags, count, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetTrashedDocuments: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]
 **includeTags** | **bool?**| Decides if tags should be included (optional - default false) | [optional] 
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


## VaultsGetUserGroups

> List&lt;UserGroup&gt; VaultsGetUserGroups (Guid vaultId, string authorization)

Returns user groups of a vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetUserGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns user groups of a vault
                List<UserGroup> result = apiInstance.VaultsGetUserGroups(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetUserGroups: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**List&lt;UserGroup&gt;**](UserGroup.md)

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


## VaultsGetVault

> Vault VaultsGetVault (Guid vaultId, string authorization)

Returns the requested vault

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetVaultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns the requested vault
                Vault result = apiInstance.VaultsGetVault(vaultId, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetVault: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
 **authorization** | **string**| Bearer JSON Web Token | [default to &quot;Bearer &quot;]

### Return type

[**Vault**](Vault.md)

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


## VaultsGetVaults

> List&lt;Vault&gt; VaultsGetVaults (string authorization)

Returns all of the user's vaults

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class VaultsGetVaultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")

            try
            {
                // Returns all of the user's vaults
                List<Vault> result = apiInstance.VaultsGetVaults(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsGetVaults: " + e.Message );
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

[**List&lt;Vault&gt;**](Vault.md)

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


## VaultsPostDocument

> Object VaultsPostDocument (Guid vaultId, string authorization, NewDocument document)

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
    public class VaultsPostDocumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new VaultsApi(Configuration.Default);
            var vaultId = new Guid(); // Guid | GUID of the vault
            var authorization = authorization_example;  // string | Bearer JSON Web Token (default to "Bearer ")
            var document = new NewDocument(); // NewDocument | Model of the new document

            try
            {
                // Creates a document
                Object result = apiInstance.VaultsPostDocument(vaultId, authorization, document);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VaultsApi.VaultsPostDocument: " + e.Message );
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
 **vaultId** | [**Guid**](Guid.md)| GUID of the vault | 
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

