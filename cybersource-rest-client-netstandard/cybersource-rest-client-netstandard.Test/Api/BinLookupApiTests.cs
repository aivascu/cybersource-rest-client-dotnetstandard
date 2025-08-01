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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing BinLookupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BinLookupApiTests
    {
        private BinLookupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BinLookupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BinLookupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BinLookupApi
            //Assert.IsInstanceOfType(typeof(BinLookupApi), instance, "instance is a BinLookupApi");
        }

        
        /// <summary>
        /// Test GetAccountInfo
        /// </summary>
        [Test]
        public void GetAccountInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBinLookupRequest createBinLookupRequest = null;
            //var response = instance.GetAccountInfo(createBinLookupRequest);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
        
    }

}
