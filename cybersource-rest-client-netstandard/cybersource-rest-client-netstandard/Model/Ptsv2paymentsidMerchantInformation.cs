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
    /// Ptsv2paymentsidMerchantInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidMerchantInformation :  IEquatable<Ptsv2paymentsidMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidMerchantInformation" /> class.
        /// </summary>
        /// <param name="TransactionLocalDateTime">Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:  - &#x60;YYYY&#x60; &#x3D; year  - &#x60;MM&#x60; &#x3D; month  - &#x60;DD&#x60; &#x3D; day  - &#x60;hh&#x60; &#x3D; hour  - &#x60;mm&#x60; &#x3D; minutes  - &#x60;ss&#x60; &#x3D; seconds  #### Used by **Authorization** Required for these processors: - American Express Direct                                                                                                                                                                                                                                                                                                                         - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - SIX  Optional for all other processors. .</param>
        public Ptsv2paymentsidMerchantInformation(string TransactionLocalDateTime = default(string))
        {
            this.TransactionLocalDateTime = TransactionLocalDateTime;
        }
        
        /// <summary>
        /// Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:  - &#x60;YYYY&#x60; &#x3D; year  - &#x60;MM&#x60; &#x3D; month  - &#x60;DD&#x60; &#x3D; day  - &#x60;hh&#x60; &#x3D; hour  - &#x60;mm&#x60; &#x3D; minutes  - &#x60;ss&#x60; &#x3D; seconds  #### Used by **Authorization** Required for these processors: - American Express Direct                                                                                                                                                                                                                                                                                                                         - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - SIX  Optional for all other processors. 
        /// </summary>
        /// <value>Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:  - &#x60;YYYY&#x60; &#x3D; year  - &#x60;MM&#x60; &#x3D; month  - &#x60;DD&#x60; &#x3D; day  - &#x60;hh&#x60; &#x3D; hour  - &#x60;mm&#x60; &#x3D; minutes  - &#x60;ss&#x60; &#x3D; seconds  #### Used by **Authorization** Required for these processors: - American Express Direct                                                                                                                                                                                                                                                                                                                         - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - SIX  Optional for all other processors. </value>
        [DataMember(Name="transactionLocalDateTime", EmitDefaultValue=false)]
        public string TransactionLocalDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidMerchantInformation {\n");
            if (TransactionLocalDateTime != null) sb.Append("  TransactionLocalDateTime: ").Append(TransactionLocalDateTime).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidMerchantInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionLocalDateTime == other.TransactionLocalDateTime ||
                    this.TransactionLocalDateTime != null &&
                    this.TransactionLocalDateTime.Equals(other.TransactionLocalDateTime)
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
                if (this.TransactionLocalDateTime != null)
                    hash = hash * 59 + this.TransactionLocalDateTime.GetHashCode();
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
