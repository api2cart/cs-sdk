# Org.OpenAPITools.Api.ReturnApi

All URIs are relative to *https://api.api2cart.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReturnActionList**](ReturnApi.md#returnactionlist) | **GET** /return.action.list.json | return.action.list |
| [**ReturnCount**](ReturnApi.md#returncount) | **GET** /return.count.json | return.count |
| [**ReturnInfo**](ReturnApi.md#returninfo) | **GET** /return.info.json | return.info |
| [**ReturnList**](ReturnApi.md#returnlist) | **GET** /return.list.json | return.list |
| [**ReturnReasonList**](ReturnApi.md#returnreasonlist) | **GET** /return.reason.list.json | return.reason.list |
| [**ReturnStatusList**](ReturnApi.md#returnstatuslist) | **GET** /return.status.list.json | return.status.list |

<a id="returnactionlist"></a>
# **ReturnActionList**
> ReturnActionList200Response ReturnActionList ()

return.action.list

Retrieve list of return actions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnActionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);

            try
            {
                // return.action.list
                ReturnActionList200Response result = apiInstance.ReturnActionList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnActionList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnActionListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.action.list
    ApiResponse<ReturnActionList200Response> response = apiInstance.ReturnActionListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnActionListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ReturnActionList200Response**](ReturnActionList200Response.md)

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

<a id="returncount"></a>
# **ReturnCount**
> ReturnCount200Response ReturnCount (string? orderIds = null, string? customerId = null, string? storeId = null, string? status = null, string? returnType = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? reportRequestId = null, bool? disableReportCache = null)

return.count

Count returns in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);
            var orderIds = 24,25;  // string? | Counts return requests specified by order ids (optional) 
            var customerId = 5;  // string? | Counts return requests quantity specified by customer id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var status = disabled;  // string? | Defines status (optional) 
            var returnType = FBA;  // string? | Retrieves returns specified by return type (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)

            try
            {
                // return.count
                ReturnCount200Response result = apiInstance.ReturnCount(orderIds, customerId, storeId, status, returnType, createdFrom, createdTo, modifiedFrom, modifiedTo, reportRequestId, disableReportCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.count
    ApiResponse<ReturnCount200Response> response = apiInstance.ReturnCountWithHttpInfo(orderIds, customerId, storeId, status, returnType, createdFrom, createdTo, modifiedFrom, modifiedTo, reportRequestId, disableReportCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderIds** | **string?** | Counts return requests specified by order ids | [optional]  |
| **customerId** | **string?** | Counts return requests quantity specified by customer id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **status** | **string?** | Defines status | [optional]  |
| **returnType** | **string?** | Retrieves returns specified by return type | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |

### Return type

[**ReturnCount200Response**](ReturnCount200Response.md)

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

<a id="returninfo"></a>
# **ReturnInfo**
> ReturnInfo200Response ReturnInfo (string id, string? orderId = null, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

return.info

Retrieve return information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);
            var id = 10;  // string | Entity id
            var orderId = 25;  // string? | Defines the order id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {return_code,return_message,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,order_products;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,order_products")
            var exclude = id,order_id;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // return.info
                ReturnInfo200Response result = apiInstance.ReturnInfo(id, orderId, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.info
    ApiResponse<ReturnInfo200Response> response = apiInstance.ReturnInfoWithHttpInfo(id, orderId, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **orderId** | **string?** | Defines the order id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,order_products&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ReturnInfo200Response**](ReturnInfo200Response.md)

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

<a id="returnlist"></a>
# **ReturnList**
> ModelResponseReturnList ReturnList (int? start = null, int? count = null, string? pageCursor = null, string? orderId = null, string? orderIds = null, string? customerId = null, string? storeId = null, string? status = null, string? returnType = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? responseFields = null, string? varParams = null, string? exclude = null, string? reportRequestId = null, bool? disableReportCache = null)

return.list

Get list of return requests from store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var orderId = 25;  // string? | Defines the order id (optional) 
            var orderIds = 24,25;  // string? | Retrieves return requests specified by order ids (optional) 
            var customerId = 5;  // string? | Retrieves return requests specified by customer id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var status = disabled;  // string? | Defines status (optional) 
            var returnType = FBA;  // string? | Retrieves returns specified by return type (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var responseFields = {return_code,return_message,pagination,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,order_products;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,order_products")
            var exclude = id,order_id;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)

            try
            {
                // return.list
                ModelResponseReturnList result = apiInstance.ReturnList(start, count, pageCursor, orderId, orderIds, customerId, storeId, status, returnType, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude, reportRequestId, disableReportCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.list
    ApiResponse<ModelResponseReturnList> response = apiInstance.ReturnListWithHttpInfo(start, count, pageCursor, orderId, orderIds, customerId, storeId, status, returnType, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude, reportRequestId, disableReportCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnListWithHttpInfo: " + e.Message);
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
| **orderId** | **string?** | Defines the order id | [optional]  |
| **orderIds** | **string?** | Retrieves return requests specified by order ids | [optional]  |
| **customerId** | **string?** | Retrieves return requests specified by customer id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **status** | **string?** | Defines status | [optional]  |
| **returnType** | **string?** | Retrieves returns specified by return type | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,order_products&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |

### Return type

[**ModelResponseReturnList**](ModelResponseReturnList.md)

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

<a id="returnreasonlist"></a>
# **ReturnReasonList**
> ReturnReasonList200Response ReturnReasonList (string? storeId = null)

return.reason.list

Retrieve list of return reasons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReturnReasonListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // return.reason.list
                ReturnReasonList200Response result = apiInstance.ReturnReasonList(storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnReasonList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnReasonListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.reason.list
    ApiResponse<ReturnReasonList200Response> response = apiInstance.ReturnReasonListWithHttpInfo(storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnReasonListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**ReturnReasonList200Response**](ReturnReasonList200Response.md)

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

<a id="returnstatuslist"></a>
# **ReturnStatusList**
> ReturnStatusList200Response ReturnStatusList ()

return.status.list

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
    public class ReturnStatusListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: StoreKeyAuth
            config.AddApiKey("x-store-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-store-key", "Bearer");
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ReturnApi(config);

            try
            {
                // return.status.list
                ReturnStatusList200Response result = apiInstance.ReturnStatusList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnStatusList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnStatusListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // return.status.list
    ApiResponse<ReturnStatusList200Response> response = apiInstance.ReturnStatusListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnApi.ReturnStatusListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ReturnStatusList200Response**](ReturnStatusList200Response.md)

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

