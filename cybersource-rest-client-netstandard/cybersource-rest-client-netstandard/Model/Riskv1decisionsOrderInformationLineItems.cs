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
    /// Riskv1decisionsOrderInformationLineItems
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsOrderInformationLineItems :  IEquatable<Riskv1decisionsOrderInformationLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsOrderInformationLineItems" /> class.
        /// </summary>
        /// <param name="TotalAmount">Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 .</param>
        /// <param name="UnitPrice">Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15) .</param>
        /// <param name="Quantity">Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. .</param>
        /// <param name="GiftCardCurrency">When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the currency used for the gift card purchase.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) .</param>
        /// <param name="ProductSKU">Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. .</param>
        /// <param name="ProductRisk">Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. .</param>
        /// <param name="ProductDescription">Brief description of item..</param>
        /// <param name="ProductName">For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. .</param>
        /// <param name="ProductCode">Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. .</param>
        /// <param name="Gift">This field is only used in DM service.  Determines whether to assign risk to the order if the billing and shipping addresses specify different cities, states, or countries. This field can contain one of the following values: - true: Orders are assigned only slight additional risk if billing and shipping addresses are different. - false: Orders are assigned higher additional risk if billing and shipping addresses are different. .</param>
        /// <param name="DistributorProductSku">Product&#39;s identifier code. This field is inserted into the outgoing message without being parsed or formatted. This field is included as Distributor product SKU (Offer) in the list of API fields with which you can create custom rules. .</param>
        /// <param name="Passenger">Passenger.</param>
        /// <param name="ShippingDestinationTypes">Destination to where the item will be shipped. Example: Commercial, Residential, Store .</param>
        /// <param name="TaxAmount">Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  Optional field.  #### Airlines processing Tax portion of the order amount. This value cannot exceed 99999999999999 (fourteen 9s). Format: English characters only. Optional request field for a line item.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  Note if you send this field in your tax request, the value in the field will override the tax engine .</param>
        /// <param name="AllowedExportCountries">AllowedExportCountries.</param>
        /// <param name="RestrictedExportCountries">RestrictedExportCountries.</param>
        public Riskv1decisionsOrderInformationLineItems(string TotalAmount = default(string), string UnitPrice = default(string), int? Quantity = default(int?), int? GiftCardCurrency = default(int?), string ProductSKU = default(string), string ProductRisk = default(string), string ProductDescription = default(string), string ProductName = default(string), string ProductCode = default(string), bool? Gift = default(bool?), string DistributorProductSku = default(string), Ptsv2paymentsOrderInformationPassenger Passenger = default(Ptsv2paymentsOrderInformationPassenger), string ShippingDestinationTypes = default(string), string TaxAmount = default(string), List<string> AllowedExportCountries = default(List<string>), List<string> RestrictedExportCountries = default(List<string>))
        {
            this.TotalAmount = TotalAmount;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.GiftCardCurrency = GiftCardCurrency;
            this.ProductSKU = ProductSKU;
            this.ProductRisk = ProductRisk;
            this.ProductDescription = ProductDescription;
            this.ProductName = ProductName;
            this.ProductCode = ProductCode;
            this.Gift = Gift;
            this.DistributorProductSku = DistributorProductSku;
            this.Passenger = Passenger;
            this.ShippingDestinationTypes = ShippingDestinationTypes;
            this.TaxAmount = TaxAmount;
            this.AllowedExportCountries = AllowedExportCountries;
            this.RestrictedExportCountries = RestrictedExportCountries;
        }
        
        /// <summary>
        /// Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 
        /// </summary>
        /// <value>Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15) 
        /// </summary>
        /// <value>Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15) </value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. 
        /// </summary>
        /// <value>Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. </value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the currency used for the gift card purchase.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) 
        /// </summary>
        /// <value>When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the currency used for the gift card purchase.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) </value>
        [DataMember(Name="giftCardCurrency", EmitDefaultValue=false)]
        public int? GiftCardCurrency { get; set; }

        /// <summary>
        /// Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. 
        /// </summary>
        /// <value>Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. </value>
        [DataMember(Name="productSKU", EmitDefaultValue=false)]
        public string ProductSKU { get; set; }

        /// <summary>
        /// Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. 
        /// </summary>
        /// <value>Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. </value>
        [DataMember(Name="productRisk", EmitDefaultValue=false)]
        public string ProductRisk { get; set; }

        /// <summary>
        /// Brief description of item.
        /// </summary>
        /// <value>Brief description of item.</value>
        [DataMember(Name="productDescription", EmitDefaultValue=false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. 
        /// </summary>
        /// <value>For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. </value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. 
        /// </summary>
        /// <value>Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. </value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// This field is only used in DM service.  Determines whether to assign risk to the order if the billing and shipping addresses specify different cities, states, or countries. This field can contain one of the following values: - true: Orders are assigned only slight additional risk if billing and shipping addresses are different. - false: Orders are assigned higher additional risk if billing and shipping addresses are different. 
        /// </summary>
        /// <value>This field is only used in DM service.  Determines whether to assign risk to the order if the billing and shipping addresses specify different cities, states, or countries. This field can contain one of the following values: - true: Orders are assigned only slight additional risk if billing and shipping addresses are different. - false: Orders are assigned higher additional risk if billing and shipping addresses are different. </value>
        [DataMember(Name="gift", EmitDefaultValue=false)]
        public bool? Gift { get; set; }

        /// <summary>
        /// Product&#39;s identifier code. This field is inserted into the outgoing message without being parsed or formatted. This field is included as Distributor product SKU (Offer) in the list of API fields with which you can create custom rules. 
        /// </summary>
        /// <value>Product&#39;s identifier code. This field is inserted into the outgoing message without being parsed or formatted. This field is included as Distributor product SKU (Offer) in the list of API fields with which you can create custom rules. </value>
        [DataMember(Name="distributorProductSku", EmitDefaultValue=false)]
        public string DistributorProductSku { get; set; }

        /// <summary>
        /// Gets or Sets Passenger
        /// </summary>
        [DataMember(Name="passenger", EmitDefaultValue=false)]
        public Ptsv2paymentsOrderInformationPassenger Passenger { get; set; }

        /// <summary>
        /// Destination to where the item will be shipped. Example: Commercial, Residential, Store 
        /// </summary>
        /// <value>Destination to where the item will be shipped. Example: Commercial, Residential, Store </value>
        [DataMember(Name="shippingDestinationTypes", EmitDefaultValue=false)]
        public string ShippingDestinationTypes { get; set; }

        /// <summary>
        /// Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  Optional field.  #### Airlines processing Tax portion of the order amount. This value cannot exceed 99999999999999 (fourteen 9s). Format: English characters only. Optional request field for a line item.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  Note if you send this field in your tax request, the value in the field will override the tax engine 
        /// </summary>
        /// <value>Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  Optional field.  #### Airlines processing Tax portion of the order amount. This value cannot exceed 99999999999999 (fourteen 9s). Format: English characters only. Optional request field for a line item.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  Note if you send this field in your tax request, the value in the field will override the tax engine </value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets AllowedExportCountries
        /// </summary>
        [DataMember(Name="allowedExportCountries", EmitDefaultValue=false)]
        public List<string> AllowedExportCountries { get; set; }

        /// <summary>
        /// Gets or Sets RestrictedExportCountries
        /// </summary>
        [DataMember(Name="restrictedExportCountries", EmitDefaultValue=false)]
        public List<string> RestrictedExportCountries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsOrderInformationLineItems {\n");
            if (TotalAmount != null) sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            if (UnitPrice != null) sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            if (Quantity != null) sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            if (GiftCardCurrency != null) sb.Append("  GiftCardCurrency: ").Append(GiftCardCurrency).Append("\n");
            if (ProductSKU != null) sb.Append("  ProductSKU: ").Append(ProductSKU).Append("\n");
            if (ProductRisk != null) sb.Append("  ProductRisk: ").Append(ProductRisk).Append("\n");
            if (ProductDescription != null) sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            if (ProductName != null) sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            if (ProductCode != null) sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            if (Gift != null) sb.Append("  Gift: ").Append(Gift).Append("\n");
            if (DistributorProductSku != null) sb.Append("  DistributorProductSku: ").Append(DistributorProductSku).Append("\n");
            if (Passenger != null) sb.Append("  Passenger: ").Append(Passenger).Append("\n");
            if (ShippingDestinationTypes != null) sb.Append("  ShippingDestinationTypes: ").Append(ShippingDestinationTypes).Append("\n");
            if (TaxAmount != null) sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            if (AllowedExportCountries != null) sb.Append("  AllowedExportCountries: ").Append(AllowedExportCountries).Append("\n");
            if (RestrictedExportCountries != null) sb.Append("  RestrictedExportCountries: ").Append(RestrictedExportCountries).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsOrderInformationLineItems);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsOrderInformationLineItems instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsOrderInformationLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsOrderInformationLineItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.GiftCardCurrency == other.GiftCardCurrency ||
                    this.GiftCardCurrency != null &&
                    this.GiftCardCurrency.Equals(other.GiftCardCurrency)
                ) && 
                (
                    this.ProductSKU == other.ProductSKU ||
                    this.ProductSKU != null &&
                    this.ProductSKU.Equals(other.ProductSKU)
                ) && 
                (
                    this.ProductRisk == other.ProductRisk ||
                    this.ProductRisk != null &&
                    this.ProductRisk.Equals(other.ProductRisk)
                ) && 
                (
                    this.ProductDescription == other.ProductDescription ||
                    this.ProductDescription != null &&
                    this.ProductDescription.Equals(other.ProductDescription)
                ) && 
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.Equals(other.ProductName)
                ) && 
                (
                    this.ProductCode == other.ProductCode ||
                    this.ProductCode != null &&
                    this.ProductCode.Equals(other.ProductCode)
                ) && 
                (
                    this.Gift == other.Gift ||
                    this.Gift != null &&
                    this.Gift.Equals(other.Gift)
                ) && 
                (
                    this.DistributorProductSku == other.DistributorProductSku ||
                    this.DistributorProductSku != null &&
                    this.DistributorProductSku.Equals(other.DistributorProductSku)
                ) && 
                (
                    this.Passenger == other.Passenger ||
                    this.Passenger != null &&
                    this.Passenger.Equals(other.Passenger)
                ) && 
                (
                    this.ShippingDestinationTypes == other.ShippingDestinationTypes ||
                    this.ShippingDestinationTypes != null &&
                    this.ShippingDestinationTypes.Equals(other.ShippingDestinationTypes)
                ) && 
                (
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
                ) && 
                (
                    this.AllowedExportCountries == other.AllowedExportCountries ||
                    this.AllowedExportCountries != null &&
                    this.AllowedExportCountries.SequenceEqual(other.AllowedExportCountries)
                ) && 
                (
                    this.RestrictedExportCountries == other.RestrictedExportCountries ||
                    this.RestrictedExportCountries != null &&
                    this.RestrictedExportCountries.SequenceEqual(other.RestrictedExportCountries)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.GiftCardCurrency != null)
                    hash = hash * 59 + this.GiftCardCurrency.GetHashCode();
                if (this.ProductSKU != null)
                    hash = hash * 59 + this.ProductSKU.GetHashCode();
                if (this.ProductRisk != null)
                    hash = hash * 59 + this.ProductRisk.GetHashCode();
                if (this.ProductDescription != null)
                    hash = hash * 59 + this.ProductDescription.GetHashCode();
                if (this.ProductName != null)
                    hash = hash * 59 + this.ProductName.GetHashCode();
                if (this.ProductCode != null)
                    hash = hash * 59 + this.ProductCode.GetHashCode();
                if (this.Gift != null)
                    hash = hash * 59 + this.Gift.GetHashCode();
                if (this.DistributorProductSku != null)
                    hash = hash * 59 + this.DistributorProductSku.GetHashCode();
                if (this.Passenger != null)
                    hash = hash * 59 + this.Passenger.GetHashCode();
                if (this.ShippingDestinationTypes != null)
                    hash = hash * 59 + this.ShippingDestinationTypes.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                if (this.AllowedExportCountries != null)
                    hash = hash * 59 + this.AllowedExportCountries.GetHashCode();
                if (this.RestrictedExportCountries != null)
                    hash = hash * 59 + this.RestrictedExportCountries.GetHashCode();
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
