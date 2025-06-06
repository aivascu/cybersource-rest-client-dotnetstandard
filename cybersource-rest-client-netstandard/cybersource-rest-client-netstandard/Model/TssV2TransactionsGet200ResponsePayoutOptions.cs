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
    /// TssV2TransactionsGet200ResponsePayoutOptions
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePayoutOptions :  IEquatable<TssV2TransactionsGet200ResponsePayoutOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePayoutOptions" /> class.
        /// </summary>
        /// <param name="PayoutInquiry">If true then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup. Possible values: - &#x60;true&#x60; - &#x60;false&#x60; .</param>
        public TssV2TransactionsGet200ResponsePayoutOptions(string PayoutInquiry = default(string))
        {
            this.PayoutInquiry = PayoutInquiry;
        }
        
        /// <summary>
        /// If true then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup. Possible values: - &#x60;true&#x60; - &#x60;false&#x60; 
        /// </summary>
        /// <value>If true then provide attributes related to fund transfer/payouts. If payout information not found then response will have standard account lookup. Possible values: - &#x60;true&#x60; - &#x60;false&#x60; </value>
        [DataMember(Name="payoutInquiry", EmitDefaultValue=false)]
        public string PayoutInquiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePayoutOptions {\n");
            if (PayoutInquiry != null) sb.Append("  PayoutInquiry: ").Append(PayoutInquiry).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePayoutOptions);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePayoutOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePayoutOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePayoutOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PayoutInquiry == other.PayoutInquiry ||
                    this.PayoutInquiry != null &&
                    this.PayoutInquiry.Equals(other.PayoutInquiry)
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
                if (this.PayoutInquiry != null)
                    hash = hash * 59 + this.PayoutInquiry.GetHashCode();
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
