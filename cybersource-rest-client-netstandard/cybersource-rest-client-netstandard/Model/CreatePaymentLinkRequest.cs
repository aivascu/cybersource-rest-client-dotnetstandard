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
    /// CreatePaymentLinkRequest
    /// </summary>
    [DataContract]
    public partial class CreatePaymentLinkRequest :  IEquatable<CreatePaymentLinkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentLinkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePaymentLinkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentLinkRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation (required).</param>
        /// <param name="PurchaseInformation">PurchaseInformation (required).</param>
        /// <param name="OrderInformation">OrderInformation (required).</param>
        public CreatePaymentLinkRequest(Invoicingv2invoicesClientReferenceInformation ClientReferenceInformation = default(Invoicingv2invoicesClientReferenceInformation), Iplv2paymentlinksProcessingInformation ProcessingInformation = default(Iplv2paymentlinksProcessingInformation), Iplv2paymentlinksPurchaseInformation PurchaseInformation = default(Iplv2paymentlinksPurchaseInformation), Iplv2paymentlinksOrderInformation OrderInformation = default(Iplv2paymentlinksOrderInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.PurchaseInformation = PurchaseInformation;
            this.OrderInformation = OrderInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Invoicingv2invoicesClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Iplv2paymentlinksProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseInformation
        /// </summary>
        [DataMember(Name="purchaseInformation", EmitDefaultValue=false)]
        public Iplv2paymentlinksPurchaseInformation PurchaseInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Iplv2paymentlinksOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePaymentLinkRequest {\n");
            if (ClientReferenceInformation != null) sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            if (ProcessingInformation != null) sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            if (PurchaseInformation != null) sb.Append("  PurchaseInformation: ").Append(PurchaseInformation).Append("\n");
            if (OrderInformation != null) sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
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
            return this.Equals(obj as CreatePaymentLinkRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentLinkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePaymentLinkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentLinkRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.PurchaseInformation == other.PurchaseInformation ||
                    this.PurchaseInformation != null &&
                    this.PurchaseInformation.Equals(other.PurchaseInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.PurchaseInformation != null)
                    hash = hash * 59 + this.PurchaseInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
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
