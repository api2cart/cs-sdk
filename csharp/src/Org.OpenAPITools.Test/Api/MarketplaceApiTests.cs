/*
 * API2Cart OpenAPI
 *
 * API2Cart
 *
 * The version of the OpenAPI document: 1.1
 * Contact: contact@api2cart.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing MarketplaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MarketplaceApiTests : IDisposable
    {
        private MarketplaceApi instance;

        public MarketplaceApiTests()
        {
            instance = new MarketplaceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MarketplaceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MarketplaceApi
            //Assert.IsType<MarketplaceApi>(instance);
        }

        /// <summary>
        /// Test MarketplaceProductFind
        /// </summary>
        [Fact]
        public void MarketplaceProductFindTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? storeId = null;
            //int? count = null;
            //string? pageCursor = null;
            //string? categoriesIds = null;
            //string? keyword = null;
            //string? asin = null;
            //string? ean = null;
            //string? gtin = null;
            //string? upc = null;
            //string? mpn = null;
            //string? isbn = null;
            //string? varParams = null;
            //string? exclude = null;
            //string? responseFields = null;
            //var response = instance.MarketplaceProductFind(storeId, count, pageCursor, categoriesIds, keyword, asin, ean, gtin, upc, mpn, isbn, varParams, exclude, responseFields);
            //Assert.IsType<ModelResponseMarketplaceProductFind>(response);
        }
    }
}
