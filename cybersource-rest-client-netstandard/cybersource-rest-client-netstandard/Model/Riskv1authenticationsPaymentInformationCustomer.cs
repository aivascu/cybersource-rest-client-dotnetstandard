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
    /// Riskv1authenticationsPaymentInformationCustomer
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsPaymentInformationCustomer :  IEquatable<Riskv1authenticationsPaymentInformationCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsPaymentInformationCustomer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Riskv1authenticationsPaymentInformationCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsPaymentInformationCustomer" /> class.
        /// </summary>
        /// <param name="CustomerId">Unique identifier for the legacy Secure Storage token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional.  (required).</param>
        /// <param name="Id">Unique identifier for the Customer token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional. .</param>
        public Riskv1authenticationsPaymentInformationCustomer(string CustomerId = default(string), string Id = default(string))
        {
            this.CustomerId = CustomerId;
            this.Id = Id;
        }
        
        /// <summary>
        /// Unique identifier for the legacy Secure Storage token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional. 
        /// </summary>
        /// <value>Unique identifier for the legacy Secure Storage token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional. </value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Unique identifier for the Customer token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional. 
        /// </summary>
        /// <value>Unique identifier for the Customer token used in the transaction. When you include this value in your request, many of the fields that are normally required for an authorization or credit become optional. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsPaymentInformationCustomer {\n");
            if (CustomerId != null) sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            if (Id != null) sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsPaymentInformationCustomer);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsPaymentInformationCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsPaymentInformationCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsPaymentInformationCustomer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
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
