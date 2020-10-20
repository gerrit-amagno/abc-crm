/* 
 * AMAGNO HTTP/REST API Version 2
 *
 * <span>Use your own or the cloud version of AMAGNO with REST/JSON!</span>  <br /><br />  <b>General</b>  <br /><br />  <span>      The AMAGNO API uses the HTTP methods GET and POST to communicate with the service. This mechanism is often called REST. It returns either JSON for informations or direct stream with the actual content type for files. A simple response looks like this:  </span>  <code>      {      \"id\": \"61776573-6f6d-6520-6578-616d706c6521\",      \"name\": \"Document.pdf\"      }  </code>  <span>      If your AMAGNO server has the name \"myserver\", the URL to the AMAGNO API would be \"https://myserver/amagnome/api/v2/\".<br />      For this individual URL we will use the term <b>BASEURL</b> in the further documentation.  </span>  <br /><br />  <b>Authentication</b>  <br /><br />  <span>      API requests are only allowed by authenticated users. To authenticate users the AMAGNO API uses <a href=\"https://tools.ietf.org/html/rfc7519\">JSON Web Token</a>.      To receive this token a POST-request to https://myserver/amagnome/api/v2/token with credentials in body should be sent. Request example:  </span>  <code>      curl -X POST - -header 'Content-Type: application/json' - -header 'Accept: application/json' -d '{      \"userName\": \"user@company.com\",      \"password\": \"password\"      }' 'http://myserver/amagnome/api/v2/token'  </code>  <span>      If the data that is sent is correct, a response will be returned including HTTP status code \"200\" and the token within the body. To make other API requests this token should be sent in the HTTP header with the name \"Authorization\"      and the value \"Bearer {token}\". The expiration time is defined in the configuration (web.config of AmagnoRestApi2, AppSettings, Key \"JwtExpirationInMinutes\").  </span><br /><br />  <b>Security</b>  <br /><br />  <span>Only use the API via HTTPS and always make sure to validate the certificate on the client side.</span>  <br /><br />  <b>Request Example</b>  <br /><br />  <span>https://myserver/amagnome/api/v2/vaults with HTTP header \"Authorization\": \"Bearer token\"</span>  <br /><br />  <b>HTTP response codes</b>  <br />  <table>      <tbody>      <tr>          <td>              <p><span>Code</span></p>          </td>          <td>              <p><span>Description</span></p>          </td>      </tr>      <tr>          <td>              <p>2xx</p>          </td>          <td>              <p>The request was successful.</p>          </td>      </tr>      <tr>          <td>              <p>4xx</p>          </td>          <td>              <p>The request was not successful. Change the request to make it work.</p>          </td>      </tr>      <tr>          <td>              <p>5xx</p>          </td>          <td>              <p>An error occurred on the server side. Please try again.</p>          </td>      </tr>      </tbody>  </table>  <code></code>  <br />  <b>Unsuccessful request details</b>  <br /><br />        <span>            For responses with http status codes 400, 403 or 500, there are also error codes and messages in JSON format in the body of the response sent. For example:        </span>  <code>      {      \"code\": 2010,      \"message\": \"Document with same file exists in vault\"      }  </code>  <span>      \"code\" is an error identifier and \"message\" presents a 'human-friendly' phrase. When responses are sent by the IIS (Internet Information Service), this information is not displayed.  </span>  <br /><br />  <b>GUIDs</b>  <br /><br />  <span>      The AMAGNO API works mainly with worldwide unique identification numbers to address elements like vaults, magnets, documents amongst other things - known as GUID.<br />      Many requests will return element GUIDs.<br />      If you want to address a specific element in your AMAGNO, e.g.: a vault; you can find out the corresponding element's GUID. In order to do this, please log in to your AMAGNO Client for Windows and activate the Developer Mode in the Help Menu of your User Profile. For more information, please consult the AMAGNO User Manual.  </span>  <br /><br />  
 *
 * The version of the OpenAPI document: v2
 * Contact: support@amagno.co.uk
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Model;
using AmagnoWebApi.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace AmagnoWebApi.Client.Test
{
    /// <summary>
    ///  Class for testing NumberTagDefinition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NumberTagDefinitionTests
    {
        // TODO uncomment below to declare an instance variable for NumberTagDefinition
        //private NumberTagDefinition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NumberTagDefinition
            //instance = new NumberTagDefinition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NumberTagDefinition
        /// </summary>
        [Test]
        public void NumberTagDefinitionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" NumberTagDefinition
            //Assert.IsInstanceOf(typeof(NumberTagDefinition), instance);
        }


        /// <summary>
        /// Test the property 'DecimalPlaces'
        /// </summary>
        [Test]
        public void DecimalPlacesTest()
        {
            // TODO unit test for the property 'DecimalPlaces'
        }
        /// <summary>
        /// Test the property 'DefaultValue'
        /// </summary>
        [Test]
        public void DefaultValueTest()
        {
            // TODO unit test for the property 'DefaultValue'
        }
        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Test]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }
        /// <summary>
        /// Test the property 'SuggestDefaultEntries'
        /// </summary>
        [Test]
        public void SuggestDefaultEntriesTest()
        {
            // TODO unit test for the property 'SuggestDefaultEntries'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'VaultId'
        /// </summary>
        [Test]
        public void VaultIdTest()
        {
            // TODO unit test for the property 'VaultId'
        }
        /// <summary>
        /// Test the property 'TagGroupDefinitionId'
        /// </summary>
        [Test]
        public void TagGroupDefinitionIdTest()
        {
            // TODO unit test for the property 'TagGroupDefinitionId'
        }
        /// <summary>
        /// Test the property 'Caption'
        /// </summary>
        [Test]
        public void CaptionTest()
        {
            // TODO unit test for the property 'Caption'
        }
        /// <summary>
        /// Test the property 'SourceType'
        /// </summary>
        [Test]
        public void SourceTypeTest()
        {
            // TODO unit test for the property 'SourceType'
        }
        /// <summary>
        /// Test the property 'Sortable'
        /// </summary>
        [Test]
        public void SortableTest()
        {
            // TODO unit test for the property 'Sortable'
        }
        /// <summary>
        /// Test the property 'SingleTag'
        /// </summary>
        [Test]
        public void SingleTagTest()
        {
            // TODO unit test for the property 'SingleTag'
        }
        /// <summary>
        /// Test the property 'AddRule'
        /// </summary>
        [Test]
        public void AddRuleTest()
        {
            // TODO unit test for the property 'AddRule'
        }
        /// <summary>
        /// Test the property 'OverwriteRule'
        /// </summary>
        [Test]
        public void OverwriteRuleTest()
        {
            // TODO unit test for the property 'OverwriteRule'
        }
        /// <summary>
        /// Test the property 'EditProtection'
        /// </summary>
        [Test]
        public void EditProtectionTest()
        {
            // TODO unit test for the property 'EditProtection'
        }
        /// <summary>
        /// Test the property 'UserInput'
        /// </summary>
        [Test]
        public void UserInputTest()
        {
            // TODO unit test for the property 'UserInput'
        }
        /// <summary>
        /// Test the property 'InputRequired'
        /// </summary>
        [Test]
        public void InputRequiredTest()
        {
            // TODO unit test for the property 'InputRequired'
        }

    }

}
