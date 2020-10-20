# AmagnoWebApi.Client.Api.TokenApi

All URIs are relative to *https://amagno.me/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokenCreate**](TokenApi.md#tokencreate) | **POST** /token | Creates JSON Web Token for authorization. This token is valid for the next 30 minutes



## TokenCreate

> string TokenCreate (LoginRequest loginRequest)

Creates JSON Web Token for authorization. This token is valid for the next 30 minutes

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Example
{
    public class TokenCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://amagno.me/api/v2";
            var apiInstance = new TokenApi(Configuration.Default);
            var loginRequest = new LoginRequest(); // LoginRequest | Model with Username and Password of the user

            try
            {
                // Creates JSON Web Token for authorization. This token is valid for the next 30 minutes
                string result = apiInstance.TokenCreate(loginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TokenApi.TokenCreate: " + e.Message );
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
 **loginRequest** | [**LoginRequest**](LoginRequest.md)| Model with Username and Password of the user | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
- **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

