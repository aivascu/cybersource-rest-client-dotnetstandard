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
    /// InlineResponse20010ResponseRecord
    /// </summary>
    [DataContract]
    public partial class InlineResponse20010ResponseRecord :  IEquatable<InlineResponse20010ResponseRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010ResponseRecord" /> class.
        /// </summary>
        /// <param name="Response">Valid Values:   * NAN   * NED   * ACL   * CCH   * CUR   * NUP   * UNA   * ERR   * DEC .</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Token">Token.</param>
        /// <param name="InstrumentIdentifierId">InstrumentIdentifierId.</param>
        /// <param name="InstrumentIdentifierCreated">Valid Values:   * true   * false .</param>
        /// <param name="CardNumber">CardNumber.</param>
        /// <param name="CardExpiryMonth">CardExpiryMonth.</param>
        /// <param name="CardExpiryYear">CardExpiryYear.</param>
        /// <param name="CardType">CardType.</param>
        /// <param name="AdditionalUpdates">AdditionalUpdates.</param>
        public InlineResponse20010ResponseRecord(string Response = default(string), string Reason = default(string), string Token = default(string), string InstrumentIdentifierId = default(string), string InstrumentIdentifierCreated = default(string), string CardNumber = default(string), string CardExpiryMonth = default(string), string CardExpiryYear = default(string), string CardType = default(string), List<InlineResponse20010ResponseRecordAdditionalUpdates> AdditionalUpdates = default(List<InlineResponse20010ResponseRecordAdditionalUpdates>))
        {
            this.Response = Response;
            this.Reason = Reason;
            this.Token = Token;
            this.InstrumentIdentifierId = InstrumentIdentifierId;
            this.InstrumentIdentifierCreated = InstrumentIdentifierCreated;
            this.CardNumber = CardNumber;
            this.CardExpiryMonth = CardExpiryMonth;
            this.CardExpiryYear = CardExpiryYear;
            this.CardType = CardType;
            this.AdditionalUpdates = AdditionalUpdates;
        }
        
        /// <summary>
        /// Valid Values:   * NAN   * NED   * ACL   * CCH   * CUR   * NUP   * UNA   * ERR   * DEC 
        /// </summary>
        /// <value>Valid Values:   * NAN   * NED   * ACL   * CCH   * CUR   * NUP   * UNA   * ERR   * DEC </value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifierId
        /// </summary>
        [DataMember(Name="instrumentIdentifierId", EmitDefaultValue=false)]
        public string InstrumentIdentifierId { get; set; }

        /// <summary>
        /// Valid Values:   * true   * false 
        /// </summary>
        /// <value>Valid Values:   * true   * false </value>
        [DataMember(Name="instrumentIdentifierCreated", EmitDefaultValue=false)]
        public string InstrumentIdentifierCreated { get; set; }

        /// <summary>
        /// Gets or Sets CardNumber
        /// </summary>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or Sets CardExpiryMonth
        /// </summary>
        [DataMember(Name="cardExpiryMonth", EmitDefaultValue=false)]
        public string CardExpiryMonth { get; set; }

        /// <summary>
        /// Gets or Sets CardExpiryYear
        /// </summary>
        [DataMember(Name="cardExpiryYear", EmitDefaultValue=false)]
        public string CardExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalUpdates
        /// </summary>
        [DataMember(Name="additionalUpdates", EmitDefaultValue=false)]
        public List<InlineResponse20010ResponseRecordAdditionalUpdates> AdditionalUpdates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20010ResponseRecord {\n");
            if (Response != null) sb.Append("  Response: ").Append(Response).Append("\n");
            if (Reason != null) sb.Append("  Reason: ").Append(Reason).Append("\n");
            if (Token != null) sb.Append("  Token: ").Append(Token).Append("\n");
            if (InstrumentIdentifierId != null) sb.Append("  InstrumentIdentifierId: ").Append(InstrumentIdentifierId).Append("\n");
            if (InstrumentIdentifierCreated != null) sb.Append("  InstrumentIdentifierCreated: ").Append(InstrumentIdentifierCreated).Append("\n");
            if (CardNumber != null) sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            if (CardExpiryMonth != null) sb.Append("  CardExpiryMonth: ").Append(CardExpiryMonth).Append("\n");
            if (CardExpiryYear != null) sb.Append("  CardExpiryYear: ").Append(CardExpiryYear).Append("\n");
            if (CardType != null) sb.Append("  CardType: ").Append(CardType).Append("\n");
            if (AdditionalUpdates != null) sb.Append("  AdditionalUpdates: ").Append(AdditionalUpdates).Append("\n");
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
            return this.Equals(obj as InlineResponse20010ResponseRecord);
        }

        /// <summary>
        /// Returns true if InlineResponse20010ResponseRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20010ResponseRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010ResponseRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.InstrumentIdentifierId == other.InstrumentIdentifierId ||
                    this.InstrumentIdentifierId != null &&
                    this.InstrumentIdentifierId.Equals(other.InstrumentIdentifierId)
                ) && 
                (
                    this.InstrumentIdentifierCreated == other.InstrumentIdentifierCreated ||
                    this.InstrumentIdentifierCreated != null &&
                    this.InstrumentIdentifierCreated.Equals(other.InstrumentIdentifierCreated)
                ) && 
                (
                    this.CardNumber == other.CardNumber ||
                    this.CardNumber != null &&
                    this.CardNumber.Equals(other.CardNumber)
                ) && 
                (
                    this.CardExpiryMonth == other.CardExpiryMonth ||
                    this.CardExpiryMonth != null &&
                    this.CardExpiryMonth.Equals(other.CardExpiryMonth)
                ) && 
                (
                    this.CardExpiryYear == other.CardExpiryYear ||
                    this.CardExpiryYear != null &&
                    this.CardExpiryYear.Equals(other.CardExpiryYear)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) && 
                (
                    this.AdditionalUpdates == other.AdditionalUpdates ||
                    this.AdditionalUpdates != null &&
                    this.AdditionalUpdates.SequenceEqual(other.AdditionalUpdates)
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
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.InstrumentIdentifierId != null)
                    hash = hash * 59 + this.InstrumentIdentifierId.GetHashCode();
                if (this.InstrumentIdentifierCreated != null)
                    hash = hash * 59 + this.InstrumentIdentifierCreated.GetHashCode();
                if (this.CardNumber != null)
                    hash = hash * 59 + this.CardNumber.GetHashCode();
                if (this.CardExpiryMonth != null)
                    hash = hash * 59 + this.CardExpiryMonth.GetHashCode();
                if (this.CardExpiryYear != null)
                    hash = hash * 59 + this.CardExpiryYear.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.AdditionalUpdates != null)
                    hash = hash * 59 + this.AdditionalUpdates.GetHashCode();
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
