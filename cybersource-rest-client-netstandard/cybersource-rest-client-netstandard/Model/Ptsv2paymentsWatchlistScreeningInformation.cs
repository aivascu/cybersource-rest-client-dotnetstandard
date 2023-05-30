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
    /// Ptsv2paymentsWatchlistScreeningInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsWatchlistScreeningInformation :  IEquatable<Ptsv2paymentsWatchlistScreeningInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsWatchlistScreeningInformation" /> class.
        /// </summary>
        /// <param name="AddressOperator">Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. .</param>
        /// <param name="Weights">Weights.</param>
        /// <param name="SanctionLists">Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. .</param>
        /// <param name="ProceedOnMatch">Indicates whether the transaction should proceed if there is a match. Possible values: - &#x60;true&#x60;: Transaction proceeds even when match is found in the Denied Parties List. The match is noted in the response. - &#x60;false&#x60;: Normal watchlist screening behavior occurs. (Transaction stops if a match to DPL occurs. Transaction proceeds if no match.) .</param>
        public Ptsv2paymentsWatchlistScreeningInformation(string AddressOperator = default(string), Ptsv2paymentsWatchlistScreeningInformationWeights Weights = default(Ptsv2paymentsWatchlistScreeningInformationWeights), List<string> SanctionLists = default(List<string>), bool? ProceedOnMatch = default(bool?))
        {
            this.AddressOperator = AddressOperator;
            this.Weights = Weights;
            this.SanctionLists = SanctionLists;
            this.ProceedOnMatch = ProceedOnMatch;
        }
        
        /// <summary>
        /// Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. 
        /// </summary>
        /// <value>Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. </value>
        [DataMember(Name="addressOperator", EmitDefaultValue=false)]
        public string AddressOperator { get; set; }

        /// <summary>
        /// Gets or Sets Weights
        /// </summary>
        [DataMember(Name="weights", EmitDefaultValue=false)]
        public Ptsv2paymentsWatchlistScreeningInformationWeights Weights { get; set; }

        /// <summary>
        /// Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. 
        /// </summary>
        /// <value>Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. </value>
        [DataMember(Name="sanctionLists", EmitDefaultValue=false)]
        public List<string> SanctionLists { get; set; }

        /// <summary>
        /// Indicates whether the transaction should proceed if there is a match. Possible values: - &#x60;true&#x60;: Transaction proceeds even when match is found in the Denied Parties List. The match is noted in the response. - &#x60;false&#x60;: Normal watchlist screening behavior occurs. (Transaction stops if a match to DPL occurs. Transaction proceeds if no match.) 
        /// </summary>
        /// <value>Indicates whether the transaction should proceed if there is a match. Possible values: - &#x60;true&#x60;: Transaction proceeds even when match is found in the Denied Parties List. The match is noted in the response. - &#x60;false&#x60;: Normal watchlist screening behavior occurs. (Transaction stops if a match to DPL occurs. Transaction proceeds if no match.) </value>
        [DataMember(Name="proceedOnMatch", EmitDefaultValue=false)]
        public bool? ProceedOnMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsWatchlistScreeningInformation {\n");
            sb.Append("  AddressOperator: ").Append(AddressOperator).Append("\n");
            sb.Append("  Weights: ").Append(Weights).Append("\n");
            sb.Append("  SanctionLists: ").Append(SanctionLists).Append("\n");
            sb.Append("  ProceedOnMatch: ").Append(ProceedOnMatch).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsWatchlistScreeningInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsWatchlistScreeningInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsWatchlistScreeningInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsWatchlistScreeningInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressOperator == other.AddressOperator ||
                    this.AddressOperator != null &&
                    this.AddressOperator.Equals(other.AddressOperator)
                ) && 
                (
                    this.Weights == other.Weights ||
                    this.Weights != null &&
                    this.Weights.Equals(other.Weights)
                ) && 
                (
                    this.SanctionLists == other.SanctionLists ||
                    this.SanctionLists != null &&
                    this.SanctionLists.SequenceEqual(other.SanctionLists)
                ) && 
                (
                    this.ProceedOnMatch == other.ProceedOnMatch ||
                    this.ProceedOnMatch != null &&
                    this.ProceedOnMatch.Equals(other.ProceedOnMatch)
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
                if (this.AddressOperator != null)
                    hash = hash * 59 + this.AddressOperator.GetHashCode();
                if (this.Weights != null)
                    hash = hash * 59 + this.Weights.GetHashCode();
                if (this.SanctionLists != null)
                    hash = hash * 59 + this.SanctionLists.GetHashCode();
                if (this.ProceedOnMatch != null)
                    hash = hash * 59 + this.ProceedOnMatch.GetHashCode();
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