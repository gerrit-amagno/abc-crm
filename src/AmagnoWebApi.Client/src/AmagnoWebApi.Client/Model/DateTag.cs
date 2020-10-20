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
    /// DateTag
    /// </summary>
    [DataContract]
    public partial class DateTag :  IEquatable<DateTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTag" /> class.
        /// </summary>
        /// <param name="value">UTC in ISO 8601 format.</param>
        /// <param name="id">id.</param>
        /// <param name="tagDefinitionId">tagDefinitionId.</param>
        /// <param name="tagGroupDefinitionId">tagGroupDefinitionId.</param>
        /// <param name="tagGroupId">tagGroupId.</param>
        /// <param name="insertOrder">Order in which the tag was added to the appropriate document.</param>
        public DateTag(DateTime value = default(DateTime), Guid id = default(Guid), Guid tagDefinitionId = default(Guid), Guid tagGroupDefinitionId = default(Guid), Guid tagGroupId = default(Guid), int insertOrder = default(int))
        {
            this.Value = value;
            this.Id = id;
            this.TagDefinitionId = tagDefinitionId;
            this.TagGroupDefinitionId = tagGroupDefinitionId;
            this.TagGroupId = tagGroupId;
            this.InsertOrder = insertOrder;
        }
        
        /// <summary>
        /// UTC in ISO 8601 format
        /// </summary>
        /// <value>UTC in ISO 8601 format</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DateTime Value { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TagDefinitionId
        /// </summary>
        [DataMember(Name="tagDefinitionId", EmitDefaultValue=false)]
        public Guid TagDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets TagGroupDefinitionId
        /// </summary>
        [DataMember(Name="tagGroupDefinitionId", EmitDefaultValue=false)]
        public Guid TagGroupDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets TagGroupId
        /// </summary>
        [DataMember(Name="tagGroupId", EmitDefaultValue=false)]
        public Guid TagGroupId { get; set; }

        /// <summary>
        /// Order in which the tag was added to the appropriate document
        /// </summary>
        /// <value>Order in which the tag was added to the appropriate document</value>
        [DataMember(Name="insertOrder", EmitDefaultValue=false)]
        public int InsertOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTag {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TagDefinitionId: ").Append(TagDefinitionId).Append("\n");
            sb.Append("  TagGroupDefinitionId: ").Append(TagGroupDefinitionId).Append("\n");
            sb.Append("  TagGroupId: ").Append(TagGroupId).Append("\n");
            sb.Append("  InsertOrder: ").Append(InsertOrder).Append("\n");
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
            return this.Equals(input as DateTag);
        }

        /// <summary>
        /// Returns true if DateTag instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TagDefinitionId == input.TagDefinitionId ||
                    (this.TagDefinitionId != null &&
                    this.TagDefinitionId.Equals(input.TagDefinitionId))
                ) && 
                (
                    this.TagGroupDefinitionId == input.TagGroupDefinitionId ||
                    (this.TagGroupDefinitionId != null &&
                    this.TagGroupDefinitionId.Equals(input.TagGroupDefinitionId))
                ) && 
                (
                    this.TagGroupId == input.TagGroupId ||
                    (this.TagGroupId != null &&
                    this.TagGroupId.Equals(input.TagGroupId))
                ) && 
                (
                    this.InsertOrder == input.InsertOrder ||
                    (this.InsertOrder != null &&
                    this.InsertOrder.Equals(input.InsertOrder))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TagDefinitionId != null)
                    hashCode = hashCode * 59 + this.TagDefinitionId.GetHashCode();
                if (this.TagGroupDefinitionId != null)
                    hashCode = hashCode * 59 + this.TagGroupDefinitionId.GetHashCode();
                if (this.TagGroupId != null)
                    hashCode = hashCode * 59 + this.TagGroupId.GetHashCode();
                if (this.InsertOrder != null)
                    hashCode = hashCode * 59 + this.InsertOrder.GetHashCode();
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
