/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2billingagreementsDeviceInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2billingagreementsDeviceInformation :  IEquatable<Ptsv2billingagreementsDeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2billingagreementsDeviceInformation" /> class.
        /// </summary>
        /// <param name="HttpAcceptBrowserValue">Value of the Accept header sent by the customer&#39;s web browser. **Note** If the customer&#39;s browser provides a value, you must include it in your request. .</param>
        /// <param name="IpAddress">IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. .</param>
        /// <param name="UserAgentBrowserValue">Value of the User-Agent header sent by the customer&#39;s web browser. Note If the customer&#39;s browser provides a value, you must include it in your request. .</param>
        public Ptsv2billingagreementsDeviceInformation(string HttpAcceptBrowserValue = default(string), string IpAddress = default(string), string UserAgentBrowserValue = default(string))
        {
            this.HttpAcceptBrowserValue = HttpAcceptBrowserValue;
            this.IpAddress = IpAddress;
            this.UserAgentBrowserValue = UserAgentBrowserValue;
        }
        
        /// <summary>
        /// Value of the Accept header sent by the customer&#39;s web browser. **Note** If the customer&#39;s browser provides a value, you must include it in your request. 
        /// </summary>
        /// <value>Value of the Accept header sent by the customer&#39;s web browser. **Note** If the customer&#39;s browser provides a value, you must include it in your request. </value>
        [DataMember(Name="httpAcceptBrowserValue", EmitDefaultValue=false)]
        public string HttpAcceptBrowserValue { get; set; }

        /// <summary>
        /// IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. 
        /// </summary>
        /// <value>IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. </value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Value of the User-Agent header sent by the customer&#39;s web browser. Note If the customer&#39;s browser provides a value, you must include it in your request. 
        /// </summary>
        /// <value>Value of the User-Agent header sent by the customer&#39;s web browser. Note If the customer&#39;s browser provides a value, you must include it in your request. </value>
        [DataMember(Name="userAgentBrowserValue", EmitDefaultValue=false)]
        public string UserAgentBrowserValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2billingagreementsDeviceInformation {\n");
            sb.Append("  HttpAcceptBrowserValue: ").Append(HttpAcceptBrowserValue).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  UserAgentBrowserValue: ").Append(UserAgentBrowserValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Ptsv2billingagreementsDeviceInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2billingagreementsDeviceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2billingagreementsDeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2billingagreementsDeviceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HttpAcceptBrowserValue == other.HttpAcceptBrowserValue ||
                    this.HttpAcceptBrowserValue != null &&
                    this.HttpAcceptBrowserValue.Equals(other.HttpAcceptBrowserValue)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.UserAgentBrowserValue == other.UserAgentBrowserValue ||
                    this.UserAgentBrowserValue != null &&
                    this.UserAgentBrowserValue.Equals(other.UserAgentBrowserValue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.HttpAcceptBrowserValue != null)
                    hash = hash * 59 + this.HttpAcceptBrowserValue.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.UserAgentBrowserValue != null)
                    hash = hash * 59 + this.UserAgentBrowserValue.GetHashCode();
                return hash;
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