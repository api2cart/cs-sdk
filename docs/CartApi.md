# Org.OpenAPITools.Api.CartApi

All URIs are relative to *https://api.api2cart.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CartBridge**](CartApi.md#cartbridge) | **GET** /cart.bridge.json | cart.bridge |
| [**CartCatalogPriceRulesCount**](CartApi.md#cartcatalogpricerulescount) | **GET** /cart.catalog_price_rules.count.json | cart.catalog_price_rules.count |
| [**CartCatalogPriceRulesList**](CartApi.md#cartcatalogpriceruleslist) | **GET** /cart.catalog_price_rules.list.json | cart.catalog_price_rules.list |
| [**CartClearCache**](CartApi.md#cartclearcache) | **POST** /cart.clear_cache.json | cart.clear_cache |
| [**CartConfig**](CartApi.md#cartconfig) | **GET** /cart.config.json | cart.config |
| [**CartConfigUpdate**](CartApi.md#cartconfigupdate) | **PUT** /cart.config.update.json | cart.config.update |
| [**CartCouponAdd**](CartApi.md#cartcouponadd) | **POST** /cart.coupon.add.json | cart.coupon.add |
| [**CartCouponConditionAdd**](CartApi.md#cartcouponconditionadd) | **POST** /cart.coupon.condition.add.json | cart.coupon.condition.add |
| [**CartCouponCount**](CartApi.md#cartcouponcount) | **GET** /cart.coupon.count.json | cart.coupon.count |
| [**CartCouponDelete**](CartApi.md#cartcoupondelete) | **DELETE** /cart.coupon.delete.json | cart.coupon.delete |
| [**CartCouponList**](CartApi.md#cartcouponlist) | **GET** /cart.coupon.list.json | cart.coupon.list |
| [**CartCreate**](CartApi.md#cartcreate) | **POST** /cart.create.json | cart.create |
| [**CartDelete**](CartApi.md#cartdelete) | **DELETE** /cart.delete.json | cart.delete |
| [**CartDisconnect**](CartApi.md#cartdisconnect) | **GET** /cart.disconnect.json | cart.disconnect |
| [**CartGiftcardAdd**](CartApi.md#cartgiftcardadd) | **POST** /cart.giftcard.add.json | cart.giftcard.add |
| [**CartGiftcardCount**](CartApi.md#cartgiftcardcount) | **GET** /cart.giftcard.count.json | cart.giftcard.count |
| [**CartGiftcardDelete**](CartApi.md#cartgiftcarddelete) | **DELETE** /cart.giftcard.delete.json | cart.giftcard.delete |
| [**CartGiftcardList**](CartApi.md#cartgiftcardlist) | **GET** /cart.giftcard.list.json | cart.giftcard.list |
| [**CartInfo**](CartApi.md#cartinfo) | **GET** /cart.info.json | cart.info |
| [**CartList**](CartApi.md#cartlist) | **GET** /cart.list.json | cart.list |
| [**CartMetaDataList**](CartApi.md#cartmetadatalist) | **GET** /cart.meta_data.list.json | cart.meta_data.list |
| [**CartMetaDataSet**](CartApi.md#cartmetadataset) | **POST** /cart.meta_data.set.json | cart.meta_data.set |
| [**CartMetaDataUnset**](CartApi.md#cartmetadataunset) | **DELETE** /cart.meta_data.unset.json | cart.meta_data.unset |
| [**CartMethods**](CartApi.md#cartmethods) | **GET** /cart.methods.json | cart.methods |
| [**CartPluginList**](CartApi.md#cartpluginlist) | **GET** /cart.plugin.list.json | cart.plugin.list |
| [**CartScriptAdd**](CartApi.md#cartscriptadd) | **POST** /cart.script.add.json | cart.script.add |
| [**CartScriptDelete**](CartApi.md#cartscriptdelete) | **DELETE** /cart.script.delete.json | cart.script.delete |
| [**CartScriptList**](CartApi.md#cartscriptlist) | **GET** /cart.script.list.json | cart.script.list |
| [**CartShippingZonesList**](CartApi.md#cartshippingzoneslist) | **GET** /cart.shipping_zones.list.json | cart.shipping_zones.list |
| [**CartValidate**](CartApi.md#cartvalidate) | **GET** /cart.validate.json | cart.validate |

<a id="cartbridge"></a>
# **CartBridge**
> CartBridge200Response CartBridge ()

cart.bridge

Get bridge key and store key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartBridgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CartApi(config);

            try
            {
                // cart.bridge
                CartBridge200Response result = apiInstance.CartBridge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartBridge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartBridgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.bridge
    ApiResponse<CartBridge200Response> response = apiInstance.CartBridgeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartBridgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CartBridge200Response**](CartBridge200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cartcatalogpricerulescount"></a>
# **CartCatalogPriceRulesCount**
> CartCatalogPriceRulesCount200Response CartCatalogPriceRulesCount ()

cart.catalog_price_rules.count

Get count of cart catalog price rules discounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCatalogPriceRulesCountExample
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

            var apiInstance = new CartApi(config);

            try
            {
                // cart.catalog_price_rules.count
                CartCatalogPriceRulesCount200Response result = apiInstance.CartCatalogPriceRulesCount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCatalogPriceRulesCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCatalogPriceRulesCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.catalog_price_rules.count
    ApiResponse<CartCatalogPriceRulesCount200Response> response = apiInstance.CartCatalogPriceRulesCountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCatalogPriceRulesCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CartCatalogPriceRulesCount200Response**](CartCatalogPriceRulesCount200Response.md)

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

<a id="cartcatalogpriceruleslist"></a>
# **CartCatalogPriceRulesList**
> ModelResponseCartCatalogPriceRulesList CartCatalogPriceRulesList (int? start = null, int? count = null, string? pageCursor = null, string? ids = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.catalog_price_rules.list

Get cart catalog price rules discounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCatalogPriceRulesListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var ids = 24,25;  // string? | Retrieves  catalog_price_rules by ids (optional) 
            var responseFields = {result{catalog_price_rules_count,catalog_price_rules{id,type,name,avail,usage_count,actions,conditions}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,description")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.catalog_price_rules.list
                ModelResponseCartCatalogPriceRulesList result = apiInstance.CartCatalogPriceRulesList(start, count, pageCursor, ids, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCatalogPriceRulesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCatalogPriceRulesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.catalog_price_rules.list
    ApiResponse<ModelResponseCartCatalogPriceRulesList> response = apiInstance.CartCatalogPriceRulesListWithHttpInfo(start, count, pageCursor, ids, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCatalogPriceRulesListWithHttpInfo: " + e.Message);
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
| **ids** | **string?** | Retrieves  catalog_price_rules by ids | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,description&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartCatalogPriceRulesList**](ModelResponseCartCatalogPriceRulesList.md)

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

<a id="cartclearcache"></a>
# **CartClearCache**
> CartClearCache200Response CartClearCache (string cacheType)

cart.clear_cache

Clear cache on store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartClearCacheExample
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

            var apiInstance = new CartApi(config);
            var cacheType = storage_cache;  // string | Defines which cache should be cleared.

            try
            {
                // cart.clear_cache
                CartClearCache200Response result = apiInstance.CartClearCache(cacheType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartClearCache: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartClearCacheWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.clear_cache
    ApiResponse<CartClearCache200Response> response = apiInstance.CartClearCacheWithHttpInfo(cacheType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartClearCacheWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cacheType** | **string** | Defines which cache should be cleared. |  |

### Return type

[**CartClearCache200Response**](CartClearCache200Response.md)

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

<a id="cartconfig"></a>
# **CartConfig**
> CartConfig200Response CartConfig (string? varParams = null, string? exclude = null)

cart.config

Get list of cart configs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartConfigExample
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

            var apiInstance = new CartApi(config);
            var varParams = store_name,store_url,db_prefix;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "store_name,store_url,db_prefix")
            var exclude = store_name,store_url,db_prefix;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.config
                CartConfig200Response result = apiInstance.CartConfig(varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.config
    ApiResponse<CartConfig200Response> response = apiInstance.CartConfigWithHttpInfo(varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;store_name,store_url,db_prefix&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**CartConfig200Response**](CartConfig200Response.md)

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

<a id="cartconfigupdate"></a>
# **CartConfigUpdate**
> CartConfigUpdate200Response CartConfigUpdate (CartConfigUpdate cartConfigUpdate)

cart.config.update

Use this API method to update custom data in client database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartConfigUpdateExample
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

            var apiInstance = new CartApi(config);
            var cartConfigUpdate = new CartConfigUpdate(); // CartConfigUpdate | 

            try
            {
                // cart.config.update
                CartConfigUpdate200Response result = apiInstance.CartConfigUpdate(cartConfigUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartConfigUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartConfigUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.config.update
    ApiResponse<CartConfigUpdate200Response> response = apiInstance.CartConfigUpdateWithHttpInfo(cartConfigUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartConfigUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cartConfigUpdate** | [**CartConfigUpdate**](CartConfigUpdate.md) |  |  |

### Return type

[**CartConfigUpdate200Response**](CartConfigUpdate200Response.md)

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

<a id="cartcouponadd"></a>
# **CartCouponAdd**
> CartCouponAdd200Response CartCouponAdd (CartCouponAdd cartCouponAdd)

cart.coupon.add

Use this method to create a coupon with specified conditions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCouponAddExample
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

            var apiInstance = new CartApi(config);
            var cartCouponAdd = new CartCouponAdd(); // CartCouponAdd | 

            try
            {
                // cart.coupon.add
                CartCouponAdd200Response result = apiInstance.CartCouponAdd(cartCouponAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCouponAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCouponAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.coupon.add
    ApiResponse<CartCouponAdd200Response> response = apiInstance.CartCouponAddWithHttpInfo(cartCouponAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCouponAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cartCouponAdd** | [**CartCouponAdd**](CartCouponAdd.md) |  |  |

### Return type

[**CartCouponAdd200Response**](CartCouponAdd200Response.md)

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

<a id="cartcouponconditionadd"></a>
# **CartCouponConditionAdd**
> BasketLiveShippingServiceDelete200Response CartCouponConditionAdd (string couponId, string entity, string key, string varOperator, string value, string? target = null, bool? includeTax = null, bool? includeShipping = null, string? storeId = null)

cart.coupon.condition.add

Use this method to add additional conditions for coupon application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCouponConditionAddExample
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

            var apiInstance = new CartApi(config);
            var couponId = 45845;  // string | Coupon Id
            var entity = order;  // string | Defines condition entity type
            var key = subtotal;  // string | Defines condition entity attribute key
            var varOperator = ==;  // string | Defines condition operator
            var value = 2;  // string | Defines condition value, can be comma separated according to the operator.
            var target = coupon_action;  // string? | Defines condition operator (optional)  (default to "coupon_prerequisite")
            var includeTax = true;  // bool? | Indicates whether to apply a discount for taxes. (optional)  (default to false)
            var includeShipping = true;  // bool? | Indicates whether to apply a discount for shipping. (optional)  (default to false)
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.coupon.condition.add
                BasketLiveShippingServiceDelete200Response result = apiInstance.CartCouponConditionAdd(couponId, entity, key, varOperator, value, target, includeTax, includeShipping, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCouponConditionAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCouponConditionAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.coupon.condition.add
    ApiResponse<BasketLiveShippingServiceDelete200Response> response = apiInstance.CartCouponConditionAddWithHttpInfo(couponId, entity, key, varOperator, value, target, includeTax, includeShipping, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCouponConditionAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **couponId** | **string** | Coupon Id |  |
| **entity** | **string** | Defines condition entity type |  |
| **key** | **string** | Defines condition entity attribute key |  |
| **varOperator** | **string** | Defines condition operator |  |
| **value** | **string** | Defines condition value, can be comma separated according to the operator. |  |
| **target** | **string?** | Defines condition operator | [optional] [default to &quot;coupon_prerequisite&quot;] |
| **includeTax** | **bool?** | Indicates whether to apply a discount for taxes. | [optional] [default to false] |
| **includeShipping** | **bool?** | Indicates whether to apply a discount for shipping. | [optional] [default to false] |
| **storeId** | **string?** | Store Id | [optional]  |

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

<a id="cartcouponcount"></a>
# **CartCouponCount**
> CartCouponCount200Response CartCouponCount (string? storeId = null, bool? avail = null, string? dateStartFrom = null, string? dateStartTo = null, string? dateEndFrom = null, string? dateEndTo = null)

cart.coupon.count

This method allows you to get the number of coupons. On some platforms, you can filter the coupons by the date they were active.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCouponCountExample
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

            var apiInstance = new CartApi(config);
            var storeId = 1;  // string? | Store Id (optional) 
            var avail = false;  // bool? | Defines category's visibility status (optional)  (default to true)
            var dateStartFrom = 2016-12-29 16:44:30;  // string? | Filter entity by date_start (greater or equal) (optional) 
            var dateStartTo = 2016-12-29 16:44:30;  // string? | Filter entity by date_start (less or equal) (optional) 
            var dateEndFrom = 2016-12-29 16:44:30;  // string? | Filter entity by date_end (greater or equal) (optional) 
            var dateEndTo = 2016-12-29 16:44:30;  // string? | Filter entity by date_end (less or equal) (optional) 

            try
            {
                // cart.coupon.count
                CartCouponCount200Response result = apiInstance.CartCouponCount(storeId, avail, dateStartFrom, dateStartTo, dateEndFrom, dateEndTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCouponCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCouponCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.coupon.count
    ApiResponse<CartCouponCount200Response> response = apiInstance.CartCouponCountWithHttpInfo(storeId, avail, dateStartFrom, dateStartTo, dateEndFrom, dateEndTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCouponCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** | Store Id | [optional]  |
| **avail** | **bool?** | Defines category&#39;s visibility status | [optional] [default to true] |
| **dateStartFrom** | **string?** | Filter entity by date_start (greater or equal) | [optional]  |
| **dateStartTo** | **string?** | Filter entity by date_start (less or equal) | [optional]  |
| **dateEndFrom** | **string?** | Filter entity by date_end (greater or equal) | [optional]  |
| **dateEndTo** | **string?** | Filter entity by date_end (less or equal) | [optional]  |

### Return type

[**CartCouponCount200Response**](CartCouponCount200Response.md)

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

<a id="cartcoupondelete"></a>
# **CartCouponDelete**
> AttributeDelete200Response CartCouponDelete (string id, string? storeId = null)

cart.coupon.delete

Delete coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCouponDeleteExample
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

            var apiInstance = new CartApi(config);
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.coupon.delete
                AttributeDelete200Response result = apiInstance.CartCouponDelete(id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCouponDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCouponDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.coupon.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.CartCouponDeleteWithHttpInfo(id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCouponDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**AttributeDelete200Response**](AttributeDelete200Response.md)

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

<a id="cartcouponlist"></a>
# **CartCouponList**
> ModelResponseCartCouponList CartCouponList (int? start = null, int? count = null, string? pageCursor = null, string? couponsIds = null, string? storeId = null, string? langId = null, bool? avail = null, string? dateStartFrom = null, string? dateStartTo = null, string? dateEndFrom = null, string? dateEndTo = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.coupon.list

Get cart coupon discounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCouponListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var couponsIds = 1,2,3;  // string? | Filter coupons by ids (optional) 
            var storeId = 1;  // string? | Filter coupons by store id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var avail = false;  // bool? | Filter coupons by avail status (optional) 
            var dateStartFrom = 2016-12-29 16:44:30;  // string? | Filter entity by date_start (greater or equal) (optional) 
            var dateStartTo = 2016-12-29 16:44:30;  // string? | Filter entity by date_start (less or equal) (optional) 
            var dateEndFrom = 2016-12-29 16:44:30;  // string? | Filter entity by date_end (greater or equal) (optional) 
            var dateEndTo = 2016-12-29 16:44:30;  // string? | Filter entity by date_end (less or equal) (optional) 
            var responseFields = {pagination,result{coupon_count,coupon{id,code,name,conditions,actions{scope,amount,conditions{id,value,sub-conditions}},date_start,avail}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,code,type,amount;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,code,name,description")
            var exclude = usage_history,type;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.coupon.list
                ModelResponseCartCouponList result = apiInstance.CartCouponList(start, count, pageCursor, couponsIds, storeId, langId, avail, dateStartFrom, dateStartTo, dateEndFrom, dateEndTo, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCouponList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCouponListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.coupon.list
    ApiResponse<ModelResponseCartCouponList> response = apiInstance.CartCouponListWithHttpInfo(start, count, pageCursor, couponsIds, storeId, langId, avail, dateStartFrom, dateStartTo, dateEndFrom, dateEndTo, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCouponListWithHttpInfo: " + e.Message);
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
| **couponsIds** | **string?** | Filter coupons by ids | [optional]  |
| **storeId** | **string?** | Filter coupons by store id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **avail** | **bool?** | Filter coupons by avail status | [optional]  |
| **dateStartFrom** | **string?** | Filter entity by date_start (greater or equal) | [optional]  |
| **dateStartTo** | **string?** | Filter entity by date_start (less or equal) | [optional]  |
| **dateEndFrom** | **string?** | Filter entity by date_end (greater or equal) | [optional]  |
| **dateEndTo** | **string?** | Filter entity by date_end (less or equal) | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,code,name,description&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartCouponList**](ModelResponseCartCouponList.md)

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

<a id="cartcreate"></a>
# **CartCreate**
> AccountCartAdd200Response CartCreate (CartCreate cartCreate)

cart.create

Add store to the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CartApi(config);
            var cartCreate = new CartCreate(); // CartCreate | 

            try
            {
                // cart.create
                AccountCartAdd200Response result = apiInstance.CartCreate(cartCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.create
    ApiResponse<AccountCartAdd200Response> response = apiInstance.CartCreateWithHttpInfo(cartCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cartCreate** | [**CartCreate**](CartCreate.md) |  |  |

### Return type

[**AccountCartAdd200Response**](AccountCartAdd200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cartdelete"></a>
# **CartDelete**
> CartDelete200Response CartDelete (bool? deleteBridge = null)

cart.delete

Remove store from API2Cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartDeleteExample
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

            var apiInstance = new CartApi(config);
            var deleteBridge = true;  // bool? | Identifies if there is a necessity to delete bridge (optional)  (default to true)

            try
            {
                // cart.delete
                CartDelete200Response result = apiInstance.CartDelete(deleteBridge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.delete
    ApiResponse<CartDelete200Response> response = apiInstance.CartDeleteWithHttpInfo(deleteBridge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteBridge** | **bool?** | Identifies if there is a necessity to delete bridge | [optional] [default to true] |

### Return type

[**CartDelete200Response**](CartDelete200Response.md)

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

<a id="cartdisconnect"></a>
# **CartDisconnect**
> CartDisconnect200Response CartDisconnect (bool? deleteBridge = null)

cart.disconnect

Disconnect with the store and clear store session data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartDisconnectExample
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

            var apiInstance = new CartApi(config);
            var deleteBridge = true;  // bool? | Identifies if there is a necessity to delete bridge (optional)  (default to false)

            try
            {
                // cart.disconnect
                CartDisconnect200Response result = apiInstance.CartDisconnect(deleteBridge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartDisconnect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartDisconnectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.disconnect
    ApiResponse<CartDisconnect200Response> response = apiInstance.CartDisconnectWithHttpInfo(deleteBridge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartDisconnectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteBridge** | **bool?** | Identifies if there is a necessity to delete bridge | [optional] [default to false] |

### Return type

[**CartDisconnect200Response**](CartDisconnect200Response.md)

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

<a id="cartgiftcardadd"></a>
# **CartGiftcardAdd**
> CartGiftcardAdd200Response CartGiftcardAdd (decimal amount, string? code = null, string? ownerEmail = null, string? recipientEmail = null, string? recipientName = null, string? ownerName = null)

cart.giftcard.add

Use this method to create a gift card for a specified amount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartGiftcardAddExample
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

            var apiInstance = new CartApi(config);
            var amount = 15.5;  // decimal | Defines the gift card amount value.
            var code = GFT1 A4S5 AA11 RD61;  // string? | Gift card code (optional) 
            var ownerEmail = jubari@hannsgroup.com;  // string? | Gift card owner email (optional) 
            var recipientEmail = jubari@hannsgroup.com;  // string? | Gift card recipient email (optional) 
            var recipientName = John Doe;  // string? | Gift card recipient name (optional) 
            var ownerName = John Doe;  // string? | Gift card owner name (optional) 

            try
            {
                // cart.giftcard.add
                CartGiftcardAdd200Response result = apiInstance.CartGiftcardAdd(amount, code, ownerEmail, recipientEmail, recipientName, ownerName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartGiftcardAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartGiftcardAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.giftcard.add
    ApiResponse<CartGiftcardAdd200Response> response = apiInstance.CartGiftcardAddWithHttpInfo(amount, code, ownerEmail, recipientEmail, recipientName, ownerName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartGiftcardAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amount** | **decimal** | Defines the gift card amount value. |  |
| **code** | **string?** | Gift card code | [optional]  |
| **ownerEmail** | **string?** | Gift card owner email | [optional]  |
| **recipientEmail** | **string?** | Gift card recipient email | [optional]  |
| **recipientName** | **string?** | Gift card recipient name | [optional]  |
| **ownerName** | **string?** | Gift card owner name | [optional]  |

### Return type

[**CartGiftcardAdd200Response**](CartGiftcardAdd200Response.md)

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

<a id="cartgiftcardcount"></a>
# **CartGiftcardCount**
> CartGiftcardCount200Response CartGiftcardCount (string? storeId = null)

cart.giftcard.count

Get gift cards count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartGiftcardCountExample
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

            var apiInstance = new CartApi(config);
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.giftcard.count
                CartGiftcardCount200Response result = apiInstance.CartGiftcardCount(storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartGiftcardCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartGiftcardCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.giftcard.count
    ApiResponse<CartGiftcardCount200Response> response = apiInstance.CartGiftcardCountWithHttpInfo(storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartGiftcardCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CartGiftcardCount200Response**](CartGiftcardCount200Response.md)

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

<a id="cartgiftcarddelete"></a>
# **CartGiftcardDelete**
> AttributeDelete200Response CartGiftcardDelete (string id)

cart.giftcard.delete

Delete giftcard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartGiftcardDeleteExample
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

            var apiInstance = new CartApi(config);
            var id = 10;  // string | Entity id

            try
            {
                // cart.giftcard.delete
                AttributeDelete200Response result = apiInstance.CartGiftcardDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartGiftcardDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartGiftcardDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.giftcard.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.CartGiftcardDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartGiftcardDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |

### Return type

[**AttributeDelete200Response**](AttributeDelete200Response.md)

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

<a id="cartgiftcardlist"></a>
# **CartGiftcardList**
> ModelResponseCartGiftCardList CartGiftcardList (int? start = null, int? count = null, string? pageCursor = null, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.giftcard.list

Get gift cards list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartGiftcardListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {pagination,result{gift_card{id,code,amount,status}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,code,name")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.giftcard.list
                ModelResponseCartGiftCardList result = apiInstance.CartGiftcardList(start, count, pageCursor, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartGiftcardList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartGiftcardListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.giftcard.list
    ApiResponse<ModelResponseCartGiftCardList> response = apiInstance.CartGiftcardListWithHttpInfo(start, count, pageCursor, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartGiftcardListWithHttpInfo: " + e.Message);
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
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,code,name&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartGiftCardList**](ModelResponseCartGiftCardList.md)

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

<a id="cartinfo"></a>
# **CartInfo**
> CartInfo200Response CartInfo (string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.info

This method allows you to get various information about the store, including a list of stores (in the case of a multistore configuration), a list of supported languages, currencies, carriers, warehouses, and many other information. This information contains data that is relatively stable and rarely changes, so API2Cart can cache certain data to reduce the load on the store and speed up the execution of the request. We also recommend that you cache the response of this method on your side to save requests. If you need to clear the cache for a specific store, then use the cart.validate method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartInfoExample
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

            var apiInstance = new CartApi(config);
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {result{name,url,stores_info{store_id,name,currency{id,iso3},store_owner_info}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = name,url;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "store_name,store_url,db_prefix")
            var exclude = name,url;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.info
                CartInfo200Response result = apiInstance.CartInfo(storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.info
    ApiResponse<CartInfo200Response> response = apiInstance.CartInfoWithHttpInfo(storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;store_name,store_url,db_prefix&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**CartInfo200Response**](CartInfo200Response.md)

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

<a id="cartlist"></a>
# **CartList**
> CartList200Response CartList ()

cart.list

Get list of supported carts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CartApi(config);

            try
            {
                // cart.list
                CartList200Response result = apiInstance.CartList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.list
    ApiResponse<CartList200Response> response = apiInstance.CartListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CartList200Response**](CartList200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cartmetadatalist"></a>
# **CartMetaDataList**
> ModelResponseCartMetaDataList CartMetaDataList (string entityId, int? count = null, string? pageCursor = null, string? entity = null, string? storeId = null, string? langId = null, string? key = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.meta_data.list

Using this method, you can get a list of metadata for various entities (products, options, customers, orders). Usually this is data created by third-party plugins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartMetaDataListExample
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

            var apiInstance = new CartApi(config);
            var entityId = 1;  // string | Entity Id
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var entity = order;  // string? | Entity (optional)  (default to "product")
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var key = subtotal;  // string? | Key (optional) 
            var responseFields = {result{items{key,value}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "key,value")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.meta_data.list
                ModelResponseCartMetaDataList result = apiInstance.CartMetaDataList(entityId, count, pageCursor, entity, storeId, langId, key, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartMetaDataList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartMetaDataListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.meta_data.list
    ApiResponse<ModelResponseCartMetaDataList> response = apiInstance.CartMetaDataListWithHttpInfo(entityId, count, pageCursor, entity, storeId, langId, key, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartMetaDataListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** | Entity Id |  |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **entity** | **string?** | Entity | [optional] [default to &quot;product&quot;] |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **key** | **string?** | Key | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;key,value&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartMetaDataList**](ModelResponseCartMetaDataList.md)

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

<a id="cartmetadataset"></a>
# **CartMetaDataSet**
> AttributeAdd200Response CartMetaDataSet (string entityId, string key, string value, string varNamespace, string? entity = null, string? storeId = null, string? langId = null)

cart.meta_data.set

Set meta data for a specific entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartMetaDataSetExample
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

            var apiInstance = new CartApi(config);
            var entityId = 1;  // string | Entity Id
            var key = subtotal;  // string | Key
            var value = 2;  // string | Value
            var varNamespace = order;  // string | Metafield namespace
            var entity = order;  // string? | Entity (optional)  (default to "product")
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 

            try
            {
                // cart.meta_data.set
                AttributeAdd200Response result = apiInstance.CartMetaDataSet(entityId, key, value, varNamespace, entity, storeId, langId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartMetaDataSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartMetaDataSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.meta_data.set
    ApiResponse<AttributeAdd200Response> response = apiInstance.CartMetaDataSetWithHttpInfo(entityId, key, value, varNamespace, entity, storeId, langId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartMetaDataSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** | Entity Id |  |
| **key** | **string** | Key |  |
| **value** | **string** | Value |  |
| **varNamespace** | **string** | Metafield namespace |  |
| **entity** | **string?** | Entity | [optional] [default to &quot;product&quot;] |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |

### Return type

[**AttributeAdd200Response**](AttributeAdd200Response.md)

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

<a id="cartmetadataunset"></a>
# **CartMetaDataUnset**
> BasketLiveShippingServiceDelete200Response CartMetaDataUnset (string entityId, string key, string id, string? entity = null, string? storeId = null)

cart.meta_data.unset

Unset meta data for a specific entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartMetaDataUnsetExample
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

            var apiInstance = new CartApi(config);
            var entityId = 1;  // string | Entity Id
            var key = subtotal;  // string | Key
            var id = 10;  // string | Entity id
            var entity = order;  // string? | Entity (optional)  (default to "product")
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.meta_data.unset
                BasketLiveShippingServiceDelete200Response result = apiInstance.CartMetaDataUnset(entityId, key, id, entity, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartMetaDataUnset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartMetaDataUnsetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.meta_data.unset
    ApiResponse<BasketLiveShippingServiceDelete200Response> response = apiInstance.CartMetaDataUnsetWithHttpInfo(entityId, key, id, entity, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartMetaDataUnsetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** | Entity Id |  |
| **key** | **string** | Key |  |
| **id** | **string** | Entity id |  |
| **entity** | **string?** | Entity | [optional] [default to &quot;product&quot;] |
| **storeId** | **string?** | Store Id | [optional]  |

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

<a id="cartmethods"></a>
# **CartMethods**
> CartMethods200Response CartMethods ()

cart.methods

Returns a list of supported API methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartMethodsExample
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

            var apiInstance = new CartApi(config);

            try
            {
                // cart.methods
                CartMethods200Response result = apiInstance.CartMethods();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.methods
    ApiResponse<CartMethods200Response> response = apiInstance.CartMethodsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CartMethods200Response**](CartMethods200Response.md)

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

<a id="cartpluginlist"></a>
# **CartPluginList**
> CartPluginList200Response CartPluginList (int? start = null, int? count = null, string? storeId = null)

cart.plugin.list

Get a list of third-party plugins installed on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartPluginListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.plugin.list
                CartPluginList200Response result = apiInstance.CartPluginList(start, count, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartPluginList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartPluginListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.plugin.list
    ApiResponse<CartPluginList200Response> response = apiInstance.CartPluginListWithHttpInfo(start, count, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartPluginListWithHttpInfo: " + e.Message);
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

[**CartPluginList200Response**](CartPluginList200Response.md)

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

<a id="cartscriptadd"></a>
# **CartScriptAdd**
> CartScriptAdd200Response CartScriptAdd (string? name = null, string? description = null, string? html = null, string? src = null, string? loadMethod = null, string? scope = null, string? events = null, string? storeId = null)

cart.script.add

Add new script to the storefront

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartScriptAddExample
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

            var apiInstance = new CartApi(config);
            var name = jQuery Minimized;  // string? | The user-friendly script name (optional) 
            var description = The Write Less, Do More, JavaScript Library;  // string? | The user-friendly description (optional) 
            var html = &#x3C;script&#x3E;alert(&#x27;foo&#x27;)&#x3C;/script&#x3E;;  // string? | An html string containing exactly one `script` tag. (optional) 
            var src = https://js-aplenty.com/foo.js;  // string? | The URL of the remote script (optional) 
            var loadMethod = async;  // string? | The load method to use for the script (optional) 
            var scope = all;  // string? | The page or pages on the online store where the script should be included (optional)  (default to "storefront")
            var events = purchase_event;  // string? | Event for run scripts (optional) 
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.script.add
                CartScriptAdd200Response result = apiInstance.CartScriptAdd(name, description, html, src, loadMethod, scope, events, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartScriptAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartScriptAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.script.add
    ApiResponse<CartScriptAdd200Response> response = apiInstance.CartScriptAddWithHttpInfo(name, description, html, src, loadMethod, scope, events, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartScriptAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | The user-friendly script name | [optional]  |
| **description** | **string?** | The user-friendly description | [optional]  |
| **html** | **string?** | An html string containing exactly one &#x60;script&#x60; tag. | [optional]  |
| **src** | **string?** | The URL of the remote script | [optional]  |
| **loadMethod** | **string?** | The load method to use for the script | [optional]  |
| **scope** | **string?** | The page or pages on the online store where the script should be included | [optional] [default to &quot;storefront&quot;] |
| **events** | **string?** | Event for run scripts | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CartScriptAdd200Response**](CartScriptAdd200Response.md)

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

<a id="cartscriptdelete"></a>
# **CartScriptDelete**
> AttributeDelete200Response CartScriptDelete (string id, string? storeId = null)

cart.script.delete

Remove script from the storefront

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartScriptDeleteExample
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

            var apiInstance = new CartApi(config);
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // cart.script.delete
                AttributeDelete200Response result = apiInstance.CartScriptDelete(id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartScriptDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartScriptDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.script.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.CartScriptDeleteWithHttpInfo(id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartScriptDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**AttributeDelete200Response**](AttributeDelete200Response.md)

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

<a id="cartscriptlist"></a>
# **CartScriptList**
> ModelResponseCartScriptList CartScriptList (int? start = null, int? count = null, string? pageCursor = null, string? scriptIds = null, string? storeId = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.script.list

Get scripts installed to the storefront

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartScriptListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var scriptIds = 34023324,34024032;  // string? | Retrieves only scripts with specific ids (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var responseFields = {pagination,result{total_count,scripts{id,name,src,created_time{value}}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,description")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.script.list
                ModelResponseCartScriptList result = apiInstance.CartScriptList(start, count, pageCursor, scriptIds, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartScriptList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartScriptListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.script.list
    ApiResponse<ModelResponseCartScriptList> response = apiInstance.CartScriptListWithHttpInfo(start, count, pageCursor, scriptIds, storeId, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartScriptListWithHttpInfo: " + e.Message);
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
| **scriptIds** | **string?** | Retrieves only scripts with specific ids | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,description&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartScriptList**](ModelResponseCartScriptList.md)

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

<a id="cartshippingzoneslist"></a>
# **CartShippingZonesList**
> ModelResponseCartShippingZonesList CartShippingZonesList (int? start = null, int? count = null, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

cart.shipping_zones.list

Get list of shipping zones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartShippingZonesListExample
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

            var apiInstance = new CartApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {result{id,name,enabled,countries,shipping_methods{name,rates}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,enabled")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // cart.shipping_zones.list
                ModelResponseCartShippingZonesList result = apiInstance.CartShippingZonesList(start, count, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartShippingZonesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartShippingZonesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.shipping_zones.list
    ApiResponse<ModelResponseCartShippingZonesList> response = apiInstance.CartShippingZonesListWithHttpInfo(start, count, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartShippingZonesListWithHttpInfo: " + e.Message);
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
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,enabled&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseCartShippingZonesList**](ModelResponseCartShippingZonesList.md)

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

<a id="cartvalidate"></a>
# **CartValidate**
> CartValidate200Response CartValidate (bool? validateVersion = null)

cart.validate

This method clears the cache in API2Cart for a particular store and checks whether the connection to the store is available. Use this method if there have been any changes in the settings on the storе, for example, if a new plugin has been installed or removed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CartValidateExample
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

            var apiInstance = new CartApi(config);
            var validateVersion = true;  // bool? | Specify if api2cart should validate cart version (optional)  (default to false)

            try
            {
                // cart.validate
                CartValidate200Response result = apiInstance.CartValidate(validateVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CartApi.CartValidate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CartValidateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // cart.validate
    ApiResponse<CartValidate200Response> response = apiInstance.CartValidateWithHttpInfo(validateVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CartApi.CartValidateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateVersion** | **bool?** | Specify if api2cart should validate cart version | [optional] [default to false] |

### Return type

[**CartValidate200Response**](CartValidate200Response.md)

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

