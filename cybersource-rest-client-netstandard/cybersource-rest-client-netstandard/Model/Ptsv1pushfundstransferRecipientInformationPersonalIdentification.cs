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
    /// Ptsv1pushfundstransferRecipientInformationPersonalIdentification
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferRecipientInformationPersonalIdentification :  IEquatable<Ptsv1pushfundstransferRecipientInformationPersonalIdentification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferRecipientInformationPersonalIdentification" /> class.
        /// </summary>
        /// <param name="Id">The ID number/value. Processor(35) .</param>
        /// <param name="Type">This tag will contain the type of sender identification. The valid values are: - &#x60;BTHD&#x60;: (Date of birth) - &#x60;CUID&#x60;: (Customer identification (unspecified)) - &#x60;NTID&#x60;: (National identification) - &#x60;PASN&#x60;: (Passport number) - &#x60;DRLN&#x60;: (Driver license) - &#x60;TXIN&#x60;: (Tax identification) - &#x60;CPNY&#x60;: (Company registration number) - &#x60;PRXY&#x60;: (Proxy identification) - &#x60;SSNB&#x60;: (Social security number) - &#x60;ARNB&#x60;: (Alien registration number) - &#x60;LAWE&#x60;: (Law enforcement identification) - &#x60;MILI&#x60;: (Military identification) - &#x60;TRVL&#x60;: (Travel identification (non-passport)) - &#x60;EMAL&#x60;: (Email) - &#x60;PHON&#x60;: (Phone number) .</param>
        /// <param name="IssuingCountry">Issuing country of the identification. The field format should be a 2 character ISO 3166-1 alpha-2 country code. .</param>
        /// <param name="PersonalIdType">This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification).  The valid values are:  - &#x60;B&#x60; (Business) - &#x60;I&#x60; (Individual) .</param>
        public Ptsv1pushfundstransferRecipientInformationPersonalIdentification(string Id = default(string), string Type = default(string), string IssuingCountry = default(string), string PersonalIdType = default(string))
        {
            this.Id = Id;
            this.Type = Type;
            this.IssuingCountry = IssuingCountry;
            this.PersonalIdType = PersonalIdType;
        }
        
        /// <summary>
        /// The ID number/value. Processor(35) 
        /// </summary>
        /// <value>The ID number/value. Processor(35) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// This tag will contain the type of sender identification. The valid values are: - &#x60;BTHD&#x60;: (Date of birth) - &#x60;CUID&#x60;: (Customer identification (unspecified)) - &#x60;NTID&#x60;: (National identification) - &#x60;PASN&#x60;: (Passport number) - &#x60;DRLN&#x60;: (Driver license) - &#x60;TXIN&#x60;: (Tax identification) - &#x60;CPNY&#x60;: (Company registration number) - &#x60;PRXY&#x60;: (Proxy identification) - &#x60;SSNB&#x60;: (Social security number) - &#x60;ARNB&#x60;: (Alien registration number) - &#x60;LAWE&#x60;: (Law enforcement identification) - &#x60;MILI&#x60;: (Military identification) - &#x60;TRVL&#x60;: (Travel identification (non-passport)) - &#x60;EMAL&#x60;: (Email) - &#x60;PHON&#x60;: (Phone number) 
        /// </summary>
        /// <value>This tag will contain the type of sender identification. The valid values are: - &#x60;BTHD&#x60;: (Date of birth) - &#x60;CUID&#x60;: (Customer identification (unspecified)) - &#x60;NTID&#x60;: (National identification) - &#x60;PASN&#x60;: (Passport number) - &#x60;DRLN&#x60;: (Driver license) - &#x60;TXIN&#x60;: (Tax identification) - &#x60;CPNY&#x60;: (Company registration number) - &#x60;PRXY&#x60;: (Proxy identification) - &#x60;SSNB&#x60;: (Social security number) - &#x60;ARNB&#x60;: (Alien registration number) - &#x60;LAWE&#x60;: (Law enforcement identification) - &#x60;MILI&#x60;: (Military identification) - &#x60;TRVL&#x60;: (Travel identification (non-passport)) - &#x60;EMAL&#x60;: (Email) - &#x60;PHON&#x60;: (Phone number) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Issuing country of the identification. The field format should be a 2 character ISO 3166-1 alpha-2 country code. 
        /// </summary>
        /// <value>Issuing country of the identification. The field format should be a 2 character ISO 3166-1 alpha-2 country code. </value>
        [DataMember(Name="issuingCountry", EmitDefaultValue=false)]
        public string IssuingCountry { get; set; }

        /// <summary>
        /// This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification).  The valid values are:  - &#x60;B&#x60; (Business) - &#x60;I&#x60; (Individual) 
        /// </summary>
        /// <value>This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification).  The valid values are:  - &#x60;B&#x60; (Business) - &#x60;I&#x60; (Individual) </value>
        [DataMember(Name="personalIdType", EmitDefaultValue=false)]
        public string PersonalIdType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferRecipientInformationPersonalIdentification {\n");
            if (Id != null) sb.Append("  Id: ").Append(Id).Append("\n");
            if (Type != null) sb.Append("  Type: ").Append(Type).Append("\n");
            if (IssuingCountry != null) sb.Append("  IssuingCountry: ").Append(IssuingCountry).Append("\n");
            if (PersonalIdType != null) sb.Append("  PersonalIdType: ").Append(PersonalIdType).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferRecipientInformationPersonalIdentification);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferRecipientInformationPersonalIdentification instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferRecipientInformationPersonalIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferRecipientInformationPersonalIdentification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IssuingCountry == other.IssuingCountry ||
                    this.IssuingCountry != null &&
                    this.IssuingCountry.Equals(other.IssuingCountry)
                ) && 
                (
                    this.PersonalIdType == other.PersonalIdType ||
                    this.PersonalIdType != null &&
                    this.PersonalIdType.Equals(other.PersonalIdType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.IssuingCountry != null)
                    hash = hash * 59 + this.IssuingCountry.GetHashCode();
                if (this.PersonalIdType != null)
                    hash = hash * 59 + this.PersonalIdType.GetHashCode();
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
