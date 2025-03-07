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
    /// Details for marking the transaction as either positive or negative.
    /// </summary>
    [DataContract]
    public partial class Riskv1liststypeentriesRiskInformationMarkingDetails :  IEquatable<Riskv1liststypeentriesRiskInformationMarkingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1liststypeentriesRiskInformationMarkingDetails" /> class.
        /// </summary>
        /// <param name="Notes">Notes or details that explain the reasons for adding the transaction to either the positive or negative list..</param>
        /// <param name="Reason">Reason for adding the transaction to the negative list. This field can contain one of the following values: - &#x60;fraud_chargeback:&#x60; You have received a fraud-related chargeback for the transaction. - &#x60;non_fraud_chargeback:&#x60; You have received a non-fraudulent chargeback for the transaction. - &#x60;suspected:&#x60; You believe that you will probably receive a chargeback for the transaction. - &#x60;creditback:&#x60; You issued a refund to the customer to avoid a chargeback for the transaction. .</param>
        /// <param name="RecordName">Name of the customer&#39;s record entered in the list. For the positive list, it is required if &#x60;action_ code&#x60;&#x3D;&#x60;add_positive&#x60;. If absent from the request, &#x60;ics_risk_update&#x60; creates the value for this field by concatenating the customer&#39;s first and last names. For the negative and the review lists, &#x60;record_name&#x60;, &#x60;customer_firstname&#x60;, and &#x60;customer_lastname&#x60; are optional. .</param>
        /// <param name="Action">Indicates whether to add to or remove a customer&#39;s identity from the negative or positive list. This field can contain one of the following values: - add: Add information to the list. - convert: moves the data. - delete: deletes the data from the list. .</param>
        public Riskv1liststypeentriesRiskInformationMarkingDetails(string Notes = default(string), string Reason = default(string), string RecordName = default(string), string Action = default(string))
        {
            this.Notes = Notes;
            this.Reason = Reason;
            this.RecordName = RecordName;
            this.Action = Action;
        }
        
        /// <summary>
        /// Notes or details that explain the reasons for adding the transaction to either the positive or negative list.
        /// </summary>
        /// <value>Notes or details that explain the reasons for adding the transaction to either the positive or negative list.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Reason for adding the transaction to the negative list. This field can contain one of the following values: - &#x60;fraud_chargeback:&#x60; You have received a fraud-related chargeback for the transaction. - &#x60;non_fraud_chargeback:&#x60; You have received a non-fraudulent chargeback for the transaction. - &#x60;suspected:&#x60; You believe that you will probably receive a chargeback for the transaction. - &#x60;creditback:&#x60; You issued a refund to the customer to avoid a chargeback for the transaction. 
        /// </summary>
        /// <value>Reason for adding the transaction to the negative list. This field can contain one of the following values: - &#x60;fraud_chargeback:&#x60; You have received a fraud-related chargeback for the transaction. - &#x60;non_fraud_chargeback:&#x60; You have received a non-fraudulent chargeback for the transaction. - &#x60;suspected:&#x60; You believe that you will probably receive a chargeback for the transaction. - &#x60;creditback:&#x60; You issued a refund to the customer to avoid a chargeback for the transaction. </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Name of the customer&#39;s record entered in the list. For the positive list, it is required if &#x60;action_ code&#x60;&#x3D;&#x60;add_positive&#x60;. If absent from the request, &#x60;ics_risk_update&#x60; creates the value for this field by concatenating the customer&#39;s first and last names. For the negative and the review lists, &#x60;record_name&#x60;, &#x60;customer_firstname&#x60;, and &#x60;customer_lastname&#x60; are optional. 
        /// </summary>
        /// <value>Name of the customer&#39;s record entered in the list. For the positive list, it is required if &#x60;action_ code&#x60;&#x3D;&#x60;add_positive&#x60;. If absent from the request, &#x60;ics_risk_update&#x60; creates the value for this field by concatenating the customer&#39;s first and last names. For the negative and the review lists, &#x60;record_name&#x60;, &#x60;customer_firstname&#x60;, and &#x60;customer_lastname&#x60; are optional. </value>
        [DataMember(Name="recordName", EmitDefaultValue=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// Indicates whether to add to or remove a customer&#39;s identity from the negative or positive list. This field can contain one of the following values: - add: Add information to the list. - convert: moves the data. - delete: deletes the data from the list. 
        /// </summary>
        /// <value>Indicates whether to add to or remove a customer&#39;s identity from the negative or positive list. This field can contain one of the following values: - add: Add information to the list. - convert: moves the data. - delete: deletes the data from the list. </value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1liststypeentriesRiskInformationMarkingDetails {\n");
            if (Notes != null) sb.Append("  Notes: ").Append(Notes).Append("\n");
            if (Reason != null) sb.Append("  Reason: ").Append(Reason).Append("\n");
            if (RecordName != null) sb.Append("  RecordName: ").Append(RecordName).Append("\n");
            if (Action != null) sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as Riskv1liststypeentriesRiskInformationMarkingDetails);
        }

        /// <summary>
        /// Returns true if Riskv1liststypeentriesRiskInformationMarkingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1liststypeentriesRiskInformationMarkingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1liststypeentriesRiskInformationMarkingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.RecordName == other.RecordName ||
                    this.RecordName != null &&
                    this.RecordName.Equals(other.RecordName)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.RecordName != null)
                    hash = hash * 59 + this.RecordName.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
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
