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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Model;

namespace AmagnoWebApi.Client.Test
{
    /// <summary>
    ///  Class for testing VaultsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VaultsApiTests
    {
        private VaultsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VaultsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VaultsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' VaultsApi
            //Assert.IsInstanceOf(typeof(VaultsApi), instance);
        }

        
        /// <summary>
        /// Test VaultsAddMember
        /// </summary>
        [Test]
        public void VaultsAddMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //VaultMemberCreationData creationData = null;
            //var response = instance.VaultsAddMember(vaultId, authorization, creationData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test VaultsAddUserGroup
        /// </summary>
        [Test]
        public void VaultsAddUserGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //UserGroupCreationData creationData = null;
            //var response = instance.VaultsAddUserGroup(vaultId, authorization, creationData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test VaultsCopyVault
        /// </summary>
        [Test]
        public void VaultsCopyVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //VaultCopyData vaultCopyData = null;
            //var response = instance.VaultsCopyVault(vaultId, authorization, vaultCopyData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test VaultsCreateMagnet
        /// </summary>
        [Test]
        public void VaultsCreateMagnetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //MagnetCreationData magnetCreationData = null;
            //var response = instance.VaultsCreateMagnet(vaultId, authorization, magnetCreationData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test VaultsCreateVault
        /// </summary>
        [Test]
        public void VaultsCreateVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //VaultCreationData vaultCreationData = null;
            //var response = instance.VaultsCreateVault(authorization, vaultCreationData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test VaultsGetCheckedOutDocuments
        /// </summary>
        [Test]
        public void VaultsGetCheckedOutDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //bool? includeTags = null;
            //var response = instance.VaultsGetCheckedOutDocuments(vaultId, authorization, includeTags);
            //Assert.IsInstanceOf(typeof(List<Document>), response, "response is List<Document>");
        }
        
        /// <summary>
        /// Test VaultsGetDocumentTagDefinitions
        /// </summary>
        [Test]
        public void VaultsGetDocumentTagDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetDocumentTagDefinitions(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(TagDefinitionCollections), response, "response is TagDefinitionCollections");
        }
        
        /// <summary>
        /// Test VaultsGetDocumentTagGroupDefinitions
        /// </summary>
        [Test]
        public void VaultsGetDocumentTagGroupDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetDocumentTagGroupDefinitions(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<TagGroupDefinition>), response, "response is List<TagGroupDefinition>");
        }
        
        /// <summary>
        /// Test VaultsGetDocumentTypeCategories
        /// </summary>
        [Test]
        public void VaultsGetDocumentTypeCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetDocumentTypeCategories(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<DocumentTypeCategory>), response, "response is List<DocumentTypeCategory>");
        }
        
        /// <summary>
        /// Test VaultsGetDocuments
        /// </summary>
        [Test]
        public void VaultsGetDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //bool? includeTags = null;
            //int? count = null;
            //int? offset = null;
            //var response = instance.VaultsGetDocuments(vaultId, authorization, includeTags, count, offset);
            //Assert.IsInstanceOf(typeof(List<Document>), response, "response is List<Document>");
        }
        
        /// <summary>
        /// Test VaultsGetMagnets
        /// </summary>
        [Test]
        public void VaultsGetMagnetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetMagnets(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<Magnet>), response, "response is List<Magnet>");
        }
        
        /// <summary>
        /// Test VaultsGetMembers
        /// </summary>
        [Test]
        public void VaultsGetMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetMembers(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<VaultMember>), response, "response is List<VaultMember>");
        }
        
        /// <summary>
        /// Test VaultsGetStamps
        /// </summary>
        [Test]
        public void VaultsGetStampsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetStamps(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<Stamp>), response, "response is List<Stamp>");
        }
        
        /// <summary>
        /// Test VaultsGetTrashedDocuments
        /// </summary>
        [Test]
        public void VaultsGetTrashedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //bool? includeTags = null;
            //int? count = null;
            //int? offset = null;
            //var response = instance.VaultsGetTrashedDocuments(vaultId, authorization, includeTags, count, offset);
            //Assert.IsInstanceOf(typeof(List<Document>), response, "response is List<Document>");
        }
        
        /// <summary>
        /// Test VaultsGetUserGroups
        /// </summary>
        [Test]
        public void VaultsGetUserGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetUserGroups(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(List<UserGroup>), response, "response is List<UserGroup>");
        }
        
        /// <summary>
        /// Test VaultsGetVault
        /// </summary>
        [Test]
        public void VaultsGetVaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //var response = instance.VaultsGetVault(vaultId, authorization);
            //Assert.IsInstanceOf(typeof(Vault), response, "response is Vault");
        }
        
        /// <summary>
        /// Test VaultsGetVaults
        /// </summary>
        [Test]
        public void VaultsGetVaultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.VaultsGetVaults(authorization);
            //Assert.IsInstanceOf(typeof(List<Vault>), response, "response is List<Vault>");
        }
        
        /// <summary>
        /// Test VaultsPostDocument
        /// </summary>
        [Test]
        public void VaultsPostDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid vaultId = null;
            //string authorization = null;
            //NewDocument document = null;
            //var response = instance.VaultsPostDocument(vaultId, authorization, document);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}
