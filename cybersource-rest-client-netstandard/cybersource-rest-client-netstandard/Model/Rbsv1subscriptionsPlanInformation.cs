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
    /// Rbsv1subscriptionsPlanInformation
    /// </summary>
    [DataContract]
    public partial class Rbsv1subscriptionsPlanInformation :  IEquatable<Rbsv1subscriptionsPlanInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rbsv1subscriptionsPlanInformation" /> class.
        /// </summary>
        /// <param name="BillingPeriod">BillingPeriod.</param>
        /// <param name="BillingCycles">BillingCycles.</param>
        public Rbsv1subscriptionsPlanInformation(GetAllPlansResponsePlanInformationBillingPeriod BillingPeriod = default(GetAllPlansResponsePlanInformationBillingPeriod), Rbsv1plansPlanInformationBillingCycles BillingCycles = default(Rbsv1plansPlanInformationBillingCycles))
        {
            this.BillingPeriod = BillingPeriod;
            this.BillingCycles = BillingCycles;
        }
        
        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
        public GetAllPlansResponsePlanInformationBillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets BillingCycles
        /// </summary>
        [DataMember(Name="billingCycles", EmitDefaultValue=false)]
        public Rbsv1plansPlanInformationBillingCycles BillingCycles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rbsv1subscriptionsPlanInformation {\n");
            if (BillingPeriod != null) sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            if (BillingCycles != null) sb.Append("  BillingCycles: ").Append(BillingCycles).Append("\n");
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
            return this.Equals(obj as Rbsv1subscriptionsPlanInformation);
        }

        /// <summary>
        /// Returns true if Rbsv1subscriptionsPlanInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Rbsv1subscriptionsPlanInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rbsv1subscriptionsPlanInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingPeriod == other.BillingPeriod ||
                    this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(other.BillingPeriod)
                ) && 
                (
                    this.BillingCycles == other.BillingCycles ||
                    this.BillingCycles != null &&
                    this.BillingCycles.Equals(other.BillingCycles)
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
                if (this.BillingPeriod != null)
                    hash = hash * 59 + this.BillingPeriod.GetHashCode();
                if (this.BillingCycles != null)
                    hash = hash * 59 + this.BillingCycles.GetHashCode();
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
