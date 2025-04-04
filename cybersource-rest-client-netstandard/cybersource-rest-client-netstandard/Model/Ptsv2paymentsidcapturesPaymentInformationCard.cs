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
    /// Ptsv2paymentsidcapturesPaymentInformationCard
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesPaymentInformationCard :  IEquatable<Ptsv2paymentsidcapturesPaymentInformationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesPaymentInformationCard" /> class.
        /// </summary>
        /// <param name="SourceAccountType">Flag that specifies the type of account associated with the card.  The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for CyberSource through VisaNet (CtV).  **Note** Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - &#x60;CH&#x60;: Checking account  - &#x60;CR&#x60;: Credit card account  - &#x60;SA&#x60;: Saving account  - &#x60;LI&#x60;: Line of credit or credit portion of combo card  - &#x60;PP&#x60;: Prepaid card account or prepaid portion of combo card  - &#x60;UA&#x60;: Universal account  If useAs is set to credit/debit and there is a value in SourceAccountType, the value in the SourceAccountType field will take precedence. If useAs is set to CR/DB and there is a value in SourceAccountType, the value in the useAs field will take precedence. .</param>
        /// <param name="SourceAccountTypeDetails">Type of account that is being used when the value for the override_payment_method field is line of credit (LI) or prepaid card (PP). Possible values for line of credit: - &#x60;AGRC&#x60;: Visa Agro Custeio - &#x60;AGRE&#x60;: Visa Agro Electron - &#x60;AGRI&#x60;: Visa Agro Investimento - &#x60;AGRO&#x60;: Visa Agro Possible values for prepaid card: - &#x60;VVA&#x60;: Visa Vale Alimentacao - &#x60;VVF&#x60;: Visa Vale Flex - &#x60;VVR&#x60;: Visa Vale Refeicao This field is supported only for combo card transactions in Brazil on CyberSource through VisaNet. .</param>
        public Ptsv2paymentsidcapturesPaymentInformationCard(string SourceAccountType = default(string), string SourceAccountTypeDetails = default(string))
        {
            this.SourceAccountType = SourceAccountType;
            this.SourceAccountTypeDetails = SourceAccountTypeDetails;
        }
        
        /// <summary>
        /// Flag that specifies the type of account associated with the card.  The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for CyberSource through VisaNet (CtV).  **Note** Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - &#x60;CH&#x60;: Checking account  - &#x60;CR&#x60;: Credit card account  - &#x60;SA&#x60;: Saving account  - &#x60;LI&#x60;: Line of credit or credit portion of combo card  - &#x60;PP&#x60;: Prepaid card account or prepaid portion of combo card  - &#x60;UA&#x60;: Universal account  If useAs is set to credit/debit and there is a value in SourceAccountType, the value in the SourceAccountType field will take precedence. If useAs is set to CR/DB and there is a value in SourceAccountType, the value in the useAs field will take precedence. 
        /// </summary>
        /// <value>Flag that specifies the type of account associated with the card.  The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for CyberSource through VisaNet (CtV).  **Note** Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - &#x60;CH&#x60;: Checking account  - &#x60;CR&#x60;: Credit card account  - &#x60;SA&#x60;: Saving account  - &#x60;LI&#x60;: Line of credit or credit portion of combo card  - &#x60;PP&#x60;: Prepaid card account or prepaid portion of combo card  - &#x60;UA&#x60;: Universal account  If useAs is set to credit/debit and there is a value in SourceAccountType, the value in the SourceAccountType field will take precedence. If useAs is set to CR/DB and there is a value in SourceAccountType, the value in the useAs field will take precedence. </value>
        [DataMember(Name="sourceAccountType", EmitDefaultValue=false)]
        public string SourceAccountType { get; set; }

        /// <summary>
        /// Type of account that is being used when the value for the override_payment_method field is line of credit (LI) or prepaid card (PP). Possible values for line of credit: - &#x60;AGRC&#x60;: Visa Agro Custeio - &#x60;AGRE&#x60;: Visa Agro Electron - &#x60;AGRI&#x60;: Visa Agro Investimento - &#x60;AGRO&#x60;: Visa Agro Possible values for prepaid card: - &#x60;VVA&#x60;: Visa Vale Alimentacao - &#x60;VVF&#x60;: Visa Vale Flex - &#x60;VVR&#x60;: Visa Vale Refeicao This field is supported only for combo card transactions in Brazil on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Type of account that is being used when the value for the override_payment_method field is line of credit (LI) or prepaid card (PP). Possible values for line of credit: - &#x60;AGRC&#x60;: Visa Agro Custeio - &#x60;AGRE&#x60;: Visa Agro Electron - &#x60;AGRI&#x60;: Visa Agro Investimento - &#x60;AGRO&#x60;: Visa Agro Possible values for prepaid card: - &#x60;VVA&#x60;: Visa Vale Alimentacao - &#x60;VVF&#x60;: Visa Vale Flex - &#x60;VVR&#x60;: Visa Vale Refeicao This field is supported only for combo card transactions in Brazil on CyberSource through VisaNet. </value>
        [DataMember(Name="sourceAccountTypeDetails", EmitDefaultValue=false)]
        public string SourceAccountTypeDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesPaymentInformationCard {\n");
            if (SourceAccountType != null) sb.Append("  SourceAccountType: ").Append(SourceAccountType).Append("\n");
            if (SourceAccountTypeDetails != null) sb.Append("  SourceAccountTypeDetails: ").Append(SourceAccountTypeDetails).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesPaymentInformationCard);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesPaymentInformationCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesPaymentInformationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesPaymentInformationCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceAccountType == other.SourceAccountType ||
                    this.SourceAccountType != null &&
                    this.SourceAccountType.Equals(other.SourceAccountType)
                ) && 
                (
                    this.SourceAccountTypeDetails == other.SourceAccountTypeDetails ||
                    this.SourceAccountTypeDetails != null &&
                    this.SourceAccountTypeDetails.Equals(other.SourceAccountTypeDetails)
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
                if (this.SourceAccountType != null)
                    hash = hash * 59 + this.SourceAccountType.GetHashCode();
                if (this.SourceAccountTypeDetails != null)
                    hash = hash * 59 + this.SourceAccountTypeDetails.GetHashCode();
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
