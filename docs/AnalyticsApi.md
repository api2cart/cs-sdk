# Org.OpenAPITools.Api.AnalyticsApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AnalyticsCustomerReport**](AnalyticsApi.md#analyticscustomerreport) | **GET** /analytics.customer_report.json | analytics.customer_report |
| [**AnalyticsProductReport**](AnalyticsApi.md#analyticsproductreport) | **GET** /analytics.product_report.json | analytics.product_report |
| [**AnalyticsReport**](AnalyticsApi.md#analyticsreport) | **GET** /analytics.report.json | analytics.report |

<a id="analyticscustomerreport"></a>
# **AnalyticsCustomerReport**
> ResponseAnalyticsCustomerReportResult AnalyticsCustomerReport (string? dateFrom = null, string? dateTo = null, int? count = null, string? currencyId = null, string? storeId = null, string? customerType = null, string? email = null, string? sortBy = null, string? sortDirection = null, string? pageCursor = null, string? responseFields = null)

analytics.customer_report

Get customer-level analytics for a store over a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnalyticsCustomerReportExample
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

            var apiInstance = new AnalyticsApi(config);
            var dateFrom = 2026-01-01;  // string? | Start date for the analytics period (Y-m-d or Y-m-d H:i:s) (optional) 
            var dateTo = 2026-01-31;  // string? | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. (optional) 
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var currencyId = usd;  // string? | Currency Id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var customerType = registered;  // string? | Filter analytics customers by customer type (optional) 
            var email = mail@example.com;  // string? | Filter analytics customers by email (optional) 
            var sortBy = total_spend;  // string? | Set field to sort by (optional)  (default to "total_spend")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "desc")
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 

            try
            {
                // analytics.customer_report
                ResponseAnalyticsCustomerReportResult result = apiInstance.AnalyticsCustomerReport(dateFrom, dateTo, count, currencyId, storeId, customerType, email, sortBy, sortDirection, pageCursor, responseFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsCustomerReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnalyticsCustomerReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // analytics.customer_report
    ApiResponse<ResponseAnalyticsCustomerReportResult> response = apiInstance.AnalyticsCustomerReportWithHttpInfo(dateFrom, dateTo, count, currencyId, storeId, customerType, email, sortBy, sortDirection, pageCursor, responseFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyticsApi.AnalyticsCustomerReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateFrom** | **string?** | Start date for the analytics period (Y-m-d or Y-m-d H:i:s) | [optional]  |
| **dateTo** | **string?** | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. | [optional]  |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **customerType** | **string?** | Filter analytics customers by customer type | [optional]  |
| **email** | **string?** | Filter analytics customers by email | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;total_spend&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;desc&quot;] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |

### Return type

[**ResponseAnalyticsCustomerReportResult**](ResponseAnalyticsCustomerReportResult.md)

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

<a id="analyticsproductreport"></a>
# **AnalyticsProductReport**
> ResponseAnalyticsProductReportResult AnalyticsProductReport (string? dateFrom = null, string? dateTo = null, int? count = null, string? productIds = null, string? currencyId = null, string? storeId = null, string? categoriesIds = null, string? sortBy = null, string? sortDirection = null, string? pageCursor = null, string? responseFields = null)

analytics.product_report

Get product-level analytics for a store over a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnalyticsProductReportExample
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

            var apiInstance = new AnalyticsApi(config);
            var dateFrom = 2026-01-01;  // string? | Start date for the analytics period (Y-m-d or Y-m-d H:i:s) (optional) 
            var dateTo = 2026-01-31;  // string? | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. (optional) 
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var productIds = 4,5;  // string? | Filter analytics by product ids (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var categoriesIds = 23,56;  // string? | Defines product add that is specified by comma-separated categories id (optional) 
            var sortBy = items_sold;  // string? | Set field to sort by (optional)  (default to "items_sold")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "desc")
            var pageCursor = ;  // string? | Used to retrieve entities via cursor-based pagination (it can't be used with any other filtering parameter) (optional) 
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 

            try
            {
                // analytics.product_report
                ResponseAnalyticsProductReportResult result = apiInstance.AnalyticsProductReport(dateFrom, dateTo, count, productIds, currencyId, storeId, categoriesIds, sortBy, sortDirection, pageCursor, responseFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsProductReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnalyticsProductReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // analytics.product_report
    ApiResponse<ResponseAnalyticsProductReportResult> response = apiInstance.AnalyticsProductReportWithHttpInfo(dateFrom, dateTo, count, productIds, currencyId, storeId, categoriesIds, sortBy, sortDirection, pageCursor, responseFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyticsApi.AnalyticsProductReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateFrom** | **string?** | Start date for the analytics period (Y-m-d or Y-m-d H:i:s) | [optional]  |
| **dateTo** | **string?** | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. | [optional]  |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **productIds** | **string?** | Filter analytics by product ids | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **categoriesIds** | **string?** | Defines product add that is specified by comma-separated categories id | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;items_sold&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;desc&quot;] |
| **pageCursor** | **string?** | Used to retrieve entities via cursor-based pagination (it can&#39;t be used with any other filtering parameter) | [optional]  |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |

### Return type

[**ResponseAnalyticsProductReportResult**](ResponseAnalyticsProductReportResult.md)

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

<a id="analyticsreport"></a>
# **AnalyticsReport**
> ResponseAnalyticsReportResult AnalyticsReport (string dateFrom, string? dateTo = null, string? interval = null, string? orderStatus = null, string? financialStatus = null, string? currencyId = null, string? storeId = null, string? sortBy = null, string? sortDirection = null, string? responseFields = null)

analytics.report

Get analytics report with totals and optional interval breakdown for a store over a given period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnalyticsReportExample
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

            var apiInstance = new AnalyticsApi(config);
            var dateFrom = 2026-01-01;  // string | Start date for the analytics period (Y-m-d or Y-m-d H:i:s)
            var dateTo = 2026-01-31;  // string? | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. (optional) 
            var interval = day;  // string? | Interval for analytics report breakdown (optional) 
            var orderStatus = Completed;  // string? | Retrieves orders specified by order status (optional) 
            var financialStatus = paid;  // string? | Retrieves orders specified by financial status (optional) 
            var currencyId = usd;  // string? | Currency Id (optional) 
            var storeId = 1;  // string? | Store Id (optional) 
            var sortBy = date;  // string? | Set field to sort by (optional)  (default to "date")
            var sortDirection = asc;  // string? | Set sorting direction (optional)  (default to "asc")
            var responseFields = {result};  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional) 

            try
            {
                // analytics.report
                ResponseAnalyticsReportResult result = apiInstance.AnalyticsReport(dateFrom, dateTo, interval, orderStatus, financialStatus, currencyId, storeId, sortBy, sortDirection, responseFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnalyticsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // analytics.report
    ApiResponse<ResponseAnalyticsReportResult> response = apiInstance.AnalyticsReportWithHttpInfo(dateFrom, dateTo, interval, orderStatus, financialStatus, currencyId, storeId, sortBy, sortDirection, responseFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateFrom** | **string** | Start date for the analytics period (Y-m-d or Y-m-d H:i:s) |  |
| **dateTo** | **string?** | End date for the analytics period (Y-m-d or Y-m-d H:i:s). Defaults to the current date. | [optional]  |
| **interval** | **string?** | Interval for analytics report breakdown | [optional]  |
| **orderStatus** | **string?** | Retrieves orders specified by order status | [optional]  |
| **financialStatus** | **string?** | Retrieves orders specified by financial status | [optional]  |
| **currencyId** | **string?** | Currency Id | [optional]  |
| **storeId** | **string?** | Store Id | [optional]  |
| **sortBy** | **string?** | Set field to sort by | [optional] [default to &quot;date&quot;] |
| **sortDirection** | **string?** | Set sorting direction | [optional] [default to &quot;asc&quot;] |
| **responseFields** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional]  |

### Return type

[**ResponseAnalyticsReportResult**](ResponseAnalyticsReportResult.md)

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

