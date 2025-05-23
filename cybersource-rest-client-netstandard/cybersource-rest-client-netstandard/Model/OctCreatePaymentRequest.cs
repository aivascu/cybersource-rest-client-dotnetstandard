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
    /// OctCreatePaymentRequest
    /// </summary>
    [DataContract]
    public partial class OctCreatePaymentRequest :  IEquatable<OctCreatePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OctCreatePaymentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="RecipientInformation">RecipientInformation.</param>
        /// <param name="SenderInformation">SenderInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="AggregatorInformation">AggregatorInformation.</param>
        public OctCreatePaymentRequest(Ptsv2payoutsClientReferenceInformation ClientReferenceInformation = default(Ptsv2payoutsClientReferenceInformation), Ptsv2payoutsOrderInformation OrderInformation = default(Ptsv2payoutsOrderInformation), Ptsv2payoutsMerchantInformation MerchantInformation = default(Ptsv2payoutsMerchantInformation), Ptsv2payoutsRecipientInformation RecipientInformation = default(Ptsv2payoutsRecipientInformation), Ptsv2payoutsSenderInformation SenderInformation = default(Ptsv2payoutsSenderInformation), Ptsv2payoutsProcessingInformation ProcessingInformation = default(Ptsv2payoutsProcessingInformation), Ptsv2payoutsPaymentInformation PaymentInformation = default(Ptsv2payoutsPaymentInformation), Ptsv2payoutsAggregatorInformation AggregatorInformation = default(Ptsv2payoutsAggregatorInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.OrderInformation = OrderInformation;
            this.MerchantInformation = MerchantInformation;
            this.RecipientInformation = RecipientInformation;
            this.SenderInformation = SenderInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.PaymentInformation = PaymentInformation;
            this.AggregatorInformation = AggregatorInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets RecipientInformation
        /// </summary>
        [DataMember(Name="recipientInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsRecipientInformation RecipientInformation { get; set; }

        /// <summary>
        /// Gets or Sets SenderInformation
        /// </summary>
        [DataMember(Name="senderInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsSenderInformation SenderInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets AggregatorInformation
        /// </summary>
        [DataMember(Name="aggregatorInformation", EmitDefaultValue=false)]
        public Ptsv2payoutsAggregatorInformation AggregatorInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OctCreatePaymentRequest {\n");
            if (ClientReferenceInformation != null) sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            if (OrderInformation != null) sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            if (MerchantInformation != null) sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            if (RecipientInformation != null) sb.Append("  RecipientInformation: ").Append(RecipientInformation).Append("\n");
            if (SenderInformation != null) sb.Append("  SenderInformation: ").Append(SenderInformation).Append("\n");
            if (ProcessingInformation != null) sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            if (PaymentInformation != null) sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            if (AggregatorInformation != null) sb.Append("  AggregatorInformation: ").Append(AggregatorInformation).Append("\n");
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
            return this.Equals(obj as OctCreatePaymentRequest);
        }

        /// <summary>
        /// Returns true if OctCreatePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OctCreatePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OctCreatePaymentRequest other)
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
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.RecipientInformation == other.RecipientInformation ||
                    this.RecipientInformation != null &&
                    this.RecipientInformation.Equals(other.RecipientInformation)
                ) && 
                (
                    this.SenderInformation == other.SenderInformation ||
                    this.SenderInformation != null &&
                    this.SenderInformation.Equals(other.SenderInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.AggregatorInformation == other.AggregatorInformation ||
                    this.AggregatorInformation != null &&
                    this.AggregatorInformation.Equals(other.AggregatorInformation)
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
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.RecipientInformation != null)
                    hash = hash * 59 + this.RecipientInformation.GetHashCode();
                if (this.SenderInformation != null)
                    hash = hash * 59 + this.SenderInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.AggregatorInformation != null)
                    hash = hash * 59 + this.AggregatorInformation.GetHashCode();
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
