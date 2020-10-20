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
    /// NumberTagDefinition
    /// </summary>
    [DataContract]
    public partial class NumberTagDefinition :  IEquatable<NumberTagDefinition>, IValidatableObject
    {
        /// <summary>
        /// Defines SourceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum Template for value: Template
            /// </summary>
            [EnumMember(Value = "Template")]
            Template = 2,

            /// <summary>
            /// Enum UserDefined for value: UserDefined
            /// </summary>
            [EnumMember(Value = "UserDefined")]
            UserDefined = 3,

            /// <summary>
            /// Enum Extraction for value: Extraction
            /// </summary>
            [EnumMember(Value = "Extraction")]
            Extraction = 4,

            /// <summary>
            /// Enum Classification for value: Classification
            /// </summary>
            [EnumMember(Value = "Classification")]
            Classification = 5

        }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Defines AddRule
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddRuleEnum
        {
            /// <summary>
            /// Enum Never for value: Never
            /// </summary>
            [EnumMember(Value = "Never")]
            Never = 1,

            /// <summary>
            /// Enum IfNotExists for value: IfNotExists
            /// </summary>
            [EnumMember(Value = "IfNotExists")]
            IfNotExists = 2,

            /// <summary>
            /// Enum Always for value: Always
            /// </summary>
            [EnumMember(Value = "Always")]
            Always = 3,

            /// <summary>
            /// Enum IfNotExistsElseIgnore for value: IfNotExistsElseIgnore
            /// </summary>
            [EnumMember(Value = "IfNotExistsElseIgnore")]
            IfNotExistsElseIgnore = 4

        }

        /// <summary>
        /// Gets or Sets AddRule
        /// </summary>
        [DataMember(Name="addRule", EmitDefaultValue=false)]
        public AddRuleEnum? AddRule { get; set; }
        /// <summary>
        /// Defines OverwriteRule
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OverwriteRuleEnum
        {
            /// <summary>
            /// Enum First for value: First
            /// </summary>
            [EnumMember(Value = "First")]
            First = 1,

            /// <summary>
            /// Enum Last for value: Last
            /// </summary>
            [EnumMember(Value = "Last")]
            Last = 2,

            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 3

        }

        /// <summary>
        /// Gets or Sets OverwriteRule
        /// </summary>
        [DataMember(Name="overwriteRule", EmitDefaultValue=false)]
        public OverwriteRuleEnum? OverwriteRule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberTagDefinition" /> class.
        /// </summary>
        /// <param name="decimalPlaces">Decimal places of appropriate number tag value. For example tag with value 10000 and tag definition decimal places 4 has real value 1.000.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="format">format.</param>
        /// <param name="suggestDefaultEntries">suggestDefaultEntries.</param>
        /// <param name="id">id.</param>
        /// <param name="vaultId">vaultId.</param>
        /// <param name="tagGroupDefinitionId">tagGroupDefinitionId.</param>
        /// <param name="caption">caption.</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="sortable">sortable.</param>
        /// <param name="singleTag">singleTag.</param>
        /// <param name="addRule">addRule.</param>
        /// <param name="overwriteRule">overwriteRule.</param>
        /// <param name="editProtection">editProtection.</param>
        /// <param name="userInput">userInput.</param>
        /// <param name="inputRequired">inputRequired.</param>
        public NumberTagDefinition(int decimalPlaces = default(int), long defaultValue = default(long), string format = default(string), bool suggestDefaultEntries = default(bool), Guid id = default(Guid), Guid vaultId = default(Guid), Guid tagGroupDefinitionId = default(Guid), string caption = default(string), SourceTypeEnum? sourceType = default(SourceTypeEnum?), bool sortable = default(bool), bool singleTag = default(bool), AddRuleEnum? addRule = default(AddRuleEnum?), OverwriteRuleEnum? overwriteRule = default(OverwriteRuleEnum?), bool editProtection = default(bool), bool userInput = default(bool), bool inputRequired = default(bool))
        {
            this.DecimalPlaces = decimalPlaces;
            this.DefaultValue = defaultValue;
            this.Format = format;
            this.SuggestDefaultEntries = suggestDefaultEntries;
            this.Id = id;
            this.VaultId = vaultId;
            this.TagGroupDefinitionId = tagGroupDefinitionId;
            this.Caption = caption;
            this.SourceType = sourceType;
            this.Sortable = sortable;
            this.SingleTag = singleTag;
            this.AddRule = addRule;
            this.OverwriteRule = overwriteRule;
            this.EditProtection = editProtection;
            this.UserInput = userInput;
            this.InputRequired = inputRequired;
        }
        
        /// <summary>
        /// Decimal places of appropriate number tag value. For example tag with value 10000 and tag definition decimal places 4 has real value 1.000
        /// </summary>
        /// <value>Decimal places of appropriate number tag value. For example tag with value 10000 and tag definition decimal places 4 has real value 1.000</value>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public long DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets SuggestDefaultEntries
        /// </summary>
        [DataMember(Name="suggestDefaultEntries", EmitDefaultValue=false)]
        public bool SuggestDefaultEntries { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets VaultId
        /// </summary>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public Guid VaultId { get; set; }

        /// <summary>
        /// Gets or Sets TagGroupDefinitionId
        /// </summary>
        [DataMember(Name="tagGroupDefinitionId", EmitDefaultValue=false)]
        public Guid TagGroupDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }


        /// <summary>
        /// Gets or Sets Sortable
        /// </summary>
        [DataMember(Name="sortable", EmitDefaultValue=false)]
        public bool Sortable { get; set; }

        /// <summary>
        /// Gets or Sets SingleTag
        /// </summary>
        [DataMember(Name="singleTag", EmitDefaultValue=false)]
        public bool SingleTag { get; set; }



        /// <summary>
        /// Gets or Sets EditProtection
        /// </summary>
        [DataMember(Name="editProtection", EmitDefaultValue=false)]
        public bool EditProtection { get; set; }

        /// <summary>
        /// Gets or Sets UserInput
        /// </summary>
        [DataMember(Name="userInput", EmitDefaultValue=false)]
        public bool UserInput { get; set; }

        /// <summary>
        /// Gets or Sets InputRequired
        /// </summary>
        [DataMember(Name="inputRequired", EmitDefaultValue=false)]
        public bool InputRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberTagDefinition {\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  SuggestDefaultEntries: ").Append(SuggestDefaultEntries).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VaultId: ").Append(VaultId).Append("\n");
            sb.Append("  TagGroupDefinitionId: ").Append(TagGroupDefinitionId).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Sortable: ").Append(Sortable).Append("\n");
            sb.Append("  SingleTag: ").Append(SingleTag).Append("\n");
            sb.Append("  AddRule: ").Append(AddRule).Append("\n");
            sb.Append("  OverwriteRule: ").Append(OverwriteRule).Append("\n");
            sb.Append("  EditProtection: ").Append(EditProtection).Append("\n");
            sb.Append("  UserInput: ").Append(UserInput).Append("\n");
            sb.Append("  InputRequired: ").Append(InputRequired).Append("\n");
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
            return this.Equals(input as NumberTagDefinition);
        }

        /// <summary>
        /// Returns true if NumberTagDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of NumberTagDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberTagDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.SuggestDefaultEntries == input.SuggestDefaultEntries ||
                    (this.SuggestDefaultEntries != null &&
                    this.SuggestDefaultEntries.Equals(input.SuggestDefaultEntries))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.TagGroupDefinitionId == input.TagGroupDefinitionId ||
                    (this.TagGroupDefinitionId != null &&
                    this.TagGroupDefinitionId.Equals(input.TagGroupDefinitionId))
                ) && 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.Sortable == input.Sortable ||
                    (this.Sortable != null &&
                    this.Sortable.Equals(input.Sortable))
                ) && 
                (
                    this.SingleTag == input.SingleTag ||
                    (this.SingleTag != null &&
                    this.SingleTag.Equals(input.SingleTag))
                ) && 
                (
                    this.AddRule == input.AddRule ||
                    (this.AddRule != null &&
                    this.AddRule.Equals(input.AddRule))
                ) && 
                (
                    this.OverwriteRule == input.OverwriteRule ||
                    (this.OverwriteRule != null &&
                    this.OverwriteRule.Equals(input.OverwriteRule))
                ) && 
                (
                    this.EditProtection == input.EditProtection ||
                    (this.EditProtection != null &&
                    this.EditProtection.Equals(input.EditProtection))
                ) && 
                (
                    this.UserInput == input.UserInput ||
                    (this.UserInput != null &&
                    this.UserInput.Equals(input.UserInput))
                ) && 
                (
                    this.InputRequired == input.InputRequired ||
                    (this.InputRequired != null &&
                    this.InputRequired.Equals(input.InputRequired))
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
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.SuggestDefaultEntries != null)
                    hashCode = hashCode * 59 + this.SuggestDefaultEntries.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.TagGroupDefinitionId != null)
                    hashCode = hashCode * 59 + this.TagGroupDefinitionId.GetHashCode();
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Sortable != null)
                    hashCode = hashCode * 59 + this.Sortable.GetHashCode();
                if (this.SingleTag != null)
                    hashCode = hashCode * 59 + this.SingleTag.GetHashCode();
                if (this.AddRule != null)
                    hashCode = hashCode * 59 + this.AddRule.GetHashCode();
                if (this.OverwriteRule != null)
                    hashCode = hashCode * 59 + this.OverwriteRule.GetHashCode();
                if (this.EditProtection != null)
                    hashCode = hashCode * 59 + this.EditProtection.GetHashCode();
                if (this.UserInput != null)
                    hashCode = hashCode * 59 + this.UserInput.GetHashCode();
                if (this.InputRequired != null)
                    hashCode = hashCode * 59 + this.InputRequired.GetHashCode();
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
