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
    /// The images to be used as background on Klarna&#39;s payment page (the image best matching the resolution will be used). This is a pass-through field. Check Klarna&#39;s documentation for more information about the correct format. This value can also be set in the merchant configuration. 
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsHostedPaymentInformationUserAgent :  IEquatable<Ptsv2paymentsHostedPaymentInformationUserAgent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsHostedPaymentInformationUserAgent" /> class.
        /// </summary>
        /// <param name="Url">Url for the image.</param>
        /// <param name="Width">Width of the image.</param>
        public Ptsv2paymentsHostedPaymentInformationUserAgent(string Url = default(string), int? Width = default(int?))
        {
            this.Url = Url;
            this.Width = Width;
        }
        
        /// <summary>
        /// Url for the image
        /// </summary>
        /// <value>Url for the image</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Width of the image
        /// </summary>
        /// <value>Width of the image</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsHostedPaymentInformationUserAgent {\n");
            if (Url != null) sb.Append("  Url: ").Append(Url).Append("\n");
            if (Width != null) sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsHostedPaymentInformationUserAgent);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsHostedPaymentInformationUserAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsHostedPaymentInformationUserAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsHostedPaymentInformationUserAgent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
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
