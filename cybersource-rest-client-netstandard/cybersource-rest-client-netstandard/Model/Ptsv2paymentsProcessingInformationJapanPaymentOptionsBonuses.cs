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
    /// Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses :  IEquatable<Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses" /> class.
        /// </summary>
        /// <param name="Month">This value is a 2-digit code indicating the first bonus month. Valid value from 1 to 12. .</param>
        /// <param name="Amount">This value contains the bonus amount of the first month. Maximum value without decimal 99999999. .</param>
        public Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses(string Month = default(string), string Amount = default(string))
        {
            this.Month = Month;
            this.Amount = Amount;
        }
        
        /// <summary>
        /// This value is a 2-digit code indicating the first bonus month. Valid value from 1 to 12. 
        /// </summary>
        /// <value>This value is a 2-digit code indicating the first bonus month. Valid value from 1 to 12. </value>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }

        /// <summary>
        /// This value contains the bonus amount of the first month. Maximum value without decimal 99999999. 
        /// </summary>
        /// <value>This value contains the bonus amount of the first month. Maximum value without decimal 99999999. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses {\n");
            if (Month != null) sb.Append("  Month: ").Append(Month).Append("\n");
            if (Amount != null) sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessingInformationJapanPaymentOptionsBonuses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
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
