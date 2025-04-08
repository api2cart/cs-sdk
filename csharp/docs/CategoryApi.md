# Org.OpenAPITools.Api.CategoryApi

All URIs are relative to *https://api.api2cart.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CategoryAdd**](CategoryApi.md#categoryadd) | **POST** /category.add.json | category.add |
| [**CategoryAddBatch**](CategoryApi.md#categoryaddbatch) | **POST** /category.add.batch.json | category.add.batch |
| [**CategoryAssign**](CategoryApi.md#categoryassign) | **POST** /category.assign.json | category.assign |
| [**CategoryCount**](CategoryApi.md#categorycount) | **GET** /category.count.json | category.count |
| [**CategoryDelete**](CategoryApi.md#categorydelete) | **DELETE** /category.delete.json | category.delete |
| [**CategoryFind**](CategoryApi.md#categoryfind) | **GET** /category.find.json | category.find |
| [**CategoryImageAdd**](CategoryApi.md#categoryimageadd) | **POST** /category.image.add.json | category.image.add |
| [**CategoryImageDelete**](CategoryApi.md#categoryimagedelete) | **DELETE** /category.image.delete.json | category.image.delete |
| [**CategoryInfo**](CategoryApi.md#categoryinfo) | **GET** /category.info.json | category.info |
| [**CategoryList**](CategoryApi.md#categorylist) | **GET** /category.list.json | category.list |
| [**CategoryUnassign**](CategoryApi.md#categoryunassign) | **POST** /category.unassign.json | category.unassign |
| [**CategoryUpdate**](CategoryApi.md#categoryupdate) | **PUT** /category.update.json | category.update |

<a id="categoryadd"></a>
# **CategoryAdd**
> CategoryAdd200Response CategoryAdd (string name, string? parentId = null, string? storesIds = null, string? storeId = null, string? langId = null, bool? avail = null, int? sortOrder = null, string? createdTime = null, string? modifiedTime = null, string? description = null, string? shortDescription = null, string? metaTitle = null, string? metaDescription = null, string? metaKeywords = null, string? seoUrl = null)

category.add

Add new category in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryAddExample
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

            var apiInstance = new CategoryApi(config);
            var name = Shoes;  // string | Defines category's name that has to be added
            var parentId = 6;  // string? | Adds categories specified by parent id (optional) 
            var storesIds = 1,2;  // string? | Create category in the stores that is specified by comma-separated stores' id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var avail = false;  // bool? | Defines category's visibility status (optional)  (default to true)
            var sortOrder = 2;  // int? | Sort number in the list (optional)  (default to 0)
            var createdTime = 2014-01-30 15:58:41;  // string? | Entity's date creation (optional) 
            var modifiedTime = 2014-07-30 15:58:41;  // string? | Entity's date modification (optional) 
            var description = Test category;  // string? | Defines category's description (optional) 
            var shortDescription = Short description. This is very short description;  // string? | Defines short description (optional) 
            var metaTitle = category,test;  // string? | Defines unique meta title for each entity (optional) 
            var metaDescription = category,test;  // string? | Defines unique meta description of a entity (optional) 
            var metaKeywords = category,test;  // string? | Defines unique meta keywords for each entity (optional) 
            var seoUrl = category,test;  // string? | Defines unique category's URL for SEO (optional) 

            try
            {
                // category.add
                CategoryAdd200Response result = apiInstance.CategoryAdd(name, parentId, storesIds, storeId, langId, avail, sortOrder, createdTime, modifiedTime, description, shortDescription, metaTitle, metaDescription, metaKeywords, seoUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.add
    ApiResponse<CategoryAdd200Response> response = apiInstance.CategoryAddWithHttpInfo(name, parentId, storesIds, storeId, langId, avail, sortOrder, createdTime, modifiedTime, description, shortDescription, metaTitle, metaDescription, metaKeywords, seoUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Defines category&#39;s name that has to be added |  |
| **parentId** | **string?** | Adds categories specified by parent id | [optional]  |
| **storesIds** | **string?** | Create category in the stores that is specified by comma-separated stores&#39; id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **avail** | **bool?** | Defines category&#39;s visibility status | [optional] [default to true] |
| **sortOrder** | **int?** | Sort number in the list | [optional] [default to 0] |
| **createdTime** | **string?** | Entity&#39;s date creation | [optional]  |
| **modifiedTime** | **string?** | Entity&#39;s date modification | [optional]  |
| **description** | **string?** | Defines category&#39;s description | [optional]  |
| **shortDescription** | **string?** | Defines short description | [optional]  |
| **metaTitle** | **string?** | Defines unique meta title for each entity | [optional]  |
| **metaDescription** | **string?** | Defines unique meta description of a entity | [optional]  |
| **metaKeywords** | **string?** | Defines unique meta keywords for each entity | [optional]  |
| **seoUrl** | **string?** | Defines unique category&#39;s URL for SEO | [optional]  |

### Return type

[**CategoryAdd200Response**](CategoryAdd200Response.md)

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

<a id="categoryaddbatch"></a>
# **CategoryAddBatch**
> CategoryAddBatch200Response CategoryAddBatch (CategoryAddBatch categoryAddBatch)

category.add.batch

Add new categories to the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryAddBatchExample
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

            var apiInstance = new CategoryApi(config);
            var categoryAddBatch = new CategoryAddBatch(); // CategoryAddBatch | 

            try
            {
                // category.add.batch
                CategoryAddBatch200Response result = apiInstance.CategoryAddBatch(categoryAddBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryAddBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryAddBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.add.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.CategoryAddBatchWithHttpInfo(categoryAddBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryAddBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryAddBatch** | [**CategoryAddBatch**](CategoryAddBatch.md) |  |  |

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

<a id="categoryassign"></a>
# **CategoryAssign**
> CartConfigUpdate200Response CategoryAssign (string productId, string categoryId, string? storeId = null)

category.assign

Assign category to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryAssignExample
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

            var apiInstance = new CategoryApi(config);
            var productId = 10;  // string | Defines category assign to the product, specified by product id
            var categoryId = 6;  // string | Defines category assign, specified by category id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.assign
                CartConfigUpdate200Response result = apiInstance.CategoryAssign(productId, categoryId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.assign
    ApiResponse<CartConfigUpdate200Response> response = apiInstance.CategoryAssignWithHttpInfo(productId, categoryId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines category assign to the product, specified by product id |  |
| **categoryId** | **string** | Defines category assign, specified by category id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CartConfigUpdate200Response**](CartConfigUpdate200Response.md)

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

<a id="categorycount"></a>
# **CategoryCount**
> CategoryCount200Response CategoryCount (string? parentId = null, string? storeId = null, string? langId = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, bool? avail = null, string? productType = null, string? findValue = null, string? findWhere = null, string? reportRequestId = null, bool? disableReportCache = null)

category.count

Count categories in store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryCountExample
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

            var apiInstance = new CategoryApi(config);
            var parentId = 6;  // string? | Counts categories specified by parent id (optional) 
            var storeId = 1;  // string? | Counts category specified by store id (optional) 
            var langId = 3;  // string? | Counts category specified by language id (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var avail = false;  // bool? | Defines category's visibility status (optional)  (default to true)
            var productType = BICYCLE;  // string? | A categorization for the product (optional) 
            var findValue = Demo category 1;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = email;  // string? | Counts categories that are searched specified by field (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)

            try
            {
                // category.count
                CategoryCount200Response result = apiInstance.CategoryCount(parentId, storeId, langId, createdFrom, createdTo, modifiedFrom, modifiedTo, avail, productType, findValue, findWhere, reportRequestId, disableReportCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.count
    ApiResponse<CategoryCount200Response> response = apiInstance.CategoryCountWithHttpInfo(parentId, storeId, langId, createdFrom, createdTo, modifiedFrom, modifiedTo, avail, productType, findValue, findWhere, reportRequestId, disableReportCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentId** | **string?** | Counts categories specified by parent id | [optional]  |
| **storeId** | **string?** | Counts category specified by store id | [optional]  |
| **langId** | **string?** | Counts category specified by language id | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **avail** | **bool?** | Defines category&#39;s visibility status | [optional] [default to true] |
| **productType** | **string?** | A categorization for the product | [optional]  |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Counts categories that are searched specified by field | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |

### Return type

[**CategoryCount200Response**](CategoryCount200Response.md)

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

<a id="categorydelete"></a>
# **CategoryDelete**
> CategoryDelete200Response CategoryDelete (string id, string? storeId = null)

category.delete

Delete category in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryDeleteExample
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

            var apiInstance = new CategoryApi(config);
            var id = 10;  // string | Defines category removal, specified by category id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.delete
                CategoryDelete200Response result = apiInstance.CategoryDelete(id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.delete
    ApiResponse<CategoryDelete200Response> response = apiInstance.CategoryDeleteWithHttpInfo(id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Defines category removal, specified by category id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CategoryDelete200Response**](CategoryDelete200Response.md)

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

<a id="categoryfind"></a>
# **CategoryFind**
> CategoryFind200Response CategoryFind (string findValue, string? findWhere = null, string? findParams = null, string? storeId = null, string? langId = null)

category.find

Search category in store. \"Laptop\" is specified here by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryFindExample
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

            var apiInstance = new CategoryApi(config);
            var findValue = Demo category 1;  // string | Entity search that is specified by some value
            var findWhere = name;  // string? | Entity search that is specified by the comma-separated unique fields (optional)  (default to "name")
            var findParams = regex;  // string? | Entity search that is specified by comma-separated parameters (optional)  (default to "whole_words")
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 

            try
            {
                // category.find
                CategoryFind200Response result = apiInstance.CategoryFind(findValue, findWhere, findParams, storeId, langId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryFind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryFindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.find
    ApiResponse<CategoryFind200Response> response = apiInstance.CategoryFindWithHttpInfo(findValue, findWhere, findParams, storeId, langId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryFindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **findValue** | **string** | Entity search that is specified by some value |  |
| **findWhere** | **string?** | Entity search that is specified by the comma-separated unique fields | [optional] [default to &quot;name&quot;] |
| **findParams** | **string?** | Entity search that is specified by comma-separated parameters | [optional] [default to &quot;whole_words&quot;] |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |

### Return type

[**CategoryFind200Response**](CategoryFind200Response.md)

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

<a id="categoryimageadd"></a>
# **CategoryImageAdd**
> CategoryImageAdd200Response CategoryImageAdd (string categoryId, string imageName, string url, string type, string? label = null, string? mime = null, int? position = null, string? storeId = null)

category.image.add

Add image to category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryImageAddExample
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

            var apiInstance = new CategoryApi(config);
            var categoryId = 6;  // string | Defines category id where the image should be added
            var imageName = bag-gray.png;  // string | Defines image's name
            var url = http://docs.api2cart.com/img/logo.png;  // string | Defines URL of the image that has to be added
            var type = base;  // string | Defines image's types that are specified by comma-separated list
            var label = This cool image;  // string? | Defines alternative text that has to be attached to the picture (optional) 
            var mime = image/jpeg;  // string? | Mime type of image http://en.wikipedia.org/wiki/Internet_media_type. (optional) 
            var position = 5;  // int? | Defines image’s position in the list (optional)  (default to 0)
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.image.add
                CategoryImageAdd200Response result = apiInstance.CategoryImageAdd(categoryId, imageName, url, type, label, mime, position, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryImageAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryImageAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.image.add
    ApiResponse<CategoryImageAdd200Response> response = apiInstance.CategoryImageAddWithHttpInfo(categoryId, imageName, url, type, label, mime, position, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryImageAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Defines category id where the image should be added |  |
| **imageName** | **string** | Defines image&#39;s name |  |
| **url** | **string** | Defines URL of the image that has to be added |  |
| **type** | **string** | Defines image&#39;s types that are specified by comma-separated list |  |
| **label** | **string?** | Defines alternative text that has to be attached to the picture | [optional]  |
| **mime** | **string?** | Mime type of image http://en.wikipedia.org/wiki/Internet_media_type. | [optional]  |
| **position** | **int?** | Defines image’s position in the list | [optional] [default to 0] |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CategoryImageAdd200Response**](CategoryImageAdd200Response.md)

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

<a id="categoryimagedelete"></a>
# **CategoryImageDelete**
> AttributeDelete200Response CategoryImageDelete (string categoryId, string imageId, string? storeId = null)

category.image.delete

Delete image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryImageDeleteExample
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

            var apiInstance = new CategoryApi(config);
            var categoryId = 6;  // string | Defines category id where the image should be deleted
            var imageId = 82950b84f468edff480680f99cedbe0d;  // string | Define image id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.image.delete
                AttributeDelete200Response result = apiInstance.CategoryImageDelete(categoryId, imageId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryImageDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryImageDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.image.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.CategoryImageDeleteWithHttpInfo(categoryId, imageId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryImageDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Defines category id where the image should be deleted |  |
| **imageId** | **string** | Define image id |  |
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

<a id="categoryinfo"></a>
# **CategoryInfo**
> CategoryInfo200Response CategoryInfo (string id, string? varParams = null, string? responseFields = null, string? exclude = null, string? storeId = null, string? langId = null, string? schemaType = null, string? reportRequestId = null, bool? disableReportCache = null)

category.info

Get category info about category ID*** or specify other category ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryInfoExample
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

            var apiInstance = new CategoryApi(config);
            var id = 10;  // string | Retrieves category's info specified by category id
            var varParams = id,parent_id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,parent_id,name,description")
            var responseFields = {result{id,name,parent_id,modified_at{value},images}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = id,parent_id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var storeId = 1;  // string? | Retrieves category info  specified by store id (optional) 
            var langId = 3;  // string? | Retrieves category info  specified by language id (optional) 
            var schemaType = LISTING;  // string? | The name of the requirements set for the provided schema. (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)

            try
            {
                // category.info
                CategoryInfo200Response result = apiInstance.CategoryInfo(id, varParams, responseFields, exclude, storeId, langId, schemaType, reportRequestId, disableReportCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.info
    ApiResponse<CategoryInfo200Response> response = apiInstance.CategoryInfoWithHttpInfo(id, varParams, responseFields, exclude, storeId, langId, schemaType, reportRequestId, disableReportCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Retrieves category&#39;s info specified by category id |  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,parent_id,name,description&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **storeId** | **string?** | Retrieves category info  specified by store id | [optional]  |
| **langId** | **string?** | Retrieves category info  specified by language id | [optional]  |
| **schemaType** | **string?** | The name of the requirements set for the provided schema. | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |

### Return type

[**CategoryInfo200Response**](CategoryInfo200Response.md)

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

<a id="categorylist"></a>
# **CategoryList**
> ModelResponseCategoryList CategoryList (int? start = null, int? count = null, string? pageCursor = null, string? parentId = null, string? varParams = null, string? responseFields = null, string? exclude = null, string? storeId = null, string? langId = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, bool? avail = null, string? productType = null, string? findValue = null, string? findWhere = null, string? reportRequestId = null, bool? disableReportCache = null, bool? disableCache = null)

category.list

Get list of categories from store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryListExample
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

            var apiInstance = new CategoryApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var parentId = 6;  // string? | Retrieves categories specified by parent id (optional) 
            var varParams = id,parent_id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,parent_id,name,description")
            var responseFields = {result{categories_count,category{id,parent_id,modified_at{value},images}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = id,parent_id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var storeId = 1;  // string? | Retrieves categories specified by store id (optional) 
            var langId = 3;  // string? | Retrieves categorys specified by language id (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var avail = false;  // bool? | Defines category's visibility status (optional)  (default to true)
            var productType = BICYCLE;  // string? | A categorization for the product (optional) 
            var findValue = Demo category 1;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = name;  // string? | Category search that is specified by field (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)
            var disableCache = false;  // bool? | Disable cache for current request (optional)  (default to false)

            try
            {
                // category.list
                ModelResponseCategoryList result = apiInstance.CategoryList(start, count, pageCursor, parentId, varParams, responseFields, exclude, storeId, langId, createdFrom, createdTo, modifiedFrom, modifiedTo, avail, productType, findValue, findWhere, reportRequestId, disableReportCache, disableCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.list
    ApiResponse<ModelResponseCategoryList> response = apiInstance.CategoryListWithHttpInfo(start, count, pageCursor, parentId, varParams, responseFields, exclude, storeId, langId, createdFrom, createdTo, modifiedFrom, modifiedTo, avail, productType, findValue, findWhere, reportRequestId, disableReportCache, disableCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryListWithHttpInfo: " + e.Message);
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
| **parentId** | **string?** | Retrieves categories specified by parent id | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,parent_id,name,description&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **storeId** | **string?** | Retrieves categories specified by store id | [optional]  |
| **langId** | **string?** | Retrieves categorys specified by language id | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **avail** | **bool?** | Defines category&#39;s visibility status | [optional] [default to true] |
| **productType** | **string?** | A categorization for the product | [optional]  |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Category search that is specified by field | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |
| **disableCache** | **bool?** | Disable cache for current request | [optional] [default to false] |

### Return type

[**ModelResponseCategoryList**](ModelResponseCategoryList.md)

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

<a id="categoryunassign"></a>
# **CategoryUnassign**
> CartConfigUpdate200Response CategoryUnassign (string categoryId, string productId, string? storeId = null)

category.unassign

Unassign category to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryUnassignExample
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

            var apiInstance = new CategoryApi(config);
            var categoryId = 6;  // string | Defines category unassign, specified by category id
            var productId = 10;  // string | Defines category unassign to the product, specified by product id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.unassign
                CartConfigUpdate200Response result = apiInstance.CategoryUnassign(categoryId, productId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryUnassign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryUnassignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.unassign
    ApiResponse<CartConfigUpdate200Response> response = apiInstance.CategoryUnassignWithHttpInfo(categoryId, productId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryUnassignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Defines category unassign, specified by category id |  |
| **productId** | **string** | Defines category unassign to the product, specified by product id |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CartConfigUpdate200Response**](CartConfigUpdate200Response.md)

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

<a id="categoryupdate"></a>
# **CategoryUpdate**
> AccountConfigUpdate200Response CategoryUpdate (string id, string? name = null, string? parentId = null, string? storesIds = null, bool? avail = null, int? sortOrder = null, string? modifiedTime = null, string? description = null, string? shortDescription = null, string? metaTitle = null, string? metaDescription = null, string? metaKeywords = null, string? seoUrl = null, string? langId = null, string? storeId = null)

category.update

Update category in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CategoryUpdateExample
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

            var apiInstance = new CategoryApi(config);
            var id = 10;  // string | Defines category update specified by category id
            var name = NEW Shoes;  // string? | Defines new category’s name (optional) 
            var parentId = 6;  // string? | Defines new parent category id (optional) 
            var storesIds = 1,2;  // string? | Update category in the stores that is specified by comma-separated stores' id (optional) 
            var avail = false;  // bool? | Defines category's visibility status (optional) 
            var sortOrder = 2;  // int? | Sort number in the list (optional) 
            var modifiedTime = 2014-07-30 15:58:41;  // string? | Entity's date modification (optional) 
            var description = New test category;  // string? | Defines new category's description (optional) 
            var shortDescription = Short description. This is very short description;  // string? | Defines short description (optional) 
            var metaTitle = category,test;  // string? | Defines unique meta title for each entity (optional) 
            var metaDescription = category,test;  // string? | Defines unique meta description of a entity (optional) 
            var metaKeywords = category,test;  // string? | Defines unique meta keywords for each entity (optional) 
            var seoUrl = category,test;  // string? | Defines unique category's URL for SEO (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // category.update
                AccountConfigUpdate200Response result = apiInstance.CategoryUpdate(id, name, parentId, storesIds, avail, sortOrder, modifiedTime, description, shortDescription, metaTitle, metaDescription, metaKeywords, seoUrl, langId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoryUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // category.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.CategoryUpdateWithHttpInfo(id, name, parentId, storesIds, avail, sortOrder, modifiedTime, description, shortDescription, metaTitle, metaDescription, metaKeywords, seoUrl, langId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoryApi.CategoryUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Defines category update specified by category id |  |
| **name** | **string?** | Defines new category’s name | [optional]  |
| **parentId** | **string?** | Defines new parent category id | [optional]  |
| **storesIds** | **string?** | Update category in the stores that is specified by comma-separated stores&#39; id | [optional]  |
| **avail** | **bool?** | Defines category&#39;s visibility status | [optional]  |
| **sortOrder** | **int?** | Sort number in the list | [optional]  |
| **modifiedTime** | **string?** | Entity&#39;s date modification | [optional]  |
| **description** | **string?** | Defines new category&#39;s description | [optional]  |
| **shortDescription** | **string?** | Defines short description | [optional]  |
| **metaTitle** | **string?** | Defines unique meta title for each entity | [optional]  |
| **metaDescription** | **string?** | Defines unique meta description of a entity | [optional]  |
| **metaKeywords** | **string?** | Defines unique meta keywords for each entity | [optional]  |
| **seoUrl** | **string?** | Defines unique category&#39;s URL for SEO | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |

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

