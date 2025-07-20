# Org.OpenAPITools.Api.MarketplaceApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MarketplaceProductFind**](MarketplaceApi.md#marketplaceproductfind) | **GET** /marketplace.product.find.json | marketplace.product.find |

<a id="marketplaceproductfind"></a>
# **MarketplaceProductFind**
> ModelResponseMarketplaceProductFind MarketplaceProductFind (int? count = null, string? pageCursor = null, string? keyword = null, string? categoriesIds = null, string? storeId = null, string? asin = null, string? ean = null, string? gtin = null, string? upc = null, string? mpn = null, string? isbn = null, string? responseFields = null, string? varParams = null, string? exclude = null)

marketplace.product.find

Search product in global catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarketplaceProductFindExample
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

            var apiInstance = new MarketplaceApi(config);
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var keyword = T-shirt;  // string? | Defines search keyword (optional) 
            var categoriesIds = 23,56;  // string? | Defines product add that is specified by comma-separated categories id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var asin = 97703178470;  // string? | Amazon Standard Identification Number. (optional) 
            var ean = 5901234123457;  // string? | European Article Number. An EAN is a unique 8 or 13-digit identifier that many industries (such as book publishers) use to identify products. (optional) 
            var gtin = 12345678912345;  // string? | Global Trade Item Number. An GTIN is an identifier for trade items. (optional) 
            var upc = 9770317847001;  // string? | Universal Product Code. A UPC (UPC-A) is a commonly used identifer for many different products. (optional) 
            var mpn = 9770317847001;  // string? | Manufacturer Part Number. A MPN is an identifier of a particular part design or material used. (optional) 
            var isbn = 9783161484100;  // string? | International Standard Book Number. An ISBN is a unique identifier for books. (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 
            var varParams = id,model,price,images;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = false;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // marketplace.product.find
                ModelResponseMarketplaceProductFind result = apiInstance.MarketplaceProductFind(count, pageCursor, keyword, categoriesIds, storeId, asin, ean, gtin, upc, mpn, isbn, responseFields, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceApi.MarketplaceProductFind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarketplaceProductFindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // marketplace.product.find
    ApiResponse<ModelResponseMarketplaceProductFind> response = apiInstance.MarketplaceProductFindWithHttpInfo(count, pageCursor, keyword, categoriesIds, storeId, asin, ean, gtin, upc, mpn, isbn, responseFields, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceApi.MarketplaceProductFindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **keyword** | **string?** | Defines search keyword | [optional]  |
| **categoriesIds** | **string?** | Defines product add that is specified by comma-separated categories id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **asin** | **string?** | Amazon Standard Identification Number. | [optional]  |
| **ean** | **string?** | European Article Number. An EAN is a unique 8 or 13-digit identifier that many industries (such as book publishers) use to identify products. | [optional]  |
| **gtin** | **string?** | Global Trade Item Number. An GTIN is an identifier for trade items. | [optional]  |
| **upc** | **string?** | Universal Product Code. A UPC (UPC-A) is a commonly used identifer for many different products. | [optional]  |
| **mpn** | **string?** | Manufacturer Part Number. A MPN is an identifier of a particular part design or material used. | [optional]  |
| **isbn** | **string?** | International Standard Book Number. An ISBN is a unique identifier for books. | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**ModelResponseMarketplaceProductFind**](ModelResponseMarketplaceProductFind.md)

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

