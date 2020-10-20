/* 
 * AMAGNO HTTP/REST API Version 2
 *
 * <span>Use your own or the cloud version of AMAGNO with REST/JSON!</span>  <br /><br />  <b>General</b>  <br /><br />  <span>      The AMAGNO API uses the HTTP methods GET and POST to communicate with the service. This mechanism is often called REST. It returns either JSON for informations or direct stream with the actual content type for files. A simple response looks like this:  </span>  <code>      {      \"id\": \"61776573-6f6d-6520-6578-616d706c6521\",      \"name\": \"Document.pdf\"      }  </code>  <span>      If your AMAGNO server has the name \"myserver\", the URL to the AMAGNO API would be \"https://myserver/amagnome/api/v2/\".<br />      For this individual URL we will use the term <b>BASEURL</b> in the further documentation.  </span>  <br /><br />  <b>Authentication</b>  <br /><br />  <span>      API requests are only allowed by authenticated users. To authenticate users the AMAGNO API uses <a href=\"https://tools.ietf.org/html/rfc7519\">JSON Web Token</a>.      To receive this token a POST-request to https://myserver/amagnome/api/v2/token with credentials in body should be sent. Request example:  </span>  <code>      curl -X POST - -header 'Content-Type: application/json' - -header 'Accept: application/json' -d '{      \"userName\": \"user@company.com\",      \"password\": \"password\"      }' 'http://myserver/amagnome/api/v2/token'  </code>  <span>      If the data that is sent is correct, a response will be returned including HTTP status code \"200\" and the token within the body. To make other API requests this token should be sent in the HTTP header with the name \"Authorization\"      and the value \"Bearer {token}\". The expiration time is defined in the configuration (web.config of AmagnoRestApi2, AppSettings, Key \"JwtExpirationInMinutes\").  </span><br /><br />  <b>Security</b>  <br /><br />  <span>Only use the API via HTTPS and always make sure to validate the certificate on the client side.</span>  <br /><br />  <b>Request Example</b>  <br /><br />  <span>https://myserver/amagnome/api/v2/vaults with HTTP header \"Authorization\": \"Bearer token\"</span>  <br /><br />  <b>HTTP response codes</b>  <br />  <table>      <tbody>      <tr>          <td>              <p><span>Code</span></p>          </td>          <td>              <p><span>Description</span></p>          </td>      </tr>      <tr>          <td>              <p>2xx</p>          </td>          <td>              <p>The request was successful.</p>          </td>      </tr>      <tr>          <td>              <p>4xx</p>          </td>          <td>              <p>The request was not successful. Change the request to make it work.</p>          </td>      </tr>      <tr>          <td>              <p>5xx</p>          </td>          <td>              <p>An error occurred on the server side. Please try again.</p>          </td>      </tr>      </tbody>  </table>  <code></code>  <br />  <b>Unsuccessful request details</b>  <br /><br />        <span>            For responses with http status codes 400, 403 or 500, there are also error codes and messages in JSON format in the body of the response sent. For example:        </span>  <code>      {      \"code\": 2010,      \"message\": \"Document with same file exists in vault\"      }  </code>  <span>      \"code\" is an error identifier and \"message\" presents a 'human-friendly' phrase. When responses are sent by the IIS (Internet Information Service), this information is not displayed.  </span>  <br /><br />  <b>GUIDs</b>  <br /><br />  <span>      The AMAGNO API works mainly with worldwide unique identification numbers to address elements like vaults, magnets, documents amongst other things - known as GUID.<br />      Many requests will return element GUIDs.<br />      If you want to address a specific element in your AMAGNO, e.g.: a vault; you can find out the corresponding element's GUID. In order to do this, please log in to your AMAGNO Client for Windows and activate the Developer Mode in the Help Menu of your User Profile. For more information, please consult the AMAGNO User Manual.  </span>  <br /><br />  
 *
 * The version of the OpenAPI document: v2
 * Contact: support@amagno.co.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace AmagnoWebApi.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVaultMembersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the requested vault member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>VaultMember</returns>
        VaultMember VaultMembersGetVaultMember (Guid memberId, string authorization);

        /// <summary>
        /// Returns the requested vault member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>ApiResponse of VaultMember</returns>
        ApiResponse<VaultMember> VaultMembersGetVaultMemberWithHttpInfo (Guid memberId, string authorization);
        /// <summary>
        /// Finishes user membership in the vault
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>Object</returns>
        Object VaultMembersRemoveVaultMember (Guid memberId, string authorization);

        /// <summary>
        /// Finishes user membership in the vault
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VaultMembersRemoveVaultMemberWithHttpInfo (Guid memberId, string authorization);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the requested vault member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of VaultMember</returns>
        System.Threading.Tasks.Task<VaultMember> VaultMembersGetVaultMemberAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the requested vault member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (VaultMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<VaultMember>> VaultMembersGetVaultMemberWithHttpInfoAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Finishes user membership in the vault
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VaultMembersRemoveVaultMemberAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Finishes user membership in the vault
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VaultMembersRemoveVaultMemberWithHttpInfoAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VaultMembersApi : IVaultMembersApi
    {
        private AmagnoWebApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultMembersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VaultMembersApi(String basePath)
        {
            this.Configuration = new AmagnoWebApi.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AmagnoWebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultMembersApi"/> class
        /// </summary>
        /// <returns></returns>
        public VaultMembersApi()
        {
            this.Configuration = AmagnoWebApi.Client.Client.Configuration.Default;

            ExceptionFactory = AmagnoWebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultMembersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VaultMembersApi(AmagnoWebApi.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AmagnoWebApi.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AmagnoWebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AmagnoWebApi.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AmagnoWebApi.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns the requested vault member 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>VaultMember</returns>
        public VaultMember VaultMembersGetVaultMember (Guid memberId, string authorization)
        {
             ApiResponse<VaultMember> localVarResponse = VaultMembersGetVaultMemberWithHttpInfo(memberId, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the requested vault member 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>ApiResponse of VaultMember</returns>
        public ApiResponse<VaultMember> VaultMembersGetVaultMemberWithHttpInfo (Guid memberId, string authorization)
        {
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling VaultMembersApi->VaultMembersGetVaultMember");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling VaultMembersApi->VaultMembersGetVaultMember");

            var localVarPath = "/vault-members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VaultMembersGetVaultMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VaultMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VaultMember) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VaultMember)));
        }

        /// <summary>
        /// Returns the requested vault member 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of VaultMember</returns>
        public async System.Threading.Tasks.Task<VaultMember> VaultMembersGetVaultMemberAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<VaultMember> localVarResponse = await VaultMembersGetVaultMemberWithHttpInfoAsync(memberId, authorization, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the requested vault member 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (VaultMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VaultMember>> VaultMembersGetVaultMemberWithHttpInfoAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling VaultMembersApi->VaultMembersGetVaultMember");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling VaultMembersApi->VaultMembersGetVaultMember");

            var localVarPath = "/vault-members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VaultMembersGetVaultMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VaultMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VaultMember) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VaultMember)));
        }

        /// <summary>
        /// Finishes user membership in the vault 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>Object</returns>
        public Object VaultMembersRemoveVaultMember (Guid memberId, string authorization)
        {
             ApiResponse<Object> localVarResponse = VaultMembersRemoveVaultMemberWithHttpInfo(memberId, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finishes user membership in the vault 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> VaultMembersRemoveVaultMemberWithHttpInfo (Guid memberId, string authorization)
        {
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling VaultMembersApi->VaultMembersRemoveVaultMember");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling VaultMembersApi->VaultMembersRemoveVaultMember");

            var localVarPath = "/vault-members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VaultMembersRemoveVaultMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Finishes user membership in the vault 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VaultMembersRemoveVaultMemberAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Object> localVarResponse = await VaultMembersRemoveVaultMemberWithHttpInfoAsync(memberId, authorization, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finishes user membership in the vault 
        /// </summary>
        /// <exception cref="AmagnoWebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberId">GUID of the vault member</param>
        /// <param name="authorization">Bearer JSON Web Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VaultMembersRemoveVaultMemberWithHttpInfoAsync (Guid memberId, string authorization, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling VaultMembersApi->VaultMembersRemoveVaultMember");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling VaultMembersApi->VaultMembersRemoveVaultMember");

            var localVarPath = "/vault-members/{memberId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "text/html",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (memberId != null) localVarPathParams.Add("memberId", this.Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VaultMembersRemoveVaultMember", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
