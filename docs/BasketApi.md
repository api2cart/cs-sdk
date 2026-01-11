# Org.OpenAPITools.Api.BasketApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BasketInfo**](BasketApi.md#basketinfo) | **GET** /basket.info.json | basket.info |
| [**BasketItemAdd**](BasketApi.md#basketitemadd) | **POST** /basket.item.add.json | basket.item.add |
| [**BasketLiveShippingServiceCreate**](BasketApi.md#basketliveshippingservicecreate) | **POST** /basket.live_shipping_service.create.json | basket.live_shipping_service.create |
| [**BasketLiveShippingServiceDelete**](BasketApi.md#basketliveshippingservicedelete) | **DELETE** /basket.live_shipping_service.delete.json | basket.live_shipping_service.delete |
| [**BasketLiveShippingServiceList**](BasketApi.md#basketliveshippingservicelist) | **GET** /basket.live_shipping_service.list.json | basket.live_shipping_service.list |

<a id="basketinfo"></a>
# **BasketInfo**
> BasketInfo200Response BasketInfo (string id, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

basket.info

Retrieve basket information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BasketInfoExample
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

            var apiInstance = new BasketApi(config);
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // basket.info
                BasketInfo200Response result = apiInstance.BasketInfo(id, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasketApi.BasketInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BasketInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // basket.info
    ApiResponse<BasketInfo200Response> response = apiInstance.BasketInfoWithHttpInfo(id, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasketApi.BasketInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**BasketInfo200Response**](BasketInfo200Response.md)

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

<a id="basketitemadd"></a>
# **BasketItemAdd**
> BasketItemAdd200Response BasketItemAdd (string customerId, string productId, string? variantId = null, decimal? quantity = null, string? storeId = null, string? idempotencyKey = null)

basket.item.add

Add item to basket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BasketItemAddExample
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

            var apiInstance = new BasketApi(config);
            var customerId = 5;  // string | Retrieves orders specified by customer id
            var productId = 10;  // string | Defines id of the product which should be added to the basket
            var variantId = 45;  // string? | Defines product's variants specified by variant id (optional) 
            var quantity = 6;  // decimal? | Defines new items quantity (optional)  (default to 0M)
            var storeId = 1;  // string? | Store Id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // basket.item.add
                BasketItemAdd200Response result = apiInstance.BasketItemAdd(customerId, productId, variantId, quantity, storeId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasketApi.BasketItemAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BasketItemAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // basket.item.add
    ApiResponse<BasketItemAdd200Response> response = apiInstance.BasketItemAddWithHttpInfo(customerId, productId, variantId, quantity, storeId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasketApi.BasketItemAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Retrieves orders specified by customer id |  |
| **productId** | **string** | Defines id of the product which should be added to the basket |  |
| **variantId** | **string?** | Defines product&#39;s variants specified by variant id | [optional]  |
| **quantity** | **decimal?** | Defines new items quantity | [optional] [default to 0M] |
| **storeId** | **string?** | Store Id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**BasketItemAdd200Response**](BasketItemAdd200Response.md)

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

<a id="basketliveshippingservicecreate"></a>
# **BasketLiveShippingServiceCreate**
> BasketLiveShippingServiceCreate200Response BasketLiveShippingServiceCreate (string name, string callback, string? storeId = null, string? idempotencyKey = null)

basket.live_shipping_service.create

Create live shipping rate service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BasketLiveShippingServiceCreateExample
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

            var apiInstance = new BasketApi(config);
            var name = BestDelivery;  // string | Shipping Service Name
            var callback = https://example.com/callback;  // string | Callback url that returns shipping rates. It should be able to accept POST requests with json data.
            var storeId = 1;  // string? | Store Id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // basket.live_shipping_service.create
                BasketLiveShippingServiceCreate200Response result = apiInstance.BasketLiveShippingServiceCreate(name, callback, storeId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BasketLiveShippingServiceCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // basket.live_shipping_service.create
    ApiResponse<BasketLiveShippingServiceCreate200Response> response = apiInstance.BasketLiveShippingServiceCreateWithHttpInfo(name, callback, storeId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Shipping Service Name |  |
| **callback** | **string** | Callback url that returns shipping rates. It should be able to accept POST requests with json data. |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**BasketLiveShippingServiceCreate200Response**](BasketLiveShippingServiceCreate200Response.md)

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

<a id="basketliveshippingservicedelete"></a>
# **BasketLiveShippingServiceDelete**
> BasketLiveShippingServiceDelete200Response BasketLiveShippingServiceDelete (int id)

basket.live_shipping_service.delete

Delete live shipping rate service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BasketLiveShippingServiceDeleteExample
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

            var apiInstance = new BasketApi(config);
            var id = 5;  // int | Entity id

            try
            {
                // basket.live_shipping_service.delete
                BasketLiveShippingServiceDelete200Response result = apiInstance.BasketLiveShippingServiceDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BasketLiveShippingServiceDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // basket.live_shipping_service.delete
    ApiResponse<BasketLiveShippingServiceDelete200Response> response = apiInstance.BasketLiveShippingServiceDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Entity id |  |

### Return type

[**BasketLiveShippingServiceDelete200Response**](BasketLiveShippingServiceDelete200Response.md)

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

<a id="basketliveshippingservicelist"></a>
# **BasketLiveShippingServiceList**
> BasketLiveShippingServiceList200Response BasketLiveShippingServiceList (int? start = null, int? count = null, string? storeId = null)

basket.live_shipping_service.list

Retrieve a list of live shipping rate services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BasketLiveShippingServiceListExample
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

            var apiInstance = new BasketApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // basket.live_shipping_service.list
                BasketLiveShippingServiceList200Response result = apiInstance.BasketLiveShippingServiceList(start, count, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BasketLiveShippingServiceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // basket.live_shipping_service.list
    ApiResponse<BasketLiveShippingServiceList200Response> response = apiInstance.BasketLiveShippingServiceListWithHttpInfo(start, count, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasketApi.BasketLiveShippingServiceListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**BasketLiveShippingServiceList200Response**](BasketLiveShippingServiceList200Response.md)

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

