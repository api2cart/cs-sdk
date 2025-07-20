# Org.OpenAPITools.Api.OrderApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrderAbandonedList**](OrderApi.md#orderabandonedlist) | **GET** /order.abandoned.list.json | order.abandoned.list |
| [**OrderAdd**](OrderApi.md#orderadd) | **POST** /order.add.json | order.add |
| [**OrderCount**](OrderApi.md#ordercount) | **GET** /order.count.json | order.count |
| [**OrderFinancialStatusList**](OrderApi.md#orderfinancialstatuslist) | **GET** /order.financial_status.list.json | order.financial_status.list |
| [**OrderFulfillmentStatusList**](OrderApi.md#orderfulfillmentstatuslist) | **GET** /order.fulfillment_status.list.json | order.fulfillment_status.list |
| [**OrderInfo**](OrderApi.md#orderinfo) | **GET** /order.info.json | order.info |
| [**OrderList**](OrderApi.md#orderlist) | **GET** /order.list.json | order.list |
| [**OrderPreestimateShippingList**](OrderApi.md#orderpreestimateshippinglist) | **POST** /order.preestimate_shipping.list.json | order.preestimate_shipping.list |
| [**OrderRefundAdd**](OrderApi.md#orderrefundadd) | **POST** /order.refund.add.json | order.refund.add |
| [**OrderReturnAdd**](OrderApi.md#orderreturnadd) | **POST** /order.return.add.json | order.return.add |
| [**OrderReturnDelete**](OrderApi.md#orderreturndelete) | **DELETE** /order.return.delete.json | order.return.delete |
| [**OrderReturnUpdate**](OrderApi.md#orderreturnupdate) | **PUT** /order.return.update.json | order.return.update |
| [**OrderShipmentAdd**](OrderApi.md#ordershipmentadd) | **POST** /order.shipment.add.json | order.shipment.add |
| [**OrderShipmentAddBatch**](OrderApi.md#ordershipmentaddbatch) | **POST** /order.shipment.add.batch.json | order.shipment.add.batch |
| [**OrderShipmentDelete**](OrderApi.md#ordershipmentdelete) | **DELETE** /order.shipment.delete.json | order.shipment.delete |
| [**OrderShipmentInfo**](OrderApi.md#ordershipmentinfo) | **GET** /order.shipment.info.json | order.shipment.info |
| [**OrderShipmentList**](OrderApi.md#ordershipmentlist) | **GET** /order.shipment.list.json | order.shipment.list |
| [**OrderShipmentTrackingAdd**](OrderApi.md#ordershipmenttrackingadd) | **POST** /order.shipment.tracking.add.json | order.shipment.tracking.add |
| [**OrderShipmentUpdate**](OrderApi.md#ordershipmentupdate) | **PUT** /order.shipment.update.json | order.shipment.update |
| [**OrderStatusList**](OrderApi.md#orderstatuslist) | **GET** /order.status.list.json | order.status.list |
| [**OrderTransactionList**](OrderApi.md#ordertransactionlist) | **GET** /order.transaction.list.json | order.transaction.list |
| [**OrderUpdate**](OrderApi.md#orderupdate) | **PUT** /order.update.json | order.update |

<a id="orderabandonedlist"></a>
# **OrderAbandonedList**
> ModelResponseOrderAbandonedList OrderAbandonedList (int? start = null, int? count = null, string? pageCursor = null, string? customerId = null, string? customerEmail = null, string? storeId = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, bool? skipEmptyEmail = null, string? responseFields = null, string? varParams = null, string? exclude = null)

order.abandoned.list

Get list of orders that were left by customers before completing the order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderAbandonedListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var customerId = 5;  // string? | Retrieves orders specified by customer id (optional) 
            var customerEmail = jubari@hannsgroup.com;  // string? | Retrieves orders specified by customer email (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var skipEmptyEmail = true;  // bool? | Filter empty emails (optional)  (default to false)
            var responseFields = {return_code,pagination,result{order{id,customer{email},created_at,totals{total},order_products}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = force_all;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "customer,totals,items")
            var exclude = customer;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // order.abandoned.list
                ModelResponseOrderAbandonedList result = apiInstance.OrderAbandonedList(start, count, pageCursor, customerId, customerEmail, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, skipEmptyEmail, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderAbandonedList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderAbandonedListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.abandoned.list
    ApiResponse<ModelResponseOrderAbandonedList> response = apiInstance.OrderAbandonedListWithHttpInfo(start, count, pageCursor, customerId, customerEmail, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, skipEmptyEmail, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderAbandonedListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **customerId** | **string?** | Retrieves orders specified by customer id | [optional]  |
| **customerEmail** | **string?** | Retrieves orders specified by customer email | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **skipEmptyEmail** | **bool?** | Filter empty emails | [optional] [default to false] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;customer,totals,items&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseOrderAbandonedList**](ModelResponseOrderAbandonedList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderadd"></a>
# **OrderAdd**
> OrderAdd200Response OrderAdd (OrderAdd orderAdd)

order.add

Add a new order to the cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderAdd = new OrderAdd(); // OrderAdd | 

            try
            {
                // order.add
                OrderAdd200Response result = apiInstance.OrderAdd(orderAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.add
    ApiResponse<OrderAdd200Response> response = apiInstance.OrderAddWithHttpInfo(orderAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderAdd** | [**OrderAdd**](OrderAdd.md) |  |  |

### Return type

[**OrderAdd200Response**](OrderAdd200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordercount"></a>
# **OrderCount**
> OrderCount200Response OrderCount (string? orderIds = null, string? ids = null, string? customerId = null, string? storeId = null, string? customerEmail = null, string? orderStatus = null, List<string>? orderStatusIds = null, string? ebayOrderStatus = null, string? financialStatus = null, List<string>? financialStatusIds = null, string? fulfillmentChannel = null, string? fulfillmentStatus = null, string? shippingMethod = null, string? deliveryMethod = null, string? tags = null, string? shipNodeType = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null)

order.count

Count orders in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderIds = 24,25;  // string? | Counts orders specified by order ids (optional) 
            var ids = 24,25;  // string? | Counts orders specified by ids (optional) 
            var customerId = 5;  // string? | Counts orders quantity specified by customer id (optional) 
            var storeId = 1;  // string? | Counts orders quantity specified by store id (optional) 
            var customerEmail = jubari@hannsgroup.com;  // string? | Counts orders quantity specified by customer email (optional) 
            var orderStatus = Completed;  // string? | Counts orders quantity specified by order status (optional) 
            var orderStatusIds = new List<string>?(); // List<string>? | Retrieves orders specified by order statuses (optional) 
            var ebayOrderStatus = Active;  // string? | Counts orders quantity specified by order status (optional) 
            var financialStatus = paid;  // string? | Counts orders quantity specified by financial status (optional) 
            var financialStatusIds = new List<string>?(); // List<string>? | Retrieves orders count specified by financial status ids (optional) 
            var fulfillmentChannel = local;  // string? | Retrieves order with a fulfillment channel (optional) 
            var fulfillmentStatus = fulfilled;  // string? | Create order with fulfillment status (optional) 
            var shippingMethod = flatrate_flatrate;  // string? | Retrieve entities according to shipping method (optional) 
            var deliveryMethod = local;  // string? | Retrieves order with delivery method (optional) 
            var tags = tag1,tag2;  // string? | Order tags (optional) 
            var shipNodeType = SellerFulfilled;  // string? | Retrieves order with ship node type (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 

            try
            {
                // order.count
                OrderCount200Response result = apiInstance.OrderCount(orderIds, ids, customerId, storeId, customerEmail, orderStatus, orderStatusIds, ebayOrderStatus, financialStatus, financialStatusIds, fulfillmentChannel, fulfillmentStatus, shippingMethod, deliveryMethod, tags, shipNodeType, createdFrom, createdTo, modifiedFrom, modifiedTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.count
    ApiResponse<OrderCount200Response> response = apiInstance.OrderCountWithHttpInfo(orderIds, ids, customerId, storeId, customerEmail, orderStatus, orderStatusIds, ebayOrderStatus, financialStatus, financialStatusIds, fulfillmentChannel, fulfillmentStatus, shippingMethod, deliveryMethod, tags, shipNodeType, createdFrom, createdTo, modifiedFrom, modifiedTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderIds** | **string?** | Counts orders specified by order ids | [optional]  |
| **ids** | **string?** | Counts orders specified by ids | [optional]  |
| **customerId** | **string?** | Counts orders quantity specified by customer id | [optional]  |
| **storeId** | **string?** | Counts orders quantity specified by store id | [optional]  |
| **customerEmail** | **string?** | Counts orders quantity specified by customer email | [optional]  |
| **orderStatus** | **string?** | Counts orders quantity specified by order status | [optional]  |
| **orderStatusIds** | [**List&lt;string&gt;?**](string.md) | Retrieves orders specified by order statuses | [optional]  |
| **ebayOrderStatus** | **string?** | Counts orders quantity specified by order status | [optional]  |
| **financialStatus** | **string?** | Counts orders quantity specified by financial status | [optional]  |
| **financialStatusIds** | [**List&lt;string&gt;?**](string.md) | Retrieves orders count specified by financial status ids | [optional]  |
| **fulfillmentChannel** | **string?** | Retrieves order with a fulfillment channel | [optional]  |
| **fulfillmentStatus** | **string?** | Create order with fulfillment status | [optional]  |
| **shippingMethod** | **string?** | Retrieve entities according to shipping method | [optional]  |
| **deliveryMethod** | **string?** | Retrieves order with delivery method | [optional]  |
| **tags** | **string?** | Order tags | [optional]  |
| **shipNodeType** | **string?** | Retrieves order with ship node type | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |

### Return type

[**OrderCount200Response**](OrderCount200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderfinancialstatuslist"></a>
# **OrderFinancialStatusList**
> OrderFinancialStatusList200Response OrderFinancialStatusList ()

order.financial_status.list

Retrieve list of financial statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderFinancialStatusListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);

            try
            {
                // order.financial_status.list
                OrderFinancialStatusList200Response result = apiInstance.OrderFinancialStatusList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderFinancialStatusList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderFinancialStatusListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.financial_status.list
    ApiResponse<OrderFinancialStatusList200Response> response = apiInstance.OrderFinancialStatusListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderFinancialStatusListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OrderFinancialStatusList200Response**](OrderFinancialStatusList200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderfulfillmentstatuslist"></a>
# **OrderFulfillmentStatusList**
> OrderFulfillmentStatusList200Response OrderFulfillmentStatusList (string? action = null)

order.fulfillment_status.list

Retrieve list of fulfillment statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderFulfillmentStatusListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var action = add;  // string? | Available statuses for the specified action. (optional) 

            try
            {
                // order.fulfillment_status.list
                OrderFulfillmentStatusList200Response result = apiInstance.OrderFulfillmentStatusList(action);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderFulfillmentStatusList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderFulfillmentStatusListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.fulfillment_status.list
    ApiResponse<OrderFulfillmentStatusList200Response> response = apiInstance.OrderFulfillmentStatusListWithHttpInfo(action);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderFulfillmentStatusListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **action** | **string?** | Available statuses for the specified action. | [optional]  |

### Return type

[**OrderFulfillmentStatusList200Response**](OrderFulfillmentStatusList200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderinfo"></a>
# **OrderInfo**
> OrderInfo200Response OrderInfo (string? id = null, string? orderId = null, string? storeId = null, string? varParams = null, string? responseFields = null, string? exclude = null, bool? enableCache = null, bool? useLatestApiVersion = null)

order.info

Info about a specific order by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var id = 10;  // string? | Retrieves order info specified by id (optional) 
            var orderId = 25;  // string? | Retrieves order’s info specified by order id (optional) 
            var storeId = 1;  // string? | Defines store id where the order should be found (optional) 
            var varParams = order_id,totals,status;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "order_id,customer,totals,address,items,bundles,status")
            var responseFields = {result{order_id,customer,totals,address,items,bundles,status}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = order_id,totals,status;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var enableCache = true;  // bool? | If the value is 'true' and order exist in our cache, we will return order.info response from cache (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // order.info
                OrderInfo200Response result = apiInstance.OrderInfo(id, orderId, storeId, varParams, responseFields, exclude, enableCache, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.info
    ApiResponse<OrderInfo200Response> response = apiInstance.OrderInfoWithHttpInfo(id, orderId, storeId, varParams, responseFields, exclude, enableCache, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string?** | Retrieves order info specified by id | [optional]  |
| **orderId** | **string?** | Retrieves order’s info specified by order id | [optional]  |
| **storeId** | **string?** | Defines store id where the order should be found | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;order_id,customer,totals,address,items,bundles,status&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **enableCache** | **bool?** | If the value is &#39;true&#39; and order exist in our cache, we will return order.info response from cache | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**OrderInfo200Response**](OrderInfo200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderlist"></a>
# **OrderList**
> ModelResponseOrderList OrderList (int? start = null, int? count = null, string? pageCursor = null, string? ids = null, string? orderIds = null, string? sinceId = null, string? storeId = null, string? customerId = null, string? customerEmail = null, string? basketId = null, string? currencyId = null, string? phone = null, string? orderStatus = null, List<string>? orderStatusIds = null, string? ebayOrderStatus = null, string? financialStatus = null, List<string>? financialStatusIds = null, string? fulfillmentStatus = null, string? returnStatus = null, string? fulfillmentChannel = null, string? shippingMethod = null, string? skipOrderIds = null, bool? isDeleted = null, string? shippingCountryIso3 = null, string? deliveryMethod = null, string? shipNodeType = null, string? createdTo = null, string? createdFrom = null, string? modifiedTo = null, string? modifiedFrom = null, string? tags = null, string? sortBy = null, string? sortDirection = null, string? varParams = null, string? responseFields = null, string? exclude = null, bool? enableCache = null, bool? useLatestApiVersion = null)

order.list

Get list of orders from store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve orders via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var ids = 24,25;  // string? | Retrieves orders specified by ids (optional) 
            var orderIds = 24,25;  // string? | Retrieves orders specified by order ids (optional) 
            var sinceId = 56;  // string? | Retrieve entities starting from the specified id. (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var customerId = 5;  // string? | Retrieves orders specified by customer id (optional) 
            var customerEmail = jubari@hannsgroup.com;  // string? | Retrieves orders specified by customer email (optional) 
            var basketId = 1;  // string? | Retrieves order’s info specified by basket id. (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var phone = 56686868654;  // string? | Filter orders by customer's phone number (optional) 
            var orderStatus = Completed;  // string? | Retrieves orders specified by order status (optional) 
            var orderStatusIds = new List<string>?(); // List<string>? | Retrieves orders specified by order statuses (optional) 
            var ebayOrderStatus = Active;  // string? | Retrieves orders specified by order status (optional) 
            var financialStatus = paid;  // string? | Retrieves orders specified by financial status (optional) 
            var financialStatusIds = new List<string>?(); // List<string>? | Retrieves orders specified by financial status ids (optional) 
            var fulfillmentStatus = fulfilled;  // string? | Create order with fulfillment status (optional) 
            var returnStatus = RETURNED;  // string? | Retrieves orders specified by return status (optional) 
            var fulfillmentChannel = local;  // string? | Retrieves order with a fulfillment channel (optional) 
            var shippingMethod = flatrate_flatrate;  // string? | Retrieve entities according to shipping method (optional) 
            var skipOrderIds = 24,25;  // string? | Skipped orders by ids (optional) 
            var isDeleted = true;  // bool? | Filter deleted orders (optional) 
            var shippingCountryIso3 = DEU;  // string? | Retrieve entities according to shipping country (optional) 
            var deliveryMethod = local;  // string? | Retrieves order with delivery method (optional) 
            var shipNodeType = SellerFulfilled;  // string? | Retrieves order with ship node type (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var tags = tag1,tag2;  // string? | Order tags (optional) 
            var sortBy = modified_at;  // string? | Set field to sort by (optional)  (default to "order_id")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "asc")
            var varParams = order_id,totals,status;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "order_id,customer,totals,address,items,bundles,status")
            var responseFields = {return_code,pagination,result{order{order_id,customer,totals,address,items,bundles,status}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = order_id,totals,status;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var enableCache = true;  // bool? | If the value is 'true', we will cache orders for a 15 minutes in order to increase speed and reduce requests throttling for some methods and shoping platforms (for example order.shipment.add) (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // order.list
                ModelResponseOrderList result = apiInstance.OrderList(start, count, pageCursor, ids, orderIds, sinceId, storeId, customerId, customerEmail, basketId, currencyId, phone, orderStatus, orderStatusIds, ebayOrderStatus, financialStatus, financialStatusIds, fulfillmentStatus, returnStatus, fulfillmentChannel, shippingMethod, skipOrderIds, isDeleted, shippingCountryIso3, deliveryMethod, shipNodeType, createdTo, createdFrom, modifiedTo, modifiedFrom, tags, sortBy, sortDirection, varParams, responseFields, exclude, enableCache, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.list
    ApiResponse<ModelResponseOrderList> response = apiInstance.OrderListWithHttpInfo(start, count, pageCursor, ids, orderIds, sinceId, storeId, customerId, customerEmail, basketId, currencyId, phone, orderStatus, orderStatusIds, ebayOrderStatus, financialStatus, financialStatusIds, fulfillmentStatus, returnStatus, fulfillmentChannel, shippingMethod, skipOrderIds, isDeleted, shippingCountryIso3, deliveryMethod, shipNodeType, createdTo, createdFrom, modifiedTo, modifiedFrom, tags, sortBy, sortDirection, varParams, responseFields, exclude, enableCache, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve orders via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **ids** | **string?** | Retrieves orders specified by ids | [optional]  |
| **orderIds** | **string?** | Retrieves orders specified by order ids | [optional]  |
| **sinceId** | **string?** | Retrieve entities starting from the specified id. | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **customerId** | **string?** | Retrieves orders specified by customer id | [optional]  |
| **customerEmail** | **string?** | Retrieves orders specified by customer email | [optional]  |
| **basketId** | **string?** | Retrieves order’s info specified by basket id. | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **phone** | **string?** | Filter orders by customer&#39;s phone number | [optional]  |
| **orderStatus** | **string?** | Retrieves orders specified by order status | [optional]  |
| **orderStatusIds** | [**List&lt;string&gt;?**](string.md) | Retrieves orders specified by order statuses | [optional]  |
| **ebayOrderStatus** | **string?** | Retrieves orders specified by order status | [optional]  |
| **financialStatus** | **string?** | Retrieves orders specified by financial status | [optional]  |
| **financialStatusIds** | [**List&lt;string&gt;?**](string.md) | Retrieves orders specified by financial status ids | [optional]  |
| **fulfillmentStatus** | **string?** | Create order with fulfillment status | [optional]  |
| **returnStatus** | **string?** | Retrieves orders specified by return status | [optional]  |
| **fulfillmentChannel** | **string?** | Retrieves order with a fulfillment channel | [optional]  |
| **shippingMethod** | **string?** | Retrieve entities according to shipping method | [optional]  |
| **skipOrderIds** | **string?** | Skipped orders by ids | [optional]  |
| **isDeleted** | **bool?** | Filter deleted orders | [optional]  |
| **shippingCountryIso3** | **string?** | Retrieve entities according to shipping country | [optional]  |
| **deliveryMethod** | **string?** | Retrieves order with delivery method | [optional]  |
| **shipNodeType** | **string?** | Retrieves order with ship node type | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **tags** | **string?** | Order tags | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;order_id&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;asc&quot;] |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;order_id,customer,totals,address,items,bundles,status&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **enableCache** | **bool?** | If the value is &#39;true&#39;, we will cache orders for a 15 minutes in order to increase speed and reduce requests throttling for some methods and shoping platforms (for example order.shipment.add) | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**ModelResponseOrderList**](ModelResponseOrderList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderpreestimateshippinglist"></a>
# **OrderPreestimateShippingList**
> ModelResponseOrderPreestimateShippingList OrderPreestimateShippingList (OrderPreestimateShippingList orderPreestimateShippingList)

order.preestimate_shipping.list

Retrieve list of order preestimated shipping methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderPreestimateShippingListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderPreestimateShippingList = new OrderPreestimateShippingList(); // OrderPreestimateShippingList | 

            try
            {
                // order.preestimate_shipping.list
                ModelResponseOrderPreestimateShippingList result = apiInstance.OrderPreestimateShippingList(orderPreestimateShippingList);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderPreestimateShippingList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderPreestimateShippingListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.preestimate_shipping.list
    ApiResponse<ModelResponseOrderPreestimateShippingList> response = apiInstance.OrderPreestimateShippingListWithHttpInfo(orderPreestimateShippingList);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderPreestimateShippingListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderPreestimateShippingList** | [**OrderPreestimateShippingList**](OrderPreestimateShippingList.md) |  |  |

### Return type

[**ModelResponseOrderPreestimateShippingList**](ModelResponseOrderPreestimateShippingList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderrefundadd"></a>
# **OrderRefundAdd**
> OrderRefundAdd200Response OrderRefundAdd (OrderRefundAdd orderRefundAdd)

order.refund.add

Add a refund to the order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderRefundAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderRefundAdd = new OrderRefundAdd(); // OrderRefundAdd | 

            try
            {
                // order.refund.add
                OrderRefundAdd200Response result = apiInstance.OrderRefundAdd(orderRefundAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderRefundAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderRefundAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.refund.add
    ApiResponse<OrderRefundAdd200Response> response = apiInstance.OrderRefundAddWithHttpInfo(orderRefundAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderRefundAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderRefundAdd** | [**OrderRefundAdd**](OrderRefundAdd.md) |  |  |

### Return type

[**OrderRefundAdd200Response**](OrderRefundAdd200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderreturnadd"></a>
# **OrderReturnAdd**
> OrderReturnAdd200Response OrderReturnAdd (OrderReturnAdd orderReturnAdd)

order.return.add

Create new return request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderReturnAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderReturnAdd = new OrderReturnAdd(); // OrderReturnAdd | 

            try
            {
                // order.return.add
                OrderReturnAdd200Response result = apiInstance.OrderReturnAdd(orderReturnAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderReturnAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderReturnAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.return.add
    ApiResponse<OrderReturnAdd200Response> response = apiInstance.OrderReturnAddWithHttpInfo(orderReturnAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderReturnAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderReturnAdd** | [**OrderReturnAdd**](OrderReturnAdd.md) |  |  |

### Return type

[**OrderReturnAdd200Response**](OrderReturnAdd200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderreturndelete"></a>
# **OrderReturnDelete**
> AttributeValueDelete200Response OrderReturnDelete (string returnId, string orderId, string? storeId = null)

order.return.delete

Delete return.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderReturnDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var returnId = 200000002;  // string | Return ID
            var orderId = 25;  // string | Defines the order id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // order.return.delete
                AttributeValueDelete200Response result = apiInstance.OrderReturnDelete(returnId, orderId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderReturnDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderReturnDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.return.delete
    ApiResponse<AttributeValueDelete200Response> response = apiInstance.OrderReturnDeleteWithHttpInfo(returnId, orderId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderReturnDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnId** | **string** | Return ID |  |
| **orderId** | **string** | Defines the order id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**AttributeValueDelete200Response**](AttributeValueDelete200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderreturnupdate"></a>
# **OrderReturnUpdate**
> AccountConfigUpdate200Response OrderReturnUpdate (OrderReturnUpdate orderReturnUpdate)

order.return.update

Update order's shipment information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderReturnUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderReturnUpdate = new OrderReturnUpdate(); // OrderReturnUpdate | 

            try
            {
                // order.return.update
                AccountConfigUpdate200Response result = apiInstance.OrderReturnUpdate(orderReturnUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderReturnUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderReturnUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.return.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.OrderReturnUpdateWithHttpInfo(orderReturnUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderReturnUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderReturnUpdate** | [**OrderReturnUpdate**](OrderReturnUpdate.md) |  |  |

### Return type

[**AccountConfigUpdate200Response**](AccountConfigUpdate200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentadd"></a>
# **OrderShipmentAdd**
> OrderShipmentAdd200Response OrderShipmentAdd (OrderShipmentAdd orderShipmentAdd)

order.shipment.add

Add a shipment to the order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderShipmentAdd = new OrderShipmentAdd(); // OrderShipmentAdd | 

            try
            {
                // order.shipment.add
                OrderShipmentAdd200Response result = apiInstance.OrderShipmentAdd(orderShipmentAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.add
    ApiResponse<OrderShipmentAdd200Response> response = apiInstance.OrderShipmentAddWithHttpInfo(orderShipmentAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderShipmentAdd** | [**OrderShipmentAdd**](OrderShipmentAdd.md) |  |  |

### Return type

[**OrderShipmentAdd200Response**](OrderShipmentAdd200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentaddbatch"></a>
# **OrderShipmentAddBatch**
> CategoryAddBatch200Response OrderShipmentAddBatch (OrderShipmentAddBatch orderShipmentAddBatch)

order.shipment.add.batch

Add a shipments to the orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentAddBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderShipmentAddBatch = new OrderShipmentAddBatch(); // OrderShipmentAddBatch | 

            try
            {
                // order.shipment.add.batch
                CategoryAddBatch200Response result = apiInstance.OrderShipmentAddBatch(orderShipmentAddBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentAddBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentAddBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.add.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.OrderShipmentAddBatchWithHttpInfo(orderShipmentAddBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentAddBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderShipmentAddBatch** | [**OrderShipmentAddBatch**](OrderShipmentAddBatch.md) |  |  |

### Return type

[**CategoryAddBatch200Response**](CategoryAddBatch200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentdelete"></a>
# **OrderShipmentDelete**
> OrderShipmentDelete200Response OrderShipmentDelete (string shipmentId, string orderId, string? storeId = null)

order.shipment.delete

Delete order's shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var shipmentId = 200000002;  // string | Shipment id indicates the number of delivery
            var orderId = 25;  // string | Defines the order for which the shipment will be deleted
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // order.shipment.delete
                OrderShipmentDelete200Response result = apiInstance.OrderShipmentDelete(shipmentId, orderId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.delete
    ApiResponse<OrderShipmentDelete200Response> response = apiInstance.OrderShipmentDeleteWithHttpInfo(shipmentId, orderId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | Shipment id indicates the number of delivery |  |
| **orderId** | **string** | Defines the order for which the shipment will be deleted |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**OrderShipmentDelete200Response**](OrderShipmentDelete200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentinfo"></a>
# **OrderShipmentInfo**
> OrderShipmentInfo200Response OrderShipmentInfo (string id, string orderId, int? start = null, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

order.shipment.info

Get information of shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var id = 10;  // string | Entity id
            var orderId = 25;  // string | Defines the order id
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {result{id,order_id,shipment_provider,tracking_numbers{tracking_number},items{product_id,quantity}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,order_id,items,tracking_numbers")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // order.shipment.info
                OrderShipmentInfo200Response result = apiInstance.OrderShipmentInfo(id, orderId, start, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.info
    ApiResponse<OrderShipmentInfo200Response> response = apiInstance.OrderShipmentInfoWithHttpInfo(id, orderId, start, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **orderId** | **string** | Defines the order id |  |
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,order_id,items,tracking_numbers&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**OrderShipmentInfo200Response**](OrderShipmentInfo200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentlist"></a>
# **OrderShipmentList**
> ModelResponseOrderShipmentList OrderShipmentList (string orderId, int? start = null, int? count = null, string? pageCursor = null, string? storeId = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? responseFields = null, string? varParams = null, string? exclude = null)

order.shipment.list

Get list of shipments per order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderId = 25;  // string | Retrieves shipments specified by order id
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var responseFields = {status_code,pagination,result{shipment{id,order_id,shipment_provider,tracking_numbers{tracking_number},items{product_id,quantity}}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,order_id,items,tracking_numbers")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // order.shipment.list
                ModelResponseOrderShipmentList result = apiInstance.OrderShipmentList(orderId, start, count, pageCursor, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.list
    ApiResponse<ModelResponseOrderShipmentList> response = apiInstance.OrderShipmentListWithHttpInfo(orderId, start, count, pageCursor, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **string** | Retrieves shipments specified by order id |  |
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,order_id,items,tracking_numbers&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseOrderShipmentList**](ModelResponseOrderShipmentList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmenttrackingadd"></a>
# **OrderShipmentTrackingAdd**
> OrderShipmentTrackingAdd200Response OrderShipmentTrackingAdd (OrderShipmentTrackingAdd orderShipmentTrackingAdd)

order.shipment.tracking.add

Add order shipment's tracking info.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentTrackingAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderShipmentTrackingAdd = new OrderShipmentTrackingAdd(); // OrderShipmentTrackingAdd | 

            try
            {
                // order.shipment.tracking.add
                OrderShipmentTrackingAdd200Response result = apiInstance.OrderShipmentTrackingAdd(orderShipmentTrackingAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentTrackingAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentTrackingAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.tracking.add
    ApiResponse<OrderShipmentTrackingAdd200Response> response = apiInstance.OrderShipmentTrackingAddWithHttpInfo(orderShipmentTrackingAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentTrackingAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderShipmentTrackingAdd** | [**OrderShipmentTrackingAdd**](OrderShipmentTrackingAdd.md) |  |  |

### Return type

[**OrderShipmentTrackingAdd200Response**](OrderShipmentTrackingAdd200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordershipmentupdate"></a>
# **OrderShipmentUpdate**
> AccountConfigUpdate200Response OrderShipmentUpdate (OrderShipmentUpdate orderShipmentUpdate)

order.shipment.update

Update order's shipment information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderShipmentUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderShipmentUpdate = new OrderShipmentUpdate(); // OrderShipmentUpdate | 

            try
            {
                // order.shipment.update
                AccountConfigUpdate200Response result = apiInstance.OrderShipmentUpdate(orderShipmentUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderShipmentUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderShipmentUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.shipment.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.OrderShipmentUpdateWithHttpInfo(orderShipmentUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderShipmentUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderShipmentUpdate** | [**OrderShipmentUpdate**](OrderShipmentUpdate.md) |  |  |

### Return type

[**AccountConfigUpdate200Response**](AccountConfigUpdate200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderstatuslist"></a>
# **OrderStatusList**
> ModelResponseOrderStatusList OrderStatusList (string? storeId = null, string? action = null, string? responseFields = null)

order.status.list

Retrieve list of statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderStatusListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var storeId = 1;  // string? | Store Id (optional) 
            var action = add;  // string? | Available statuses for the specified action. (optional) 
            var responseFields = {return_code,return_message,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 

            try
            {
                // order.status.list
                ModelResponseOrderStatusList result = apiInstance.OrderStatusList(storeId, action, responseFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderStatusList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderStatusListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.status.list
    ApiResponse<ModelResponseOrderStatusList> response = apiInstance.OrderStatusListWithHttpInfo(storeId, action, responseFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderStatusListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** | Store Id | [optional]  |
| **action** | **string?** | Available statuses for the specified action. | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |

### Return type

[**ModelResponseOrderStatusList**](ModelResponseOrderStatusList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordertransactionlist"></a>
# **OrderTransactionList**
> ModelResponseOrderTransactionList OrderTransactionList (string orderIds, int? count = null, string? pageCursor = null, string? storeId = null, string? varParams = null, string? responseFields = null, string? exclude = null)

order.transaction.list

Retrieve list of order transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderTransactionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderIds = 24,25;  // string | Retrieves order transactions specified by order ids
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,order_id,amount,description")
            var responseFields = {return_code,pagination,result{transactions_count,transactions{id,transaction_id,status,description,settlement_amount,gateway,card_brand,card_last_four}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // order.transaction.list
                ModelResponseOrderTransactionList result = apiInstance.OrderTransactionList(orderIds, count, pageCursor, storeId, varParams, responseFields, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderTransactionList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderTransactionListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.transaction.list
    ApiResponse<ModelResponseOrderTransactionList> response = apiInstance.OrderTransactionListWithHttpInfo(orderIds, count, pageCursor, storeId, varParams, responseFields, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderTransactionListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderIds** | **string** | Retrieves order transactions specified by order ids |  |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,order_id,amount,description&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseOrderTransactionList**](ModelResponseOrderTransactionList.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderupdate"></a>
# **OrderUpdate**
> AccountConfigUpdate200Response OrderUpdate (string orderId, string? storeId = null, string? orderStatus = null, string? financialStatus = null, string? fulfillmentStatus = null, string? cancellationReason = null, string? orderPaymentMethod = null, string? comment = null, string? adminComment = null, string? adminPrivateComment = null, string? invoiceAdminComment = null, string? dateModified = null, string? dateFinished = null, bool? sendNotifications = null, bool? createInvoice = null, string? origin = null, string? tags = null)

order.update

Update existing order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrderUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OrderApi(config);
            var orderId = 25;  // string | Defines the orders specified by order id
            var storeId = 1;  // string? | Defines store id where the order should be found (optional) 
            var orderStatus = Completed;  // string? | Defines new order's status (optional) 
            var financialStatus = paid;  // string? | Update order financial status to specified (optional) 
            var fulfillmentStatus = fulfilled;  // string? | Create order with fulfillment status (optional) 
            var cancellationReason = ORDER_UNPAID;  // string? | Defines the cancellation reason when the order will be canceled (optional) 
            var orderPaymentMethod = PayPal;  // string? | Defines order payment method.<br/>Setting order_payment_method on Shopify will also change financial_status field value to 'paid' (optional) 
            var comment = This coole order;  // string? | Specifies order comment (optional) 
            var adminComment = Test admin comment;  // string? | Specifies admin's order comment (optional) 
            var adminPrivateComment = Test admin private comment;  // string? | Specifies private admin's order comment (optional) 
            var invoiceAdminComment = Test admin comment;  // string? | Specifies admin's order invoice comment (optional) 
            var dateModified = 2014-05-05 05:05:00;  // string? | Specifies order's  modification date (optional) 
            var dateFinished = 2014-06-05 05:05:00;  // string? | Specifies order's  finished date (optional) 
            var sendNotifications = true;  // bool? | Send notifications to customer after order was created (optional)  (default to false)
            var createInvoice = true;  // bool? | Determines whether an invoice should be created if it has not already been created (optional) 
            var origin = newsletter;  // string? | The source of the order (optional) 
            var tags = tag1,tag2;  // string? | Order tags (optional) 

            try
            {
                // order.update
                AccountConfigUpdate200Response result = apiInstance.OrderUpdate(orderId, storeId, orderStatus, financialStatus, fulfillmentStatus, cancellationReason, orderPaymentMethod, comment, adminComment, adminPrivateComment, invoiceAdminComment, dateModified, dateFinished, sendNotifications, createInvoice, origin, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // order.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.OrderUpdateWithHttpInfo(orderId, storeId, orderStatus, financialStatus, fulfillmentStatus, cancellationReason, orderPaymentMethod, comment, adminComment, adminPrivateComment, invoiceAdminComment, dateModified, dateFinished, sendNotifications, createInvoice, origin, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **string** | Defines the orders specified by order id |  |
| **storeId** | **string?** | Defines store id where the order should be found | [optional]  |
| **orderStatus** | **string?** | Defines new order&#39;s status | [optional]  |
| **financialStatus** | **string?** | Update order financial status to specified | [optional]  |
| **fulfillmentStatus** | **string?** | Create order with fulfillment status | [optional]  |
| **cancellationReason** | **string?** | Defines the cancellation reason when the order will be canceled | [optional]  |
| **orderPaymentMethod** | **string?** | Defines order payment method.&lt;br/&gt;Setting order_payment_method on Shopify will also change financial_status field value to &#39;paid&#39; | [optional]  |
| **comment** | **string?** | Specifies order comment | [optional]  |
| **adminComment** | **string?** | Specifies admin&#39;s order comment | [optional]  |
| **adminPrivateComment** | **string?** | Specifies private admin&#39;s order comment | [optional]  |
| **invoiceAdminComment** | **string?** | Specifies admin&#39;s order invoice comment | [optional]  |
| **dateModified** | **string?** | Specifies order&#39;s  modification date | [optional]  |
| **dateFinished** | **string?** | Specifies order&#39;s  finished date | [optional]  |
| **sendNotifications** | **bool?** | Send notifications to customer after order was created | [optional] [default to false] |
| **createInvoice** | **bool?** | Determines whether an invoice should be created if it has not already been created | [optional]  |
| **origin** | **string?** | The source of the order | [optional]  |
| **tags** | **string?** | Order tags | [optional]  |

### Return type

[**AccountConfigUpdate200Response**](AccountConfigUpdate200Response.md)

### Authorization

[StoreKeyAuth](../README.md#StoreKeyAuth), [ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

