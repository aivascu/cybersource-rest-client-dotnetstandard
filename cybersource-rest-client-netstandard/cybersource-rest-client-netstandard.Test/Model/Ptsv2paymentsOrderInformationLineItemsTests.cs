/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CyberSource.Api;
using CyberSource.Model;
using CyberSource.Client;
using System.Reflection;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing Ptsv2paymentsOrderInformationLineItems
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class Ptsv2paymentsOrderInformationLineItemsTests
    {
        // TODO uncomment below to declare an instance variable for Ptsv2paymentsOrderInformationLineItems
        //private Ptsv2paymentsOrderInformationLineItems instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Ptsv2paymentsOrderInformationLineItems
            //instance = new Ptsv2paymentsOrderInformationLineItems();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Ptsv2paymentsOrderInformationLineItems
        /// </summary>
        [Test]
        public void Ptsv2paymentsOrderInformationLineItemsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Ptsv2paymentsOrderInformationLineItems
            //Assert.IsInstanceOfType<Ptsv2paymentsOrderInformationLineItems> (instance, "variable 'instance' is a Ptsv2paymentsOrderInformationLineItems");
        }

        /// <summary>
        /// Test the property 'ProductCode'
        /// </summary>
        [Test]
        public void ProductCodeTest()
        {
            // TODO unit test for the property 'ProductCode'
        }
        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Test]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }
        /// <summary>
        /// Test the property 'ProductSku'
        /// </summary>
        [Test]
        public void ProductSkuTest()
        {
            // TODO unit test for the property 'ProductSku'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'UnitPrice'
        /// </summary>
        [Test]
        public void UnitPriceTest()
        {
            // TODO unit test for the property 'UnitPrice'
        }
        /// <summary>
        /// Test the property 'UnitOfMeasure'
        /// </summary>
        [Test]
        public void UnitOfMeasureTest()
        {
            // TODO unit test for the property 'UnitOfMeasure'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Test]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }
        /// <summary>
        /// Test the property 'TaxAmount'
        /// </summary>
        [Test]
        public void TaxAmountTest()
        {
            // TODO unit test for the property 'TaxAmount'
        }
        /// <summary>
        /// Test the property 'TaxRate'
        /// </summary>
        [Test]
        public void TaxRateTest()
        {
            // TODO unit test for the property 'TaxRate'
        }
        /// <summary>
        /// Test the property 'TaxAppliedAfterDiscount'
        /// </summary>
        [Test]
        public void TaxAppliedAfterDiscountTest()
        {
            // TODO unit test for the property 'TaxAppliedAfterDiscount'
        }
        /// <summary>
        /// Test the property 'TaxStatusIndicator'
        /// </summary>
        [Test]
        public void TaxStatusIndicatorTest()
        {
            // TODO unit test for the property 'TaxStatusIndicator'
        }
        /// <summary>
        /// Test the property 'TaxTypeCode'
        /// </summary>
        [Test]
        public void TaxTypeCodeTest()
        {
            // TODO unit test for the property 'TaxTypeCode'
        }
        /// <summary>
        /// Test the property 'AmountIncludesTax'
        /// </summary>
        [Test]
        public void AmountIncludesTaxTest()
        {
            // TODO unit test for the property 'AmountIncludesTax'
        }
        /// <summary>
        /// Test the property 'TypeOfSupply'
        /// </summary>
        [Test]
        public void TypeOfSupplyTest()
        {
            // TODO unit test for the property 'TypeOfSupply'
        }
        /// <summary>
        /// Test the property 'CommodityCode'
        /// </summary>
        [Test]
        public void CommodityCodeTest()
        {
            // TODO unit test for the property 'CommodityCode'
        }
        /// <summary>
        /// Test the property 'DiscountAmount'
        /// </summary>
        [Test]
        public void DiscountAmountTest()
        {
            // TODO unit test for the property 'DiscountAmount'
        }
        /// <summary>
        /// Test the property 'DiscountApplied'
        /// </summary>
        [Test]
        public void DiscountAppliedTest()
        {
            // TODO unit test for the property 'DiscountApplied'
        }
        /// <summary>
        /// Test the property 'DiscountRate'
        /// </summary>
        [Test]
        public void DiscountRateTest()
        {
            // TODO unit test for the property 'DiscountRate'
        }
        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Test]
        public void InvoiceNumberTest()
        {
            // TODO unit test for the property 'InvoiceNumber'
        }
        /// <summary>
        /// Test the property 'TaxDetails'
        /// </summary>
        [Test]
        public void TaxDetailsTest()
        {
            // TODO unit test for the property 'TaxDetails'
        }
        /// <summary>
        /// Test the property 'FulfillmentType'
        /// </summary>
        [Test]
        public void FulfillmentTypeTest()
        {
            // TODO unit test for the property 'FulfillmentType'
        }
        /// <summary>
        /// Test the property 'Weight'
        /// </summary>
        [Test]
        public void WeightTest()
        {
            // TODO unit test for the property 'Weight'
        }
        /// <summary>
        /// Test the property 'WeightIdentifier'
        /// </summary>
        [Test]
        public void WeightIdentifierTest()
        {
            // TODO unit test for the property 'WeightIdentifier'
        }
        /// <summary>
        /// Test the property 'WeightUnit'
        /// </summary>
        [Test]
        public void WeightUnitTest()
        {
            // TODO unit test for the property 'WeightUnit'
        }
        /// <summary>
        /// Test the property 'ReferenceDataCode'
        /// </summary>
        [Test]
        public void ReferenceDataCodeTest()
        {
            // TODO unit test for the property 'ReferenceDataCode'
        }
        /// <summary>
        /// Test the property 'ReferenceDataNumber'
        /// </summary>
        [Test]
        public void ReferenceDataNumberTest()
        {
            // TODO unit test for the property 'ReferenceDataNumber'
        }
        /// <summary>
        /// Test the property 'UnitTaxAmount'
        /// </summary>
        [Test]
        public void UnitTaxAmountTest()
        {
            // TODO unit test for the property 'UnitTaxAmount'
        }
        /// <summary>
        /// Test the property 'Measurement'
        /// </summary>
        [Test]
        public void MeasurementTest()
        {
            // TODO unit test for the property 'Measurement'
        }
        /// <summary>
        /// Test the property 'ProductDescription'
        /// </summary>
        [Test]
        public void ProductDescriptionTest()
        {
            // TODO unit test for the property 'ProductDescription'
        }
        /// <summary>
        /// Test the property 'GiftCardCurrency'
        /// </summary>
        [Test]
        public void GiftCardCurrencyTest()
        {
            // TODO unit test for the property 'GiftCardCurrency'
        }
        /// <summary>
        /// Test the property 'ShippingDestinationTypes'
        /// </summary>
        [Test]
        public void ShippingDestinationTypesTest()
        {
            // TODO unit test for the property 'ShippingDestinationTypes'
        }
        /// <summary>
        /// Test the property 'Gift'
        /// </summary>
        [Test]
        public void GiftTest()
        {
            // TODO unit test for the property 'Gift'
        }
        /// <summary>
        /// Test the property 'Passenger'
        /// </summary>
        [Test]
        public void PassengerTest()
        {
            // TODO unit test for the property 'Passenger'
        }
        /// <summary>
        /// Test the property 'AllowedExportCountries'
        /// </summary>
        [Test]
        public void AllowedExportCountriesTest()
        {
            // TODO unit test for the property 'AllowedExportCountries'
        }
        /// <summary>
        /// Test the property 'RestrictedExportCountries'
        /// </summary>
        [Test]
        public void RestrictedExportCountriesTest()
        {
            // TODO unit test for the property 'RestrictedExportCountries'
        }

    }

}
