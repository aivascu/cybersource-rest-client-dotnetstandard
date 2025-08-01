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
    /// Ptsv2intentsPaymentInformationTokenizedPaymentMethod
    /// </summary>
    [DataContract]
    public partial class Ptsv2intentsPaymentInformationTokenizedPaymentMethod :  IEquatable<Ptsv2intentsPaymentInformationTokenizedPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2intentsPaymentInformationTokenizedPaymentMethod" /> class.
        /// </summary>
        /// <param name="Description">Description of the vaulted payment method shown to the buyer during checkout and in their PayPal account. .</param>
        /// <param name="UsagePattern">Indicates how the merchant will primarily use the vaulted payment method. Valid values: - \&quot;IMMEDIATE\&quot;: For on-demand, instant payments. These payments are variable in both amount and frequency and will be used to pay for goods or services before they are rendered to the buyer - \&quot;DEFERRED\&quot;: For post-pay payments; that is, payments for goods or services that have already been rendered to the buyer - \&quot;RECURRING_PREPAID\&quot;: For recurring payments before services are rendered. - \&quot;RECURRING_POSTPAID\&quot;: For recurring payments after services are rendered. - \&quot;THRESHOLD_PREPAID\&quot;: For payments when a pre-defined threshold is reached before services are rendered. - \&quot;THRESHOLD_POSTPAID\&quot;: For payments when a pre-defined threshold is reached after services are rendered. .</param>
        /// <param name="UsageType">Indicates the type of vaulting relationship. Valid values: - \&quot;MERCHANT\&quot;: Single merchant relationship. - \&quot;PLATFORM\&quot;: Platform hosting multiple merchants. .</param>
        /// <param name="AllowMultipleTokens">Create multiple payment tokens for the same payer, merchant/platform combination. This helps to identify customers distinctly even though they may share the same PayPal account. .</param>
        public Ptsv2intentsPaymentInformationTokenizedPaymentMethod(string Description = default(string), string UsagePattern = default(string), string UsageType = default(string), bool? AllowMultipleTokens = default(bool?))
        {
            this.Description = Description;
            this.UsagePattern = UsagePattern;
            this.UsageType = UsageType;
            this.AllowMultipleTokens = AllowMultipleTokens;
        }
        
        /// <summary>
        /// Description of the vaulted payment method shown to the buyer during checkout and in their PayPal account. 
        /// </summary>
        /// <value>Description of the vaulted payment method shown to the buyer during checkout and in their PayPal account. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates how the merchant will primarily use the vaulted payment method. Valid values: - \&quot;IMMEDIATE\&quot;: For on-demand, instant payments. These payments are variable in both amount and frequency and will be used to pay for goods or services before they are rendered to the buyer - \&quot;DEFERRED\&quot;: For post-pay payments; that is, payments for goods or services that have already been rendered to the buyer - \&quot;RECURRING_PREPAID\&quot;: For recurring payments before services are rendered. - \&quot;RECURRING_POSTPAID\&quot;: For recurring payments after services are rendered. - \&quot;THRESHOLD_PREPAID\&quot;: For payments when a pre-defined threshold is reached before services are rendered. - \&quot;THRESHOLD_POSTPAID\&quot;: For payments when a pre-defined threshold is reached after services are rendered. 
        /// </summary>
        /// <value>Indicates how the merchant will primarily use the vaulted payment method. Valid values: - \&quot;IMMEDIATE\&quot;: For on-demand, instant payments. These payments are variable in both amount and frequency and will be used to pay for goods or services before they are rendered to the buyer - \&quot;DEFERRED\&quot;: For post-pay payments; that is, payments for goods or services that have already been rendered to the buyer - \&quot;RECURRING_PREPAID\&quot;: For recurring payments before services are rendered. - \&quot;RECURRING_POSTPAID\&quot;: For recurring payments after services are rendered. - \&quot;THRESHOLD_PREPAID\&quot;: For payments when a pre-defined threshold is reached before services are rendered. - \&quot;THRESHOLD_POSTPAID\&quot;: For payments when a pre-defined threshold is reached after services are rendered. </value>
        [DataMember(Name="usagePattern", EmitDefaultValue=false)]
        public string UsagePattern { get; set; }

        /// <summary>
        /// Indicates the type of vaulting relationship. Valid values: - \&quot;MERCHANT\&quot;: Single merchant relationship. - \&quot;PLATFORM\&quot;: Platform hosting multiple merchants. 
        /// </summary>
        /// <value>Indicates the type of vaulting relationship. Valid values: - \&quot;MERCHANT\&quot;: Single merchant relationship. - \&quot;PLATFORM\&quot;: Platform hosting multiple merchants. </value>
        [DataMember(Name="usageType", EmitDefaultValue=false)]
        public string UsageType { get; set; }

        /// <summary>
        /// Create multiple payment tokens for the same payer, merchant/platform combination. This helps to identify customers distinctly even though they may share the same PayPal account. 
        /// </summary>
        /// <value>Create multiple payment tokens for the same payer, merchant/platform combination. This helps to identify customers distinctly even though they may share the same PayPal account. </value>
        [DataMember(Name="allowMultipleTokens", EmitDefaultValue=false)]
        public bool? AllowMultipleTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2intentsPaymentInformationTokenizedPaymentMethod {\n");
            if (Description != null) sb.Append("  Description: ").Append(Description).Append("\n");
            if (UsagePattern != null) sb.Append("  UsagePattern: ").Append(UsagePattern).Append("\n");
            if (UsageType != null) sb.Append("  UsageType: ").Append(UsageType).Append("\n");
            if (AllowMultipleTokens != null) sb.Append("  AllowMultipleTokens: ").Append(AllowMultipleTokens).Append("\n");
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
            return this.Equals(obj as Ptsv2intentsPaymentInformationTokenizedPaymentMethod);
        }

        /// <summary>
        /// Returns true if Ptsv2intentsPaymentInformationTokenizedPaymentMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2intentsPaymentInformationTokenizedPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2intentsPaymentInformationTokenizedPaymentMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.UsagePattern == other.UsagePattern ||
                    this.UsagePattern != null &&
                    this.UsagePattern.Equals(other.UsagePattern)
                ) && 
                (
                    this.UsageType == other.UsageType ||
                    this.UsageType != null &&
                    this.UsageType.Equals(other.UsageType)
                ) && 
                (
                    this.AllowMultipleTokens == other.AllowMultipleTokens ||
                    this.AllowMultipleTokens != null &&
                    this.AllowMultipleTokens.Equals(other.AllowMultipleTokens)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.UsagePattern != null)
                    hash = hash * 59 + this.UsagePattern.GetHashCode();
                if (this.UsageType != null)
                    hash = hash * 59 + this.UsageType.GetHashCode();
                if (this.AllowMultipleTokens != null)
                    hash = hash * 59 + this.AllowMultipleTokens.GetHashCode();
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
