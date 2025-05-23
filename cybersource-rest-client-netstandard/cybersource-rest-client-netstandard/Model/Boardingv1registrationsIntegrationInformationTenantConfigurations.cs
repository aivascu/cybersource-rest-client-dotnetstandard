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
    /// Boardingv1registrationsIntegrationInformationTenantConfigurations
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsIntegrationInformationTenantConfigurations :  IEquatable<Boardingv1registrationsIntegrationInformationTenantConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsIntegrationInformationTenantConfigurations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boardingv1registrationsIntegrationInformationTenantConfigurations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsIntegrationInformationTenantConfigurations" /> class.
        /// </summary>
        /// <param name="SolutionId">The solutionId is the unique identifier for this system resource. Partner can use it to reference the specific solution through out the system.  (required).</param>
        /// <param name="TenantInformation">TenantInformation.</param>
        public Boardingv1registrationsIntegrationInformationTenantConfigurations(string SolutionId = default(string), Boardingv1registrationsIntegrationInformationTenantInformation TenantInformation = default(Boardingv1registrationsIntegrationInformationTenantInformation))
        {
            this.SolutionId = SolutionId;
            this.TenantInformation = TenantInformation;
        }
        
        /// <summary>
        /// The solutionId is the unique identifier for this system resource. Partner can use it to reference the specific solution through out the system. 
        /// </summary>
        /// <value>The solutionId is the unique identifier for this system resource. Partner can use it to reference the specific solution through out the system. </value>
        [DataMember(Name="solutionId", EmitDefaultValue=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// Gets or Sets TenantInformation
        /// </summary>
        [DataMember(Name="tenantInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsIntegrationInformationTenantInformation TenantInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsIntegrationInformationTenantConfigurations {\n");
            if (SolutionId != null) sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            if (TenantInformation != null) sb.Append("  TenantInformation: ").Append(TenantInformation).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsIntegrationInformationTenantConfigurations);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsIntegrationInformationTenantConfigurations instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsIntegrationInformationTenantConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsIntegrationInformationTenantConfigurations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SolutionId == other.SolutionId ||
                    this.SolutionId != null &&
                    this.SolutionId.Equals(other.SolutionId)
                ) && 
                (
                    this.TenantInformation == other.TenantInformation ||
                    this.TenantInformation != null &&
                    this.TenantInformation.Equals(other.TenantInformation)
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
                if (this.SolutionId != null)
                    hash = hash * 59 + this.SolutionId.GetHashCode();
                if (this.TenantInformation != null)
                    hash = hash * 59 + this.TenantInformation.GetHashCode();
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
