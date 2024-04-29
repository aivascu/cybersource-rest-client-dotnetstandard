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
    /// PtsV2CreateBillingAgreementPost201ResponseLinks
    /// </summary>
    [DataContract]
    public partial class PtsV2CreateBillingAgreementPost201ResponseLinks :  IEquatable<PtsV2CreateBillingAgreementPost201ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2CreateBillingAgreementPost201ResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="UpdateAgreement">UpdateAgreement.</param>
        /// <param name="RevokeAgreement">RevokeAgreement.</param>
        /// <param name="Status">Status.</param>
        public PtsV2CreateBillingAgreementPost201ResponseLinks(PtsV2PaymentsPost201ResponseLinksSelf Self = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf UpdateAgreement = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf RevokeAgreement = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Status = default(PtsV2PaymentsPost201ResponseLinksSelf))
        {
            this.Self = Self;
            this.UpdateAgreement = UpdateAgreement;
            this.RevokeAgreement = RevokeAgreement;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAgreement
        /// </summary>
        [DataMember(Name="updateAgreement", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf UpdateAgreement { get; set; }

        /// <summary>
        /// Gets or Sets RevokeAgreement
        /// </summary>
        [DataMember(Name="revokeAgreement", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf RevokeAgreement { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2CreateBillingAgreementPost201ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  UpdateAgreement: ").Append(UpdateAgreement).Append("\n");
            sb.Append("  RevokeAgreement: ").Append(RevokeAgreement).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as PtsV2CreateBillingAgreementPost201ResponseLinks);
        }

        /// <summary>
        /// Returns true if PtsV2CreateBillingAgreementPost201ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2CreateBillingAgreementPost201ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2CreateBillingAgreementPost201ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.UpdateAgreement == other.UpdateAgreement ||
                    this.UpdateAgreement != null &&
                    this.UpdateAgreement.Equals(other.UpdateAgreement)
                ) && 
                (
                    this.RevokeAgreement == other.RevokeAgreement ||
                    this.RevokeAgreement != null &&
                    this.RevokeAgreement.Equals(other.RevokeAgreement)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.UpdateAgreement != null)
                    hash = hash * 59 + this.UpdateAgreement.GetHashCode();
                if (this.RevokeAgreement != null)
                    hash = hash * 59 + this.RevokeAgreement.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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