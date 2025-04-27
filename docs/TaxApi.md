# Org.OpenAPITools.Api.TaxApi

All URIs are relative to *https://api.api2cart.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TaxClassInfo**](TaxApi.md#taxclassinfo) | **GET** /tax.class.info.json | tax.class.info |
| [**TaxClassList**](TaxApi.md#taxclasslist) | **GET** /tax.class.list.json | tax.class.list |

<a id="taxclassinfo"></a>
# **TaxClassInfo**
> ModelResponseTaxClassInfo TaxClassInfo (string taxClassId, string? storeId = null, string? langId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

tax.class.info

Use this method to get information about a tax class and its rates. It allows you to calculate the tax percentage for a specific customer's address. This information contains relatively static data that rarely changes, so API2Cart may cache certain data to reduce the load on the store and speed up request execution. We also recommend that you cache the response of this method on your side to save requests. If you need to clear the cache for a specific store, use the cart.validate method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaxClassInfoExample
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

            var apiInstance = new TaxApi(config);
            var taxClassId = 9;  // string | Retrieves taxes specified by class id
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var responseFields = {result{id,name,tax,tax_rates{id,countries{id,name,states},cities,address,zip_codes{is_range,range,fields}}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = tax_class_id,tax;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "tax_class_id,name,avail")
            var exclude = tax_class_id,tax;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // tax.class.info
                ModelResponseTaxClassInfo result = apiInstance.TaxClassInfo(taxClassId, storeId, langId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.TaxClassInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaxClassInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // tax.class.info
    ApiResponse<ModelResponseTaxClassInfo> response = apiInstance.TaxClassInfoWithHttpInfo(taxClassId, storeId, langId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxApi.TaxClassInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taxClassId** | **string** | Retrieves taxes specified by class id |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;tax_class_id,name,avail&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseTaxClassInfo**](ModelResponseTaxClassInfo.md)

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

<a id="taxclasslist"></a>
# **TaxClassList**
> ModelResponseTaxClassList TaxClassList (int? count = null, string? pageCursor = null, string? storeId = null, string? findValue = null, string? findWhere = null, string? createdTo = null, string? createdFrom = null, string? modifiedTo = null, string? modifiedFrom = null, string? responseFields = null)

tax.class.list

Get list of tax classes from your store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaxClassListExample
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

            var apiInstance = new TaxApi(config);
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var findValue = tax;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = name;  // string? | Tax class search that is specified by field (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "{return_code,return_message,pagination,result}")

            try
            {
                // tax.class.list
                ModelResponseTaxClassList result = apiInstance.TaxClassList(count, pageCursor, storeId, findValue, findWhere, createdTo, createdFrom, modifiedTo, modifiedFrom, responseFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.TaxClassList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaxClassListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // tax.class.list
    ApiResponse<ModelResponseTaxClassList> response = apiInstance.TaxClassListWithHttpInfo(count, pageCursor, storeId, findValue, findWhere, createdTo, createdFrom, modifiedTo, modifiedFrom, responseFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxApi.TaxClassListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Tax class search that is specified by field | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;{return_code,return_message,pagination,result}&quot;] |

### Return type

[**ModelResponseTaxClassList**](ModelResponseTaxClassList.md)

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

