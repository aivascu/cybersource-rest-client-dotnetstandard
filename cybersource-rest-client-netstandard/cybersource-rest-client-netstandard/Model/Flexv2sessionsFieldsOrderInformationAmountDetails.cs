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
    /// Flexv2sessionsFieldsOrderInformationAmountDetails
    /// </summary>
    [DataContract]
    public partial class Flexv2sessionsFieldsOrderInformationAmountDetails :  IEquatable<Flexv2sessionsFieldsOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Flexv2sessionsFieldsOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">TotalAmount.</param>
        /// <param name="Currency">Currency.</param>
        public Flexv2sessionsFieldsOrderInformationAmountDetails(Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount TotalAmount = default(Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount), Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount Currency = default(Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount))
        {
            this.TotalAmount = TotalAmount;
            this.Currency = Currency;
        }
        
        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public Flexv2sessionsFieldsOrderInformationAmountDetailsTotalAmount Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flexv2sessionsFieldsOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as Flexv2sessionsFieldsOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if Flexv2sessionsFieldsOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Flexv2sessionsFieldsOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flexv2sessionsFieldsOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
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