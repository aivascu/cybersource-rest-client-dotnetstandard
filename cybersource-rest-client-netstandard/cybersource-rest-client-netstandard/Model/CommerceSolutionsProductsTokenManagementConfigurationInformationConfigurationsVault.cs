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
    /// CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault
    /// </summary>
    [DataContract]
    public partial class CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault :  IEquatable<CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault" /> class.
        /// </summary>
        /// <param name="DefaultTokenType">Default token type to be used. Possible Values:   - &#39;CUSTOMER&#39;  - &#39;PAYMENT_INSTRUMENT&#39;  - &#39;INSTRUMENT_IDENTIFIER&#39; .</param>
        /// <param name="Location">Location where the vault will be stored.  Use &#39;IDC&#39; (the Indian Data Centre) when merchant is storing token data in India  or &#39;GDC&#39; (the Global Data Centre) for all other cases.  Possible Values:    - &#39;IDC&#39;   - &#39;GDC&#39; .</param>
        /// <param name="TokenFormats">TokenFormats.</param>
        /// <param name="TokenPermissions">TokenPermissions.</param>
        /// <param name="SensitivePrivileges">SensitivePrivileges.</param>
        /// <param name="Nullify">Nullify.</param>
        /// <param name="NetworkTokenServices">NetworkTokenServices.</param>
        public CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault(string DefaultTokenType = default(string), string Location = default(string), TmsTokenFormats TokenFormats = default(TmsTokenFormats), TokenPermissions TokenPermissions = default(TokenPermissions), TmsSensitivePrivileges SensitivePrivileges = default(TmsSensitivePrivileges), TmsNullify Nullify = default(TmsNullify), TmsNetworkTokenServices NetworkTokenServices = default(TmsNetworkTokenServices))
        {
            this.DefaultTokenType = DefaultTokenType;
            this.Location = Location;
            this.TokenFormats = TokenFormats;
            this.TokenPermissions = TokenPermissions;
            this.SensitivePrivileges = SensitivePrivileges;
            this.Nullify = Nullify;
            this.NetworkTokenServices = NetworkTokenServices;
        }
        
        /// <summary>
        /// Default token type to be used. Possible Values:   - &#39;CUSTOMER&#39;  - &#39;PAYMENT_INSTRUMENT&#39;  - &#39;INSTRUMENT_IDENTIFIER&#39; 
        /// </summary>
        /// <value>Default token type to be used. Possible Values:   - &#39;CUSTOMER&#39;  - &#39;PAYMENT_INSTRUMENT&#39;  - &#39;INSTRUMENT_IDENTIFIER&#39; </value>
        [DataMember(Name="defaultTokenType", EmitDefaultValue=false)]
        public string DefaultTokenType { get; set; }

        /// <summary>
        /// Location where the vault will be stored.  Use &#39;IDC&#39; (the Indian Data Centre) when merchant is storing token data in India  or &#39;GDC&#39; (the Global Data Centre) for all other cases.  Possible Values:    - &#39;IDC&#39;   - &#39;GDC&#39; 
        /// </summary>
        /// <value>Location where the vault will be stored.  Use &#39;IDC&#39; (the Indian Data Centre) when merchant is storing token data in India  or &#39;GDC&#39; (the Global Data Centre) for all other cases.  Possible Values:    - &#39;IDC&#39;   - &#39;GDC&#39; </value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets TokenFormats
        /// </summary>
        [DataMember(Name="tokenFormats", EmitDefaultValue=false)]
        public TmsTokenFormats TokenFormats { get; set; }

        /// <summary>
        /// Gets or Sets TokenPermissions
        /// </summary>
        [DataMember(Name="tokenPermissions", EmitDefaultValue=false)]
        public TokenPermissions TokenPermissions { get; set; }

        /// <summary>
        /// Gets or Sets SensitivePrivileges
        /// </summary>
        [DataMember(Name="sensitivePrivileges", EmitDefaultValue=false)]
        public TmsSensitivePrivileges SensitivePrivileges { get; set; }

        /// <summary>
        /// Gets or Sets Nullify
        /// </summary>
        [DataMember(Name="nullify", EmitDefaultValue=false)]
        public TmsNullify Nullify { get; set; }

        /// <summary>
        /// Gets or Sets NetworkTokenServices
        /// </summary>
        [DataMember(Name="networkTokenServices", EmitDefaultValue=false)]
        public TmsNetworkTokenServices NetworkTokenServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault {\n");
            if (DefaultTokenType != null) sb.Append("  DefaultTokenType: ").Append(DefaultTokenType).Append("\n");
            if (Location != null) sb.Append("  Location: ").Append(Location).Append("\n");
            if (TokenFormats != null) sb.Append("  TokenFormats: ").Append(TokenFormats).Append("\n");
            if (TokenPermissions != null) sb.Append("  TokenPermissions: ").Append(TokenPermissions).Append("\n");
            if (SensitivePrivileges != null) sb.Append("  SensitivePrivileges: ").Append(SensitivePrivileges).Append("\n");
            if (Nullify != null) sb.Append("  Nullify: ").Append(Nullify).Append("\n");
            if (NetworkTokenServices != null) sb.Append("  NetworkTokenServices: ").Append(NetworkTokenServices).Append("\n");
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
            return this.Equals(obj as CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault);
        }

        /// <summary>
        /// Returns true if CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault instances are equal
        /// </summary>
        /// <param name="other">Instance of CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DefaultTokenType == other.DefaultTokenType ||
                    this.DefaultTokenType != null &&
                    this.DefaultTokenType.Equals(other.DefaultTokenType)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.TokenFormats == other.TokenFormats ||
                    this.TokenFormats != null &&
                    this.TokenFormats.Equals(other.TokenFormats)
                ) && 
                (
                    this.TokenPermissions == other.TokenPermissions ||
                    this.TokenPermissions != null &&
                    this.TokenPermissions.Equals(other.TokenPermissions)
                ) && 
                (
                    this.SensitivePrivileges == other.SensitivePrivileges ||
                    this.SensitivePrivileges != null &&
                    this.SensitivePrivileges.Equals(other.SensitivePrivileges)
                ) && 
                (
                    this.Nullify == other.Nullify ||
                    this.Nullify != null &&
                    this.Nullify.Equals(other.Nullify)
                ) && 
                (
                    this.NetworkTokenServices == other.NetworkTokenServices ||
                    this.NetworkTokenServices != null &&
                    this.NetworkTokenServices.Equals(other.NetworkTokenServices)
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
                if (this.DefaultTokenType != null)
                    hash = hash * 59 + this.DefaultTokenType.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.TokenFormats != null)
                    hash = hash * 59 + this.TokenFormats.GetHashCode();
                if (this.TokenPermissions != null)
                    hash = hash * 59 + this.TokenPermissions.GetHashCode();
                if (this.SensitivePrivileges != null)
                    hash = hash * 59 + this.SensitivePrivileges.GetHashCode();
                if (this.Nullify != null)
                    hash = hash * 59 + this.Nullify.GetHashCode();
                if (this.NetworkTokenServices != null)
                    hash = hash * 59 + this.NetworkTokenServices.GetHashCode();
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
