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
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests : IDisposable
    {
        private WebhookApi instance;

        public WebhookApiTests()
        {
            instance = new WebhookApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookApi
            //Assert.IsType<WebhookApi>(instance);
        }

        /// <summary>
        /// Test WebhookCount
        /// </summary>
        [Fact]
        public void WebhookCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? entity = null;
            //string? action = null;
            //bool? active = null;
            //var response = instance.WebhookCount(entity, action, active);
            //Assert.IsType<WebhookCount200Response>(response);
        }

        /// <summary>
        /// Test WebhookCreate
        /// </summary>
        [Fact]
        public void WebhookCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entity = null;
            //string action = null;
            //string? callback = null;
            //string? label = null;
            //string? fields = null;
            //string? responseFields = null;
            //bool? active = null;
            //string? langId = null;
            //string? storeId = null;
            //var response = instance.WebhookCreate(entity, action, callback, label, fields, responseFields, active, langId, storeId);
            //Assert.IsType<BasketLiveShippingServiceCreate200Response>(response);
        }

        /// <summary>
        /// Test WebhookDelete
        /// </summary>
        [Fact]
        public void WebhookDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WebhookDelete(id);
            //Assert.IsType<AttributeDelete200Response>(response);
        }

        /// <summary>
        /// Test WebhookEvents
        /// </summary>
        [Fact]
        public void WebhookEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WebhookEvents();
            //Assert.IsType<WebhookEvents200Response>(response);
        }

        /// <summary>
        /// Test WebhookList
        /// </summary>
        [Fact]
        public void WebhookListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? start = null;
            //int? count = null;
            //string? entity = null;
            //string? action = null;
            //bool? active = null;
            //string? ids = null;
            //string? varParams = null;
            //var response = instance.WebhookList(start, count, entity, action, active, ids, varParams);
            //Assert.IsType<WebhookList200Response>(response);
        }

        /// <summary>
        /// Test WebhookUpdate
        /// </summary>
        [Fact]
        public void WebhookUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? callback = null;
            //string? label = null;
            //string? fields = null;
            //string? responseFields = null;
            //bool? active = null;
            //string? langId = null;
            //var response = instance.WebhookUpdate(id, callback, label, fields, responseFields, active, langId);
            //Assert.IsType<ProductImageUpdate200Response>(response);
        }
    }
}
