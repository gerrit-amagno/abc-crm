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
    /// DynamicDateSettings
    /// </summary>
    [DataContract]
    public partial class DynamicDateSettings :  IEquatable<DynamicDateSettings>, IValidatableObject
    {
        /// <summary>
        /// Defines AddUnit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddUnitEnum
        {
            /// <summary>
            /// Enum Ticks for value: Ticks
            /// </summary>
            [EnumMember(Value = "Ticks")]
            Ticks = 1,

            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 2

        }

        /// <summary>
        /// Gets or Sets AddUnit
        /// </summary>
        [DataMember(Name="addUnit", EmitDefaultValue=false)]
        public AddUnitEnum? AddUnit { get; set; }
        /// <summary>
        /// Defines SubtractUnit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubtractUnitEnum
        {
            /// <summary>
            /// Enum Ticks for value: Ticks
            /// </summary>
            [EnumMember(Value = "Ticks")]
            Ticks = 1,

            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 2

        }

        /// <summary>
        /// Gets or Sets SubtractUnit
        /// </summary>
        [DataMember(Name="subtractUnit", EmitDefaultValue=false)]
        public SubtractUnitEnum? SubtractUnit { get; set; }
        /// <summary>
        /// Defines RoundType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoundTypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum BeginOfDay for value: BeginOfDay
            /// </summary>
            [EnumMember(Value = "BeginOfDay")]
            BeginOfDay = 2,

            /// <summary>
            /// Enum EndOfDay for value: EndOfDay
            /// </summary>
            [EnumMember(Value = "EndOfDay")]
            EndOfDay = 3,

            /// <summary>
            /// Enum BeginOfMonth for value: BeginOfMonth
            /// </summary>
            [EnumMember(Value = "BeginOfMonth")]
            BeginOfMonth = 4,

            /// <summary>
            /// Enum EndOfMonth for value: EndOfMonth
            /// </summary>
            [EnumMember(Value = "EndOfMonth")]
            EndOfMonth = 5,

            /// <summary>
            /// Enum BeginOfQuarterYear for value: BeginOfQuarterYear
            /// </summary>
            [EnumMember(Value = "BeginOfQuarterYear")]
            BeginOfQuarterYear = 6,

            /// <summary>
            /// Enum EndOfQuarterYear for value: EndOfQuarterYear
            /// </summary>
            [EnumMember(Value = "EndOfQuarterYear")]
            EndOfQuarterYear = 7,

            /// <summary>
            /// Enum BeginOfYear for value: BeginOfYear
            /// </summary>
            [EnumMember(Value = "BeginOfYear")]
            BeginOfYear = 8,

            /// <summary>
            /// Enum EndOfYear for value: EndOfYear
            /// </summary>
            [EnumMember(Value = "EndOfYear")]
            EndOfYear = 9

        }

        /// <summary>
        /// Gets or Sets RoundType
        /// </summary>
        [DataMember(Name="roundType", EmitDefaultValue=false)]
        public RoundTypeEnum? RoundType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDateSettings" /> class.
        /// </summary>
        /// <param name="addUnit">addUnit.</param>
        /// <param name="addValue">addValue.</param>
        /// <param name="subtractUnit">subtractUnit.</param>
        /// <param name="subtractValue">subtractValue.</param>
        /// <param name="roundType">roundType.</param>
        public DynamicDateSettings(AddUnitEnum? addUnit = default(AddUnitEnum?), long addValue = default(long), SubtractUnitEnum? subtractUnit = default(SubtractUnitEnum?), long subtractValue = default(long), RoundTypeEnum? roundType = default(RoundTypeEnum?))
        {
            this.AddUnit = addUnit;
            this.AddValue = addValue;
            this.SubtractUnit = subtractUnit;
            this.SubtractValue = subtractValue;
            this.RoundType = roundType;
        }
        

        /// <summary>
        /// Gets or Sets AddValue
        /// </summary>
        [DataMember(Name="addValue", EmitDefaultValue=false)]
        public long AddValue { get; set; }


        /// <summary>
        /// Gets or Sets SubtractValue
        /// </summary>
        [DataMember(Name="subtractValue", EmitDefaultValue=false)]
        public long SubtractValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicDateSettings {\n");
            sb.Append("  AddUnit: ").Append(AddUnit).Append("\n");
            sb.Append("  AddValue: ").Append(AddValue).Append("\n");
            sb.Append("  SubtractUnit: ").Append(SubtractUnit).Append("\n");
            sb.Append("  SubtractValue: ").Append(SubtractValue).Append("\n");
            sb.Append("  RoundType: ").Append(RoundType).Append("\n");
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
            return this.Equals(input as DynamicDateSettings);
        }

        /// <summary>
        /// Returns true if DynamicDateSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicDateSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicDateSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddUnit == input.AddUnit ||
                    (this.AddUnit != null &&
                    this.AddUnit.Equals(input.AddUnit))
                ) && 
                (
                    this.AddValue == input.AddValue ||
                    (this.AddValue != null &&
                    this.AddValue.Equals(input.AddValue))
                ) && 
                (
                    this.SubtractUnit == input.SubtractUnit ||
                    (this.SubtractUnit != null &&
                    this.SubtractUnit.Equals(input.SubtractUnit))
                ) && 
                (
                    this.SubtractValue == input.SubtractValue ||
                    (this.SubtractValue != null &&
                    this.SubtractValue.Equals(input.SubtractValue))
                ) && 
                (
                    this.RoundType == input.RoundType ||
                    (this.RoundType != null &&
                    this.RoundType.Equals(input.RoundType))
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
                if (this.AddUnit != null)
                    hashCode = hashCode * 59 + this.AddUnit.GetHashCode();
                if (this.AddValue != null)
                    hashCode = hashCode * 59 + this.AddValue.GetHashCode();
                if (this.SubtractUnit != null)
                    hashCode = hashCode * 59 + this.SubtractUnit.GetHashCode();
                if (this.SubtractValue != null)
                    hashCode = hashCode * 59 + this.SubtractValue.GetHashCode();
                if (this.RoundType != null)
                    hashCode = hashCode * 59 + this.RoundType.GetHashCode();
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
