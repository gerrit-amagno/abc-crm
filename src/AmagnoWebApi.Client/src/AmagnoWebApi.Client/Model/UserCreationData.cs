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
    /// UserCreationData
    /// </summary>
    [DataContract]
    public partial class UserCreationData :  IEquatable<UserCreationData>, IValidatableObject
    {
        /// <summary>
        /// Type of account
        /// </summary>
        /// <value>Type of account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,

            /// <summary>
            /// Enum Concurrent for value: Concurrent
            /// </summary>
            [EnumMember(Value = "Concurrent")]
            Concurrent = 2,

            /// <summary>
            /// Enum ReadOnly for value: ReadOnly
            /// </summary>
            [EnumMember(Value = "ReadOnly")]
            ReadOnly = 3

        }

        /// <summary>
        /// Type of account
        /// </summary>
        /// <value>Type of account</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCreationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreationData" /> class.
        /// </summary>
        /// <param name="type">Type of account.</param>
        /// <param name="fullName">First and last name (required).</param>
        /// <param name="email">Email (required).</param>
        /// <param name="password">Password (required).</param>
        /// <param name="quota">File quota in MB (optional - default value is set in server settings).</param>
        /// <param name="userSid">ID to recognize record in external direction systems (e.g. MS Active Directory) (optional).</param>
        /// <param name="isInactive">Flag of inactivity (optional - default is false, user is active).</param>
        public UserCreationData(TypeEnum? type = default(TypeEnum?), string fullName = default(string), string email = default(string), string password = default(string), int quota = default(int), string userSid = default(string), bool isInactive = default(bool))
        {
            // to ensure "fullName" is required (not null)
            if (fullName == null)
            {
                throw new InvalidDataException("fullName is a required property for UserCreationData and cannot be null");
            }
            else
            {
                this.FullName = fullName;
            }
            
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UserCreationData and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for UserCreationData and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
            this.Type = type;
            this.Quota = quota;
            this.UserSid = userSid;
            this.IsInactive = isInactive;
        }
        

        /// <summary>
        /// First and last name
        /// </summary>
        /// <value>First and last name</value>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// File quota in MB (optional - default value is set in server settings)
        /// </summary>
        /// <value>File quota in MB (optional - default value is set in server settings)</value>
        [DataMember(Name="quota", EmitDefaultValue=false)]
        public int Quota { get; set; }

        /// <summary>
        /// ID to recognize record in external direction systems (e.g. MS Active Directory) (optional)
        /// </summary>
        /// <value>ID to recognize record in external direction systems (e.g. MS Active Directory) (optional)</value>
        [DataMember(Name="userSid", EmitDefaultValue=false)]
        public string UserSid { get; set; }

        /// <summary>
        /// Flag of inactivity (optional - default is false, user is active)
        /// </summary>
        /// <value>Flag of inactivity (optional - default is false, user is active)</value>
        [DataMember(Name="isInactive", EmitDefaultValue=false)]
        public bool IsInactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreationData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  UserSid: ").Append(UserSid).Append("\n");
            sb.Append("  IsInactive: ").Append(IsInactive).Append("\n");
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
            return this.Equals(input as UserCreationData);
        }

        /// <summary>
        /// Returns true if UserCreationData instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCreationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.UserSid == input.UserSid ||
                    (this.UserSid != null &&
                    this.UserSid.Equals(input.UserSid))
                ) && 
                (
                    this.IsInactive == input.IsInactive ||
                    (this.IsInactive != null &&
                    this.IsInactive.Equals(input.IsInactive))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.UserSid != null)
                    hashCode = hashCode * 59 + this.UserSid.GetHashCode();
                if (this.IsInactive != null)
                    hashCode = hashCode * 59 + this.IsInactive.GetHashCode();
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
