# Org.OpenAPITools.Api.WebhookApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookCount**](WebhookApi.md#webhookcount) | **GET** /webhook.count.json | webhook.count |
| [**WebhookCreate**](WebhookApi.md#webhookcreate) | **POST** /webhook.create.json | webhook.create |
| [**WebhookDelete**](WebhookApi.md#webhookdelete) | **DELETE** /webhook.delete.json | webhook.delete |
| [**WebhookEvents**](WebhookApi.md#webhookevents) | **GET** /webhook.events.json | webhook.events |
| [**WebhookList**](WebhookApi.md#webhooklist) | **GET** /webhook.list.json | webhook.list |
| [**WebhookUpdate**](WebhookApi.md#webhookupdate) | **PUT** /webhook.update.json | webhook.update |

<a id="webhookcount"></a>
# **WebhookCount**
> WebhookCount200Response WebhookCount (string? entity = null, string? action = null, bool? active = null)

webhook.count

Count registered webhooks on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookCountExample
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

            var apiInstance = new WebhookApi(config);
            var entity = product;  // string? | The entity you want to filter webhooks by (e.g. order or product) (optional) 
            var action = add;  // string? | The action you want to filter webhooks by (e.g. order or product) (optional) 
            var active = true;  // bool? | The webhook status you want to filter webhooks by (optional) 

            try
            {
                // webhook.count
                WebhookCount200Response result = apiInstance.WebhookCount(entity, action, active);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.count
    ApiResponse<WebhookCount200Response> response = apiInstance.WebhookCountWithHttpInfo(entity, action, active);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | **string?** | The entity you want to filter webhooks by (e.g. order or product) | [optional]  |
| **action** | **string?** | The action you want to filter webhooks by (e.g. order or product) | [optional]  |
| **active** | **bool?** | The webhook status you want to filter webhooks by | [optional]  |

### Return type

[**WebhookCount200Response**](WebhookCount200Response.md)

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

<a id="webhookcreate"></a>
# **WebhookCreate**
> BasketLiveShippingServiceCreate200Response WebhookCreate (string entity, string action, string? callback = null, string? label = null, string? fields = null, string? responseFields = null, bool? active = null, string? langId = null, string? storeId = null, string? idempotencyKey = null)

webhook.create

Create webhook on the store and subscribe to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookCreateExample
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

            var apiInstance = new WebhookApi(config);
            var entity = product;  // string | Specify the entity that you want to enable webhooks for (e.g product, order, customer, category)
            var action = add;  // string | Specify what action (event) will trigger the webhook (e.g add, delete, or update)
            var callback = https://example.com/callback;  // string? | Callback url that returns shipping rates. It should be able to accept POST requests with json data. (optional) 
            var label = Super webhook;  // string? | The name you give to the webhook (optional) 
            var fields = id, name, description;  // string? | Fields the webhook should send (optional)  (default to "force_all")
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var active = true;  // bool? | Webhook status (optional)  (default to true)
            var langId = 3;  // string? | Language id (optional) 
            var storeId = 1;  // string? | Defines store id where the webhook should be assigned (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // webhook.create
                BasketLiveShippingServiceCreate200Response result = apiInstance.WebhookCreate(entity, action, callback, label, fields, responseFields, active, langId, storeId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.create
    ApiResponse<BasketLiveShippingServiceCreate200Response> response = apiInstance.WebhookCreateWithHttpInfo(entity, action, callback, label, fields, responseFields, active, langId, storeId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | **string** | Specify the entity that you want to enable webhooks for (e.g product, order, customer, category) |  |
| **action** | **string** | Specify what action (event) will trigger the webhook (e.g add, delete, or update) |  |
| **callback** | **string?** | Callback url that returns shipping rates. It should be able to accept POST requests with json data. | [optional]  |
| **label** | **string?** | The name you give to the webhook | [optional]  |
| **fields** | **string?** | Fields the webhook should send | [optional] [default to &quot;force_all&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **active** | **bool?** | Webhook status | [optional] [default to true] |
| **langId** | **string?** | Language id | [optional]  |
| **storeId** | **string?** | Defines store id where the webhook should be assigned | [optional]  |
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

<a id="webhookdelete"></a>
# **WebhookDelete**
> AttributeDelete200Response WebhookDelete (string id)

webhook.delete

Delete registered webhook on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookDeleteExample
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

            var apiInstance = new WebhookApi(config);
            var id = 25;  // string | Webhook id

            try
            {
                // webhook.delete
                AttributeDelete200Response result = apiInstance.WebhookDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.WebhookDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Webhook id |  |

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

<a id="webhookevents"></a>
# **WebhookEvents**
> WebhookEvents200Response WebhookEvents ()

webhook.events

List all Webhooks that are available on this store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookEventsExample
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

            var apiInstance = new WebhookApi(config);

            try
            {
                // webhook.events
                WebhookEvents200Response result = apiInstance.WebhookEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.events
    ApiResponse<WebhookEvents200Response> response = apiInstance.WebhookEventsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WebhookEvents200Response**](WebhookEvents200Response.md)

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

<a id="webhooklist"></a>
# **WebhookList**
> WebhookList200Response WebhookList (int? start = null, int? count = null, string? entity = null, string? action = null, bool? active = null, string? ids = null, string? varParams = null)

webhook.list

List registered webhook on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookListExample
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

            var apiInstance = new WebhookApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var entity = product;  // string? | The entity you want to filter webhooks by (e.g. order or product) (optional) 
            var action = add;  // string? | The action you want to filter webhooks by (e.g. add, update, or delete) (optional) 
            var active = true;  // bool? | The webhook status you want to filter webhooks by (optional) 
            var ids = 3,14,25;  // string? | List of сomma-separated webhook ids (optional) 
            var varParams = id,entity,callback,fields;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,entity,action,callback")

            try
            {
                // webhook.list
                WebhookList200Response result = apiInstance.WebhookList(start, count, entity, action, active, ids, varParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.list
    ApiResponse<WebhookList200Response> response = apiInstance.WebhookListWithHttpInfo(start, count, entity, action, active, ids, varParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **entity** | **string?** | The entity you want to filter webhooks by (e.g. order or product) | [optional]  |
| **action** | **string?** | The action you want to filter webhooks by (e.g. add, update, or delete) | [optional]  |
| **active** | **bool?** | The webhook status you want to filter webhooks by | [optional]  |
| **ids** | **string?** | List of сomma-separated webhook ids | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,entity,action,callback&quot;] |

### Return type

[**WebhookList200Response**](WebhookList200Response.md)

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

<a id="webhookupdate"></a>
# **WebhookUpdate**
> ProductImageUpdate200Response WebhookUpdate (string id, string? callback = null, string? label = null, string? fields = null, string? responseFields = null, bool? active = null, string? langId = null, string? idempotencyKey = null)

webhook.update

Update Webhooks parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WebhookUpdateExample
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

            var apiInstance = new WebhookApi(config);
            var id = 25;  // string | Webhook id
            var callback = https://example.com/callback;  // string? | Callback url that returns shipping rates. It should be able to accept POST requests with json data. (optional) 
            var label = Super webhook;  // string? | The name you give to the webhook (optional) 
            var fields = id, name, description;  // string? | Fields the webhook should send (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var active = true;  // bool? | Webhook status (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // webhook.update
                ProductImageUpdate200Response result = apiInstance.WebhookUpdate(id, callback, label, fields, responseFields, active, langId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.WebhookUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // webhook.update
    ApiResponse<ProductImageUpdate200Response> response = apiInstance.WebhookUpdateWithHttpInfo(id, callback, label, fields, responseFields, active, langId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.WebhookUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Webhook id |  |
| **callback** | **string?** | Callback url that returns shipping rates. It should be able to accept POST requests with json data. | [optional]  |
| **label** | **string?** | The name you give to the webhook | [optional]  |
| **fields** | **string?** | Fields the webhook should send | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **active** | **bool?** | Webhook status | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**ProductImageUpdate200Response**](ProductImageUpdate200Response.md)

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

