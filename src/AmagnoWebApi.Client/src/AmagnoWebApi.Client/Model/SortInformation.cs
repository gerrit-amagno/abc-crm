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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AmagnoWebApi.Client.Client.OpenAPIDateConverter;

namespace AmagnoWebApi.Client.Model
{
    /// <summary>
    /// SortInformation
    /// </summary>
    [DataContract]
    public partial class SortInformation :  IEquatable<SortInformation>, IValidatableObject
    {
        /// <summary>
        /// Sorting order
        /// </summary>
        /// <value>Sorting order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 1,

            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 2

        }

        /// <summary>
        /// Sorting order
        /// </summary>
        /// <value>Sorting order</value>
        [DataMember(Name="order", EmitDefaultValue=true)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SortInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortInformation" /> class.
        /// </summary>
        /// <param name="tagDefinitionId">GUID of the tag definition for sorting found documents (required).</param>
        /// <param name="order">Sorting order (required).</param>
        public SortInformation(Guid tagDefinitionId = default(Guid), OrderEnum order = default(OrderEnum))
        {
            // to ensure "tagDefinitionId" is required (not null)
            if (tagDefinitionId == null)
            {
                throw new InvalidDataException("tagDefinitionId is a required property for SortInformation and cannot be null");
            }
            else
            {
                this.TagDefinitionId = tagDefinitionId;
            }
            
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for SortInformation and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            
        }
        
        /// <summary>
        /// GUID of the tag definition for sorting found documents
        /// </summary>
        /// <value>GUID of the tag definition for sorting found documents</value>
        [DataMember(Name="tagDefinitionId", EmitDefaultValue=true)]
        public Guid TagDefinitionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortInformation {\n");
            sb.Append("  TagDefinitionId: ").Append(TagDefinitionId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SortInformation);
        }

        /// <summary>
        /// Returns true if SortInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of SortInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagDefinitionId == input.TagDefinitionId ||
                    (this.TagDefinitionId != null &&
                    this.TagDefinitionId.Equals(input.TagDefinitionId))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TagDefinitionId != null)
                    hashCode = hashCode * 59 + this.TagDefinitionId.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
