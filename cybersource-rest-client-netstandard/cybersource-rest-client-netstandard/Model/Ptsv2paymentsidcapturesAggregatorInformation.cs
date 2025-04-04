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
    /// Ptsv2paymentsidcapturesAggregatorInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesAggregatorInformation :  IEquatable<Ptsv2paymentsidcapturesAggregatorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesAggregatorInformation" /> class.
        /// </summary>
        /// <param name="AggregatorId">Value that identifies you as a payment aggregator. Get this value from the processor.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR6 - Position: 95-105 - Field: Payment Facilitator ID  This field is supported for Visa, Mastercard and Discover Transactions.  **FDC Compass**\\ This value must consist of uppercase characters. .</param>
        /// <param name="Name">Your payment aggregator business name.  **American Express Direct**\\ The maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters.\\  #### CyberSource through VisaNet With American Express, the maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  **FDC Compass**\\ This value must consist of uppercase characters. .</param>
        /// <param name="SubMerchant">SubMerchant.</param>
        public Ptsv2paymentsidcapturesAggregatorInformation(string AggregatorId = default(string), string Name = default(string), Ptsv2paymentsidcapturesAggregatorInformationSubMerchant SubMerchant = default(Ptsv2paymentsidcapturesAggregatorInformationSubMerchant))
        {
            this.AggregatorId = AggregatorId;
            this.Name = Name;
            this.SubMerchant = SubMerchant;
        }
        
        /// <summary>
        /// Value that identifies you as a payment aggregator. Get this value from the processor.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR6 - Position: 95-105 - Field: Payment Facilitator ID  This field is supported for Visa, Mastercard and Discover Transactions.  **FDC Compass**\\ This value must consist of uppercase characters. 
        /// </summary>
        /// <value>Value that identifies you as a payment aggregator. Get this value from the processor.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR6 - Position: 95-105 - Field: Payment Facilitator ID  This field is supported for Visa, Mastercard and Discover Transactions.  **FDC Compass**\\ This value must consist of uppercase characters. </value>
        [DataMember(Name="aggregatorId", EmitDefaultValue=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// Your payment aggregator business name.  **American Express Direct**\\ The maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters.\\  #### CyberSource through VisaNet With American Express, the maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  **FDC Compass**\\ This value must consist of uppercase characters. 
        /// </summary>
        /// <value>Your payment aggregator business name.  **American Express Direct**\\ The maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters.\\  #### CyberSource through VisaNet With American Express, the maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.  **FDC Compass**\\ This value must consist of uppercase characters. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchant
        /// </summary>
        [DataMember(Name="subMerchant", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesAggregatorInformationSubMerchant SubMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesAggregatorInformation {\n");
            if (AggregatorId != null) sb.Append("  AggregatorId: ").Append(AggregatorId).Append("\n");
            if (Name != null) sb.Append("  Name: ").Append(Name).Append("\n");
            if (SubMerchant != null) sb.Append("  SubMerchant: ").Append(SubMerchant).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesAggregatorInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesAggregatorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesAggregatorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesAggregatorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AggregatorId == other.AggregatorId ||
                    this.AggregatorId != null &&
                    this.AggregatorId.Equals(other.AggregatorId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubMerchant == other.SubMerchant ||
                    this.SubMerchant != null &&
                    this.SubMerchant.Equals(other.SubMerchant)
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
                if (this.AggregatorId != null)
                    hash = hash * 59 + this.AggregatorId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SubMerchant != null)
                    hash = hash * 59 + this.SubMerchant.GetHashCode();
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
