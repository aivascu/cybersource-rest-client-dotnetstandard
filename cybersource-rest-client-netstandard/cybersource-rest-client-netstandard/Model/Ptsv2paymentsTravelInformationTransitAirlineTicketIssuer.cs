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
    /// Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer :  IEquatable<Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer" /> class.
        /// </summary>
        /// <param name="Code">IATA2 airline code. Format: English characters only. Required for Mastercard; optional for all other card types. .</param>
        /// <param name="Name">Name of the ticket issuer. If you do not include this field, CyberSource uses the value for your merchant name that is in the CyberSource merchant configuration database. .</param>
        /// <param name="Address">Address of the company issuing the ticket. .</param>
        /// <param name="Locality">City in which the transaction occurred. If the name of the city exceeds 18 characters, use meaningful abbreviations. Format: English characters only. Optional request field. .</param>
        /// <param name="AdministrativeArea">State in which transaction occured. .</param>
        /// <param name="PostalCode">Zip code of the city in which transaction occured. .</param>
        /// <param name="Country">Country in which transaction occured. .</param>
        public Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer(string Code = default(string), string Name = default(string), string Address = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string))
        {
            this.Code = Code;
            this.Name = Name;
            this.Address = Address;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
        }
        
        /// <summary>
        /// IATA2 airline code. Format: English characters only. Required for Mastercard; optional for all other card types. 
        /// </summary>
        /// <value>IATA2 airline code. Format: English characters only. Required for Mastercard; optional for all other card types. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Name of the ticket issuer. If you do not include this field, CyberSource uses the value for your merchant name that is in the CyberSource merchant configuration database. 
        /// </summary>
        /// <value>Name of the ticket issuer. If you do not include this field, CyberSource uses the value for your merchant name that is in the CyberSource merchant configuration database. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Address of the company issuing the ticket. 
        /// </summary>
        /// <value>Address of the company issuing the ticket. </value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// City in which the transaction occurred. If the name of the city exceeds 18 characters, use meaningful abbreviations. Format: English characters only. Optional request field. 
        /// </summary>
        /// <value>City in which the transaction occurred. If the name of the city exceeds 18 characters, use meaningful abbreviations. Format: English characters only. Optional request field. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// State in which transaction occured. 
        /// </summary>
        /// <value>State in which transaction occured. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Zip code of the city in which transaction occured. 
        /// </summary>
        /// <value>Zip code of the city in which transaction occured. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country in which transaction occured. 
        /// </summary>
        /// <value>Country in which transaction occured. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer {\n");
            if (Code != null) sb.Append("  Code: ").Append(Code).Append("\n");
            if (Name != null) sb.Append("  Name: ").Append(Name).Append("\n");
            if (Address != null) sb.Append("  Address: ").Append(Address).Append("\n");
            if (Locality != null) sb.Append("  Locality: ").Append(Locality).Append("\n");
            if (AdministrativeArea != null) sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            if (PostalCode != null) sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            if (Country != null) sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsTravelInformationTransitAirlineTicketIssuer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
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
