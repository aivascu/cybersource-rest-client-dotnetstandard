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
    /// InlineResponse20010
    /// </summary>
    [DataContract]
    public partial class InlineResponse20010 :  IEquatable<InlineResponse20010>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="ReportCreatedDate">ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ.</param>
        /// <param name="BatchId">Unique identification number assigned to the submitted request..</param>
        /// <param name="BatchSource">Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE .</param>
        /// <param name="BatchCaEndpoints">BatchCaEndpoints.</param>
        /// <param name="BatchCreatedDate">ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ.</param>
        /// <param name="MerchantReference">Reference used by merchant to identify batch..</param>
        /// <param name="Totals">Totals.</param>
        /// <param name="Billing">Billing.</param>
        /// <param name="Records">Records.</param>
        public InlineResponse20010(string Version = default(string), string ReportCreatedDate = default(string), string BatchId = default(string), string BatchSource = default(string), string BatchCaEndpoints = default(string), string BatchCreatedDate = default(string), string MerchantReference = default(string), InlineResponse2008EmbeddedTotals Totals = default(InlineResponse2008EmbeddedTotals), InlineResponse2009Billing Billing = default(InlineResponse2009Billing), List<InlineResponse20010Records> Records = default(List<InlineResponse20010Records>))
        {
            this.Version = Version;
            this.ReportCreatedDate = ReportCreatedDate;
            this.BatchId = BatchId;
            this.BatchSource = BatchSource;
            this.BatchCaEndpoints = BatchCaEndpoints;
            this.BatchCreatedDate = BatchCreatedDate;
            this.MerchantReference = MerchantReference;
            this.Totals = Totals;
            this.Billing = Billing;
            this.Records = Records;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        /// <value>ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ</value>
        [DataMember(Name="reportCreatedDate", EmitDefaultValue=false)]
        public string ReportCreatedDate { get; set; }

        /// <summary>
        /// Unique identification number assigned to the submitted request.
        /// </summary>
        /// <value>Unique identification number assigned to the submitted request.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE 
        /// </summary>
        /// <value>Valid Values:   * SCHEDULER   * TOKEN_API   * CREDIT_CARD_FILE_UPLOAD   * AMEX_REGSITRY   * AMEX_REGISTRY_API   * AMEX_MAINTENANCE </value>
        [DataMember(Name="batchSource", EmitDefaultValue=false)]
        public string BatchSource { get; set; }

        /// <summary>
        /// Gets or Sets BatchCaEndpoints
        /// </summary>
        [DataMember(Name="batchCaEndpoints", EmitDefaultValue=false)]
        public string BatchCaEndpoints { get; set; }

        /// <summary>
        /// ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        /// <value>ISO-8601 format: yyyy-MM-ddTHH:mm:ssZ</value>
        [DataMember(Name="batchCreatedDate", EmitDefaultValue=false)]
        public string BatchCreatedDate { get; set; }

        /// <summary>
        /// Reference used by merchant to identify batch.
        /// </summary>
        /// <value>Reference used by merchant to identify batch.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets Totals
        /// </summary>
        [DataMember(Name="totals", EmitDefaultValue=false)]
        public InlineResponse2008EmbeddedTotals Totals { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public InlineResponse2009Billing Billing { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<InlineResponse20010Records> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20010 {\n");
            if (Version != null) sb.Append("  Version: ").Append(Version).Append("\n");
            if (ReportCreatedDate != null) sb.Append("  ReportCreatedDate: ").Append(ReportCreatedDate).Append("\n");
            if (BatchId != null) sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            if (BatchSource != null) sb.Append("  BatchSource: ").Append(BatchSource).Append("\n");
            if (BatchCaEndpoints != null) sb.Append("  BatchCaEndpoints: ").Append(BatchCaEndpoints).Append("\n");
            if (BatchCreatedDate != null) sb.Append("  BatchCreatedDate: ").Append(BatchCreatedDate).Append("\n");
            if (MerchantReference != null) sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            if (Totals != null) sb.Append("  Totals: ").Append(Totals).Append("\n");
            if (Billing != null) sb.Append("  Billing: ").Append(Billing).Append("\n");
            if (Records != null) sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(obj as InlineResponse20010);
        }

        /// <summary>
        /// Returns true if InlineResponse20010 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20010 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.ReportCreatedDate == other.ReportCreatedDate ||
                    this.ReportCreatedDate != null &&
                    this.ReportCreatedDate.Equals(other.ReportCreatedDate)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.BatchSource == other.BatchSource ||
                    this.BatchSource != null &&
                    this.BatchSource.Equals(other.BatchSource)
                ) && 
                (
                    this.BatchCaEndpoints == other.BatchCaEndpoints ||
                    this.BatchCaEndpoints != null &&
                    this.BatchCaEndpoints.Equals(other.BatchCaEndpoints)
                ) && 
                (
                    this.BatchCreatedDate == other.BatchCreatedDate ||
                    this.BatchCreatedDate != null &&
                    this.BatchCreatedDate.Equals(other.BatchCreatedDate)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.Totals == other.Totals ||
                    this.Totals != null &&
                    this.Totals.Equals(other.Totals)
                ) && 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
                ) && 
                (
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.ReportCreatedDate != null)
                    hash = hash * 59 + this.ReportCreatedDate.GetHashCode();
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.BatchSource != null)
                    hash = hash * 59 + this.BatchSource.GetHashCode();
                if (this.BatchCaEndpoints != null)
                    hash = hash * 59 + this.BatchCaEndpoints.GetHashCode();
                if (this.BatchCreatedDate != null)
                    hash = hash * 59 + this.BatchCreatedDate.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.Totals != null)
                    hash = hash * 59 + this.Totals.GetHashCode();
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                if (this.Records != null)
                    hash = hash * 59 + this.Records.GetHashCode();
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
