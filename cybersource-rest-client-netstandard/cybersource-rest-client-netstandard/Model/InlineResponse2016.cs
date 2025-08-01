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
    /// InlineResponse2016
    /// </summary>
    [DataContract]
    public partial class InlineResponse2016 :  IEquatable<InlineResponse2016>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2016" /> class.
        /// </summary>
        /// <param name="EventDate">Date that the webhook was delivered.</param>
        /// <param name="EventType">The event name the webhook was delivered for.</param>
        /// <param name="OrganizationId">The Organization Identifier..</param>
        /// <param name="Payloads">Payloads.</param>
        /// <param name="ProductId">The product the webhook was delivered for.</param>
        /// <param name="RequestType">Identifies the the type of request.</param>
        /// <param name="RetryNumber">The number of retry attempts for a given webhook.</param>
        /// <param name="TransactionTraceId">The identifier for the webhook.</param>
        /// <param name="WebhookId">The identifier of the subscription.</param>
        public InlineResponse2016(string EventDate = default(string), string EventType = default(string), string OrganizationId = default(string), InlineResponse2016Payloads Payloads = default(InlineResponse2016Payloads), string ProductId = default(string), string RequestType = default(string), int? RetryNumber = default(int?), string TransactionTraceId = default(string), string WebhookId = default(string))
        {
            this.EventDate = EventDate;
            this.EventType = EventType;
            this.OrganizationId = OrganizationId;
            this.Payloads = Payloads;
            this.ProductId = ProductId;
            this.RequestType = RequestType;
            this.RetryNumber = RetryNumber;
            this.TransactionTraceId = TransactionTraceId;
            this.WebhookId = WebhookId;
        }
        
        /// <summary>
        /// Date that the webhook was delivered
        /// </summary>
        /// <value>Date that the webhook was delivered</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        public string EventDate { get; set; }

        /// <summary>
        /// The event name the webhook was delivered for
        /// </summary>
        /// <value>The event name the webhook was delivered for</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The Organization Identifier.
        /// </summary>
        /// <value>The Organization Identifier.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Payloads
        /// </summary>
        [DataMember(Name="payloads", EmitDefaultValue=false)]
        public InlineResponse2016Payloads Payloads { get; set; }

        /// <summary>
        /// The product the webhook was delivered for
        /// </summary>
        /// <value>The product the webhook was delivered for</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Identifies the the type of request
        /// </summary>
        /// <value>Identifies the the type of request</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// The number of retry attempts for a given webhook
        /// </summary>
        /// <value>The number of retry attempts for a given webhook</value>
        [DataMember(Name="retryNumber", EmitDefaultValue=false)]
        public int? RetryNumber { get; set; }

        /// <summary>
        /// The identifier for the webhook
        /// </summary>
        /// <value>The identifier for the webhook</value>
        [DataMember(Name="transactionTraceId", EmitDefaultValue=false)]
        public string TransactionTraceId { get; set; }

        /// <summary>
        /// The identifier of the subscription
        /// </summary>
        /// <value>The identifier of the subscription</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public string WebhookId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2016 {\n");
            if (EventDate != null) sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            if (EventType != null) sb.Append("  EventType: ").Append(EventType).Append("\n");
            if (OrganizationId != null) sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            if (Payloads != null) sb.Append("  Payloads: ").Append(Payloads).Append("\n");
            if (ProductId != null) sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            if (RequestType != null) sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            if (RetryNumber != null) sb.Append("  RetryNumber: ").Append(RetryNumber).Append("\n");
            if (TransactionTraceId != null) sb.Append("  TransactionTraceId: ").Append(TransactionTraceId).Append("\n");
            if (WebhookId != null) sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
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
            return this.Equals(obj as InlineResponse2016);
        }

        /// <summary>
        /// Returns true if InlineResponse2016 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2016 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2016 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) && 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.Payloads == other.Payloads ||
                    this.Payloads != null &&
                    this.Payloads.Equals(other.Payloads)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.RequestType == other.RequestType ||
                    this.RequestType != null &&
                    this.RequestType.Equals(other.RequestType)
                ) && 
                (
                    this.RetryNumber == other.RetryNumber ||
                    this.RetryNumber != null &&
                    this.RetryNumber.Equals(other.RetryNumber)
                ) && 
                (
                    this.TransactionTraceId == other.TransactionTraceId ||
                    this.TransactionTraceId != null &&
                    this.TransactionTraceId.Equals(other.TransactionTraceId)
                ) && 
                (
                    this.WebhookId == other.WebhookId ||
                    this.WebhookId != null &&
                    this.WebhookId.Equals(other.WebhookId)
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
                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.Payloads != null)
                    hash = hash * 59 + this.Payloads.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.RequestType != null)
                    hash = hash * 59 + this.RequestType.GetHashCode();
                if (this.RetryNumber != null)
                    hash = hash * 59 + this.RetryNumber.GetHashCode();
                if (this.TransactionTraceId != null)
                    hash = hash * 59 + this.TransactionTraceId.GetHashCode();
                if (this.WebhookId != null)
                    hash = hash * 59 + this.WebhookId.GetHashCode();
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
