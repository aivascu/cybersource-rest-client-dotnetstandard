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
    /// PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor
    /// </summary>
    [DataContract]
    public partial class PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor :  IEquatable<PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor" /> class.
        /// </summary>
        /// <param name="Name">Your merchant name.  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22.  #### PIN debit Your business name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests.  #### Airline processing Your merchant name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  **Note** Some airline fee programs may require the original ticket number (ticket identifier) or the ancillary service description in positions 13 through 23 of this field.  **Important** This value must consist of English characters.  Required for captures and credits. .</param>
        /// <param name="Locality">Merchant&#39;s City.  #### PIN debit City for your business location. This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests. .</param>
        /// <param name="Country">Merchant&#39;s country.  #### PIN debit Country code for your business location. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters. **Note** If your business is located in the U.S. or Canada and you include this field in a request, you must also include &#x60;merchantInformation.merchantDescriptor.administrativeArea&#x60;.  Optional field for PIN debit credit or PIN debit purchase. .</param>
        public PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor(string Name = default(string), string Locality = default(string), string Country = default(string))
        {
            this.Name = Name;
            this.Locality = Locality;
            this.Country = Country;
        }
        
        /// <summary>
        /// Your merchant name.  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22.  #### PIN debit Your business name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests.  #### Airline processing Your merchant name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  **Note** Some airline fee programs may require the original ticket number (ticket identifier) or the ancillary service description in positions 13 through 23 of this field.  **Important** This value must consist of English characters.  Required for captures and credits. 
        /// </summary>
        /// <value>Your merchant name.  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22.  #### PIN debit Your business name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests.  #### Airline processing Your merchant name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.  **Note** Some airline fee programs may require the original ticket number (ticket identifier) or the ancillary service description in positions 13 through 23 of this field.  **Important** This value must consist of English characters.  Required for captures and credits. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Merchant&#39;s City.  #### PIN debit City for your business location. This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests. 
        /// </summary>
        /// <value>Merchant&#39;s City.  #### PIN debit City for your business location. This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.  Optional field for PIN debit credit or PIN debit purchase requests. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Merchant&#39;s country.  #### PIN debit Country code for your business location. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters. **Note** If your business is located in the U.S. or Canada and you include this field in a request, you must also include &#x60;merchantInformation.merchantDescriptor.administrativeArea&#x60;.  Optional field for PIN debit credit or PIN debit purchase. 
        /// </summary>
        /// <value>Merchant&#39;s country.  #### PIN debit Country code for your business location. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) This value might be displayed on the cardholder&#39;s statement.  When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters. **Note** If your business is located in the U.S. or Canada and you include this field in a request, you must also include &#x60;merchantInformation.merchantDescriptor.administrativeArea&#x60;.  Optional field for PIN debit credit or PIN debit purchase. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor {\n");
            if (Name != null) sb.Append("  Name: ").Append(Name).Append("\n");
            if (Locality != null) sb.Append("  Locality: ").Append(Locality).Append("\n");
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
            return this.Equals(obj as PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor);
        }

        /// <summary>
        /// Returns true if PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
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
