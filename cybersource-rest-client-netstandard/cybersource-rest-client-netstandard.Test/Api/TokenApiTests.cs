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
    ///  Class for testing TokenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TokenApiTests
    {
        private TokenApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TokenApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TokenApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TokenApi
            //Assert.IsInstanceOfType(typeof(TokenApi), instance, "instance is a TokenApi");
        }

        
        /// <summary>
        /// Test PostTokenPaymentCredentials
        /// </summary>
        [Test]
        public void PostTokenPaymentCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tokenId = null;
            //string profileId = null;
            //var response = instance.PostTokenPaymentCredentials(tokenId, profileId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}