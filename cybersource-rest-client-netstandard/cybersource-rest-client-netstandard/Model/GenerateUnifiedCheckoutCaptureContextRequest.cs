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
    /// GenerateUnifiedCheckoutCaptureContextRequest
    /// </summary>
    [DataContract]
    public partial class GenerateUnifiedCheckoutCaptureContextRequest :  IEquatable<GenerateUnifiedCheckoutCaptureContextRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateUnifiedCheckoutCaptureContextRequest" /> class.
        /// </summary>
        /// <param name="ClientVersion">Specify the version of Unified Checkout that you want to use..</param>
        /// <param name="TargetOrigins">The [target origin](https://developer.mozilla.org/en-US/docs/Glossary/Origin) of the website on which you will be launching Unified Checkout is defined by the scheme (protocol), hostname (domain) and port number (if used).    You must use https://hostname (unless you use http://localhost) Wildcards are NOT supported.  Ensure that subdomains are included. Any valid top-level domain is supported (e.g. .com, .co.uk, .gov.br etc)  Examples:   - https://example.com   - https://subdomain.example.com   - https://example.com:8080&lt;br&gt;&lt;br&gt;  If you are embedding within multiple nested iframes you need to specify the origins of all the browser contexts used, for example:    targetOrigins: [     \&quot;https://example.com\&quot;,     \&quot;https://basket.example.com\&quot;,     \&quot;https://ecom.example.com\&quot;   ] .</param>
        /// <param name="AllowedCardNetworks">The list of card networks you want to use for this Unified Checkout transaction.  Unified Checkout currently supports the following card networks:     - VISA     - MASTERCARD     - AMEX     - CARNET     - CARTESBANCAIRES     - CUP     - DINERSCLUB     - DISCOVER     - EFTPOS     - ELO     - JCB     - JCREW     - MADA     - MAESTRO     - MEEZA .</param>
        /// <param name="AllowedPaymentTypes">The payment types that are allowed for the merchant.    Possible values when launching Unified Checkout:   - PANENTRY                 - GOOGLEPAY   - SRC   - CHECK &lt;br&gt;&lt;br&gt;  Possible values when launching Unified Checkout with Checkout API: - PANENTRY               - SRC &lt;br&gt;&lt;br&gt;  Possible values when launching Click To Pay Drop-In UI: - CLICKTOPAY &lt;br&gt;&lt;br&gt;  **Important:**    - SRC and CLICKTOPAY are only available for Visa, Mastercard and AMEX. .</param>
        /// <param name="Country">Country the purchase is originating from (e.g. country of the merchant).  Use the two-character ISO Standard .</param>
        /// <param name="Locale">Localization of the User experience conforming to the ISO 639-1 language standards and two-character ISO Standard Country Code.  Please refer to list of [supported locales through Unified Checkout](https://developer.cybersource.com/docs/cybs/en-us/unified-checkout/developer/all/rest/unified-checkout/uc-appendix-languages.html) .</param>
        /// <param name="CaptureMandate">CaptureMandate.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="CheckoutApiInitialization">CheckoutApiInitialization.</param>
        public GenerateUnifiedCheckoutCaptureContextRequest(string ClientVersion = default(string), List<string> TargetOrigins = default(List<string>), List<string> AllowedCardNetworks = default(List<string>), List<string> AllowedPaymentTypes = default(List<string>), string Country = default(string), string Locale = default(string), Upv1capturecontextsCaptureMandate CaptureMandate = default(Upv1capturecontextsCaptureMandate), Upv1capturecontextsOrderInformation OrderInformation = default(Upv1capturecontextsOrderInformation), Upv1capturecontextsCheckoutApiInitialization CheckoutApiInitialization = default(Upv1capturecontextsCheckoutApiInitialization))
        {
            this.ClientVersion = ClientVersion;
            this.TargetOrigins = TargetOrigins;
            this.AllowedCardNetworks = AllowedCardNetworks;
            this.AllowedPaymentTypes = AllowedPaymentTypes;
            this.Country = Country;
            this.Locale = Locale;
            this.CaptureMandate = CaptureMandate;
            this.OrderInformation = OrderInformation;
            this.CheckoutApiInitialization = CheckoutApiInitialization;
        }
        
        /// <summary>
        /// Specify the version of Unified Checkout that you want to use.
        /// </summary>
        /// <value>Specify the version of Unified Checkout that you want to use.</value>
        [DataMember(Name="clientVersion", EmitDefaultValue=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// The [target origin](https://developer.mozilla.org/en-US/docs/Glossary/Origin) of the website on which you will be launching Unified Checkout is defined by the scheme (protocol), hostname (domain) and port number (if used).    You must use https://hostname (unless you use http://localhost) Wildcards are NOT supported.  Ensure that subdomains are included. Any valid top-level domain is supported (e.g. .com, .co.uk, .gov.br etc)  Examples:   - https://example.com   - https://subdomain.example.com   - https://example.com:8080&lt;br&gt;&lt;br&gt;  If you are embedding within multiple nested iframes you need to specify the origins of all the browser contexts used, for example:    targetOrigins: [     \&quot;https://example.com\&quot;,     \&quot;https://basket.example.com\&quot;,     \&quot;https://ecom.example.com\&quot;   ] 
        /// </summary>
        /// <value>The [target origin](https://developer.mozilla.org/en-US/docs/Glossary/Origin) of the website on which you will be launching Unified Checkout is defined by the scheme (protocol), hostname (domain) and port number (if used).    You must use https://hostname (unless you use http://localhost) Wildcards are NOT supported.  Ensure that subdomains are included. Any valid top-level domain is supported (e.g. .com, .co.uk, .gov.br etc)  Examples:   - https://example.com   - https://subdomain.example.com   - https://example.com:8080&lt;br&gt;&lt;br&gt;  If you are embedding within multiple nested iframes you need to specify the origins of all the browser contexts used, for example:    targetOrigins: [     \&quot;https://example.com\&quot;,     \&quot;https://basket.example.com\&quot;,     \&quot;https://ecom.example.com\&quot;   ] </value>
        [DataMember(Name="targetOrigins", EmitDefaultValue=false)]
        public List<string> TargetOrigins { get; set; }

        /// <summary>
        /// The list of card networks you want to use for this Unified Checkout transaction.  Unified Checkout currently supports the following card networks:     - VISA     - MASTERCARD     - AMEX     - CARNET     - CARTESBANCAIRES     - CUP     - DINERSCLUB     - DISCOVER     - EFTPOS     - ELO     - JCB     - JCREW     - MADA     - MAESTRO     - MEEZA 
        /// </summary>
        /// <value>The list of card networks you want to use for this Unified Checkout transaction.  Unified Checkout currently supports the following card networks:     - VISA     - MASTERCARD     - AMEX     - CARNET     - CARTESBANCAIRES     - CUP     - DINERSCLUB     - DISCOVER     - EFTPOS     - ELO     - JCB     - JCREW     - MADA     - MAESTRO     - MEEZA </value>
        [DataMember(Name="allowedCardNetworks", EmitDefaultValue=false)]
        public List<string> AllowedCardNetworks { get; set; }

        /// <summary>
        /// The payment types that are allowed for the merchant.    Possible values when launching Unified Checkout:   - PANENTRY                 - GOOGLEPAY   - SRC   - CHECK &lt;br&gt;&lt;br&gt;  Possible values when launching Unified Checkout with Checkout API: - PANENTRY               - SRC &lt;br&gt;&lt;br&gt;  Possible values when launching Click To Pay Drop-In UI: - CLICKTOPAY &lt;br&gt;&lt;br&gt;  **Important:**    - SRC and CLICKTOPAY are only available for Visa, Mastercard and AMEX. 
        /// </summary>
        /// <value>The payment types that are allowed for the merchant.    Possible values when launching Unified Checkout:   - PANENTRY                 - GOOGLEPAY   - SRC   - CHECK &lt;br&gt;&lt;br&gt;  Possible values when launching Unified Checkout with Checkout API: - PANENTRY               - SRC &lt;br&gt;&lt;br&gt;  Possible values when launching Click To Pay Drop-In UI: - CLICKTOPAY &lt;br&gt;&lt;br&gt;  **Important:**    - SRC and CLICKTOPAY are only available for Visa, Mastercard and AMEX. </value>
        [DataMember(Name="allowedPaymentTypes", EmitDefaultValue=false)]
        public List<string> AllowedPaymentTypes { get; set; }

        /// <summary>
        /// Country the purchase is originating from (e.g. country of the merchant).  Use the two-character ISO Standard 
        /// </summary>
        /// <value>Country the purchase is originating from (e.g. country of the merchant).  Use the two-character ISO Standard </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Localization of the User experience conforming to the ISO 639-1 language standards and two-character ISO Standard Country Code.  Please refer to list of [supported locales through Unified Checkout](https://developer.cybersource.com/docs/cybs/en-us/unified-checkout/developer/all/rest/unified-checkout/uc-appendix-languages.html) 
        /// </summary>
        /// <value>Localization of the User experience conforming to the ISO 639-1 language standards and two-character ISO Standard Country Code.  Please refer to list of [supported locales through Unified Checkout](https://developer.cybersource.com/docs/cybs/en-us/unified-checkout/developer/all/rest/unified-checkout/uc-appendix-languages.html) </value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets CaptureMandate
        /// </summary>
        [DataMember(Name="captureMandate", EmitDefaultValue=false)]
        public Upv1capturecontextsCaptureMandate CaptureMandate { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Upv1capturecontextsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutApiInitialization
        /// </summary>
        [DataMember(Name="checkoutApiInitialization", EmitDefaultValue=false)]
        public Upv1capturecontextsCheckoutApiInitialization CheckoutApiInitialization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateUnifiedCheckoutCaptureContextRequest {\n");
            sb.Append("  ClientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  TargetOrigins: ").Append(TargetOrigins).Append("\n");
            sb.Append("  AllowedCardNetworks: ").Append(AllowedCardNetworks).Append("\n");
            sb.Append("  AllowedPaymentTypes: ").Append(AllowedPaymentTypes).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  CaptureMandate: ").Append(CaptureMandate).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  CheckoutApiInitialization: ").Append(CheckoutApiInitialization).Append("\n");
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
            return this.Equals(obj as GenerateUnifiedCheckoutCaptureContextRequest);
        }

        /// <summary>
        /// Returns true if GenerateUnifiedCheckoutCaptureContextRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GenerateUnifiedCheckoutCaptureContextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateUnifiedCheckoutCaptureContextRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientVersion == other.ClientVersion ||
                    this.ClientVersion != null &&
                    this.ClientVersion.Equals(other.ClientVersion)
                ) && 
                (
                    this.TargetOrigins == other.TargetOrigins ||
                    this.TargetOrigins != null &&
                    this.TargetOrigins.SequenceEqual(other.TargetOrigins)
                ) && 
                (
                    this.AllowedCardNetworks == other.AllowedCardNetworks ||
                    this.AllowedCardNetworks != null &&
                    this.AllowedCardNetworks.SequenceEqual(other.AllowedCardNetworks)
                ) && 
                (
                    this.AllowedPaymentTypes == other.AllowedPaymentTypes ||
                    this.AllowedPaymentTypes != null &&
                    this.AllowedPaymentTypes.SequenceEqual(other.AllowedPaymentTypes)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.CaptureMandate == other.CaptureMandate ||
                    this.CaptureMandate != null &&
                    this.CaptureMandate.Equals(other.CaptureMandate)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.CheckoutApiInitialization == other.CheckoutApiInitialization ||
                    this.CheckoutApiInitialization != null &&
                    this.CheckoutApiInitialization.Equals(other.CheckoutApiInitialization)
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
                if (this.ClientVersion != null)
                    hash = hash * 59 + this.ClientVersion.GetHashCode();
                if (this.TargetOrigins != null)
                    hash = hash * 59 + this.TargetOrigins.GetHashCode();
                if (this.AllowedCardNetworks != null)
                    hash = hash * 59 + this.AllowedCardNetworks.GetHashCode();
                if (this.AllowedPaymentTypes != null)
                    hash = hash * 59 + this.AllowedPaymentTypes.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.CaptureMandate != null)
                    hash = hash * 59 + this.CaptureMandate.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.CheckoutApiInitialization != null)
                    hash = hash * 59 + this.CheckoutApiInitialization.GetHashCode();
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
