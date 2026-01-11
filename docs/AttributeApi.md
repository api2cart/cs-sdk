# Org.OpenAPITools.Api.AttributeApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AttributeAdd**](AttributeApi.md#attributeadd) | **POST** /attribute.add.json | attribute.add |
| [**AttributeAssignGroup**](AttributeApi.md#attributeassigngroup) | **POST** /attribute.assign.group.json | attribute.assign.group |
| [**AttributeAssignSet**](AttributeApi.md#attributeassignset) | **POST** /attribute.assign.set.json | attribute.assign.set |
| [**AttributeAttributesetList**](AttributeApi.md#attributeattributesetlist) | **GET** /attribute.attributeset.list.json | attribute.attributeset.list |
| [**AttributeCount**](AttributeApi.md#attributecount) | **GET** /attribute.count.json | attribute.count |
| [**AttributeDelete**](AttributeApi.md#attributedelete) | **DELETE** /attribute.delete.json | attribute.delete |
| [**AttributeGroupList**](AttributeApi.md#attributegrouplist) | **GET** /attribute.group.list.json | attribute.group.list |
| [**AttributeInfo**](AttributeApi.md#attributeinfo) | **GET** /attribute.info.json | attribute.info |
| [**AttributeList**](AttributeApi.md#attributelist) | **GET** /attribute.list.json | attribute.list |
| [**AttributeTypeList**](AttributeApi.md#attributetypelist) | **GET** /attribute.type.list.json | attribute.type.list |
| [**AttributeUnassignGroup**](AttributeApi.md#attributeunassigngroup) | **POST** /attribute.unassign.group.json | attribute.unassign.group |
| [**AttributeUnassignSet**](AttributeApi.md#attributeunassignset) | **POST** /attribute.unassign.set.json | attribute.unassign.set |
| [**AttributeUpdate**](AttributeApi.md#attributeupdate) | **PUT** /attribute.update.json | attribute.update |
| [**AttributeValueAdd**](AttributeApi.md#attributevalueadd) | **POST** /attribute.value.add.json | attribute.value.add |
| [**AttributeValueDelete**](AttributeApi.md#attributevaluedelete) | **DELETE** /attribute.value.delete.json | attribute.value.delete |
| [**AttributeValueUpdate**](AttributeApi.md#attributevalueupdate) | **PUT** /attribute.value.update.json | attribute.value.update |

<a id="attributeadd"></a>
# **AttributeAdd**
> AttributeAdd200Response AttributeAdd (string type, string name, string? code = null, string? storeId = null, string? langId = null, bool? visible = null, bool? required = null, int? position = null, string? attributeGroupId = null, string? isGlobal = null, bool? isSearchable = null, string? isFilterable = null, bool? isComparable = null, bool? isHtmlAllowedOnFront = null, bool? isFilterableInSearch = null, bool? isConfigurable = null, bool? isVisibleInAdvancedSearch = null, bool? isUsedForPromoRules = null, bool? usedInProductListing = null, bool? usedForSortBy = null, string? applyTo = null, string? idempotencyKey = null)

attribute.add

Add new attribute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeAddExample
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

            var apiInstance = new AttributeApi(config);
            var type = text;  // string | Defines attribute's type
            var name = Specification;  // string | Defines attributes's name
            var code = code;  // string? | Entity code (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var visible = true;  // bool? | Set visibility status (optional)  (default to false)
            var required = true;  // bool? | Defines if the option is required (optional)  (default to false)
            var position = 5;  // int? | Attribute`s position (optional)  (default to 0)
            var attributeGroupId = 202;  // string? | Filter by attribute_group_id (optional) 
            var isGlobal = Global;  // string? | Attribute saving scope (optional)  (default to "Store")
            var isSearchable = false;  // bool? | Use attribute in Quick Search (optional)  (default to false)
            var isFilterable = No;  // string? | Use In Layered Navigation (optional)  (default to "No")
            var isComparable = true;  // bool? | Comparable on Front-end (optional)  (default to false)
            var isHtmlAllowedOnFront = true;  // bool? | Allow HTML Tags on Frontend (optional)  (default to false)
            var isFilterableInSearch = true;  // bool? | Use In Search Results Layered Navigation (optional)  (default to false)
            var isConfigurable = true;  // bool? | Use To Create Configurable Product (optional)  (default to false)
            var isVisibleInAdvancedSearch = true;  // bool? | Use in Advanced Search (optional)  (default to false)
            var isUsedForPromoRules = true;  // bool? | Use for Promo Rule Conditions (optional)  (default to false)
            var usedInProductListing = true;  // bool? | Used in Product Listing (optional)  (default to false)
            var usedForSortBy = true;  // bool? | Used for Sorting in Product Listing (optional)  (default to false)
            var applyTo = Global;  // string? | Types of products which can have this attribute (optional)  (default to "all_types")
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.add
                AttributeAdd200Response result = apiInstance.AttributeAdd(type, name, code, storeId, langId, visible, required, position, attributeGroupId, isGlobal, isSearchable, isFilterable, isComparable, isHtmlAllowedOnFront, isFilterableInSearch, isConfigurable, isVisibleInAdvancedSearch, isUsedForPromoRules, usedInProductListing, usedForSortBy, applyTo, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.add
    ApiResponse<AttributeAdd200Response> response = apiInstance.AttributeAddWithHttpInfo(type, name, code, storeId, langId, visible, required, position, attributeGroupId, isGlobal, isSearchable, isFilterable, isComparable, isHtmlAllowedOnFront, isFilterableInSearch, isConfigurable, isVisibleInAdvancedSearch, isUsedForPromoRules, usedInProductListing, usedForSortBy, applyTo, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Defines attribute&#39;s type |  |
| **name** | **string** | Defines attributes&#39;s name |  |
| **code** | **string?** | Entity code | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **visible** | **bool?** | Set visibility status | [optional] [default to false] |
| **required** | **bool?** | Defines if the option is required | [optional] [default to false] |
| **position** | **int?** | Attribute&#x60;s position | [optional] [default to 0] |
| **attributeGroupId** | **string?** | Filter by attribute_group_id | [optional]  |
| **isGlobal** | **string?** | Attribute saving scope | [optional] [default to &quot;Store&quot;] |
| **isSearchable** | **bool?** | Use attribute in Quick Search | [optional] [default to false] |
| **isFilterable** | **string?** | Use In Layered Navigation | [optional] [default to &quot;No&quot;] |
| **isComparable** | **bool?** | Comparable on Front-end | [optional] [default to false] |
| **isHtmlAllowedOnFront** | **bool?** | Allow HTML Tags on Frontend | [optional] [default to false] |
| **isFilterableInSearch** | **bool?** | Use In Search Results Layered Navigation | [optional] [default to false] |
| **isConfigurable** | **bool?** | Use To Create Configurable Product | [optional] [default to false] |
| **isVisibleInAdvancedSearch** | **bool?** | Use in Advanced Search | [optional] [default to false] |
| **isUsedForPromoRules** | **bool?** | Use for Promo Rule Conditions | [optional] [default to false] |
| **usedInProductListing** | **bool?** | Used in Product Listing | [optional] [default to false] |
| **usedForSortBy** | **bool?** | Used for Sorting in Product Listing | [optional] [default to false] |
| **applyTo** | **string?** | Types of products which can have this attribute | [optional] [default to &quot;all_types&quot;] |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

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

<a id="attributeassigngroup"></a>
# **AttributeAssignGroup**
> AttributeAssignGroup200Response AttributeAssignGroup (string id, string groupId, string? attributeSetId = null, string? idempotencyKey = null)

attribute.assign.group

Assign attribute to the group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeAssignGroupExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var groupId = 3;  // string | Attribute group_id
            var attributeSetId = 4;  // string? | Attribute set id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.assign.group
                AttributeAssignGroup200Response result = apiInstance.AttributeAssignGroup(id, groupId, attributeSetId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeAssignGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeAssignGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.assign.group
    ApiResponse<AttributeAssignGroup200Response> response = apiInstance.AttributeAssignGroupWithHttpInfo(id, groupId, attributeSetId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeAssignGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **groupId** | **string** | Attribute group_id |  |
| **attributeSetId** | **string?** | Attribute set id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeAssignGroup200Response**](AttributeAssignGroup200Response.md)

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

<a id="attributeassignset"></a>
# **AttributeAssignSet**
> AttributeAssignGroup200Response AttributeAssignSet (string id, string attributeSetId, string? groupId = null, string? idempotencyKey = null)

attribute.assign.set

Assign attribute to the attribute set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeAssignSetExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var attributeSetId = 4;  // string | Attribute set id
            var groupId = 3;  // string? | Attribute group_id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.assign.set
                AttributeAssignGroup200Response result = apiInstance.AttributeAssignSet(id, attributeSetId, groupId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeAssignSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeAssignSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.assign.set
    ApiResponse<AttributeAssignGroup200Response> response = apiInstance.AttributeAssignSetWithHttpInfo(id, attributeSetId, groupId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeAssignSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **attributeSetId** | **string** | Attribute set id |  |
| **groupId** | **string?** | Attribute group_id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeAssignGroup200Response**](AttributeAssignGroup200Response.md)

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

<a id="attributeattributesetlist"></a>
# **AttributeAttributesetList**
> ModelResponseAttributeAttributesetList AttributeAttributesetList (int? start = null, int? count = null, string? responseFields = null, string? varParams = null, string? exclude = null)

attribute.attributeset.list

Get attribute_set list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeAttributesetListExample
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

            var apiInstance = new AttributeApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name")
            var exclude = id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // attribute.attributeset.list
                ModelResponseAttributeAttributesetList result = apiInstance.AttributeAttributesetList(start, count, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeAttributesetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeAttributesetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.attributeset.list
    ApiResponse<ModelResponseAttributeAttributesetList> response = apiInstance.AttributeAttributesetListWithHttpInfo(start, count, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeAttributesetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseAttributeAttributesetList**](ModelResponseAttributeAttributesetList.md)

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

<a id="attributecount"></a>
# **AttributeCount**
> AttributeCount200Response AttributeCount (string? type = null, string? attributeSetId = null, string? storeId = null, string? langId = null, bool? visible = null, bool? required = null, bool? varSystem = null)

attribute.count

Get attributes count

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeCountExample
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

            var apiInstance = new AttributeApi(config);
            var type = text;  // string? | Defines attribute's type (optional) 
            var attributeSetId = 4;  // string? | Filter items by attribute set id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var visible = true;  // bool? | Filter items by visibility status (optional) 
            var required = true;  // bool? | Defines if the option is required (optional) 
            var varSystem = false;  // bool? | True if attribute is system (optional) 

            try
            {
                // attribute.count
                AttributeCount200Response result = apiInstance.AttributeCount(type, attributeSetId, storeId, langId, visible, required, varSystem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.count
    ApiResponse<AttributeCount200Response> response = apiInstance.AttributeCountWithHttpInfo(type, attributeSetId, storeId, langId, visible, required, varSystem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Defines attribute&#39;s type | [optional]  |
| **attributeSetId** | **string?** | Filter items by attribute set id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **visible** | **bool?** | Filter items by visibility status | [optional]  |
| **required** | **bool?** | Defines if the option is required | [optional]  |
| **varSystem** | **bool?** | True if attribute is system | [optional]  |

### Return type

[**AttributeCount200Response**](AttributeCount200Response.md)

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

<a id="attributedelete"></a>
# **AttributeDelete**
> AttributeDelete200Response AttributeDelete (string id, string? storeId = null)

attribute.delete

Delete attribute from store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeDeleteExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // attribute.delete
                AttributeDelete200Response result = apiInstance.AttributeDelete(id, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.delete
    ApiResponse<AttributeDelete200Response> response = apiInstance.AttributeDeleteWithHttpInfo(id, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeDeleteWithHttpInfo: " + e.Message);
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

<a id="attributegrouplist"></a>
# **AttributeGroupList**
> ModelResponseAttributeGroupList AttributeGroupList (int? start = null, int? count = null, string? attributeSetId = null, string? langId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

attribute.group.list

Get attribute group list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeGroupListExample
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

            var apiInstance = new AttributeApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var attributeSetId = 4;  // string? | Attribute set id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name")
            var exclude = id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // attribute.group.list
                ModelResponseAttributeGroupList result = apiInstance.AttributeGroupList(start, count, attributeSetId, langId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeGroupList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeGroupListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.group.list
    ApiResponse<ModelResponseAttributeGroupList> response = apiInstance.AttributeGroupListWithHttpInfo(start, count, attributeSetId, langId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeGroupListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **attributeSetId** | **string?** | Attribute set id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseAttributeGroupList**](ModelResponseAttributeGroupList.md)

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

<a id="attributeinfo"></a>
# **AttributeInfo**
> AttributeInfo200Response AttributeInfo (string id, string? attributeSetId = null, string? storeId = null, string? langId = null, string? responseFields = null, string? varParams = null, string? exclude = null)

attribute.info

Get information about a specific global attribute by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeInfoExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var attributeSetId = 4;  // string? | Attribute set id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = force_all;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // attribute.info
                AttributeInfo200Response result = apiInstance.AttributeInfo(id, attributeSetId, storeId, langId, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.info
    ApiResponse<AttributeInfo200Response> response = apiInstance.AttributeInfoWithHttpInfo(id, attributeSetId, storeId, langId, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **attributeSetId** | **string?** | Attribute set id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**AttributeInfo200Response**](AttributeInfo200Response.md)

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

<a id="attributelist"></a>
# **AttributeList**
> ModelResponseAttributeList AttributeList (int? start = null, int? count = null, string? attributeIds = null, string? attributeSetId = null, string? storeId = null, string? langId = null, string? type = null, bool? visible = null, bool? required = null, bool? varSystem = null, string? responseFields = null, string? varParams = null, string? exclude = null)

attribute.list

Get a list of global attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeListExample
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

            var apiInstance = new AttributeApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var attributeIds = 1,2,3;  // string? | Filter attributes by ids (optional) 
            var attributeSetId = 4;  // string? | Filter items by attribute set id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Retrieves attributes on specified language id (optional) 
            var type = text;  // string? | Defines attribute's type (optional) 
            var visible = true;  // bool? | Filter items by visibility status (optional) 
            var required = true;  // bool? | Defines if the option is required (optional) 
            var varSystem = false;  // bool? | True if attribute is system (optional) 
            var responseFields = {return_code,return_message,pagination,result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,name;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "id,name,code,type")
            var exclude = id,name;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // attribute.list
                ModelResponseAttributeList result = apiInstance.AttributeList(start, count, attributeIds, attributeSetId, storeId, langId, type, visible, required, varSystem, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.list
    ApiResponse<ModelResponseAttributeList> response = apiInstance.AttributeListWithHttpInfo(start, count, attributeIds, attributeSetId, storeId, langId, type, visible, required, varSystem, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **attributeIds** | **string?** | Filter attributes by ids | [optional]  |
| **attributeSetId** | **string?** | Filter items by attribute set id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Retrieves attributes on specified language id | [optional]  |
| **type** | **string?** | Defines attribute&#39;s type | [optional]  |
| **visible** | **bool?** | Filter items by visibility status | [optional]  |
| **required** | **bool?** | Defines if the option is required | [optional]  |
| **varSystem** | **bool?** | True if attribute is system | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;id,name,code,type&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseAttributeList**](ModelResponseAttributeList.md)

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

<a id="attributetypelist"></a>
# **AttributeTypeList**
> AttributeTypeList200Response AttributeTypeList ()

attribute.type.list

Get list of supported attributes types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeTypeListExample
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

            var apiInstance = new AttributeApi(config);

            try
            {
                // attribute.type.list
                AttributeTypeList200Response result = apiInstance.AttributeTypeList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeTypeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeTypeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.type.list
    ApiResponse<AttributeTypeList200Response> response = apiInstance.AttributeTypeListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeTypeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AttributeTypeList200Response**](AttributeTypeList200Response.md)

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

<a id="attributeunassigngroup"></a>
# **AttributeUnassignGroup**
> AttributeUnassignGroup200Response AttributeUnassignGroup (string id, string groupId, string? idempotencyKey = null)

attribute.unassign.group

Unassign attribute from group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeUnassignGroupExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var groupId = 3;  // string | Customer group_id
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.unassign.group
                AttributeUnassignGroup200Response result = apiInstance.AttributeUnassignGroup(id, groupId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeUnassignGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeUnassignGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.unassign.group
    ApiResponse<AttributeUnassignGroup200Response> response = apiInstance.AttributeUnassignGroupWithHttpInfo(id, groupId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeUnassignGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **groupId** | **string** | Customer group_id |  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeUnassignGroup200Response**](AttributeUnassignGroup200Response.md)

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

<a id="attributeunassignset"></a>
# **AttributeUnassignSet**
> AttributeUnassignGroup200Response AttributeUnassignSet (string id, string attributeSetId, string? idempotencyKey = null)

attribute.unassign.set

Unassign attribute from attribute set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeUnassignSetExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var attributeSetId = 4;  // string | Attribute set id
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.unassign.set
                AttributeUnassignGroup200Response result = apiInstance.AttributeUnassignSet(id, attributeSetId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeUnassignSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeUnassignSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.unassign.set
    ApiResponse<AttributeUnassignGroup200Response> response = apiInstance.AttributeUnassignSetWithHttpInfo(id, attributeSetId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeUnassignSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **attributeSetId** | **string** | Attribute set id |  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeUnassignGroup200Response**](AttributeUnassignGroup200Response.md)

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

<a id="attributeupdate"></a>
# **AttributeUpdate**
> AttributeUpdate200Response AttributeUpdate (string id, string name, string? storeId = null, string? langId = null, string? idempotencyKey = null)

attribute.update

Update attribute data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeUpdateExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var name = Test name;  // string | Defines new attributes's name
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.update
                AttributeUpdate200Response result = apiInstance.AttributeUpdate(id, name, storeId, langId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.update
    ApiResponse<AttributeUpdate200Response> response = apiInstance.AttributeUpdateWithHttpInfo(id, name, storeId, langId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **name** | **string** | Defines new attributes&#39;s name |  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeUpdate200Response**](AttributeUpdate200Response.md)

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

<a id="attributevalueadd"></a>
# **AttributeValueAdd**
> AttributeAdd200Response AttributeValueAdd (string attributeId, string name, string? code = null, string? description = null, string? storeId = null, string? langId = null, string? idempotencyKey = null)

attribute.value.add

Add new value to attribute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeValueAddExample
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

            var apiInstance = new AttributeApi(config);
            var attributeId = 156;  // string | Attribute Id
            var name = Test name;  // string | Defines attribute value's name
            var code = code;  // string? | Entity code (optional) 
            var description = Test value;  // string? | Defines attribute value's description (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.value.add
                AttributeAdd200Response result = apiInstance.AttributeValueAdd(attributeId, name, code, description, storeId, langId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeValueAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeValueAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.value.add
    ApiResponse<AttributeAdd200Response> response = apiInstance.AttributeValueAddWithHttpInfo(attributeId, name, code, description, storeId, langId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeValueAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeId** | **string** | Attribute Id |  |
| **name** | **string** | Defines attribute value&#39;s name |  |
| **code** | **string?** | Entity code | [optional]  |
| **description** | **string?** | Defines attribute value&#39;s description | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

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

<a id="attributevaluedelete"></a>
# **AttributeValueDelete**
> AttributeValueDelete200Response AttributeValueDelete (string id, string attributeId, string? storeId = null)

attribute.value.delete

Delete attribute value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeValueDeleteExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Entity id
            var attributeId = 156;  // string | Attribute Id
            var storeId = 1;  // string? | Store Id (optional) 

            try
            {
                // attribute.value.delete
                AttributeValueDelete200Response result = apiInstance.AttributeValueDelete(id, attributeId, storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeValueDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeValueDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.value.delete
    ApiResponse<AttributeValueDelete200Response> response = apiInstance.AttributeValueDeleteWithHttpInfo(id, attributeId, storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeValueDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Entity id |  |
| **attributeId** | **string** | Attribute Id |  |
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

<a id="attributevalueupdate"></a>
# **AttributeValueUpdate**
> AttributeUpdate200Response AttributeValueUpdate (string id, string attributeId, string? name = null, string? description = null, string? code = null, string? storeId = null, string? langId = null, string? idempotencyKey = null)

attribute.value.update

Update attribute value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttributeValueUpdateExample
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

            var apiInstance = new AttributeApi(config);
            var id = 10;  // string | Defines attribute value's id
            var attributeId = 156;  // string | Attribute Id
            var name = Test name;  // string? | Defines attribute value's name (optional) 
            var description = Test value;  // string? | Defines new attribute value's description (optional) 
            var code = code;  // string? | Entity code (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var langId = 3;  // string? | Language id (optional) 
            var idempotencyKey = 098f6bcd4621d373cade4e832627b4f6;  // string? | A unique identifier associated with a specific request. Repeated requests with the same <strong>idempotency_key</strong> return a cached response without re-executing the business logic. <strong>Please note that the cache lifetime is 15 minutes.</strong> (optional) 

            try
            {
                // attribute.value.update
                AttributeUpdate200Response result = apiInstance.AttributeValueUpdate(id, attributeId, name, description, code, storeId, langId, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributeApi.AttributeValueUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AttributeValueUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // attribute.value.update
    ApiResponse<AttributeUpdate200Response> response = apiInstance.AttributeValueUpdateWithHttpInfo(id, attributeId, name, description, code, storeId, langId, idempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributeApi.AttributeValueUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Defines attribute value&#39;s id |  |
| **attributeId** | **string** | Attribute Id |  |
| **name** | **string?** | Defines attribute value&#39;s name | [optional]  |
| **description** | **string?** | Defines new attribute value&#39;s description | [optional]  |
| **code** | **string?** | Entity code | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **langId** | **string?** | Language id | [optional]  |
| **idempotencyKey** | **string?** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional]  |

### Return type

[**AttributeUpdate200Response**](AttributeUpdate200Response.md)

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

