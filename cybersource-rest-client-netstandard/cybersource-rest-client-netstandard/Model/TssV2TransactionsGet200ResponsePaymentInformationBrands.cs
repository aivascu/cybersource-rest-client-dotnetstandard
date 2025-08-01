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
    /// TssV2TransactionsGet200ResponsePaymentInformationBrands
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationBrands :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationBrands>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationBrands" /> class.
        /// </summary>
        /// <param name="Type">Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;008&#x60;: Optima - &#x60;009&#x60;: GE Private Label - &#x60;010&#x60;: Beneficial Private Label - &#x60;011&#x60;: Twinpay Credit Card - &#x60;012&#x60;: Twinpay Debit Card - &#x60;013&#x60;: WalMart - &#x60;014&#x60;: Enroute[^1] - &#x60;015&#x60;: Lowe&#39;s Consumer - &#x60;016&#x60;: Home Depot Consumer - &#x60;017&#x60;: MBNA - &#x60;018&#x60;: Dick&#39;s Sportswear - &#x60;019&#x60;: Casual Corner - &#x60;020&#x60;: Sears - &#x60;021&#x60;: JAL[^1] - &#x60;023&#x60;: Disney Card - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;025&#x60;: Sam&#39;s Club Consumer - &#x60;026&#x60;: Sam&#39;s Club Business - &#x60;027&#x60;: Nico&#39;s - &#x60;028&#x60;: Paymentech Bill Me Later - &#x60;029&#x60;: Bebe - &#x60;030&#x60;: Restoration Hardware - &#x60;031&#x60;: Delta Online - &#x60;032&#x60;: Solo - &#x60;033&#x60;: Visa Electron[^1]. Do not use this value. Use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;035&#x60;: Laser - &#x60;036&#x60;: Cartes Bancaires[^1,4] - &#x60;037&#x60;: Carta Si[^1] - &#x60;038&#x60;: Pinless Debit - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;041&#x60;: HOUSEHOLD - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;043&#x60;: GE MONEY - &#x60;044&#x60;: Korean Cards - &#x60;045&#x60;: Style Cards - &#x60;046&#x60;: JCrew - &#x60;047&#x60;: Payeasecn eWallet - &#x60;048&#x60;: Payeasecn Bank Transfer - &#x60;049&#x60;: Meijer - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;052&#x60;: Redecard - &#x60;053&#x60;: Orico card - &#x60;054&#x60;: Elo[^3] - &#x60;055&#x60;: Capitol One Private Label - &#x60;056&#x60;: Carnet - &#x60;057&#x60;: Costco Private Label - &#x60;058&#x60;: Carnet - &#x60;059&#x60;: ValueLink - &#x60;060&#x60;: MADA - &#x60;061&#x60;: RuPay - &#x60;062&#x60;: China UnionPay - &#x60;063&#x60;: Falabella Private Label - &#x60;064&#x60;: Prompt Card - &#x60;065&#x60;: Korean Domestic - &#x60;066&#x60;: Banricompras - &#x60;067&#x60;: MEEZA - &#x60;068&#x60;: PayPak - &#x60;070&#x60;: EFTPOS - &#x60;071&#x60;: Codensa - &#x60;072&#x60;: Olimpica - &#x60;073&#x60;: Colsubsidio - &#x60;074&#x60;: Tuya - &#x60;075&#x60;: Sodexo - &#x60;076&#x60;: Naranja - &#x60;077&#x60;: Cabal - &#x60;078&#x60;: DINELCO - &#x60;079&#x60;: PANAL - &#x60;080&#x60;: EPM - &#x60;081&#x60;: Jaywan  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. [^4]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; in your request for any payer authentication services.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### Google Pay transactions For PAN-based Google Pay transactions, this field is returned in the API response.  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International .</param>
        /// <param name="BrandName">This field contains the card brand name.   Some of the possible values (not an exhaustive list) are -    - VISA   - MASTERCARD   - AMERICAN EXPRESS   - DISCOVER   - DINERS CLUB   - CARTE BLANCHE   - JCB   - OPTIMA   - TWINPAY CREDIT CARD   - TWINPAY DEBIT CARD   - WALMART   - ENROUTE   - LOWES CONSUMER   - HOME DEPOT CONSUMER   - MBNA   - DICKS SPORTWEAR   - CASUAL CORNER   - SEARS   - JAL   - DISNEY CARD   - SWITCH/SOLO   - SAMS CLUB CONSUMER   - SAMS CLUB BUSINESS   - NICOS HOUSE CARD   - BEBE   - RESTORATION HARDWARE   - DELTA ONLINE   - SOLO   - VISA ELECTRON   - DANKORT   - LASER   - CARTE BANCAIRE   - CARTA SI   - ENCODED ACCOUNT   - UATP   - HOUSEHOLD   - MAESTRO   - GE CAPITAL   - KOREAN CARDS   - STYLE CARDS   - JCREW   - MEIJER   - HIPERCARD   - AURA   - REDECARD   - ORICO HOUSE CARD   - ELO   - CAPITAL ONE PRIVATE LABEL   - CARNET   - RUPAY   - CHINA UNION PAY   - FALABELLA PRIVATE LABEL   - PROMPTCARD   - KOREAN DOMESTIC   - BANRICOMPRAS .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationBrands(string Type = default(string), string BrandName = default(string))
        {
            this.Type = Type;
            this.BrandName = BrandName;
        }
        
        /// <summary>
        /// Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;008&#x60;: Optima - &#x60;009&#x60;: GE Private Label - &#x60;010&#x60;: Beneficial Private Label - &#x60;011&#x60;: Twinpay Credit Card - &#x60;012&#x60;: Twinpay Debit Card - &#x60;013&#x60;: WalMart - &#x60;014&#x60;: Enroute[^1] - &#x60;015&#x60;: Lowe&#39;s Consumer - &#x60;016&#x60;: Home Depot Consumer - &#x60;017&#x60;: MBNA - &#x60;018&#x60;: Dick&#39;s Sportswear - &#x60;019&#x60;: Casual Corner - &#x60;020&#x60;: Sears - &#x60;021&#x60;: JAL[^1] - &#x60;023&#x60;: Disney Card - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;025&#x60;: Sam&#39;s Club Consumer - &#x60;026&#x60;: Sam&#39;s Club Business - &#x60;027&#x60;: Nico&#39;s - &#x60;028&#x60;: Paymentech Bill Me Later - &#x60;029&#x60;: Bebe - &#x60;030&#x60;: Restoration Hardware - &#x60;031&#x60;: Delta Online - &#x60;032&#x60;: Solo - &#x60;033&#x60;: Visa Electron[^1]. Do not use this value. Use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;035&#x60;: Laser - &#x60;036&#x60;: Cartes Bancaires[^1,4] - &#x60;037&#x60;: Carta Si[^1] - &#x60;038&#x60;: Pinless Debit - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;041&#x60;: HOUSEHOLD - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;043&#x60;: GE MONEY - &#x60;044&#x60;: Korean Cards - &#x60;045&#x60;: Style Cards - &#x60;046&#x60;: JCrew - &#x60;047&#x60;: Payeasecn eWallet - &#x60;048&#x60;: Payeasecn Bank Transfer - &#x60;049&#x60;: Meijer - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;052&#x60;: Redecard - &#x60;053&#x60;: Orico card - &#x60;054&#x60;: Elo[^3] - &#x60;055&#x60;: Capitol One Private Label - &#x60;056&#x60;: Carnet - &#x60;057&#x60;: Costco Private Label - &#x60;058&#x60;: Carnet - &#x60;059&#x60;: ValueLink - &#x60;060&#x60;: MADA - &#x60;061&#x60;: RuPay - &#x60;062&#x60;: China UnionPay - &#x60;063&#x60;: Falabella Private Label - &#x60;064&#x60;: Prompt Card - &#x60;065&#x60;: Korean Domestic - &#x60;066&#x60;: Banricompras - &#x60;067&#x60;: MEEZA - &#x60;068&#x60;: PayPak - &#x60;070&#x60;: EFTPOS - &#x60;071&#x60;: Codensa - &#x60;072&#x60;: Olimpica - &#x60;073&#x60;: Colsubsidio - &#x60;074&#x60;: Tuya - &#x60;075&#x60;: Sodexo - &#x60;076&#x60;: Naranja - &#x60;077&#x60;: Cabal - &#x60;078&#x60;: DINELCO - &#x60;079&#x60;: PANAL - &#x60;080&#x60;: EPM - &#x60;081&#x60;: Jaywan  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. [^4]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; in your request for any payer authentication services.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### Google Pay transactions For PAN-based Google Pay transactions, this field is returned in the API response.  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International 
        /// </summary>
        /// <value>Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;008&#x60;: Optima - &#x60;009&#x60;: GE Private Label - &#x60;010&#x60;: Beneficial Private Label - &#x60;011&#x60;: Twinpay Credit Card - &#x60;012&#x60;: Twinpay Debit Card - &#x60;013&#x60;: WalMart - &#x60;014&#x60;: Enroute[^1] - &#x60;015&#x60;: Lowe&#39;s Consumer - &#x60;016&#x60;: Home Depot Consumer - &#x60;017&#x60;: MBNA - &#x60;018&#x60;: Dick&#39;s Sportswear - &#x60;019&#x60;: Casual Corner - &#x60;020&#x60;: Sears - &#x60;021&#x60;: JAL[^1] - &#x60;023&#x60;: Disney Card - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;025&#x60;: Sam&#39;s Club Consumer - &#x60;026&#x60;: Sam&#39;s Club Business - &#x60;027&#x60;: Nico&#39;s - &#x60;028&#x60;: Paymentech Bill Me Later - &#x60;029&#x60;: Bebe - &#x60;030&#x60;: Restoration Hardware - &#x60;031&#x60;: Delta Online - &#x60;032&#x60;: Solo - &#x60;033&#x60;: Visa Electron[^1]. Do not use this value. Use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;035&#x60;: Laser - &#x60;036&#x60;: Cartes Bancaires[^1,4] - &#x60;037&#x60;: Carta Si[^1] - &#x60;038&#x60;: Pinless Debit - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;041&#x60;: HOUSEHOLD - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;043&#x60;: GE MONEY - &#x60;044&#x60;: Korean Cards - &#x60;045&#x60;: Style Cards - &#x60;046&#x60;: JCrew - &#x60;047&#x60;: Payeasecn eWallet - &#x60;048&#x60;: Payeasecn Bank Transfer - &#x60;049&#x60;: Meijer - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;052&#x60;: Redecard - &#x60;053&#x60;: Orico card - &#x60;054&#x60;: Elo[^3] - &#x60;055&#x60;: Capitol One Private Label - &#x60;056&#x60;: Carnet - &#x60;057&#x60;: Costco Private Label - &#x60;058&#x60;: Carnet - &#x60;059&#x60;: ValueLink - &#x60;060&#x60;: MADA - &#x60;061&#x60;: RuPay - &#x60;062&#x60;: China UnionPay - &#x60;063&#x60;: Falabella Private Label - &#x60;064&#x60;: Prompt Card - &#x60;065&#x60;: Korean Domestic - &#x60;066&#x60;: Banricompras - &#x60;067&#x60;: MEEZA - &#x60;068&#x60;: PayPak - &#x60;070&#x60;: EFTPOS - &#x60;071&#x60;: Codensa - &#x60;072&#x60;: Olimpica - &#x60;073&#x60;: Colsubsidio - &#x60;074&#x60;: Tuya - &#x60;075&#x60;: Sodexo - &#x60;076&#x60;: Naranja - &#x60;077&#x60;: Cabal - &#x60;078&#x60;: DINELCO - &#x60;079&#x60;: PANAL - &#x60;080&#x60;: EPM - &#x60;081&#x60;: Jaywan  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. [^4]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; in your request for any payer authentication services.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### Google Pay transactions For PAN-based Google Pay transactions, this field is returned in the API response.  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// This field contains the card brand name.   Some of the possible values (not an exhaustive list) are -    - VISA   - MASTERCARD   - AMERICAN EXPRESS   - DISCOVER   - DINERS CLUB   - CARTE BLANCHE   - JCB   - OPTIMA   - TWINPAY CREDIT CARD   - TWINPAY DEBIT CARD   - WALMART   - ENROUTE   - LOWES CONSUMER   - HOME DEPOT CONSUMER   - MBNA   - DICKS SPORTWEAR   - CASUAL CORNER   - SEARS   - JAL   - DISNEY CARD   - SWITCH/SOLO   - SAMS CLUB CONSUMER   - SAMS CLUB BUSINESS   - NICOS HOUSE CARD   - BEBE   - RESTORATION HARDWARE   - DELTA ONLINE   - SOLO   - VISA ELECTRON   - DANKORT   - LASER   - CARTE BANCAIRE   - CARTA SI   - ENCODED ACCOUNT   - UATP   - HOUSEHOLD   - MAESTRO   - GE CAPITAL   - KOREAN CARDS   - STYLE CARDS   - JCREW   - MEIJER   - HIPERCARD   - AURA   - REDECARD   - ORICO HOUSE CARD   - ELO   - CAPITAL ONE PRIVATE LABEL   - CARNET   - RUPAY   - CHINA UNION PAY   - FALABELLA PRIVATE LABEL   - PROMPTCARD   - KOREAN DOMESTIC   - BANRICOMPRAS 
        /// </summary>
        /// <value>This field contains the card brand name.   Some of the possible values (not an exhaustive list) are -    - VISA   - MASTERCARD   - AMERICAN EXPRESS   - DISCOVER   - DINERS CLUB   - CARTE BLANCHE   - JCB   - OPTIMA   - TWINPAY CREDIT CARD   - TWINPAY DEBIT CARD   - WALMART   - ENROUTE   - LOWES CONSUMER   - HOME DEPOT CONSUMER   - MBNA   - DICKS SPORTWEAR   - CASUAL CORNER   - SEARS   - JAL   - DISNEY CARD   - SWITCH/SOLO   - SAMS CLUB CONSUMER   - SAMS CLUB BUSINESS   - NICOS HOUSE CARD   - BEBE   - RESTORATION HARDWARE   - DELTA ONLINE   - SOLO   - VISA ELECTRON   - DANKORT   - LASER   - CARTE BANCAIRE   - CARTA SI   - ENCODED ACCOUNT   - UATP   - HOUSEHOLD   - MAESTRO   - GE CAPITAL   - KOREAN CARDS   - STYLE CARDS   - JCREW   - MEIJER   - HIPERCARD   - AURA   - REDECARD   - ORICO HOUSE CARD   - ELO   - CAPITAL ONE PRIVATE LABEL   - CARNET   - RUPAY   - CHINA UNION PAY   - FALABELLA PRIVATE LABEL   - PROMPTCARD   - KOREAN DOMESTIC   - BANRICOMPRAS </value>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationBrands {\n");
            if (Type != null) sb.Append("  Type: ").Append(Type).Append("\n");
            if (BrandName != null) sb.Append("  BrandName: ").Append(BrandName).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationBrands);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationBrands instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationBrands to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationBrands other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.BrandName == other.BrandName ||
                    this.BrandName != null &&
                    this.BrandName.Equals(other.BrandName)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.BrandName != null)
                    hash = hash * 59 + this.BrandName.GetHashCode();
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
