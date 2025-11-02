# Org.OpenAPITools.Api.ProductApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductAdd**](ProductApi.md#productadd) | **POST** /product.add.json | product.add |
| [**ProductAddBatch**](ProductApi.md#productaddbatch) | **POST** /product.add.batch.json | product.add.batch |
| [**ProductAttributeList**](ProductApi.md#productattributelist) | **GET** /product.attribute.list.json | product.attribute.list |
| [**ProductAttributeValueSet**](ProductApi.md#productattributevalueset) | **POST** /product.attribute.value.set.json | product.attribute.value.set |
| [**ProductAttributeValueUnset**](ProductApi.md#productattributevalueunset) | **POST** /product.attribute.value.unset.json | product.attribute.value.unset |
| [**ProductBrandList**](ProductApi.md#productbrandlist) | **GET** /product.brand.list.json | product.brand.list |
| [**ProductChildItemFind**](ProductApi.md#productchilditemfind) | **GET** /product.child_item.find.json | product.child_item.find |
| [**ProductChildItemInfo**](ProductApi.md#productchilditeminfo) | **GET** /product.child_item.info.json | product.child_item.info |
| [**ProductChildItemList**](ProductApi.md#productchilditemlist) | **GET** /product.child_item.list.json | product.child_item.list |
| [**ProductCount**](ProductApi.md#productcount) | **GET** /product.count.json | product.count |
| [**ProductCurrencyAdd**](ProductApi.md#productcurrencyadd) | **POST** /product.currency.add.json | product.currency.add |
| [**ProductCurrencyList**](ProductApi.md#productcurrencylist) | **GET** /product.currency.list.json | product.currency.list |
| [**ProductDelete**](ProductApi.md#productdelete) | **DELETE** /product.delete.json | product.delete |
| [**ProductDeleteBatch**](ProductApi.md#productdeletebatch) | **POST** /product.delete.batch.json | product.delete.batch |
| [**ProductFind**](ProductApi.md#productfind) | **GET** /product.find.json | product.find |
| [**ProductImageAdd**](ProductApi.md#productimageadd) | **POST** /product.image.add.json | product.image.add |
| [**ProductImageDelete**](ProductApi.md#productimagedelete) | **DELETE** /product.image.delete.json | product.image.delete |
| [**ProductImageUpdate**](ProductApi.md#productimageupdate) | **PUT** /product.image.update.json | product.image.update |
| [**ProductInfo**](ProductApi.md#productinfo) | **GET** /product.info.json | product.info |
| [**ProductList**](ProductApi.md#productlist) | **GET** /product.list.json | product.list |
| [**ProductManufacturerAdd**](ProductApi.md#productmanufactureradd) | **POST** /product.manufacturer.add.json | product.manufacturer.add |
| [**ProductOptionAdd**](ProductApi.md#productoptionadd) | **POST** /product.option.add.json | product.option.add |
| [**ProductOptionAssign**](ProductApi.md#productoptionassign) | **POST** /product.option.assign.json | product.option.assign |
| [**ProductOptionDelete**](ProductApi.md#productoptiondelete) | **DELETE** /product.option.delete.json | product.option.delete |
| [**ProductOptionList**](ProductApi.md#productoptionlist) | **GET** /product.option.list.json | product.option.list |
| [**ProductOptionValueAdd**](ProductApi.md#productoptionvalueadd) | **POST** /product.option.value.add.json | product.option.value.add |
| [**ProductOptionValueAssign**](ProductApi.md#productoptionvalueassign) | **POST** /product.option.value.assign.json | product.option.value.assign |
| [**ProductOptionValueDelete**](ProductApi.md#productoptionvaluedelete) | **DELETE** /product.option.value.delete.json | product.option.value.delete |
| [**ProductOptionValueUpdate**](ProductApi.md#productoptionvalueupdate) | **PUT** /product.option.value.update.json | product.option.value.update |
| [**ProductPriceAdd**](ProductApi.md#productpriceadd) | **POST** /product.price.add.json | product.price.add |
| [**ProductPriceDelete**](ProductApi.md#productpricedelete) | **DELETE** /product.price.delete.json | product.price.delete |
| [**ProductPriceUpdate**](ProductApi.md#productpriceupdate) | **PUT** /product.price.update.json | product.price.update |
| [**ProductReviewList**](ProductApi.md#productreviewlist) | **GET** /product.review.list.json | product.review.list |
| [**ProductStoreAssign**](ProductApi.md#productstoreassign) | **POST** /product.store.assign.json | product.store.assign |
| [**ProductTaxAdd**](ProductApi.md#producttaxadd) | **POST** /product.tax.add.json | product.tax.add |
| [**ProductUpdate**](ProductApi.md#productupdate) | **PUT** /product.update.json | product.update |
| [**ProductUpdateBatch**](ProductApi.md#productupdatebatch) | **POST** /product.update.batch.json | product.update.batch |
| [**ProductVariantAdd**](ProductApi.md#productvariantadd) | **POST** /product.variant.add.json | product.variant.add |
| [**ProductVariantAddBatch**](ProductApi.md#productvariantaddbatch) | **POST** /product.variant.add.batch.json | product.variant.add.batch |
| [**ProductVariantDelete**](ProductApi.md#productvariantdelete) | **DELETE** /product.variant.delete.json | product.variant.delete |
| [**ProductVariantDeleteBatch**](ProductApi.md#productvariantdeletebatch) | **POST** /product.variant.delete.batch.json | product.variant.delete.batch |
| [**ProductVariantImageAdd**](ProductApi.md#productvariantimageadd) | **POST** /product.variant.image.add.json | product.variant.image.add |
| [**ProductVariantImageDelete**](ProductApi.md#productvariantimagedelete) | **DELETE** /product.variant.image.delete.json | product.variant.image.delete |
| [**ProductVariantPriceAdd**](ProductApi.md#productvariantpriceadd) | **POST** /product.variant.price.add.json | product.variant.price.add |
| [**ProductVariantPriceDelete**](ProductApi.md#productvariantpricedelete) | **DELETE** /product.variant.price.delete.json | product.variant.price.delete |
| [**ProductVariantPriceUpdate**](ProductApi.md#productvariantpriceupdate) | **PUT** /product.variant.price.update.json | product.variant.price.update |
| [**ProductVariantUpdate**](ProductApi.md#productvariantupdate) | **PUT** /product.variant.update.json | product.variant.update |
| [**ProductVariantUpdateBatch**](ProductApi.md#productvariantupdatebatch) | **POST** /product.variant.update.batch.json | product.variant.update.batch |

<a id="productadd"></a>
# **ProductAdd**
> ProductAdd200Response ProductAdd (ProductAdd productAdd)

product.add

Add new product to store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductAddExample
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

            var apiInstance = new ProductApi(config);
            var productAdd = new ProductAdd(); // ProductAdd | 

            try
            {
                // product.add
                ProductAdd200Response result = apiInstance.ProductAdd(productAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.add
    ApiResponse<ProductAdd200Response> response = apiInstance.ProductAddWithHttpInfo(productAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productAdd** | [**ProductAdd**](ProductAdd.md) |  |  |

### Return type

[**ProductAdd200Response**](ProductAdd200Response.md)

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

<a id="productaddbatch"></a>
# **ProductAddBatch**
> CategoryAddBatch200Response ProductAddBatch (ProductAddBatch productAddBatch)

product.add.batch

Add new products to the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductAddBatchExample
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

            var apiInstance = new ProductApi(config);
            var productAddBatch = new ProductAddBatch(); // ProductAddBatch | 

            try
            {
                // product.add.batch
                CategoryAddBatch200Response result = apiInstance.ProductAddBatch(productAddBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAddBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAddBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.add.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductAddBatchWithHttpInfo(productAddBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAddBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productAddBatch** | [**ProductAddBatch**](ProductAddBatch.md) |  |  |

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

<a id="productattributelist"></a>
# **ProductAttributeList**
> ModelResponseProductAttributeList ProductAttributeList (string productId, int? start = null, int? count = null, string? pageCursor = null, string? attributeId = null, string? variantId = null, string? attributeGroupId = null, string? langId = null, string? storeId = null, string? setName = null, string? sortBy = null, string? sortDirection = null, string? responseFields = null, string? varParams = null, string? exclude = null)

product.attribute.list

Get list of attributes and values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductAttributeListExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Retrieves attributes specified by product id
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var attributeId = 156;  // string? | Retrieves info for specified attribute_id (optional) 
            var variantId = 45;  // string? | Defines product's variants specified by variant id (optional) 
            var attributeGroupId = 202;  // string? | Filter by attribute_group_id (optional) 
            var langId = 3;  // string? | Retrieves attributes specified by language id (optional) 
            var storeId = 1;  // string? | Retrieves attributes specified by store id (optional) 
            var setName = Shoes;  // string? | Retrieves attributes specified by set_name in Magento (optional) 
            var sortBy = value;  // string? | Set field to sort by (optional)  (default to "attribute_id")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "asc")
            var responseFields = {pagination,result{attribute}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = attribute_id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "attribute_id,name")
            var exclude = attribute_id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // product.attribute.list
                ModelResponseProductAttributeList result = apiInstance.ProductAttributeList(productId, start, count, pageCursor, attributeId, variantId, attributeGroupId, langId, storeId, setName, sortBy, sortDirection, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttributeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttributeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.attribute.list
    ApiResponse<ModelResponseProductAttributeList> response = apiInstance.ProductAttributeListWithHttpInfo(productId, start, count, pageCursor, attributeId, variantId, attributeGroupId, langId, storeId, setName, sortBy, sortDirection, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttributeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Retrieves attributes specified by product id |  |
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **attributeId** | **string?** | Retrieves info for specified attribute_id | [optional]  |
| **variantId** | **string?** | Defines product&#39;s variants specified by variant id | [optional]  |
| **attributeGroupId** | **string?** | Filter by attribute_group_id | [optional]  |
| **langId** | **string?** | Retrieves attributes specified by language id | [optional]  |
| **storeId** | **string?** | Retrieves attributes specified by store id | [optional]  |
| **setName** | **string?** | Retrieves attributes specified by set_name in Magento | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;attribute_id&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;asc&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;attribute_id,name&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseProductAttributeList**](ModelResponseProductAttributeList.md)

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

<a id="productattributevalueset"></a>
# **ProductAttributeValueSet**
> ProductAttributeValueSet200Response ProductAttributeValueSet (string productId, string? attributeId = null, string? attributeGroupId = null, string? attributeName = null, string? value = null, int? valueId = null, string? langId = null, string? storeId = null)

product.attribute.value.set

Set attribute value to product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductAttributeValueSetExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the attribute should be added
            var attributeId = 156;  // string? | Filter by attribute_id (optional) 
            var attributeGroupId = 202;  // string? | Filter by attribute_group_id (optional) 
            var attributeName = Color;  // string? | Define attribute name (optional) 
            var value = Red;  // string? | Define attribute value (optional) 
            var valueId = 22;  // int? | Define attribute value id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.attribute.value.set
                ProductAttributeValueSet200Response result = apiInstance.ProductAttributeValueSet(productId, attributeId, attributeGroupId, attributeName, value, valueId, langId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttributeValueSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttributeValueSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.attribute.value.set
    ApiResponse<ProductAttributeValueSet200Response> response = apiInstance.ProductAttributeValueSetWithHttpInfo(productId, attributeId, attributeGroupId, attributeName, value, valueId, langId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttributeValueSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the attribute should be added |  |
| **attributeId** | **string?** | Filter by attribute_id | [optional]  |
| **attributeGroupId** | **string?** | Filter by attribute_group_id | [optional]  |
| **attributeName** | **string?** | Define attribute name | [optional]  |
| **value** | **string?** | Define attribute value | [optional]  |
| **valueId** | **int?** | Define attribute value id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**ProductAttributeValueSet200Response**](ProductAttributeValueSet200Response.md)

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

<a id="productattributevalueunset"></a>
# **ProductAttributeValueUnset**
> ProductAttributeValueUnset200Response ProductAttributeValueUnset (string productId, string attributeId, string? storeId = null, bool? includeDefault = null, bool? reindex = null, bool? clearCache = null)

product.attribute.value.unset

Removes attribute value for a product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductAttributeValueUnsetExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Product id
            var attributeId = 156;  // string | Attribute Id
            var storeId = 1;  // string? | Store Id (optional) 
            var includeDefault = true;  // bool? | Boolean, whether or not to unset default value of the attribute, if applicable (optional)  (default to false)
            var reindex = false;  // bool? | Is reindex required (optional)  (default to true)
            var clearCache = false;  // bool? | Is cache clear required (optional)  (default to true)

            try
            {
                // product.attribute.value.unset
                ProductAttributeValueUnset200Response result = apiInstance.ProductAttributeValueUnset(productId, attributeId, storeId, includeDefault, reindex, clearCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttributeValueUnset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttributeValueUnsetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.attribute.value.unset
    ApiResponse<ProductAttributeValueUnset200Response> response = apiInstance.ProductAttributeValueUnsetWithHttpInfo(productId, attributeId, storeId, includeDefault, reindex, clearCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttributeValueUnsetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Product id |  |
| **attributeId** | **string** | Attribute Id |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **includeDefault** | **bool?** | Boolean, whether or not to unset default value of the attribute, if applicable | [optional] [default to false] |
| **reindex** | **bool?** | Is reindex required | [optional] [default to true] |
| **clearCache** | **bool?** | Is cache clear required | [optional] [default to true] |

### Return type

[**ProductAttributeValueUnset200Response**](ProductAttributeValueUnset200Response.md)

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

<a id="productbrandlist"></a>
# **ProductBrandList**
> ModelResponseProductBrandList ProductBrandList (int? start = null, int? count = null, string? pageCursor = null, string? brandIds = null, string? categoryId = null, string? parentId = null, string? storeId = null, string? langId = null, string? findWhere = null, string? findValue = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? responseFields = null, string? varParams = null, string? exclude = null)

product.brand.list

Get list of brands from your store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductBrandListExample
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

            var apiInstance = new ProductApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var brandIds = 4,5;  // string? | Retrieves brands specified by brand ids (optional) 
            var categoryId = 6;  // string? | Retrieves product brands specified by category id (optional) 
            var parentId = 6;  // string? | Retrieves brands specified by parent id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var findWhere = name;  // string? | Entity search that is specified by the comma-separated unique fields (optional) 
            var findValue = Phone;  // string? | Entity search that is specified by some value (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var responseFields = {return_code,return_message,pagination,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,short_description,active,url")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // product.brand.list
                ModelResponseProductBrandList result = apiInstance.ProductBrandList(start, count, pageCursor, brandIds, categoryId, parentId, storeId, langId, findWhere, findValue, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductBrandList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductBrandListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.brand.list
    ApiResponse<ModelResponseProductBrandList> response = apiInstance.ProductBrandListWithHttpInfo(start, count, pageCursor, brandIds, categoryId, parentId, storeId, langId, findWhere, findValue, createdFrom, createdTo, modifiedFrom, modifiedTo, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductBrandListWithHttpInfo: " + e.Message);
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
| **brandIds** | **string?** | Retrieves brands specified by brand ids | [optional]  |
| **categoryId** | **string?** | Retrieves product brands specified by category id | [optional]  |
| **parentId** | **string?** | Retrieves brands specified by parent id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **findWhere** | **string?** | Entity search that is specified by the comma-separated unique fields | [optional]  |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,short_description,active,url&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseProductBrandList**](ModelResponseProductBrandList.md)

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

<a id="productchilditemfind"></a>
# **ProductChildItemFind**
> ProductChildItemFind200Response ProductChildItemFind (string? findValue = null, string? findWhere = null, string? findParams = null, string? storeId = null)

product.child_item.find

Search product child item (bundled item or configurable product variant) in store catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductChildItemFindExample
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

            var apiInstance = new ProductApi(config);
            var findValue = bundled-item-123-;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = sku;  // string? | Entity search that is specified by the comma-separated unique fields (optional) 
            var findParams = regex;  // string? | Entity search that is specified by comma-separated parameters (optional)  (default to "whole_words")
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.child_item.find
                ProductChildItemFind200Response result = apiInstance.ProductChildItemFind(findValue, findWhere, findParams, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductChildItemFind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductChildItemFindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.child_item.find
    ApiResponse<ProductChildItemFind200Response> response = apiInstance.ProductChildItemFindWithHttpInfo(findValue, findWhere, findParams, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductChildItemFindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Entity search that is specified by the comma-separated unique fields | [optional]  |
| **findParams** | **string?** | Entity search that is specified by comma-separated parameters | [optional] [default to &quot;whole_words&quot;] |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**ProductChildItemFind200Response**](ProductChildItemFind200Response.md)

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

<a id="productchilditeminfo"></a>
# **ProductChildItemInfo**
> ProductChildItemInfo200Response ProductChildItemInfo (string productId, string id, string? storeId = null, string? langId = null, string? currencyId = null, string? responseFields = null, string? varParams = null, string? exclude = null, bool? useLatestApiVersion = null)

product.child_item.info

Get child for specific product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductChildItemInfoExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Filter by parent product id
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var responseFields = {result{id,parent_id,sku,upc,images,combination}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // product.child_item.info
                ProductChildItemInfo200Response result = apiInstance.ProductChildItemInfo(productId, id, storeId, langId, currencyId, responseFields, varParams, exclude, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductChildItemInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductChildItemInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.child_item.info
    ApiResponse<ProductChildItemInfo200Response> response = apiInstance.ProductChildItemInfoWithHttpInfo(productId, id, storeId, langId, currencyId, responseFields, varParams, exclude, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductChildItemInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Filter by parent product id |  |
| **id** | **string** | Entity id |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**ProductChildItemInfo200Response**](ProductChildItemInfo200Response.md)

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

<a id="productchilditemlist"></a>
# **ProductChildItemList**
> ModelResponseProductChildItemList ProductChildItemList (int? start = null, int? count = null, string? pageCursor = null, string? productId = null, string? productIds = null, string? sku = null, string? storeId = null, string? langId = null, string? currencyId = null, bool? availSale = null, string? findValue = null, string? findWhere = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, bool? returnGlobal = null, string? responseFields = null, string? varParams = null, string? exclude = null, string? reportRequestId = null, bool? disableReportCache = null, bool? useLatestApiVersion = null)

product.child_item.list

Get a list of a product's child items, such as variants or bundle components. The total_count field in the response indicates the total number of items in the context of the current filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductChildItemListExample
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

            var apiInstance = new ProductApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve products child items via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var productId = 10;  // string? | Filter by parent product id (optional) 
            var productIds = 4,5;  // string? | Filter by parent product ids (optional) 
            var sku = bag_01;  // string? | Filter by products variant's sku (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var availSale = false;  // bool? | Specifies the set of available/not available products for sale (optional) 
            var findValue = bundled-item-123-;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = sku;  // string? | Child products search that is specified by field (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var returnGlobal = false;  // bool? | Determines the type of products to be returned. If set to 'true', only global products will be returned; if set to 'false', only local products will be returned. (optional)  (default to false)
            var responseFields = {result{children{id,parent_id,sku,upc,images,combination}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // product.child_item.list
                ModelResponseProductChildItemList result = apiInstance.ProductChildItemList(start, count, pageCursor, productId, productIds, sku, storeId, langId, currencyId, availSale, findValue, findWhere, createdFrom, createdTo, modifiedFrom, modifiedTo, returnGlobal, responseFields, varParams, exclude, reportRequestId, disableReportCache, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductChildItemList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductChildItemListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.child_item.list
    ApiResponse<ModelResponseProductChildItemList> response = apiInstance.ProductChildItemListWithHttpInfo(start, count, pageCursor, productId, productIds, sku, storeId, langId, currencyId, availSale, findValue, findWhere, createdFrom, createdTo, modifiedFrom, modifiedTo, returnGlobal, responseFields, varParams, exclude, reportRequestId, disableReportCache, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductChildItemListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve products child items via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **productId** | **string?** | Filter by parent product id | [optional]  |
| **productIds** | **string?** | Filter by parent product ids | [optional]  |
| **sku** | **string?** | Filter by products variant&#39;s sku | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **availSale** | **bool?** | Specifies the set of available/not available products for sale | [optional]  |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Child products search that is specified by field | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **returnGlobal** | **bool?** | Determines the type of products to be returned. If set to &#39;true&#39;, only global products will be returned; if set to &#39;false&#39;, only local products will be returned. | [optional] [default to false] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**ModelResponseProductChildItemList**](ModelResponseProductChildItemList.md)

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

<a id="productcount"></a>
# **ProductCount**
> ProductCount200Response ProductCount (string? sku = null, string? productIds = null, string? sinceId = null, string? categoriesIds = null, string? categoryId = null, string? storeId = null, string? langId = null, bool? availView = null, bool? availSale = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? brandName = null, string? manufacturerId = null, List<string>? productAttributes = null, string? status = null, string? type = null, string? visible = null, string? findValue = null, string? findWhere = null, string? reportRequestId = null, bool? returnGlobal = null, bool? disableReportCache = null, bool? useLatestApiVersion = null)

product.count

Count products in store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductCountExample
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

            var apiInstance = new ProductApi(config);
            var sku = bag_01;  // string? | Filter by product's sku (optional) 
            var productIds = 4,5;  // string? | Counts products specified by product ids (optional) 
            var sinceId = 56;  // string? | Retrieve entities starting from the specified id. (optional) 
            var categoriesIds = 23,56;  // string? | Defines product add that is specified by comma-separated categories id (optional) 
            var categoryId = 6;  // string? | Counts products specified by category id (optional) 
            var storeId = 1;  // string? | Counts products specified by store id (optional) 
            var langId = 3;  // string? | Counts products specified by language id (optional) 
            var availView = true;  // bool? | Specifies the set of visible/invisible products (optional) 
            var availSale = false;  // bool? | Specifies the set of available/not available products for sale (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var brandName = Abidas;  // string? | Retrieves brands specified by brand name (optional) 
            var manufacturerId = 1;  // string? | Defines product's manufacturer by manufacturer_id (optional) 
            var productAttributes = new List<string>?(); // List<string>? | Defines product attributes (optional) 
            var status = disabled;  // string? | Defines product's status (optional) 
            var type = simple;  // string? | Defines products's type (optional) 
            var visible = everywhere;  // string? | Filter items by visibility status (optional)  (default to "everywhere")
            var findValue = Phone;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = name;  // string? | Counts products that are searched specified by field (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var returnGlobal = false;  // bool? | Determines the type of products to be returned. If set to 'true', only global products will be returned; if set to 'false', only local products will be returned. (optional)  (default to false)
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // product.count
                ProductCount200Response result = apiInstance.ProductCount(sku, productIds, sinceId, categoriesIds, categoryId, storeId, langId, availView, availSale, createdFrom, createdTo, modifiedFrom, modifiedTo, brandName, manufacturerId, productAttributes, status, type, visible, findValue, findWhere, reportRequestId, returnGlobal, disableReportCache, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.count
    ApiResponse<ProductCount200Response> response = apiInstance.ProductCountWithHttpInfo(sku, productIds, sinceId, categoriesIds, categoryId, storeId, langId, availView, availSale, createdFrom, createdTo, modifiedFrom, modifiedTo, brandName, manufacturerId, productAttributes, status, type, visible, findValue, findWhere, reportRequestId, returnGlobal, disableReportCache, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sku** | **string?** | Filter by product&#39;s sku | [optional]  |
| **productIds** | **string?** | Counts products specified by product ids | [optional]  |
| **sinceId** | **string?** | Retrieve entities starting from the specified id. | [optional]  |
| **categoriesIds** | **string?** | Defines product add that is specified by comma-separated categories id | [optional]  |
| **categoryId** | **string?** | Counts products specified by category id | [optional]  |
| **storeId** | **string?** | Counts products specified by store id | [optional]  |
| **langId** | **string?** | Counts products specified by language id | [optional]  |
| **availView** | **bool?** | Specifies the set of visible/invisible products | [optional]  |
| **availSale** | **bool?** | Specifies the set of available/not available products for sale | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **brandName** | **string?** | Retrieves brands specified by brand name | [optional]  |
| **manufacturerId** | **string?** | Defines product&#39;s manufacturer by manufacturer_id | [optional]  |
| **productAttributes** | [**List&lt;string&gt;?**](string.md) | Defines product attributes | [optional]  |
| **status** | **string?** | Defines product&#39;s status | [optional]  |
| **type** | **string?** | Defines products&#39;s type | [optional]  |
| **visible** | **string?** | Filter items by visibility status | [optional] [default to &quot;everywhere&quot;] |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Counts products that are searched specified by field | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **returnGlobal** | **bool?** | Determines the type of products to be returned. If set to &#39;true&#39;, only global products will be returned; if set to &#39;false&#39;, only local products will be returned. | [optional] [default to false] |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**ProductCount200Response**](ProductCount200Response.md)

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

<a id="productcurrencyadd"></a>
# **ProductCurrencyAdd**
> ProductCurrencyAdd200Response ProductCurrencyAdd (string iso3, decimal rate, string? name = null, bool? avail = null, string? symbolLeft = null, string? symbolRight = null, bool? varDefault = null)

product.currency.add

Add currency and/or set default in store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductCurrencyAddExample
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

            var apiInstance = new ProductApi(config);
            var iso3 = USD;  // string | Specifies standardized currency code
            var rate = 1;  // decimal | Defines the numerical identifier against to the major currency
            var name = US Dollar;  // string? | Defines currency's name (optional) 
            var avail = false;  // bool? | Specifies whether the currency is available (optional)  (default to true)
            var symbolLeft = $;  // string? | Defines the symbol that is located before the currency (optional) 
            var symbolRight = грн;  // string? | Defines the symbol that is located after the currency (optional) 
            var varDefault = true;  // bool? | Specifies currency's default meaning (optional)  (default to false)

            try
            {
                // product.currency.add
                ProductCurrencyAdd200Response result = apiInstance.ProductCurrencyAdd(iso3, rate, name, avail, symbolLeft, symbolRight, varDefault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCurrencyAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCurrencyAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.currency.add
    ApiResponse<ProductCurrencyAdd200Response> response = apiInstance.ProductCurrencyAddWithHttpInfo(iso3, rate, name, avail, symbolLeft, symbolRight, varDefault);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCurrencyAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iso3** | **string** | Specifies standardized currency code |  |
| **rate** | **decimal** | Defines the numerical identifier against to the major currency |  |
| **name** | **string?** | Defines currency&#39;s name | [optional]  |
| **avail** | **bool?** | Specifies whether the currency is available | [optional] [default to true] |
| **symbolLeft** | **string?** | Defines the symbol that is located before the currency | [optional]  |
| **symbolRight** | **string?** | Defines the symbol that is located after the currency | [optional]  |
| **varDefault** | **bool?** | Specifies currency&#39;s default meaning | [optional] [default to false] |

### Return type

[**ProductCurrencyAdd200Response**](ProductCurrencyAdd200Response.md)

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

<a id="productcurrencylist"></a>
# **ProductCurrencyList**
> ModelResponseProductCurrencyList ProductCurrencyList (int? start = null, int? count = null, string? pageCursor = null, bool? varDefault = null, bool? avail = null, string? responseFields = null, string? varParams = null, string? exclude = null)

product.currency.list

Get list of currencies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductCurrencyListExample
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

            var apiInstance = new ProductApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var varDefault = true;  // bool? | Specifies the set of default/not default currencies (optional) 
            var avail = false;  // bool? | Specifies the set of available/not available currencies (optional) 
            var responseFields = {return_message,pagination,result{currency}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = name,iso3,default,avail;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "name,iso3,default,avail")
            var exclude = name,iso3,default,avail;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // product.currency.list
                ModelResponseProductCurrencyList result = apiInstance.ProductCurrencyList(start, count, pageCursor, varDefault, avail, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductCurrencyList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductCurrencyListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.currency.list
    ApiResponse<ModelResponseProductCurrencyList> response = apiInstance.ProductCurrencyListWithHttpInfo(start, count, pageCursor, varDefault, avail, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductCurrencyListWithHttpInfo: " + e.Message);
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
| **varDefault** | **bool?** | Specifies the set of default/not default currencies | [optional]  |
| **avail** | **bool?** | Specifies the set of available/not available currencies | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;name,iso3,default,avail&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseProductCurrencyList**](ModelResponseProductCurrencyList.md)

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

<a id="productdelete"></a>
# **ProductDelete**
> CustomerDelete200Response ProductDelete (string id, string? storeId = null)

product.delete

Product delete

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductDeleteExample
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

            var apiInstance = new ProductApi(config);
            var id = 10;  // string | Product id that will be removed
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.delete
                CustomerDelete200Response result = apiInstance.ProductDelete(id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.delete
    ApiResponse<CustomerDelete200Response> response = apiInstance.ProductDeleteWithHttpInfo(id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Product id that will be removed |  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**CustomerDelete200Response**](CustomerDelete200Response.md)

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

<a id="productdeletebatch"></a>
# **ProductDeleteBatch**
> CategoryAddBatch200Response ProductDeleteBatch (ProductDeleteBatch productDeleteBatch)

product.delete.batch

Remove product from the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductDeleteBatchExample
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

            var apiInstance = new ProductApi(config);
            var productDeleteBatch = new ProductDeleteBatch(); // ProductDeleteBatch | 

            try
            {
                // product.delete.batch
                CategoryAddBatch200Response result = apiInstance.ProductDeleteBatch(productDeleteBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductDeleteBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductDeleteBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.delete.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductDeleteBatchWithHttpInfo(productDeleteBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductDeleteBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productDeleteBatch** | [**ProductDeleteBatch**](ProductDeleteBatch.md) |  |  |

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

<a id="productfind"></a>
# **ProductFind**
> ProductFind200Response ProductFind (string findValue, string? findWhere = null, string? findParams = null, string? findWhat = null, string? langId = null, string? storeId = null)

product.find

Search product in store catalog. \"Apple\" is specified here by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductFindExample
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

            var apiInstance = new ProductApi(config);
            var findValue = Simple;  // string | Entity search that is specified by some value
            var findWhere = name;  // string? | Entity search that is specified by the comma-separated unique fields (optional)  (default to "name")
            var findParams = regex;  // string? | Entity search that is specified by comma-separated parameters (optional)  (default to "whole_words")
            var findWhat = each;  // string? | Parameter's value specifies the entity that has to be found (optional)  (default to "product")
            var langId = 3;  // string? | Search products specified by language id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.find
                ProductFind200Response result = apiInstance.ProductFind(findValue, findWhere, findParams, findWhat, langId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductFind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductFindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.find
    ApiResponse<ProductFind200Response> response = apiInstance.ProductFindWithHttpInfo(findValue, findWhere, findParams, findWhat, langId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductFindWithHttpInfo: " + e.Message);
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
| **findWhat** | **string?** | Parameter&#39;s value specifies the entity that has to be found | [optional] [default to &quot;product&quot;] |
| **langId** | **string?** | Search products specified by language id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |

### Return type

[**ProductFind200Response**](ProductFind200Response.md)

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

<a id="productimageadd"></a>
# **ProductImageAdd**
> ProductImageAdd200Response ProductImageAdd (ProductImageAdd productImageAdd)

product.image.add

Add image to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductImageAddExample
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

            var apiInstance = new ProductApi(config);
            var productImageAdd = new ProductImageAdd(); // ProductImageAdd | 

            try
            {
                // product.image.add
                ProductImageAdd200Response result = apiInstance.ProductImageAdd(productImageAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductImageAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductImageAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.image.add
    ApiResponse<ProductImageAdd200Response> response = apiInstance.ProductImageAddWithHttpInfo(productImageAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductImageAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productImageAdd** | [**ProductImageAdd**](ProductImageAdd.md) |  |  |

### Return type

[**ProductImageAdd200Response**](ProductImageAdd200Response.md)

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

<a id="productimagedelete"></a>
# **ProductImageDelete**
> AttributeDelete200Response ProductImageDelete (string productId, string id, string? storeId = null)

product.image.delete

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
    public class ProductImageDeleteExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the image should be deleted
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.image.delete
                AttributeDelete200Response result = apiInstance.ProductImageDelete(productId, id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductImageDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductImageDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.image.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductImageDeleteWithHttpInfo(productId, id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductImageDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the image should be deleted |  |
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

<a id="productimageupdate"></a>
# **ProductImageUpdate**
> ProductImageUpdate200Response ProductImageUpdate (string productId, string id, string? variantIds = null, string? storeId = null, string? langId = null, string? imageName = null, string? type = null, string? label = null, int? position = null, bool? hidden = null)

product.image.update

Update details of image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductImageUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the image should be updated
            var id = 10;  // string | Defines image update specified by image id
            var variantIds = 1,2,3,4,5;  // string? | Defines product's variants ids (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var imageName = data/product/main/product_69_bag-gray.png;  // string? | Defines image's name (optional) 
            var type = thumbnail;  // string? | Defines image's types that are specified by comma-separated list (optional)  (default to "additional")
            var label = This cool image;  // string? | Defines alternative text that has to be attached to the picture (optional) 
            var position = 5;  // int? | Defines image’s position in the list (optional) 
            var hidden = true;  // bool? | Define is hide image (optional) 

            try
            {
                // product.image.update
                ProductImageUpdate200Response result = apiInstance.ProductImageUpdate(productId, id, variantIds, storeId, langId, imageName, type, label, position, hidden);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductImageUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductImageUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.image.update
    ApiResponse<ProductImageUpdate200Response> response = apiInstance.ProductImageUpdateWithHttpInfo(productId, id, variantIds, storeId, langId, imageName, type, label, position, hidden);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductImageUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the image should be updated |  |
| **id** | **string** | Defines image update specified by image id |  |
| **variantIds** | **string?** | Defines product&#39;s variants ids | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **imageName** | **string?** | Defines image&#39;s name | [optional]  |
| **type** | **string?** | Defines image&#39;s types that are specified by comma-separated list | [optional] [default to &quot;additional&quot;] |
| **label** | **string?** | Defines alternative text that has to be attached to the picture | [optional]  |
| **position** | **int?** | Defines image’s position in the list | [optional]  |
| **hidden** | **bool?** | Define is hide image | [optional]  |

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

<a id="productinfo"></a>
# **ProductInfo**
> ProductInfo200Response ProductInfo (string id, string? storeId = null, string? langId = null, string? currencyId = null, string? responseFields = null, string? varParams = null, string? exclude = null, string? reportRequestId = null, bool? disableReportCache = null, bool? useLatestApiVersion = null)

product.info

Get information about a specific product by its ID. In the case of a multistore configuration, use the store_id filter to get a response in the context of a specific store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductInfoExample
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

            var apiInstance = new ProductApi(config);
            var id = 10;  // string | Retrieves product's info specified by product id
            var storeId = 1;  // string? | Retrieves product info specified by store id (optional) 
            var langId = 3;  // string? | Retrieves product info specified by language id (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var responseFields = {result{id,name,price,images}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,description,price,categories_ids")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)

            try
            {
                // product.info
                ProductInfo200Response result = apiInstance.ProductInfo(id, storeId, langId, currencyId, responseFields, varParams, exclude, reportRequestId, disableReportCache, useLatestApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.info
    ApiResponse<ProductInfo200Response> response = apiInstance.ProductInfoWithHttpInfo(id, storeId, langId, currencyId, responseFields, varParams, exclude, reportRequestId, disableReportCache, useLatestApiVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Retrieves product&#39;s info specified by product id |  |
| **storeId** | **string?** | Retrieves product info specified by store id | [optional]  |
| **langId** | **string?** | Retrieves product info specified by language id | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,description,price,categories_ids&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |

### Return type

[**ProductInfo200Response**](ProductInfo200Response.md)

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

<a id="productlist"></a>
# **ProductList**
> ModelResponseProductList ProductList (int? start = null, int? count = null, string? pageCursor = null, string? productIds = null, string? sinceId = null, string? categoriesIds = null, string? categoryId = null, string? storeId = null, string? langId = null, string? currencyId = null, bool? availView = null, bool? availSale = null, string? createdFrom = null, string? createdTo = null, string? modifiedFrom = null, string? modifiedTo = null, string? sku = null, string? brandName = null, List<string>? productAttributes = null, string? manufacturerId = null, string? status = null, string? type = null, string? visible = null, string? findValue = null, string? findWhere = null, bool? returnGlobal = null, string? varParams = null, string? responseFields = null, string? exclude = null, string? sortBy = null, string? sortDirection = null, string? reportRequestId = null, bool? disableCache = null, bool? disableReportCache = null, bool? useLatestApiVersion = null, string? productType = null)

product.list

Get list of products from your store. Returns 10 products by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductListExample
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

            var apiInstance = new ProductApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve products via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var productIds = 4,5;  // string? | Retrieves products specified by product ids (optional) 
            var sinceId = 56;  // string? | Retrieve entities starting from the specified id. (optional) 
            var categoriesIds = 23,56;  // string? | Retrieves products specified by categories ids (optional) 
            var categoryId = 6;  // string? | Retrieves products specified by category id (optional) 
            var storeId = 1;  // string? | Retrieves products specified by store id (optional) 
            var langId = 3;  // string? | Retrieves products specified by language id (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var availView = true;  // bool? | Specifies the set of visible/invisible products (optional) 
            var availSale = false;  // bool? | Specifies the set of available/not available products for sale (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var modifiedFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their modification date (optional) 
            var modifiedTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their modification date (optional) 
            var sku = bag_01;  // string? | Filter by product's sku (optional) 
            var brandName = Abidas;  // string? | Retrieves brands specified by brand name (optional) 
            var productAttributes = new List<string>?(); // List<string>? | Defines product attributes (optional) 
            var manufacturerId = 1;  // string? | Defines product's manufacturer by manufacturer_id (optional) 
            var status = disabled;  // string? | Defines product's status (optional) 
            var type = simple;  // string? | Defines products's type (optional) 
            var visible = everywhere;  // string? | Filter items by visibility status (optional)  (default to "everywhere")
            var findValue = Phone;  // string? | Entity search that is specified by some value (optional) 
            var findWhere = name;  // string? | Product search that is specified by field (optional) 
            var returnGlobal = false;  // bool? | Determines the type of products to be returned. If set to 'true', only global products will be returned; if set to 'false', only local products will be returned. (optional)  (default to false)
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,description,price,categories_ids")
            var responseFields = {return_code,pagination,result{product{id,name,price,images}}};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 
            var sortBy = value_id;  // string? | Set field to sort by (optional)  (default to "id")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "asc")
            var reportRequestId = 105245017661;  // string? | Report request id (optional) 
            var disableCache = false;  // bool? | Disable cache for current request (optional)  (default to false)
            var disableReportCache = false;  // bool? | Disable report cache for current request (optional)  (default to false)
            var useLatestApiVersion = true;  // bool? | Use the latest platform API version (optional)  (default to false)
            var productType = BICYCLE;  // string? | A categorization for the product (optional) 

            try
            {
                // product.list
                ModelResponseProductList result = apiInstance.ProductList(start, count, pageCursor, productIds, sinceId, categoriesIds, categoryId, storeId, langId, currencyId, availView, availSale, createdFrom, createdTo, modifiedFrom, modifiedTo, sku, brandName, productAttributes, manufacturerId, status, type, visible, findValue, findWhere, returnGlobal, varParams, responseFields, exclude, sortBy, sortDirection, reportRequestId, disableCache, disableReportCache, useLatestApiVersion, productType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.list
    ApiResponse<ModelResponseProductList> response = apiInstance.ProductListWithHttpInfo(start, count, pageCursor, productIds, sinceId, categoriesIds, categoryId, storeId, langId, currencyId, availView, availSale, createdFrom, createdTo, modifiedFrom, modifiedTo, sku, brandName, productAttributes, manufacturerId, status, type, visible, findValue, findWhere, returnGlobal, varParams, responseFields, exclude, sortBy, sortDirection, reportRequestId, disableCache, disableReportCache, useLatestApiVersion, productType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve products via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **productIds** | **string?** | Retrieves products specified by product ids | [optional]  |
| **sinceId** | **string?** | Retrieve entities starting from the specified id. | [optional]  |
| **categoriesIds** | **string?** | Retrieves products specified by categories ids | [optional]  |
| **categoryId** | **string?** | Retrieves products specified by category id | [optional]  |
| **storeId** | **string?** | Retrieves products specified by store id | [optional]  |
| **langId** | **string?** | Retrieves products specified by language id | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **availView** | **bool?** | Specifies the set of visible/invisible products | [optional]  |
| **availSale** | **bool?** | Specifies the set of available/not available products for sale | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **modifiedFrom** | **string?** | Retrieve entities from their modification date | [optional]  |
| **modifiedTo** | **string?** | Retrieve entities to their modification date | [optional]  |
| **sku** | **string?** | Filter by product&#39;s sku | [optional]  |
| **brandName** | **string?** | Retrieves brands specified by brand name | [optional]  |
| **productAttributes** | [**List&lt;string&gt;?**](string.md) | Defines product attributes | [optional]  |
| **manufacturerId** | **string?** | Defines product&#39;s manufacturer by manufacturer_id | [optional]  |
| **status** | **string?** | Defines product&#39;s status | [optional]  |
| **type** | **string?** | Defines products&#39;s type | [optional]  |
| **visible** | **string?** | Filter items by visibility status | [optional] [default to &quot;everywhere&quot;] |
| **findValue** | **string?** | Entity search that is specified by some value | [optional]  |
| **findWhere** | **string?** | Product search that is specified by field | [optional]  |
| **returnGlobal** | **bool?** | Determines the type of products to be returned. If set to &#39;true&#39;, only global products will be returned; if set to &#39;false&#39;, only local products will be returned. | [optional] [default to false] |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,description,price,categories_ids&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;id&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;asc&quot;] |
| **reportRequestId** | **string?** | Report request id | [optional]  |
| **disableCache** | **bool?** | Disable cache for current request | [optional] [default to false] |
| **disableReportCache** | **bool?** | Disable report cache for current request | [optional] [default to false] |
| **useLatestApiVersion** | **bool?** | Use the latest platform API version | [optional] [default to false] |
| **productType** | **string?** | A categorization for the product | [optional]  |

### Return type

[**ModelResponseProductList**](ModelResponseProductList.md)

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

<a id="productmanufactureradd"></a>
# **ProductManufacturerAdd**
> ProductManufacturerAdd200Response ProductManufacturerAdd (string productId, string manufacturer, string? storeId = null, string? metaTitle = null, string? metaKeywords = null, string? metaDescription = null, string? searchKeywords = null, string? imageUrl = null, string? seoUrl = null)

product.manufacturer.add

Add manufacturer to store and assign to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductManufacturerAddExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines products specified by product id
            var manufacturer = Samsung;  // string | Defines product’s manufacturer's name
            var storeId = 1;  // string? | Store Id (optional) 
            var metaTitle = category,test;  // string? | Defines unique meta title for each entity (optional) 
            var metaKeywords = category,test;  // string? | Defines unique meta keywords for each entity (optional) 
            var metaDescription = category,test;  // string? | Defines unique meta description of a entity (optional) 
            var searchKeywords = key1,key2,key3;  // string? | Defines unique search keywords (optional) 
            var imageUrl = https://docs.api2cart.com/img/logo.png;  // string? | Image Url (optional) 
            var seoUrl = some seo url;  // string? | Defines unique URL for SEO (optional) 

            try
            {
                // product.manufacturer.add
                ProductManufacturerAdd200Response result = apiInstance.ProductManufacturerAdd(productId, manufacturer, storeId, metaTitle, metaKeywords, metaDescription, searchKeywords, imageUrl, seoUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductManufacturerAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductManufacturerAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.manufacturer.add
    ApiResponse<ProductManufacturerAdd200Response> response = apiInstance.ProductManufacturerAddWithHttpInfo(productId, manufacturer, storeId, metaTitle, metaKeywords, metaDescription, searchKeywords, imageUrl, seoUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductManufacturerAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines products specified by product id |  |
| **manufacturer** | **string** | Defines product’s manufacturer&#39;s name |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **metaTitle** | **string?** | Defines unique meta title for each entity | [optional]  |
| **metaKeywords** | **string?** | Defines unique meta keywords for each entity | [optional]  |
| **metaDescription** | **string?** | Defines unique meta description of a entity | [optional]  |
| **searchKeywords** | **string?** | Defines unique search keywords | [optional]  |
| **imageUrl** | **string?** | Image Url | [optional]  |
| **seoUrl** | **string?** | Defines unique URL for SEO | [optional]  |

### Return type

[**ProductManufacturerAdd200Response**](ProductManufacturerAdd200Response.md)

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

<a id="productoptionadd"></a>
# **ProductOptionAdd**
> ProductOptionAdd200Response ProductOptionAdd (ProductOptionAdd productOptionAdd)

product.option.add

Add product option from store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionAddExample
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

            var apiInstance = new ProductApi(config);
            var productOptionAdd = new ProductOptionAdd(); // ProductOptionAdd | 

            try
            {
                // product.option.add
                ProductOptionAdd200Response result = apiInstance.ProductOptionAdd(productOptionAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.add
    ApiResponse<ProductOptionAdd200Response> response = apiInstance.ProductOptionAddWithHttpInfo(productOptionAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productOptionAdd** | [**ProductOptionAdd**](ProductOptionAdd.md) |  |  |

### Return type

[**ProductOptionAdd200Response**](ProductOptionAdd200Response.md)

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

<a id="productoptionassign"></a>
# **ProductOptionAssign**
> ProductOptionAssign200Response ProductOptionAssign (string productId, string optionId, bool? required = null, int? sortOrder = null, string? optionValues = null, bool? clearCache = null)

product.option.assign

Assign option from product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionAssignExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the option should be assigned
            var optionId = 5;  // string | Defines option id which has to be assigned
            var required = true;  // bool? | Defines if the option is required (optional)  (default to false)
            var sortOrder = 2;  // int? | Sort number in the list (optional)  (default to 0)
            var optionValues = green,black,yellow;  // string? | Defines option values that has to be assigned (optional) 
            var clearCache = false;  // bool? | Is cache clear required (optional)  (default to true)

            try
            {
                // product.option.assign
                ProductOptionAssign200Response result = apiInstance.ProductOptionAssign(productId, optionId, required, sortOrder, optionValues, clearCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.assign
    ApiResponse<ProductOptionAssign200Response> response = apiInstance.ProductOptionAssignWithHttpInfo(productId, optionId, required, sortOrder, optionValues, clearCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the option should be assigned |  |
| **optionId** | **string** | Defines option id which has to be assigned |  |
| **required** | **bool?** | Defines if the option is required | [optional] [default to false] |
| **sortOrder** | **int?** | Sort number in the list | [optional] [default to 0] |
| **optionValues** | **string?** | Defines option values that has to be assigned | [optional]  |
| **clearCache** | **bool?** | Is cache clear required | [optional] [default to true] |

### Return type

[**ProductOptionAssign200Response**](ProductOptionAssign200Response.md)

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

<a id="productoptiondelete"></a>
# **ProductOptionDelete**
> AttributeDelete200Response ProductOptionDelete (string optionId, string productId, string? storeId = null)

product.option.delete

Product option delete.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionDeleteExample
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

            var apiInstance = new ProductApi(config);
            var optionId = 5;  // string | Defines option id that should be deleted
            var productId = 10;  // string | Defines product id where the option should be deleted
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.option.delete
                AttributeDelete200Response result = apiInstance.ProductOptionDelete(optionId, productId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductOptionDeleteWithHttpInfo(optionId, productId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optionId** | **string** | Defines option id that should be deleted |  |
| **productId** | **string** | Defines product id where the option should be deleted |  |
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

<a id="productoptionlist"></a>
# **ProductOptionList**
> ModelResponseProductOptionList ProductOptionList (int? start = null, int? count = null, string? productId = null, string? langId = null, string? storeId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

product.option.list

Get list of options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionListExample
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

            var apiInstance = new ProductApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var productId = 10;  // string? | Retrieves products' options specified by product id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var responseFields = {return_code,return_message,pagination,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,name,sort_order;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,description")
            var exclude = id,name,sort_order;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // product.option.list
                ModelResponseProductOptionList result = apiInstance.ProductOptionList(start, count, productId, langId, storeId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.list
    ApiResponse<ModelResponseProductOptionList> response = apiInstance.ProductOptionListWithHttpInfo(start, count, productId, langId, storeId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **productId** | **string?** | Retrieves products&#39; options specified by product id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,description&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseProductOptionList**](ModelResponseProductOptionList.md)

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

<a id="productoptionvalueadd"></a>
# **ProductOptionValueAdd**
> ProductOptionValueAdd200Response ProductOptionValueAdd (string productId, string optionId, string? optionValue = null, int? sortOrder = null, string? displayValue = null, bool? isDefault = null, bool? clearCache = null)

product.option.value.add

Add product option item from option.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionValueAddExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the option value should be added
            var optionId = 5;  // string | Defines option id where the value has to be added
            var optionValue = green;  // string? | Defines option value that has to be added (optional) 
            var sortOrder = 2;  // int? | Sort number in the list (optional)  (default to 0)
            var displayValue = value;  // string? | Defines the value that will be displayed for the option value (optional) 
            var isDefault = true;  // bool? | Defines as a default (optional) 
            var clearCache = false;  // bool? | Is cache clear required (optional)  (default to true)

            try
            {
                // product.option.value.add
                ProductOptionValueAdd200Response result = apiInstance.ProductOptionValueAdd(productId, optionId, optionValue, sortOrder, displayValue, isDefault, clearCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionValueAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionValueAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.value.add
    ApiResponse<ProductOptionValueAdd200Response> response = apiInstance.ProductOptionValueAddWithHttpInfo(productId, optionId, optionValue, sortOrder, displayValue, isDefault, clearCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionValueAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the option value should be added |  |
| **optionId** | **string** | Defines option id where the value has to be added |  |
| **optionValue** | **string?** | Defines option value that has to be added | [optional]  |
| **sortOrder** | **int?** | Sort number in the list | [optional] [default to 0] |
| **displayValue** | **string?** | Defines the value that will be displayed for the option value | [optional]  |
| **isDefault** | **bool?** | Defines as a default | [optional]  |
| **clearCache** | **bool?** | Is cache clear required | [optional] [default to true] |

### Return type

[**ProductOptionValueAdd200Response**](ProductOptionValueAdd200Response.md)

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

<a id="productoptionvalueassign"></a>
# **ProductOptionValueAssign**
> ProductOptionValueAssign200Response ProductOptionValueAssign (int productOptionId, string optionValueId, bool? clearCache = null)

product.option.value.assign

Assign product option item from product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionValueAssignExample
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

            var apiInstance = new ProductApi(config);
            var productOptionId = 5;  // int | Defines product's option id where the value has to be assigned
            var optionValueId = 45;  // string | Defines value id that has to be assigned
            var clearCache = false;  // bool? | Is cache clear required (optional)  (default to true)

            try
            {
                // product.option.value.assign
                ProductOptionValueAssign200Response result = apiInstance.ProductOptionValueAssign(productOptionId, optionValueId, clearCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionValueAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionValueAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.value.assign
    ApiResponse<ProductOptionValueAssign200Response> response = apiInstance.ProductOptionValueAssignWithHttpInfo(productOptionId, optionValueId, clearCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionValueAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productOptionId** | **int** | Defines product&#39;s option id where the value has to be assigned |  |
| **optionValueId** | **string** | Defines value id that has to be assigned |  |
| **clearCache** | **bool?** | Is cache clear required | [optional] [default to true] |

### Return type

[**ProductOptionValueAssign200Response**](ProductOptionValueAssign200Response.md)

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

<a id="productoptionvaluedelete"></a>
# **ProductOptionValueDelete**
> AttributeDelete200Response ProductOptionValueDelete (string optionId, string optionValueId, string productId, string? storeId = null)

product.option.value.delete

Product option value delete.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionValueDeleteExample
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

            var apiInstance = new ProductApi(config);
            var optionId = 5;  // string | Defines option id where the value should be deleted
            var optionValueId = 45;  // string | Defines option value id that should be deleted
            var productId = 10;  // string | Defines product id where the option value should be deleted
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.option.value.delete
                AttributeDelete200Response result = apiInstance.ProductOptionValueDelete(optionId, optionValueId, productId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionValueDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionValueDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.value.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductOptionValueDeleteWithHttpInfo(optionId, optionValueId, productId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionValueDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optionId** | **string** | Defines option id where the value should be deleted |  |
| **optionValueId** | **string** | Defines option value id that should be deleted |  |
| **productId** | **string** | Defines product id where the option value should be deleted |  |
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

<a id="productoptionvalueupdate"></a>
# **ProductOptionValueUpdate**
> AccountConfigUpdate200Response ProductOptionValueUpdate (string productId, string optionId, string optionValueId, string? optionValue = null, decimal? price = null, decimal? quantity = null, string? displayValue = null, bool? clearCache = null)

product.option.value.update

Update product option item from option.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductOptionValueUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the option value should be updated
            var optionId = 5;  // string | Defines option id where the value has to be updated
            var optionValueId = 45;  // string | Defines value id that has to be assigned
            var optionValue = green;  // string? | Defines option value that has to be added (optional) 
            var price = 99.9;  // decimal? | Defines new product option price (optional) 
            var quantity = 6;  // decimal? | Defines new products' options quantity (optional) 
            var displayValue = value;  // string? | Defines the value that will be displayed for the option value (optional) 
            var clearCache = false;  // bool? | Is cache clear required (optional)  (default to true)

            try
            {
                // product.option.value.update
                AccountConfigUpdate200Response result = apiInstance.ProductOptionValueUpdate(productId, optionId, optionValueId, optionValue, price, quantity, displayValue, clearCache);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductOptionValueUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductOptionValueUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.option.value.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductOptionValueUpdateWithHttpInfo(productId, optionId, optionValueId, optionValue, price, quantity, displayValue, clearCache);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductOptionValueUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the option value should be updated |  |
| **optionId** | **string** | Defines option id where the value has to be updated |  |
| **optionValueId** | **string** | Defines value id that has to be assigned |  |
| **optionValue** | **string?** | Defines option value that has to be added | [optional]  |
| **price** | **decimal?** | Defines new product option price | [optional]  |
| **quantity** | **decimal?** | Defines new products&#39; options quantity | [optional]  |
| **displayValue** | **string?** | Defines the value that will be displayed for the option value | [optional]  |
| **clearCache** | **bool?** | Is cache clear required | [optional] [default to true] |

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

<a id="productpriceadd"></a>
# **ProductPriceAdd**
> CartValidate200Response ProductPriceAdd (ProductPriceAdd productPriceAdd)

product.price.add

Add some prices to the product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductPriceAddExample
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

            var apiInstance = new ProductApi(config);
            var productPriceAdd = new ProductPriceAdd(); // ProductPriceAdd | 

            try
            {
                // product.price.add
                CartValidate200Response result = apiInstance.ProductPriceAdd(productPriceAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductPriceAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductPriceAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.price.add
    ApiResponse<CartValidate200Response> response = apiInstance.ProductPriceAddWithHttpInfo(productPriceAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductPriceAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productPriceAdd** | [**ProductPriceAdd**](ProductPriceAdd.md) |  |  |

### Return type

[**CartValidate200Response**](CartValidate200Response.md)

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

<a id="productpricedelete"></a>
# **ProductPriceDelete**
> AttributeDelete200Response ProductPriceDelete (string productId, string? groupPrices = null, string? storeId = null)

product.price.delete

Delete some prices of the product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductPriceDeleteExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines the product where the price has to be deleted
            var groupPrices = group_prices=5,8,9;  // string? | Defines product's group prices (optional) 
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.price.delete
                AttributeDelete200Response result = apiInstance.ProductPriceDelete(productId, groupPrices, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductPriceDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductPriceDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.price.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductPriceDeleteWithHttpInfo(productId, groupPrices, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductPriceDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines the product where the price has to be deleted |  |
| **groupPrices** | **string?** | Defines product&#39;s group prices | [optional]  |
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

<a id="productpriceupdate"></a>
# **ProductPriceUpdate**
> AccountConfigUpdate200Response ProductPriceUpdate (ProductPriceUpdate productPriceUpdate)

product.price.update

Update some prices of the product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductPriceUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productPriceUpdate = new ProductPriceUpdate(); // ProductPriceUpdate | 

            try
            {
                // product.price.update
                AccountConfigUpdate200Response result = apiInstance.ProductPriceUpdate(productPriceUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductPriceUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductPriceUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.price.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductPriceUpdateWithHttpInfo(productPriceUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductPriceUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productPriceUpdate** | [**ProductPriceUpdate**](ProductPriceUpdate.md) |  |  |

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

<a id="productreviewlist"></a>
# **ProductReviewList**
> ModelResponseProductReviewList ProductReviewList (string productId, int? start = null, int? count = null, string? pageCursor = null, string? ids = null, string? storeId = null, string? langId = null, string? status = null, string? createdFrom = null, string? createdTo = null, string? customerId = null, string? sortBy = null, string? sortDirection = null, string? responseFields = null, string? varParams = null, string? exclude = null)

product.review.list

Get reviews of a specific product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductReviewListExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Product id
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var ids = 24,25;  // string? | Retrieves reviews specified by ids (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var status = disabled;  // string? | Defines status (optional) 
            var createdFrom = 2010-07-29 13:45:52;  // string? | Retrieve entities from their creation date (optional) 
            var createdTo = 2100-08-29 13:45:52;  // string? | Retrieve entities to their creation date (optional) 
            var customerId = 5;  // string? | Retrieves orders specified by customer id (optional) 
            var sortBy = value_id;  // string? | Set field to sort by (optional)  (default to "id")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "asc")
            var responseFields = {return_code,return_message,pagination,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,customer_id,email,message,status,product_id,nick_name,summary,rating,ratings,status,created_time")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // product.review.list
                ModelResponseProductReviewList result = apiInstance.ProductReviewList(productId, start, count, pageCursor, ids, storeId, langId, status, createdFrom, createdTo, customerId, sortBy, sortDirection, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductReviewList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductReviewListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.review.list
    ApiResponse<ModelResponseProductReviewList> response = apiInstance.ProductReviewListWithHttpInfo(productId, start, count, pageCursor, ids, storeId, langId, status, createdFrom, createdTo, customerId, sortBy, sortDirection, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductReviewListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Product id |  |
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **ids** | **string?** | Retrieves reviews specified by ids | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **status** | **string?** | Defines status | [optional]  |
| **createdFrom** | **string?** | Retrieve entities from their creation date | [optional]  |
| **createdTo** | **string?** | Retrieve entities to their creation date | [optional]  |
| **customerId** | **string?** | Retrieves orders specified by customer id | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;id&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;asc&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,customer_id,email,message,status,product_id,nick_name,summary,rating,ratings,status,created_time&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseProductReviewList**](ModelResponseProductReviewList.md)

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

<a id="productstoreassign"></a>
# **ProductStoreAssign**
> AccountConfigUpdate200Response ProductStoreAssign (string productId, string storeId)

product.store.assign

Assign product to store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductStoreAssignExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines id of the product which should be assigned to a store
            var storeId = 1;  // string | Defines id of the store product should be assigned to

            try
            {
                // product.store.assign
                AccountConfigUpdate200Response result = apiInstance.ProductStoreAssign(productId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductStoreAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductStoreAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.store.assign
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductStoreAssignWithHttpInfo(productId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductStoreAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines id of the product which should be assigned to a store |  |
| **storeId** | **string** | Defines id of the store product should be assigned to |  |

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

<a id="producttaxadd"></a>
# **ProductTaxAdd**
> ProductTaxAdd200Response ProductTaxAdd (ProductTaxAdd productTaxAdd)

product.tax.add

Add tax class and tax rate to store and assign to product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductTaxAddExample
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

            var apiInstance = new ProductApi(config);
            var productTaxAdd = new ProductTaxAdd(); // ProductTaxAdd | 

            try
            {
                // product.tax.add
                ProductTaxAdd200Response result = apiInstance.ProductTaxAdd(productTaxAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductTaxAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductTaxAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.tax.add
    ApiResponse<ProductTaxAdd200Response> response = apiInstance.ProductTaxAddWithHttpInfo(productTaxAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductTaxAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productTaxAdd** | [**ProductTaxAdd**](ProductTaxAdd.md) |  |  |

### Return type

[**ProductTaxAdd200Response**](ProductTaxAdd200Response.md)

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

<a id="productupdate"></a>
# **ProductUpdate**
> AccountConfigUpdate200Response ProductUpdate (ProductUpdate productUpdate)

product.update

This method can be used to update certain product data. The list of supported parameters depends on the specific platform. Please transmit only those parameters that are supported by the particular platform. Please note that to update the product quantity, it is recommended to use relative parameters (increase_quantity or reduce_quantity) to avoid unexpected overwrites on heavily loaded stores.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productUpdate = new ProductUpdate(); // ProductUpdate | 

            try
            {
                // product.update
                AccountConfigUpdate200Response result = apiInstance.ProductUpdate(productUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductUpdateWithHttpInfo(productUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productUpdate** | [**ProductUpdate**](ProductUpdate.md) |  |  |

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

<a id="productupdatebatch"></a>
# **ProductUpdateBatch**
> CategoryAddBatch200Response ProductUpdateBatch (ProductUpdateBatch productUpdateBatch)

product.update.batch

Update products on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductUpdateBatchExample
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

            var apiInstance = new ProductApi(config);
            var productUpdateBatch = new ProductUpdateBatch(); // ProductUpdateBatch | 

            try
            {
                // product.update.batch
                CategoryAddBatch200Response result = apiInstance.ProductUpdateBatch(productUpdateBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductUpdateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductUpdateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.update.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductUpdateBatchWithHttpInfo(productUpdateBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductUpdateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productUpdateBatch** | [**ProductUpdateBatch**](ProductUpdateBatch.md) |  |  |

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

<a id="productvariantadd"></a>
# **ProductVariantAdd**
> ProductVariantAdd200Response ProductVariantAdd (ProductVariantAdd productVariantAdd)

product.variant.add

Add variant to product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantAddExample
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

            var apiInstance = new ProductApi(config);
            var productVariantAdd = new ProductVariantAdd(); // ProductVariantAdd | 

            try
            {
                // product.variant.add
                ProductVariantAdd200Response result = apiInstance.ProductVariantAdd(productVariantAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.add
    ApiResponse<ProductVariantAdd200Response> response = apiInstance.ProductVariantAddWithHttpInfo(productVariantAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantAdd** | [**ProductVariantAdd**](ProductVariantAdd.md) |  |  |

### Return type

[**ProductVariantAdd200Response**](ProductVariantAdd200Response.md)

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

<a id="productvariantaddbatch"></a>
# **ProductVariantAddBatch**
> CategoryAddBatch200Response ProductVariantAddBatch (ProductVariantAddBatch productVariantAddBatch)

product.variant.add.batch

Add new product variants to the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantAddBatchExample
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

            var apiInstance = new ProductApi(config);
            var productVariantAddBatch = new ProductVariantAddBatch(); // ProductVariantAddBatch | 

            try
            {
                // product.variant.add.batch
                CategoryAddBatch200Response result = apiInstance.ProductVariantAddBatch(productVariantAddBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantAddBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantAddBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.add.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductVariantAddBatchWithHttpInfo(productVariantAddBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantAddBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantAddBatch** | [**ProductVariantAddBatch**](ProductVariantAddBatch.md) |  |  |

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

<a id="productvariantdelete"></a>
# **ProductVariantDelete**
> AttributeValueDelete200Response ProductVariantDelete (string id, string productId, string? storeId = null)

product.variant.delete

Delete variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantDeleteExample
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

            var apiInstance = new ProductApi(config);
            var id = 10;  // string | Defines variant removal, specified by variant id
            var productId = 10;  // string | Defines product's id where the variant has to be deleted
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.variant.delete
                AttributeValueDelete200Response result = apiInstance.ProductVariantDelete(id, productId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.delete
    ApiResponse<AttributeValueDelete200Response> response = apiInstance.ProductVariantDeleteWithHttpInfo(id, productId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Defines variant removal, specified by variant id |  |
| **productId** | **string** | Defines product&#39;s id where the variant has to be deleted |  |
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

<a id="productvariantdeletebatch"></a>
# **ProductVariantDeleteBatch**
> CategoryAddBatch200Response ProductVariantDeleteBatch (ProductVariantDeleteBatch productVariantDeleteBatch)

product.variant.delete.batch

Remove product variants from the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantDeleteBatchExample
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

            var apiInstance = new ProductApi(config);
            var productVariantDeleteBatch = new ProductVariantDeleteBatch(); // ProductVariantDeleteBatch | 

            try
            {
                // product.variant.delete.batch
                CategoryAddBatch200Response result = apiInstance.ProductVariantDeleteBatch(productVariantDeleteBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantDeleteBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantDeleteBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.delete.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductVariantDeleteBatchWithHttpInfo(productVariantDeleteBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantDeleteBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantDeleteBatch** | [**ProductVariantDeleteBatch**](ProductVariantDeleteBatch.md) |  |  |

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

<a id="productvariantimageadd"></a>
# **ProductVariantImageAdd**
> ProductVariantImageAdd200Response ProductVariantImageAdd (ProductVariantImageAdd productVariantImageAdd)

product.variant.image.add

Add image to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantImageAddExample
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

            var apiInstance = new ProductApi(config);
            var productVariantImageAdd = new ProductVariantImageAdd(); // ProductVariantImageAdd | 

            try
            {
                // product.variant.image.add
                ProductVariantImageAdd200Response result = apiInstance.ProductVariantImageAdd(productVariantImageAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantImageAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantImageAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.image.add
    ApiResponse<ProductVariantImageAdd200Response> response = apiInstance.ProductVariantImageAddWithHttpInfo(productVariantImageAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantImageAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantImageAdd** | [**ProductVariantImageAdd**](ProductVariantImageAdd.md) |  |  |

### Return type

[**ProductVariantImageAdd200Response**](ProductVariantImageAdd200Response.md)

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

<a id="productvariantimagedelete"></a>
# **ProductVariantImageDelete**
> AttributeDelete200Response ProductVariantImageDelete (string productId, string productVariantId, string id, string? storeId = null)

product.variant.image.delete

Delete  image to product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantImageDeleteExample
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

            var apiInstance = new ProductApi(config);
            var productId = 10;  // string | Defines product id where the variant image should be deleted
            var productVariantId = 45;  // string | Defines product's variants specified by variant id
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.variant.image.delete
                AttributeDelete200Response result = apiInstance.ProductVariantImageDelete(productId, productVariantId, id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantImageDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantImageDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.image.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductVariantImageDeleteWithHttpInfo(productId, productVariantId, id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantImageDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Defines product id where the variant image should be deleted |  |
| **productVariantId** | **string** | Defines product&#39;s variants specified by variant id |  |
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

<a id="productvariantpriceadd"></a>
# **ProductVariantPriceAdd**
> CartValidate200Response ProductVariantPriceAdd (ProductVariantPriceAdd productVariantPriceAdd)

product.variant.price.add

Add some prices to the product variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantPriceAddExample
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

            var apiInstance = new ProductApi(config);
            var productVariantPriceAdd = new ProductVariantPriceAdd(); // ProductVariantPriceAdd | 

            try
            {
                // product.variant.price.add
                CartValidate200Response result = apiInstance.ProductVariantPriceAdd(productVariantPriceAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantPriceAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantPriceAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.price.add
    ApiResponse<CartValidate200Response> response = apiInstance.ProductVariantPriceAddWithHttpInfo(productVariantPriceAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantPriceAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantPriceAdd** | [**ProductVariantPriceAdd**](ProductVariantPriceAdd.md) |  |  |

### Return type

[**CartValidate200Response**](CartValidate200Response.md)

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

<a id="productvariantpricedelete"></a>
# **ProductVariantPriceDelete**
> AttributeDelete200Response ProductVariantPriceDelete (string id, string productId, string groupPrices, string? storeId = null)

product.variant.price.delete

Delete some prices of the product variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantPriceDeleteExample
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

            var apiInstance = new ProductApi(config);
            var id = 10;  // string | Defines the variant where the price has to be deleted
            var productId = 10;  // string | Product id
            var groupPrices = group_prices=6,8,9;  // string | Defines variants's group prices
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // product.variant.price.delete
                AttributeDelete200Response result = apiInstance.ProductVariantPriceDelete(id, productId, groupPrices, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantPriceDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantPriceDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.price.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.ProductVariantPriceDeleteWithHttpInfo(id, productId, groupPrices, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantPriceDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Defines the variant where the price has to be deleted |  |
| **productId** | **string** | Product id |  |
| **groupPrices** | **string** | Defines variants&#39;s group prices |  |
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

<a id="productvariantpriceupdate"></a>
# **ProductVariantPriceUpdate**
> AccountConfigUpdate200Response ProductVariantPriceUpdate (ProductVariantPriceUpdate productVariantPriceUpdate)

product.variant.price.update

Update some prices of the product variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantPriceUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productVariantPriceUpdate = new ProductVariantPriceUpdate(); // ProductVariantPriceUpdate | 

            try
            {
                // product.variant.price.update
                AccountConfigUpdate200Response result = apiInstance.ProductVariantPriceUpdate(productVariantPriceUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantPriceUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantPriceUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.price.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductVariantPriceUpdateWithHttpInfo(productVariantPriceUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantPriceUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantPriceUpdate** | [**ProductVariantPriceUpdate**](ProductVariantPriceUpdate.md) |  |  |

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

<a id="productvariantupdate"></a>
# **ProductVariantUpdate**
> AccountConfigUpdate200Response ProductVariantUpdate (ProductVariantUpdate productVariantUpdate)

product.variant.update

Update variant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantUpdateExample
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

            var apiInstance = new ProductApi(config);
            var productVariantUpdate = new ProductVariantUpdate(); // ProductVariantUpdate | 

            try
            {
                // product.variant.update
                AccountConfigUpdate200Response result = apiInstance.ProductVariantUpdate(productVariantUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.ProductVariantUpdateWithHttpInfo(productVariantUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantUpdate** | [**ProductVariantUpdate**](ProductVariantUpdate.md) |  |  |

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

<a id="productvariantupdatebatch"></a>
# **ProductVariantUpdateBatch**
> CategoryAddBatch200Response ProductVariantUpdateBatch (ProductVariantUpdateBatch productVariantUpdateBatch)

product.variant.update.batch

Update products variants on the store.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductVariantUpdateBatchExample
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

            var apiInstance = new ProductApi(config);
            var productVariantUpdateBatch = new ProductVariantUpdateBatch(); // ProductVariantUpdateBatch | 

            try
            {
                // product.variant.update.batch
                CategoryAddBatch200Response result = apiInstance.ProductVariantUpdateBatch(productVariantUpdateBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductVariantUpdateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductVariantUpdateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // product.variant.update.batch
    ApiResponse<CategoryAddBatch200Response> response = apiInstance.ProductVariantUpdateBatchWithHttpInfo(productVariantUpdateBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductVariantUpdateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productVariantUpdateBatch** | [**ProductVariantUpdateBatch**](ProductVariantUpdateBatch.md) |  |  |

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

