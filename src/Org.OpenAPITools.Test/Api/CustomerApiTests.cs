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
    ///  Class for testing CustomerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomerApiTests : IDisposable
    {
        private CustomerApi instance;

        public CustomerApiTests()
        {
            instance = new CustomerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomerApi
            //Assert.IsType<CustomerApi>(instance);
        }

        /// <summary>
        /// Test CustomerAdd
        /// </summary>
        [Fact]
        public void CustomerAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerAdd customerAdd = null;
            //var response = instance.CustomerAdd(customerAdd);
            //Assert.IsType<CustomerAdd200Response>(response);
        }

        /// <summary>
        /// Test CustomerAddressAdd
        /// </summary>
        [Fact]
        public void CustomerAddressAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerAddressAdd customerAddressAdd = null;
            //var response = instance.CustomerAddressAdd(customerAddressAdd);
            //Assert.IsType<AttributeAdd200Response>(response);
        }

        /// <summary>
        /// Test CustomerAttributeList
        /// </summary>
        [Fact]
        public void CustomerAttributeListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //int? count = null;
            //string? pageCursor = null;
            //string? storeId = null;
            //string? langId = null;
            //string? responseFields = null;
            //string? varParams = null;
            //string? exclude = null;
            //var response = instance.CustomerAttributeList(customerId, count, pageCursor, storeId, langId, responseFields, varParams, exclude);
            //Assert.IsType<ModelResponseCustomerAttributeList>(response);
        }

        /// <summary>
        /// Test CustomerCount
        /// </summary>
        [Fact]
        public void CustomerCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? ids = null;
            //string? sinceId = null;
            //string? customerListId = null;
            //string? groupId = null;
            //string? storeId = null;
            //bool? avail = null;
            //bool? includeGuests = null;
            //string? findValue = null;
            //string? findWhere = null;
            //string? createdFrom = null;
            //string? createdTo = null;
            //string? modifiedFrom = null;
            //string? modifiedTo = null;
            //var response = instance.CustomerCount(ids, sinceId, customerListId, groupId, storeId, avail, includeGuests, findValue, findWhere, createdFrom, createdTo, modifiedFrom, modifiedTo);
            //Assert.IsType<CustomerCount200Response>(response);
        }

        /// <summary>
        /// Test CustomerDelete
        /// </summary>
        [Fact]
        public void CustomerDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CustomerDelete(id);
            //Assert.IsType<CustomerDelete200Response>(response);
        }

        /// <summary>
        /// Test CustomerFind
        /// </summary>
        [Fact]
        public void CustomerFindTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string findValue = null;
            //string? findWhere = null;
            //string? findParams = null;
            //string? storeId = null;
            //bool? includeGuests = null;
            //var response = instance.CustomerFind(findValue, findWhere, findParams, storeId, includeGuests);
            //Assert.IsType<CustomerFind200Response>(response);
        }

        /// <summary>
        /// Test CustomerGroupAdd
        /// </summary>
        [Fact]
        public void CustomerGroupAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string? storeId = null;
            //string? storesIds = null;
            //var response = instance.CustomerGroupAdd(name, storeId, storesIds);
            //Assert.IsType<CustomerGroupAdd200Response>(response);
        }

        /// <summary>
        /// Test CustomerGroupList
        /// </summary>
        [Fact]
        public void CustomerGroupListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? start = null;
            //int? count = null;
            //string? pageCursor = null;
            //string? groupIds = null;
            //string? storeId = null;
            //string? langId = null;
            //string? responseFields = null;
            //string? varParams = null;
            //string? exclude = null;
            //bool? disableCache = null;
            //var response = instance.CustomerGroupList(start, count, pageCursor, groupIds, storeId, langId, responseFields, varParams, exclude, disableCache);
            //Assert.IsType<ModelResponseCustomerGroupList>(response);
        }

        /// <summary>
        /// Test CustomerInfo
        /// </summary>
        [Fact]
        public void CustomerInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string? storeId = null;
            //string? responseFields = null;
            //string? varParams = null;
            //string? exclude = null;
            //var response = instance.CustomerInfo(id, storeId, responseFields, varParams, exclude);
            //Assert.IsType<CustomerInfo200Response>(response);
        }

        /// <summary>
        /// Test CustomerList
        /// </summary>
        [Fact]
        public void CustomerListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? start = null;
            //int? count = null;
            //string? pageCursor = null;
            //string? ids = null;
            //string? sinceId = null;
            //string? customerListId = null;
            //string? groupId = null;
            //string? storeId = null;
            //bool? avail = null;
            //bool? includeGuests = null;
            //string? findValue = null;
            //string? findWhere = null;
            //string? createdFrom = null;
            //string? createdTo = null;
            //string? modifiedFrom = null;
            //string? modifiedTo = null;
            //string? sortBy = null;
            //string? sortDirection = null;
            //string? responseFields = null;
            //string? varParams = null;
            //string? exclude = null;
            //var response = instance.CustomerList(start, count, pageCursor, ids, sinceId, customerListId, groupId, storeId, avail, includeGuests, findValue, findWhere, createdFrom, createdTo, modifiedFrom, modifiedTo, sortBy, sortDirection, responseFields, varParams, exclude);
            //Assert.IsType<ModelResponseCustomerList>(response);
        }

        /// <summary>
        /// Test CustomerUpdate
        /// </summary>
        [Fact]
        public void CustomerUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerUpdate customerUpdate = null;
            //var response = instance.CustomerUpdate(customerUpdate);
            //Assert.IsType<AccountConfigUpdate200Response>(response);
        }

        /// <summary>
        /// Test CustomerWishlistList
        /// </summary>
        [Fact]
        public void CustomerWishlistListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //int? start = null;
            //int? count = null;
            //string? pageCursor = null;
            //string? id = null;
            //string? storeId = null;
            //string? responseFields = null;
            //var response = instance.CustomerWishlistList(customerId, start, count, pageCursor, id, storeId, responseFields);
            //Assert.IsType<ModelResponseCustomerWishlistList>(response);
        }
    }
}
