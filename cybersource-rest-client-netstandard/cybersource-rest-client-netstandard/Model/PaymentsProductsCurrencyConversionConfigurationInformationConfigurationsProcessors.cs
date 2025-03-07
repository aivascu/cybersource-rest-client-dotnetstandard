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
    /// PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors :  IEquatable<PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors" /> class.
        /// </summary>
        /// <param name="MerchantId">The merchant identifier for the Currency Conversion service. Check with your Currency Conversion Provider for details..</param>
        /// <param name="AcquirerId">AcquirerId.</param>
        public PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors(string MerchantId = default(string), string AcquirerId = default(string))
        {
            this.MerchantId = MerchantId;
            this.AcquirerId = AcquirerId;
        }
        
        /// <summary>
        /// The merchant identifier for the Currency Conversion service. Check with your Currency Conversion Provider for details.
        /// </summary>
        /// <value>The merchant identifier for the Currency Conversion service. Check with your Currency Conversion Provider for details.</value>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerId
        /// </summary>
        [DataMember(Name="acquirerId", EmitDefaultValue=false)]
        public string AcquirerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors {\n");
            if (MerchantId != null) sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            if (AcquirerId != null) sb.Append("  AcquirerId: ").Append(AcquirerId).Append("\n");
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
            return this.Equals(obj as PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors);
        }

        /// <summary>
        /// Returns true if PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsCurrencyConversionConfigurationInformationConfigurationsProcessors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                ) && 
                (
                    this.AcquirerId == other.AcquirerId ||
                    this.AcquirerId != null &&
                    this.AcquirerId.Equals(other.AcquirerId)
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
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                if (this.AcquirerId != null)
                    hash = hash * 59 + this.AcquirerId.GetHashCode();
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
