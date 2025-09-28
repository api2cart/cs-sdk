# Org.OpenAPITools.Api.AccountApi

All URIs are relative to *https://api.api2cart.local.com/v1.1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountCartAdd**](AccountApi.md#accountcartadd) | **POST** /account.cart.add.json | account.cart.add |
| [**AccountCartList**](AccountApi.md#accountcartlist) | **GET** /account.cart.list.json | account.cart.list |
| [**AccountConfigUpdate**](AccountApi.md#accountconfigupdate) | **PUT** /account.config.update.json | account.config.update |
| [**AccountFailedWebhooks**](AccountApi.md#accountfailedwebhooks) | **GET** /account.failed_webhooks.json | account.failed_webhooks |
| [**AccountSupportedPlatforms**](AccountApi.md#accountsupportedplatforms) | **GET** /account.supported_platforms.json | account.supported_platforms |

<a id="accountcartadd"></a>
# **AccountCartAdd**
> AccountCartAdd200Response AccountCartAdd (AccountCartAdd accountCartAdd)

account.cart.add

Use this method to automate the process of connecting stores to API2Cart. The list of parameters will vary depending on the platform. To get a list of parameters that are specific to a particular shopping platform, you need to execute the account.supported_platforms.json method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountCartAddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AccountApi(config);
            var accountCartAdd = new AccountCartAdd(); // AccountCartAdd | 

            try
            {
                // account.cart.add
                AccountCartAdd200Response result = apiInstance.AccountCartAdd(accountCartAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountCartAdd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCartAddWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // account.cart.add
    ApiResponse<AccountCartAdd200Response> response = apiInstance.AccountCartAddWithHttpInfo(accountCartAdd);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountCartAddWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountCartAdd** | [**AccountCartAdd**](AccountCartAdd.md) |  |  |

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

<a id="accountcartlist"></a>
# **AccountCartList**
> AccountCartList200Response AccountCartList (string? storeUrl = null, string? storeKey = null, string? requestFromDate = null, string? requestToDate = null, string? varParams = null, string? exclude = null)

account.cart.list

This method lets you get a list of online stores connected to your API2Cart account. You can get the number of API requests to each store if you specify a period using parameters (request_from_date, request_to_date). The total_calls field is displayed only if there are parameters (request_from_date, request_to_date).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountCartListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AccountApi(config);
            var storeUrl = http://mystore.com;  // string? | A web address of a store (optional) 
            var storeKey = ab37fc230bc5df63a5be1b11220949be;  // string? | Find store by store key (optional) 
            var requestFromDate = 2010-07-29;  // string? | Retrieve entities from their creation date (optional) 
            var requestToDate = 2100-08-29;  // string? | Retrieve entities to their creation date (optional) 
            var varParams = url,store_key;  // string? | Set this parameter in order to choose which entity fields you want to retrieve (optional)  (default to "force_all")
            var exclude = url,store_key;  // string? | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter `params` equal force_all (optional) 

            try
            {
                // account.cart.list
                AccountCartList200Response result = apiInstance.AccountCartList(storeUrl, storeKey, requestFromDate, requestToDate, varParams, exclude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountCartList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountCartListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // account.cart.list
    ApiResponse<AccountCartList200Response> response = apiInstance.AccountCartListWithHttpInfo(storeUrl, storeKey, requestFromDate, requestToDate, varParams, exclude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountCartListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeUrl** | **string?** | A web address of a store | [optional]  |
| **storeKey** | **string?** | Find store by store key | [optional]  |
| **requestFromDate** | **string?** | Retrieve entities from their creation date | [optional]  |
| **requestToDate** | **string?** | Retrieve entities to their creation date | [optional]  |
| **varParams** | **string?** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to &quot;force_all&quot;] |
| **exclude** | **string?** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional]  |

### Return type

[**AccountCartList200Response**](AccountCartList200Response.md)

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

<a id="accountconfigupdate"></a>
# **AccountConfigUpdate**
> AccountConfigUpdate200Response AccountConfigUpdate (bool? replaceParameters = null, string? newStoreUrl = null, string? newStoreKey = null, string? bridgeUrl = null, string? storeRoot = null, string? dbTablesPrefix = null, string? userAgent = null, string? var3dcartPrivateKey = null, string? var3dcartAccessToken = null, string? var3dcartapiApiKey = null, string? amazonSpClientId = null, string? amazonSpClientSecret = null, string? amazonSpRefreshToken = null, string? amazonSpAwsRegion = null, string? amazonSpApiEnvironment = null, string? amazonSellerId = null, string? aspdotnetstorefrontApiUser = null, string? aspdotnetstorefrontApiPass = null, string? bigcommerceapiAdminAccount = null, string? bigcommerceapiApiPath = null, string? bigcommerceapiApiKey = null, string? bigcommerceapiClientId = null, string? bigcommerceapiAccessToken = null, string? bigcommerceapiContext = null, string? bolApiKey = null, string? bolApiSecret = null, int? bolRetailerId = null, string? demandwareClientId = null, string? demandwareApiPassword = null, string? demandwareUserName = null, string? demandwareUserPassword = null, string? ebayClientId = null, string? ebayClientSecret = null, string? ebayRuname = null, string? ebayAccessToken = null, string? ebayRefreshToken = null, string? ebayEnvironment = null, int? ebaySiteId = null, string? ecwidAcessToken = null, string? ecwidStoreId = null, string? lazadaAppId = null, string? lazadaAppSecret = null, string? lazadaRefreshToken = null, string? lazadaRegion = null, string? etsyKeystring = null, string? etsySharedSecret = null, string? etsyAccessToken = null, string? etsyTokenSecret = null, string? etsyClientId = null, string? etsyRefreshToken = null, string? facebookAppId = null, string? facebookAppSecret = null, string? facebookAccessToken = null, string? facebookBusinessId = null, string? netoApiKey = null, string? netoApiUsername = null, string? shoplineAccessToken = null, string? shoplineAppKey = null, string? shoplineAppSecret = null, string? shoplineSharedSecret = null, string? shopifyAccessToken = null, string? shopifyApiKey = null, string? shopifyApiPassword = null, string? shopifySharedSecret = null, string? shopeePartnerId = null, string? shopeePartnerKey = null, string? shopeeShopId = null, string? shopeeRefreshToken = null, string? shopeeRegion = null, string? shopeeEnvironment = null, string? shoplazzaAccessToken = null, string? shoplazzaSharedSecret = null, string? mivaAccessToken = null, string? mivaSignature = null, string? shopwareAccessKey = null, string? unasApiKey = null, string? shopwareApiKey = null, string? shopwareApiSecret = null, string? bigcartelUserName = null, string? bigcartelPassword = null, string? bricklinkConsumerKey = null, string? bricklinkConsumerSecret = null, string? bricklinkToken = null, string? bricklinkTokenSecret = null, string? volusionLogin = null, string? volusionPassword = null, string? walmartClientId = null, string? walmartClientSecret = null, string? walmartEnvironment = null, string? walmartChannelType = null, string? walmartRegion = null, string? squareClientId = null, string? squareClientSecret = null, string? squareRefreshToken = null, string? squarespaceApiKey = null, string? squarespaceClientId = null, string? squarespaceClientSecret = null, string? squarespaceAccessToken = null, string? squarespaceRefreshToken = null, string? hybrisClientId = null, string? hybrisClientSecret = null, string? hybrisUsername = null, string? hybrisPassword = null, List<string>? hybrisWebsites = null, string? lightspeedApiKey = null, string? lightspeedApiSecret = null, string? commercehqApiKey = null, string? commercehqApiPassword = null, string? wcConsumerKey = null, string? wcConsumerSecret = null, string? magentoConsumerKey = null, string? magentoConsumerSecret = null, string? magentoAccessToken = null, string? magentoTokenSecret = null, string? prestashopWebserviceKey = null, string? wixAppId = null, string? wixAppSecretKey = null, string? wixInstanceId = null, string? wixRefreshToken = null, string? mercadoLibreAppId = null, string? mercadoLibreAppSecretKey = null, string? mercadoLibreRefreshToken = null, int? zidClientId = null, string? zidClientSecret = null, string? zidAccessToken = null, string? zidAuthorization = null, string? zidRefreshToken = null, string? flipkartClientId = null, string? flipkartClientSecret = null, string? allegroClientId = null, string? allegroClientSecret = null, string? allegroAccessToken = null, string? allegroRefreshToken = null, string? allegroEnvironment = null, string? zohoClientId = null, string? zohoClientSecret = null, string? zohoRefreshToken = null, string? zohoRegion = null, int? tiendanubeUserId = null, string? tiendanubeAccessToken = null, string? tiendanubeClientSecret = null, string? ottoClientId = null, string? ottoClientSecret = null, string? ottoAppId = null, string? ottoRefreshToken = null, string? ottoEnvironment = null, string? ottoAccessToken = null, string? tiktokshopAppKey = null, string? tiktokshopAppSecret = null, string? tiktokshopRefreshToken = null, string? tiktokshopAccessToken = null, string? sallaClientId = null, string? sallaClientSecret = null, string? sallaRefreshToken = null, string? sallaAccessToken = null, string? temuAppKey = null, string? temuAppSecret = null, string? temuAccessToken = null, string? temuRegion = null)

account.config.update

Use this method to automate the change of credentials used to connect online stores. The list of supported parameters differs depending on the platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountConfigUpdateExample
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

            var apiInstance = new AccountApi(config);
            var replaceParameters = true;  // bool? | Identifies if there is a necessity to replace parameters (optional) 
            var newStoreUrl = http://mystore.com;  // string? | The web address of the store you want to update to connect to API2Cart (optional) 
            var newStoreKey = b636495648de3086f6f57b1bd4be548f;  // string? | Update store key (optional) 
            var bridgeUrl = https://your-store.com/custom/bridge/path/bridge.php;  // string? | This parameter allows to set up store with custom bridge url (also you must use store_root parameter if a bridge folder is not in the root folder of the store) (optional) 
            var storeRoot = /home/www/stores/magento1922;  // string? | Absolute path to the store root directory (used with \"bridge_url\" parameter) (optional) 
            var dbTablesPrefix = oc_;  // string? | DB tables prefix (optional) 
            var userAgent = Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0;  // string? | This parameter allows you to set your custom user agent, which will be used in requests to the store. Please use it cautiously, as the store's firewall may block specific values. (optional) 
            var var3dcartPrivateKey = 7dba81f90bdbe25e7000e73214ca51b;  // string? | 3DCart Private Key (optional) 
            var var3dcartAccessToken = 4Grr_ZCLNNoSUuhAjesKuchxo9SL;  // string? | 3DCart Token (optional) 
            var var3dcartapiApiKey = 82cc921c6a5c67082cc921c6a5c6707e1d6e6862ba3201a;  // string? | 3DCart API Key (optional) 
            var amazonSpClientId = amzn1.application-oa2-client.11e000e1f47d4998aca3733716d3b5a4;  // string? | Amazon SP API app client id (optional) 
            var amazonSpClientSecret = 2c987428209f235443221255bde064f4bdf8a65165a80f5d22760a83cb;  // string? | Amazon SP API app client secret (optional) 
            var amazonSpRefreshToken = Atzr|IwEBIPUI-bwRTdDgKNQ_g56C30wGqymtx30c9MdDC7Emwmojhs20k5BBG2hHtJiGZ_7OfG7khd1RuQr6KEst4qyWbo_eXi5S_T_VOxzJUuksG1cFOGFpFK-cnhReNzAeZIpZeJT7_ROy1csEFlQfC8FJS3bsbSkkbTz2ZcTN7_7ey0HVlhyfFizgROeSeOI24Wjs9l_KKzZW0jvi_oC2cxlIcyknnHLK6KMNz2rTXqQJWRtlK9xPJDdbcUa5STA8MQru91cxNBpSkZN_cq9OOELhbsIGKD75y7nZ3yJU4uHQC_9iBQQoFm0biKgi-kEQwOhwws8;  // string? | Amazon SP API OAuth refresh token (optional) 
            var amazonSpAwsRegion = us-east-1;  // string? | Amazon AWS Region (optional) 
            var amazonSpApiEnvironment = sandbox;  // string? | Amazon SP API environment (optional)  (default to "production")
            var amazonSellerId = 13P636B2M1N4WR;  // string? | Amazon Seller ID (Merchant token) (optional) 
            var aspdotnetstorefrontApiUser = admin;  // string? | It's a AspDotNetStorefront account for which API is available (optional) 
            var aspdotnetstorefrontApiPass = f6471ef78f72b41849a8b8b67791b0b5;  // string? | AspDotNetStorefront API Password (optional) 
            var bigcommerceapiAdminAccount = admin;  // string? | It's a BigCommerce account for which API is enabled (optional) 
            var bigcommerceapiApiPath = http://mystore.bigcommerce.com/api/v1;  // string? | BigCommerce API URL (optional) 
            var bigcommerceapiApiKey = 6b89704cd75738cb0f9f6468d5462aba;  // string? | Bigcommerce API Key (optional) 
            var bigcommerceapiClientId = p1r37bt131z86675nofv9xmhietoe4t;  // string? | Client ID of the requesting app (optional) 
            var bigcommerceapiAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Access token authorizing the app to access resources on behalf of a user (optional) 
            var bigcommerceapiContext = stores/etplnf8o8v;  // string? | API Path section unique to the store (optional) 
            var bolApiKey = 51369628-feee-11ed-be56-0242ac120002;  // string? | Bol API Key (optional) 
            var bolApiSecret = 8fGzEsbEP5z2MNZubmIil87m-sWzTkj?KDQKrmzmU!fA6aAUNMdKRp7LMWHwE!G37UMfnWByHBGSXJHkAG?QcuYTO2uklv4idIHwUMLHK!OO1yfRlWh!;  // string? | Bol API Secret (optional) 
            var bolRetailerId = 145001;  // int? | Bol Retailer ID (optional) 
            var demandwareClientId = b849eb85-v8b9-1dw8-9fe2-97e1d6ffc7b0;  // string? | Demandware client id (optional) 
            var demandwareApiPassword = testpassword;  // string? | Demandware api password (optional) 
            var demandwareUserName = admin;  // string? | Demandware user name (optional) 
            var demandwareUserPassword = 12345;  // string? | Demandware user password (optional) 
            var ebayClientId = a9psel85v1wy5faeyjw03y0r;  // string? | Application ID (AppID). (optional) 
            var ebayClientSecret = gmz3iz45x2;  // string? | Shared Secret from eBay application (optional) 
            var ebayRuname = gmz3iz45x2;  // string? | The RuName value that eBay assigns to your application. (optional) 
            var ebayAccessToken = v^1.1#i ... AjRV4yNjA=;  // string? | Used to authenticate API requests. (optional) 
            var ebayRefreshToken = v^1.1#i ... rAewqVasdA=;  // string? | Used to renew the access token. (optional) 
            var ebayEnvironment = sandbox;  // string? | eBay environment (optional) 
            var ebaySiteId = 101;  // int? | eBay global ID (optional)  (default to 0)
            var ecwidAcessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Access token authorizing the app to access resources on behalf of a user (optional) 
            var ecwidStoreId = 1;  // string? | Store Id (optional) 
            var lazadaAppId = 112577;  // string? | Lazada App ID (optional) 
            var lazadaAppSecret = er33raICJ79Q5b0EsR9stmRnjE9XQ2WH;  // string? | Lazada App Secret (optional) 
            var lazadaRefreshToken = EAAPP06rM2n8BO4mZBuMPnu9zS0MaMbN7ue8aUkcxw4zewU337mVVb5br;  // string? | Lazada Refresh Token (optional) 
            var lazadaRegion = Malaysia;  // string? | Lazada API endpoint Region (optional) 
            var etsyKeystring = a9psel85v1wy5faeyjw03y0r;  // string? | Etsy keystring (optional) 
            var etsySharedSecret = gmz3iz45x2;  // string? | Etsy shared secret (optional) 
            var etsyAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Access token authorizing the app to access resources on behalf of a user (optional) 
            var etsyTokenSecret = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Secret token authorizing the app to access resources on behalf of a user (optional) 
            var etsyClientId = w0fi0igk2w29bjcd7ydr2s35;  // string? | Etsy Client Id (optional) 
            var etsyRefreshToken = 223577551.L07_RE-y7unmKf2dox4djsHkVxwpUfs1ikG_uQmHhF-aASEReNn_Qns1Wqn3dDa0ZMxrt9CIael3dgudeDZb31ZUdS;  // string? | Etsy Refresh token (optional) 
            var facebookAppId = 6516912365277570;  // string? | Facebook App ID (optional) 
            var facebookAppSecret = 737cf6bd2879cb6c7e5a8ff9cd63f3d46b0b5b7b;  // string? | Facebook App Secret (optional) 
            var facebookAccessToken = EAAPP06rM2n8BO4mZBuMPnu9zS0MaMbN7ue8aUAhqbS58clzJwyp1rYRMpP31QJGziqtYbKypdVx3Cs0RpuufoUeLsbfX195XIB8VTlkcxw4zewU337mVVb5br;  // string? | Facebook Access Token (optional) 
            var facebookBusinessId = 294042786906655;  // string? | Facebook Business ID (optional) 
            var netoApiKey = bbca57d8ff3c3677128112c15556d9e3;  // string? | Neto API Key (optional) 
            var netoApiUsername = mylogin;  // string? | Neto User Name (optional) 
            var shoplineAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Shopline APP Key (optional) 
            var shoplineAppKey = 737cf6bd2879cb6c7e5a8ff9cd63f3d46b0b5b7b;  // string? | Shopline APP Key (optional) 
            var shoplineAppSecret = 1701d123bb5cc14cd2732dcaed90638316c0a09;  // string? | Shopline App Secret (optional) 
            var shoplineSharedSecret = 1701d123bb5cc14cd2732dcaed90638316c0a09;  // string? | Shopline Shared Secret (optional) 
            var shopifyAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Access token authorizing the app to access resources on behalf of a user (optional) 
            var shopifyApiKey = bbca57d8ff3c3677128112c15556d9e3;  // string? | Shopify API Key (optional) 
            var shopifyApiPassword = 860f3a6fc87632301a42cd88e4b5ab3d;  // string? | Shopify API Password (optional) 
            var shopifySharedSecret = gmz3iz45x2;  // string? | Shared secret (optional) 
            var shopeePartnerId = 1276777;  // string? | Shopee Partner ID (optional) 
            var shopeePartnerKey = 6a46494b4d746576554646626775617a577542774850636375464d6a736d5598;  // string? | Shopee Partner Key (optional) 
            var shopeeShopId = 137968;  // string? | Shopee SHOP ID (optional) 
            var shopeeRefreshToken = EAAPP06rM2n8BO4mZBuMPnu9zS0MaMbN7ue8aUkcxw4zewU987mVVb5br;  // string? | Shopee Refresh Token (optional) 
            var shopeeRegion = CN;  // string? | Shopee API endpoint Region. Use for Chinese Mainland or Brazil. (optional) 
            var shopeeEnvironment = sandbox;  // string? | Shopee Environment (optional) 
            var shoplazzaAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Access token authorizing the app to access resources on behalf of a user (optional) 
            var shoplazzaSharedSecret = gmz3iz45x2;  // string? | Shared secret (optional) 
            var mivaAccessToken = 227cbe434a1e358d72db0de993x9d9fd;  // string? | Miva access token (optional) 
            var mivaSignature = 1hpkrebfdsObGTor/0Gk9XcNBUQohrxrw67Sg9AM9ps=;  // string? | Miva signature (optional) 
            var shopwareAccessKey = SWSCS3O1RJBSRNBYQLFIYJN2ZQ;  // string? | Shopware access key (optional) 
            var unasApiKey = c238908e29ceb6e6ad3df15f89a6234709d3f000;  // string? | UNAS API Key (optional) 
            var shopwareApiKey = SWSCS3O1RJBSRNBYQLFIYJN2ZQ;  // string? | Shopware api key (optional) 
            var shopwareApiSecret = V3NYNWg2b1dZdHBUWDN1cmdKdGhnenp5enVJYlJ0WlJvOFF2bnQ;  // string? | Shopware client secret access key (optional) 
            var bigcartelUserName = subdomain;  // string? | Subdomain of store (optional) 
            var bigcartelPassword = 4GrrZCLNNoSUuhAjesKuchxo9SL;  // string? | BigCartel account password (optional) 
            var bricklinkConsumerKey = 26F6CDA087D9444EAA71AC09E7A1D39A;  // string? | Bricklink Consumer Key (optional) 
            var bricklinkConsumerSecret = a46abc3kxyinlbggy06i9g975xqo6gjq;  // string? | Bricklink Consumer Secret (optional) 
            var bricklinkToken = ktv4n9rgrj0evjuy2t6p2xlb1f8u5pmy;  // string? | Bricklink Access Token (optional) 
            var bricklinkTokenSecret = a46abc3kxyinlbggy06i9g975xqo6gjq;  // string? | Bricklink Access Token Secret (optional) 
            var volusionLogin = admin;  // string? | It's a Volusion account for which API is enabled (optional) 
            var volusionPassword = 7943CA5F3990E00D9A4CCF0BD998211F;  // string? | Volusion API Password (optional) 
            var walmartClientId = 423f6A24-123z-8654-989u-6fa96478289;  // string? | Walmart client ID. For the region 'ca' use Consumer ID (optional) 
            var walmartClientSecret = 1gf85fea-8974-2648-w12w-rt54284tdf54;  // string? | Walmart client secret. For the region 'ca' use Private Key (optional) 
            var walmartEnvironment = production;  // string? | Walmart environment (optional)  (default to "production")
            var walmartChannelType = 0f3e4dd4-0514-4346-b39d-af0e00ea066d;  // string? | Walmart WM_CONSUMER.CHANNEL.TYPE header (optional) 
            var walmartRegion = us;  // string? | Walmart region (optional)  (default to "us")
            var squareClientId = sq0idp-qwer_1pvuTYe9cAf1lmxyQ;  // string? | Square (Weebly) Client ID (optional) 
            var squareClientSecret = c8d7077fce7b2b111111111898170695a01473a2ad;  // string? | Square (Weebly) Client Secret (optional) 
            var squareRefreshToken = EQAAlquVXMr6xIcPu7qPkIEAZ0thqChhQuowrvZIqOlwhOwhtmyh4ZRfesdRc434;  // string? | Square (Weebly) Refresh Token (optional) 
            var squarespaceApiKey = 8f7849d5-1411-47f2-9722-aa81c2a48d95;  // string? | Squarespace API Key (optional) 
            var squarespaceClientId = 9UGbUtS2V96BxRGmfOjsGAhTdsr9Vxxx;  // string? | Squarespace Connector Client ID (optional) 
            var squarespaceClientSecret = GPZkUFkIKWg0KLE6rajsFMMYA9ma0udaaq2bYwBDXXX=;  // string? | Squarespace Connector Client Secret (optional) 
            var squarespaceAccessToken = SWSCS3O1RJBSRNBYQLFIYJN2ZQ;  // string? | Squarespace access token (optional) 
            var squarespaceRefreshToken = def50eyfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe657e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65de64a0c865d;  // string? | Squarespace refresh token (optional) 
            var hybrisClientId = api_client_1;  // string? | Omni Commerce Connector Client ID (optional) 
            var hybrisClientSecret = secret_phrase_1;  // string? | Omni Commerce Connector Client Secret (optional) 
            var hybrisUsername = admin;  // string? | User Name (optional) 
            var hybrisPassword = nimda;  // string? | User password (optional) 
            var hybrisWebsites = new List<string>?(); // List<string>? | Websites to stores mapping data (optional) 
            var lightspeedApiKey = cf5444729c2abd6b6a5d983691767cb5;  // string? | LightSpeed api key (optional) 
            var lightspeedApiSecret = 2620ee52a8bc942f9d5d3a575f4d363e;  // string? | LightSpeed api secret (optional) 
            var commercehqApiKey = sJrD-LM0eddhe63rfgfva0dDydXfre4;  // string? | CommerceHQ api key (optional) 
            var commercehqApiPassword = 4Grr_ZCLNNoSUuhAjesKuchxo9SL;  // string? | CommerceHQ api password (optional) 
            var wcConsumerKey = ck_26d8e2ad604f3917e429df6961722282bdcf109d;  // string? | Woocommerce consumer key (optional) 
            var wcConsumerSecret = cs_931ced666118a15c5f7b4a33a15gf5589cbeba55;  // string? | Woocommerce consumer secret (optional) 
            var magentoConsumerKey = ktv4n9rgrj0evjuy2t6p2xlb1f8u5pmy;  // string? | Magento Consumer Key (optional) 
            var magentoConsumerSecret = a46abc3kxyinlbggy06i9g975xqo6gjq;  // string? | Magento Consumer Secret (optional) 
            var magentoAccessToken = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Magento Access Token (optional) 
            var magentoTokenSecret = igse8e4rdmzkxdi937qe69d59en1imw;  // string? | Magento Token Secret (optional) 
            var prestashopWebserviceKey = CKJ1ZEWRJWRLTPVBQJ9FGGRORD4AGS96;  // string? | Prestashop webservice key (optional) 
            var wixAppId = 6b0b5b7b-7d87-45b5-bf34-ac6b438e63da;  // string? | Wix App ID (optional) 
            var wixAppSecretKey = 316c0a09-f195-42be-74f6-a02cebb9cae6;  // string? | Wix App Secret Key (optional) 
            var wixInstanceId = 58b893a4-6b16-5c2f-qt78-qa3r61t32rt8;  // string? | Wix Instance ID (optional) 
            var wixRefreshToken = 
        OAUTH2.eyJraWQiOiJkZ0x3cjNRMCIsImFsZyI6IkhTMjU2In0.
        eyJkYXRhIjoie1wiaWRcIjpcImJlZjM3MmRmLTUyNGItNDI3NS05M2RkL
        Tg4NDBlOTU3ZWU2OFwifSIsImlhdCI6MTY0ODA0NTEyNiwiZXhwIjoxNzExMTE3MTI2fQ.
        VRR2lGSbcTVmaArtmyyhy6o4WRDwTn-nlDCQpZ97eYw
      ;  // string? | Wix refresh token (optional) 
            var mercadoLibreAppId = 211188015100135;  // string? | Mercado Libre App ID (optional) 
            var mercadoLibreAppSecretKey = e2qoG2zklLlfP7cEngEJ94YjhkejkjAm;  // string? | Mercado Libre App Secret Key (optional) 
            var mercadoLibreRefreshToken = TG-63h13529vb5464110188d2x9-703754376;  // string? | Mercado Libre Refresh Token (optional) 
            var zidClientId = 1234;  // int? | Zid Client ID (optional) 
            var zidClientSecret = nl5l1lE0vxgv6cV111fHsdlOOIfb0Ms5IR7l4Igs;  // string? | Zid Client Secret (optional) 
            var zidAccessToken = def50eyfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe657e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65de64a0c865d;  // string? | Zid Access Token (optional) 
            var zidAuthorization = def50eyfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe657e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65de64a0c865d;  // string? | Zid Authorization (optional) 
            var zidRefreshToken = def50eyfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe657e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65d7e64a0cfe9fe65de64a0c865d;  // string? | Zid refresh token (optional) 
            var flipkartClientId = 19414773883a13a850b6a52350b7246499a24;  // string? | Flipkart Client ID (optional) 
            var flipkartClientSecret = nl5l1lE0vxgv6cV111fHsdlOOIfb0Ms5IR7l4Igs;  // string? | Flipkart Client Secret (optional) 
            var allegroClientId = 2915e189ce3d23d23d2327d204ae6a0bd;  // string? | Allegro Client ID (optional) 
            var allegroClientSecret = DNHtqdL2WPIefeUhQWYgtXPS23fgbfgasdsGHHJGhg3RTFDQWFGZmVoFRT5IfkQj1E7eR5;  // string? | Allegro Client Secret (optional) 
            var allegroAccessToken = eyJhbGciOiJSUzI1NiIsInR5cCI6IsfddfdfdeyJ1c2VyX25hbWUiOiI5NDUxMzE1MSIsInNjb3BlIjpbImFsbGVncm86YXBpOm9yZGVyczpyZWFkIiwiYWxsZWdybzphcGk6cHJvZmlsZTp3cml0ZSIsImFsbGVncm86YXBpOnNhbGU6b2ZmZXJzOndyaXRlIiwiYWxsZWdybzphcGk6YmlsbGluZzpyZWFkIiwiYWxsZWdybzphcGk6Y2FtcGFpZ25zIiwiYWxsZWdybzphcGk6ZGlzcHV0ZXMiLCJhbGxlZ3JvOmFwaTpzYWxlOm9mZmVyczpyZWFkIiwiYWxsZWdybzphcGk6YmlkcyIsImFsbGVncm86YXBpOm9yZGVyczp3cml0ZSIsImFsbGVncm86YXBpOnBheW1lbnRzOndyaXRlIiwiYWxsZWdybzphcGk6c2FsZTpzZXR0aW5nczp3cml0ZSIsImFsbGVncm86YXBpOnByb2ZpbGU6cmVhZCIsImFsbGVncm86YXBpOnJhdGluZ3MiLCJhbGxlZ3JvOmFwaTpzYWxlOnNldHRpbmdzOnJlYWQiLCJhbGxlZ3JvOmFwaTpwYXltZW50czpyZWFkIiwiYWxsZWdybzphcGk6bWVzc2FnaW5nIl0sI;  // string? | Allegro Access Token (optional) 
            var allegroRefreshToken = eyJhbGciOiJSUzI1NiIsInR5cCI6IsfddfdfdeyJ1c2VyX25hbWUiOiI5NDUxMzE1MSIsInNjb3BlIjpbImFsbGVncm86YXBpOm9yZGVyczpyZWFkIiwiYWxsZWdybzphcGk6cHJvZmlsZTp3cml0ZSIsImFsbGVncm86YXBpOnNhbGU6b2ZmZXJzOndyaXRlIiwiYWxsZWdybzphcGk6YmlsbGluZzpyZWFkIiwiYWxsZWdybzphcGk6Y2FtcGFpZ25zIiwiYWxsZWdybzphcGk6ZGlzcHV0ZXMiLCJhbGxlZ3JvOmFwaTpzYWxlOm9mZmVyczpyZWFkIiwiYWxsZWdybzphcGk6YmlkcyIsImFsbGVncm86YXBpOm9yZGVyczp3cml0ZSIsImFsbGVncm86YXBpOnBheW1lbnRzOndyaXRlIiwiYWxsZWdybzphcGk6c2FsZTpzZXR0aW5nczp3cml0ZSIsImFsbGVncm86YXBpOnByb2ZpbGU6cmVhZCIsImFsbGVncm86YXBpOnJhdGluZ3MiLCJhbGxlZ3JvOmFwaTpzYWxlOnNldHRpbmdzOnJlYWQiLCJhbGxlZ3JvOmFwaTpwYXltZW50czpyZWFkIiwiYWxsZWdybzphcGk6bWVzc2FnaW5nIl0sI;  // string? | Allegro Refresh Token (optional) 
            var allegroEnvironment = sandbox;  // string? | Allegro Environment (optional)  (default to "production")
            var zohoClientId = 1000.FLCHGI2LS1111111TOR4OGB697W4IX;  // string? | Zoho Client ID (optional) 
            var zohoClientSecret = c8d7077fce7b2b111111111898170695a01473a2ad;  // string? | Zoho Client Secret (optional) 
            var zohoRefreshToken = 1000.11111111111111111111111111111111.1b3ca6f054341a111118abf928beb33b;  // string? | Zoho Refresh Token (optional) 
            var zohoRegion = Europe;  // string? | Zoho API endpoint Region (optional) 
            var tiendanubeUserId = 1234;  // int? | Tiendanube User ID (optional) 
            var tiendanubeAccessToken = 75bde7bb0b437475423e7e87c142c06052f80199;  // string? | Tiendanube Access Token (optional) 
            var tiendanubeClientSecret = 5e3588f514a5ae0d0fa063d1b556531e25c83fa7e47472ed;  // string? | Tiendanube Client Secret (optional) 
            var ottoClientId = 911a3dbf-d261-4763-cc81-052876465b55;  // string? | Otto Client ID (optional) 
            var ottoClientSecret = 9887a82a-2879-421e-a6wc-54e986b3458c;  // string? | Otto Client Secret (optional) 
            var ottoAppId = 6eaef6a3-822e-425b-8mc9-53750063e34d;  // string? | Otto App ID (optional) 
            var ottoRefreshToken = eyJhbGciOiJSUzI1NiIsInR5cCI6IsfddfdfdeyJ1c2VyX25hbWUiOiI5NDUxMzE1MSIsInNjb3BlIjpbImFsbGVncm86YXBpOm9yZGVyczpyZWFkIiwiYWxsZWdybzphcGk6cHJvZmlsZTp3cml0ZSIsImFsbGVncm86YXBpOnNhbGU6b2ZmZXJzOndyaXRlIiwiYWxsZWdybzphcGk6YmlsbGluZzpyZWFkIiwiYWxsZWdybzphcGk6Y2FtcGFpZ25zIiwiYWxsZWdybzphcGk6ZGlzcHV0ZXMiLCJhbGxlZ3JvOmFwaTpzYWxlOm9mZmVyczpyZWFkIiwiYWxsZWdybzphcGk6YmlkcyIsImFsbGVncm86YXBpOm9yZGVyczp3cml0ZSIsImFsbGVncm86YXBpOnBheW1lbnRzOndyaXRlIiwiYWxsZWdybzphcGk6c2FsZTpzZXR0aW5nczp3cml0ZSIsImFsbGVncm86YXBpOnByb2ZpbGU6cmVhZCIsImFsbGVncm86YXBpOnJhdGluZ3MiLCJhbGxlZ3JvOmFwaTpzYWxlOnNldHRpbmdzOnJlYWQiLCJhbGxlZ3JvOmFwaTpwYXltZW50czpyZWFkIiwiYWxsZWdybzphcGk6bWVzc2FnaW5nIl0sI;  // string? | Otto Refresh Token (optional) 
            var ottoEnvironment = sandbox;  // string? | Otto Environment (optional) 
            var ottoAccessToken = eyJhbGciOiJS34535f45f54f5656deyJ1c2VyX25hbWUiOiI5NDUxMzE1MSIsInNjb3BlIjpbImFsbGVncm86YXBpOm9yZGVyczpyZWFkIiwiYWxsZWdybzphcGk6cHJvZmlsZTp3cml0ZSIsImFsbGVncm86YXBpOnNhbGU6b2ZmZXJzOndyaXRlIiwiYWxsZWdybzphcGk6YmlsbGluZzpyZWFkIiwiYWxsZWdybzphcGk6Y2FtcGFpZ25zIiwiYWxsZWdybzphcGk6ZGlzcHV0ZXMiLCJhbGxlZ3JvOmFwaTpzYWxlOm9mZmVyczpyZWFkIiwiYWxsZWdybzphcGk6YmlkcyIsImFsbGVncm86YXBpOm9yZGVyczp3cml0ZSIsImFsbGVncm86YXBpOnBheW1lbnRzOndyaXRlIiwiYWxsZWdybzphcGk6c2FsZTpzZXR0aW5nczp3cml0ZSIsImFsbGVncm86YXBpOnByb2ZpbGU6cmVhZCIsImFsbGVncm86YXBpOnJhdGluZ3MiLCJhbGxlZ3JvOmFwaTpzYWxlOnNldHRpbmdzOnJlYWQiLCJhbGxlZ3JvOmFwaTpwYXltZW50czpyZWFkIiwiYWxsZWdybzphcGk6bWVzc2FnaW5nIl0sI;  // string? | Otto Access Token (optional) 
            var tiktokshopAppKey = 6arbhkzno8nbv;  // string? | TikTok Shop App Key (optional) 
            var tiktokshopAppSecret = d95820a05a0cd54fb394fcd26fgat63999b183bc;  // string? | TikTok Shop App Secret (optional) 
            var tiktokshopRefreshToken = TTP_NTUxZTNhYTQ2ZDk2YmRmZWNmYWY2YWY12345NGYwNjQ3YjkzYTllYjA0YmNlMw;  // string? | TikTok Shop Refresh Token (optional) 
            var tiktokshopAccessToken = TTP_Fw8r12345kW03FYd09DG-9INtpw361hWthei12345iPJ5AUv99fLSCYD9-Uu12345TgNRzKZxi5-tfFMtdWqglEt5_iCk;  // string? | TikTok Shop Access Token (optional) 
            var sallaClientId = 1bxxxcf9-5xx4-xxx-bxxf-929b8xxxxe11;  // string? | Salla Client ID (optional) 
            var sallaClientSecret = 8x88axxxc25e1fxxxa1c06fxxx150xx5;  // string? | Salla Client Secret (optional) 
            var sallaRefreshToken = oxy_rt_zxxxxiY2xxZWWxxxxlU-tROxxxxx2JzS2fwzxxxxxkU.p3xxxkCIyFexxxxP50WwZYfhw5_wg1xxxxV5F-8xxXc;  // string? | Salla Refresh Token (optional) 
            var sallaAccessToken = oxy_rt_zxxxxiY2xxZWWxxxxlU-tROxxxxx2JzS2fwzxxxxxkU.p3xxxkCIyFexxxxP50WwZYfhw5_wg1xxxxV5F-8xxXc;  // string? | Salla Access Token (optional) 
            var temuAppKey = 4ebbc9190ae410443d65b4c2faca9811;  // string? | Temu App Key (optional) 
            var temuAppSecret = 4782d2d827276688bf4758bed55dbdd4bbe79a78;  // string? | Temu App Secret (optional) 
            var temuAccessToken = uplv3hfyt5kcwoymrgnajnbl1ow5qxlz4sqhev6hl3xosz5dejrtyl2jre6;  // string? | Temu Access Token (optional) 
            var temuRegion = US;  // string? | Temu API endpoint Region. (optional) 

            try
            {
                // account.config.update
                AccountConfigUpdate200Response result = apiInstance.AccountConfigUpdate(replaceParameters, newStoreUrl, newStoreKey, bridgeUrl, storeRoot, dbTablesPrefix, userAgent, var3dcartPrivateKey, var3dcartAccessToken, var3dcartapiApiKey, amazonSpClientId, amazonSpClientSecret, amazonSpRefreshToken, amazonSpAwsRegion, amazonSpApiEnvironment, amazonSellerId, aspdotnetstorefrontApiUser, aspdotnetstorefrontApiPass, bigcommerceapiAdminAccount, bigcommerceapiApiPath, bigcommerceapiApiKey, bigcommerceapiClientId, bigcommerceapiAccessToken, bigcommerceapiContext, bolApiKey, bolApiSecret, bolRetailerId, demandwareClientId, demandwareApiPassword, demandwareUserName, demandwareUserPassword, ebayClientId, ebayClientSecret, ebayRuname, ebayAccessToken, ebayRefreshToken, ebayEnvironment, ebaySiteId, ecwidAcessToken, ecwidStoreId, lazadaAppId, lazadaAppSecret, lazadaRefreshToken, lazadaRegion, etsyKeystring, etsySharedSecret, etsyAccessToken, etsyTokenSecret, etsyClientId, etsyRefreshToken, facebookAppId, facebookAppSecret, facebookAccessToken, facebookBusinessId, netoApiKey, netoApiUsername, shoplineAccessToken, shoplineAppKey, shoplineAppSecret, shoplineSharedSecret, shopifyAccessToken, shopifyApiKey, shopifyApiPassword, shopifySharedSecret, shopeePartnerId, shopeePartnerKey, shopeeShopId, shopeeRefreshToken, shopeeRegion, shopeeEnvironment, shoplazzaAccessToken, shoplazzaSharedSecret, mivaAccessToken, mivaSignature, shopwareAccessKey, unasApiKey, shopwareApiKey, shopwareApiSecret, bigcartelUserName, bigcartelPassword, bricklinkConsumerKey, bricklinkConsumerSecret, bricklinkToken, bricklinkTokenSecret, volusionLogin, volusionPassword, walmartClientId, walmartClientSecret, walmartEnvironment, walmartChannelType, walmartRegion, squareClientId, squareClientSecret, squareRefreshToken, squarespaceApiKey, squarespaceClientId, squarespaceClientSecret, squarespaceAccessToken, squarespaceRefreshToken, hybrisClientId, hybrisClientSecret, hybrisUsername, hybrisPassword, hybrisWebsites, lightspeedApiKey, lightspeedApiSecret, commercehqApiKey, commercehqApiPassword, wcConsumerKey, wcConsumerSecret, magentoConsumerKey, magentoConsumerSecret, magentoAccessToken, magentoTokenSecret, prestashopWebserviceKey, wixAppId, wixAppSecretKey, wixInstanceId, wixRefreshToken, mercadoLibreAppId, mercadoLibreAppSecretKey, mercadoLibreRefreshToken, zidClientId, zidClientSecret, zidAccessToken, zidAuthorization, zidRefreshToken, flipkartClientId, flipkartClientSecret, allegroClientId, allegroClientSecret, allegroAccessToken, allegroRefreshToken, allegroEnvironment, zohoClientId, zohoClientSecret, zohoRefreshToken, zohoRegion, tiendanubeUserId, tiendanubeAccessToken, tiendanubeClientSecret, ottoClientId, ottoClientSecret, ottoAppId, ottoRefreshToken, ottoEnvironment, ottoAccessToken, tiktokshopAppKey, tiktokshopAppSecret, tiktokshopRefreshToken, tiktokshopAccessToken, sallaClientId, sallaClientSecret, sallaRefreshToken, sallaAccessToken, temuAppKey, temuAppSecret, temuAccessToken, temuRegion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountConfigUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountConfigUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // account.config.update
    ApiResponse<AccountConfigUpdate200Response> response = apiInstance.AccountConfigUpdateWithHttpInfo(replaceParameters, newStoreUrl, newStoreKey, bridgeUrl, storeRoot, dbTablesPrefix, userAgent, var3dcartPrivateKey, var3dcartAccessToken, var3dcartapiApiKey, amazonSpClientId, amazonSpClientSecret, amazonSpRefreshToken, amazonSpAwsRegion, amazonSpApiEnvironment, amazonSellerId, aspdotnetstorefrontApiUser, aspdotnetstorefrontApiPass, bigcommerceapiAdminAccount, bigcommerceapiApiPath, bigcommerceapiApiKey, bigcommerceapiClientId, bigcommerceapiAccessToken, bigcommerceapiContext, bolApiKey, bolApiSecret, bolRetailerId, demandwareClientId, demandwareApiPassword, demandwareUserName, demandwareUserPassword, ebayClientId, ebayClientSecret, ebayRuname, ebayAccessToken, ebayRefreshToken, ebayEnvironment, ebaySiteId, ecwidAcessToken, ecwidStoreId, lazadaAppId, lazadaAppSecret, lazadaRefreshToken, lazadaRegion, etsyKeystring, etsySharedSecret, etsyAccessToken, etsyTokenSecret, etsyClientId, etsyRefreshToken, facebookAppId, facebookAppSecret, facebookAccessToken, facebookBusinessId, netoApiKey, netoApiUsername, shoplineAccessToken, shoplineAppKey, shoplineAppSecret, shoplineSharedSecret, shopifyAccessToken, shopifyApiKey, shopifyApiPassword, shopifySharedSecret, shopeePartnerId, shopeePartnerKey, shopeeShopId, shopeeRefreshToken, shopeeRegion, shopeeEnvironment, shoplazzaAccessToken, shoplazzaSharedSecret, mivaAccessToken, mivaSignature, shopwareAccessKey, unasApiKey, shopwareApiKey, shopwareApiSecret, bigcartelUserName, bigcartelPassword, bricklinkConsumerKey, bricklinkConsumerSecret, bricklinkToken, bricklinkTokenSecret, volusionLogin, volusionPassword, walmartClientId, walmartClientSecret, walmartEnvironment, walmartChannelType, walmartRegion, squareClientId, squareClientSecret, squareRefreshToken, squarespaceApiKey, squarespaceClientId, squarespaceClientSecret, squarespaceAccessToken, squarespaceRefreshToken, hybrisClientId, hybrisClientSecret, hybrisUsername, hybrisPassword, hybrisWebsites, lightspeedApiKey, lightspeedApiSecret, commercehqApiKey, commercehqApiPassword, wcConsumerKey, wcConsumerSecret, magentoConsumerKey, magentoConsumerSecret, magentoAccessToken, magentoTokenSecret, prestashopWebserviceKey, wixAppId, wixAppSecretKey, wixInstanceId, wixRefreshToken, mercadoLibreAppId, mercadoLibreAppSecretKey, mercadoLibreRefreshToken, zidClientId, zidClientSecret, zidAccessToken, zidAuthorization, zidRefreshToken, flipkartClientId, flipkartClientSecret, allegroClientId, allegroClientSecret, allegroAccessToken, allegroRefreshToken, allegroEnvironment, zohoClientId, zohoClientSecret, zohoRefreshToken, zohoRegion, tiendanubeUserId, tiendanubeAccessToken, tiendanubeClientSecret, ottoClientId, ottoClientSecret, ottoAppId, ottoRefreshToken, ottoEnvironment, ottoAccessToken, tiktokshopAppKey, tiktokshopAppSecret, tiktokshopRefreshToken, tiktokshopAccessToken, sallaClientId, sallaClientSecret, sallaRefreshToken, sallaAccessToken, temuAppKey, temuAppSecret, temuAccessToken, temuRegion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountConfigUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **replaceParameters** | **bool?** | Identifies if there is a necessity to replace parameters | [optional]  |
| **newStoreUrl** | **string?** | The web address of the store you want to update to connect to API2Cart | [optional]  |
| **newStoreKey** | **string?** | Update store key | [optional]  |
| **bridgeUrl** | **string?** | This parameter allows to set up store with custom bridge url (also you must use store_root parameter if a bridge folder is not in the root folder of the store) | [optional]  |
| **storeRoot** | **string?** | Absolute path to the store root directory (used with \&quot;bridge_url\&quot; parameter) | [optional]  |
| **dbTablesPrefix** | **string?** | DB tables prefix | [optional]  |
| **userAgent** | **string?** | This parameter allows you to set your custom user agent, which will be used in requests to the store. Please use it cautiously, as the store&#39;s firewall may block specific values. | [optional]  |
| **var3dcartPrivateKey** | **string?** | 3DCart Private Key | [optional]  |
| **var3dcartAccessToken** | **string?** | 3DCart Token | [optional]  |
| **var3dcartapiApiKey** | **string?** | 3DCart API Key | [optional]  |
| **amazonSpClientId** | **string?** | Amazon SP API app client id | [optional]  |
| **amazonSpClientSecret** | **string?** | Amazon SP API app client secret | [optional]  |
| **amazonSpRefreshToken** | **string?** | Amazon SP API OAuth refresh token | [optional]  |
| **amazonSpAwsRegion** | **string?** | Amazon AWS Region | [optional]  |
| **amazonSpApiEnvironment** | **string?** | Amazon SP API environment | [optional] [default to &quot;production&quot;] |
| **amazonSellerId** | **string?** | Amazon Seller ID (Merchant token) | [optional]  |
| **aspdotnetstorefrontApiUser** | **string?** | It&#39;s a AspDotNetStorefront account for which API is available | [optional]  |
| **aspdotnetstorefrontApiPass** | **string?** | AspDotNetStorefront API Password | [optional]  |
| **bigcommerceapiAdminAccount** | **string?** | It&#39;s a BigCommerce account for which API is enabled | [optional]  |
| **bigcommerceapiApiPath** | **string?** | BigCommerce API URL | [optional]  |
| **bigcommerceapiApiKey** | **string?** | Bigcommerce API Key | [optional]  |
| **bigcommerceapiClientId** | **string?** | Client ID of the requesting app | [optional]  |
| **bigcommerceapiAccessToken** | **string?** | Access token authorizing the app to access resources on behalf of a user | [optional]  |
| **bigcommerceapiContext** | **string?** | API Path section unique to the store | [optional]  |
| **bolApiKey** | **string?** | Bol API Key | [optional]  |
| **bolApiSecret** | **string?** | Bol API Secret | [optional]  |
| **bolRetailerId** | **int?** | Bol Retailer ID | [optional]  |
| **demandwareClientId** | **string?** | Demandware client id | [optional]  |
| **demandwareApiPassword** | **string?** | Demandware api password | [optional]  |
| **demandwareUserName** | **string?** | Demandware user name | [optional]  |
| **demandwareUserPassword** | **string?** | Demandware user password | [optional]  |
| **ebayClientId** | **string?** | Application ID (AppID). | [optional]  |
| **ebayClientSecret** | **string?** | Shared Secret from eBay application | [optional]  |
| **ebayRuname** | **string?** | The RuName value that eBay assigns to your application. | [optional]  |
| **ebayAccessToken** | **string?** | Used to authenticate API requests. | [optional]  |
| **ebayRefreshToken** | **string?** | Used to renew the access token. | [optional]  |
| **ebayEnvironment** | **string?** | eBay environment | [optional]  |
| **ebaySiteId** | **int?** | eBay global ID | [optional] [default to 0] |
| **ecwidAcessToken** | **string?** | Access token authorizing the app to access resources on behalf of a user | [optional]  |
| **ecwidStoreId** | **string?** | Store Id | [optional]  |
| **lazadaAppId** | **string?** | Lazada App ID | [optional]  |
| **lazadaAppSecret** | **string?** | Lazada App Secret | [optional]  |
| **lazadaRefreshToken** | **string?** | Lazada Refresh Token | [optional]  |
| **lazadaRegion** | **string?** | Lazada API endpoint Region | [optional]  |
| **etsyKeystring** | **string?** | Etsy keystring | [optional]  |
| **etsySharedSecret** | **string?** | Etsy shared secret | [optional]  |
| **etsyAccessToken** | **string?** | Access token authorizing the app to access resources on behalf of a user | [optional]  |
| **etsyTokenSecret** | **string?** | Secret token authorizing the app to access resources on behalf of a user | [optional]  |
| **etsyClientId** | **string?** | Etsy Client Id | [optional]  |
| **etsyRefreshToken** | **string?** | Etsy Refresh token | [optional]  |
| **facebookAppId** | **string?** | Facebook App ID | [optional]  |
| **facebookAppSecret** | **string?** | Facebook App Secret | [optional]  |
| **facebookAccessToken** | **string?** | Facebook Access Token | [optional]  |
| **facebookBusinessId** | **string?** | Facebook Business ID | [optional]  |
| **netoApiKey** | **string?** | Neto API Key | [optional]  |
| **netoApiUsername** | **string?** | Neto User Name | [optional]  |
| **shoplineAccessToken** | **string?** | Shopline APP Key | [optional]  |
| **shoplineAppKey** | **string?** | Shopline APP Key | [optional]  |
| **shoplineAppSecret** | **string?** | Shopline App Secret | [optional]  |
| **shoplineSharedSecret** | **string?** | Shopline Shared Secret | [optional]  |
| **shopifyAccessToken** | **string?** | Access token authorizing the app to access resources on behalf of a user | [optional]  |
| **shopifyApiKey** | **string?** | Shopify API Key | [optional]  |
| **shopifyApiPassword** | **string?** | Shopify API Password | [optional]  |
| **shopifySharedSecret** | **string?** | Shared secret | [optional]  |
| **shopeePartnerId** | **string?** | Shopee Partner ID | [optional]  |
| **shopeePartnerKey** | **string?** | Shopee Partner Key | [optional]  |
| **shopeeShopId** | **string?** | Shopee SHOP ID | [optional]  |
| **shopeeRefreshToken** | **string?** | Shopee Refresh Token | [optional]  |
| **shopeeRegion** | **string?** | Shopee API endpoint Region. Use for Chinese Mainland or Brazil. | [optional]  |
| **shopeeEnvironment** | **string?** | Shopee Environment | [optional]  |
| **shoplazzaAccessToken** | **string?** | Access token authorizing the app to access resources on behalf of a user | [optional]  |
| **shoplazzaSharedSecret** | **string?** | Shared secret | [optional]  |
| **mivaAccessToken** | **string?** | Miva access token | [optional]  |
| **mivaSignature** | **string?** | Miva signature | [optional]  |
| **shopwareAccessKey** | **string?** | Shopware access key | [optional]  |
| **unasApiKey** | **string?** | UNAS API Key | [optional]  |
| **shopwareApiKey** | **string?** | Shopware api key | [optional]  |
| **shopwareApiSecret** | **string?** | Shopware client secret access key | [optional]  |
| **bigcartelUserName** | **string?** | Subdomain of store | [optional]  |
| **bigcartelPassword** | **string?** | BigCartel account password | [optional]  |
| **bricklinkConsumerKey** | **string?** | Bricklink Consumer Key | [optional]  |
| **bricklinkConsumerSecret** | **string?** | Bricklink Consumer Secret | [optional]  |
| **bricklinkToken** | **string?** | Bricklink Access Token | [optional]  |
| **bricklinkTokenSecret** | **string?** | Bricklink Access Token Secret | [optional]  |
| **volusionLogin** | **string?** | It&#39;s a Volusion account for which API is enabled | [optional]  |
| **volusionPassword** | **string?** | Volusion API Password | [optional]  |
| **walmartClientId** | **string?** | Walmart client ID. For the region &#39;ca&#39; use Consumer ID | [optional]  |
| **walmartClientSecret** | **string?** | Walmart client secret. For the region &#39;ca&#39; use Private Key | [optional]  |
| **walmartEnvironment** | **string?** | Walmart environment | [optional] [default to &quot;production&quot;] |
| **walmartChannelType** | **string?** | Walmart WM_CONSUMER.CHANNEL.TYPE header | [optional]  |
| **walmartRegion** | **string?** | Walmart region | [optional] [default to &quot;us&quot;] |
| **squareClientId** | **string?** | Square (Weebly) Client ID | [optional]  |
| **squareClientSecret** | **string?** | Square (Weebly) Client Secret | [optional]  |
| **squareRefreshToken** | **string?** | Square (Weebly) Refresh Token | [optional]  |
| **squarespaceApiKey** | **string?** | Squarespace API Key | [optional]  |
| **squarespaceClientId** | **string?** | Squarespace Connector Client ID | [optional]  |
| **squarespaceClientSecret** | **string?** | Squarespace Connector Client Secret | [optional]  |
| **squarespaceAccessToken** | **string?** | Squarespace access token | [optional]  |
| **squarespaceRefreshToken** | **string?** | Squarespace refresh token | [optional]  |
| **hybrisClientId** | **string?** | Omni Commerce Connector Client ID | [optional]  |
| **hybrisClientSecret** | **string?** | Omni Commerce Connector Client Secret | [optional]  |
| **hybrisUsername** | **string?** | User Name | [optional]  |
| **hybrisPassword** | **string?** | User password | [optional]  |
| **hybrisWebsites** | [**List&lt;string&gt;?**](string.md) | Websites to stores mapping data | [optional]  |
| **lightspeedApiKey** | **string?** | LightSpeed api key | [optional]  |
| **lightspeedApiSecret** | **string?** | LightSpeed api secret | [optional]  |
| **commercehqApiKey** | **string?** | CommerceHQ api key | [optional]  |
| **commercehqApiPassword** | **string?** | CommerceHQ api password | [optional]  |
| **wcConsumerKey** | **string?** | Woocommerce consumer key | [optional]  |
| **wcConsumerSecret** | **string?** | Woocommerce consumer secret | [optional]  |
| **magentoConsumerKey** | **string?** | Magento Consumer Key | [optional]  |
| **magentoConsumerSecret** | **string?** | Magento Consumer Secret | [optional]  |
| **magentoAccessToken** | **string?** | Magento Access Token | [optional]  |
| **magentoTokenSecret** | **string?** | Magento Token Secret | [optional]  |
| **prestashopWebserviceKey** | **string?** | Prestashop webservice key | [optional]  |
| **wixAppId** | **string?** | Wix App ID | [optional]  |
| **wixAppSecretKey** | **string?** | Wix App Secret Key | [optional]  |
| **wixInstanceId** | **string?** | Wix Instance ID | [optional]  |
| **wixRefreshToken** | **string?** | Wix refresh token | [optional]  |
| **mercadoLibreAppId** | **string?** | Mercado Libre App ID | [optional]  |
| **mercadoLibreAppSecretKey** | **string?** | Mercado Libre App Secret Key | [optional]  |
| **mercadoLibreRefreshToken** | **string?** | Mercado Libre Refresh Token | [optional]  |
| **zidClientId** | **int?** | Zid Client ID | [optional]  |
| **zidClientSecret** | **string?** | Zid Client Secret | [optional]  |
| **zidAccessToken** | **string?** | Zid Access Token | [optional]  |
| **zidAuthorization** | **string?** | Zid Authorization | [optional]  |
| **zidRefreshToken** | **string?** | Zid refresh token | [optional]  |
| **flipkartClientId** | **string?** | Flipkart Client ID | [optional]  |
| **flipkartClientSecret** | **string?** | Flipkart Client Secret | [optional]  |
| **allegroClientId** | **string?** | Allegro Client ID | [optional]  |
| **allegroClientSecret** | **string?** | Allegro Client Secret | [optional]  |
| **allegroAccessToken** | **string?** | Allegro Access Token | [optional]  |
| **allegroRefreshToken** | **string?** | Allegro Refresh Token | [optional]  |
| **allegroEnvironment** | **string?** | Allegro Environment | [optional] [default to &quot;production&quot;] |
| **zohoClientId** | **string?** | Zoho Client ID | [optional]  |
| **zohoClientSecret** | **string?** | Zoho Client Secret | [optional]  |
| **zohoRefreshToken** | **string?** | Zoho Refresh Token | [optional]  |
| **zohoRegion** | **string?** | Zoho API endpoint Region | [optional]  |
| **tiendanubeUserId** | **int?** | Tiendanube User ID | [optional]  |
| **tiendanubeAccessToken** | **string?** | Tiendanube Access Token | [optional]  |
| **tiendanubeClientSecret** | **string?** | Tiendanube Client Secret | [optional]  |
| **ottoClientId** | **string?** | Otto Client ID | [optional]  |
| **ottoClientSecret** | **string?** | Otto Client Secret | [optional]  |
| **ottoAppId** | **string?** | Otto App ID | [optional]  |
| **ottoRefreshToken** | **string?** | Otto Refresh Token | [optional]  |
| **ottoEnvironment** | **string?** | Otto Environment | [optional]  |
| **ottoAccessToken** | **string?** | Otto Access Token | [optional]  |
| **tiktokshopAppKey** | **string?** | TikTok Shop App Key | [optional]  |
| **tiktokshopAppSecret** | **string?** | TikTok Shop App Secret | [optional]  |
| **tiktokshopRefreshToken** | **string?** | TikTok Shop Refresh Token | [optional]  |
| **tiktokshopAccessToken** | **string?** | TikTok Shop Access Token | [optional]  |
| **sallaClientId** | **string?** | Salla Client ID | [optional]  |
| **sallaClientSecret** | **string?** | Salla Client Secret | [optional]  |
| **sallaRefreshToken** | **string?** | Salla Refresh Token | [optional]  |
| **sallaAccessToken** | **string?** | Salla Access Token | [optional]  |
| **temuAppKey** | **string?** | Temu App Key | [optional]  |
| **temuAppSecret** | **string?** | Temu App Secret | [optional]  |
| **temuAccessToken** | **string?** | Temu Access Token | [optional]  |
| **temuRegion** | **string?** | Temu API endpoint Region. | [optional]  |

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

<a id="accountfailedwebhooks"></a>
# **AccountFailedWebhooks**
> AccountFailedWebhooks200Response AccountFailedWebhooks (int? start = null, int? count = null, string? ids = null)

account.failed_webhooks

If the callback of your service for some reason could not accept webhooks from API2Cart, then with the help of this method you can get a list of missed webhooks to perform synchronization again using entity_id. Please note that we keep such records for 24 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountFailedWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AccountApi(config);
            var start = 0;  // int? | This parameter sets the number from which you want to get entities (optional)  (default to 0)
            var count = 20;  // int? | This parameter sets the entity amount that has to be retrieved. Max allowed count=250 (optional)  (default to 10)
            var ids = 3,14,25;  // string? | List of сomma-separated webhook ids (optional) 

            try
            {
                // account.failed_webhooks
                AccountFailedWebhooks200Response result = apiInstance.AccountFailedWebhooks(start, count, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountFailedWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountFailedWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // account.failed_webhooks
    ApiResponse<AccountFailedWebhooks200Response> response = apiInstance.AccountFailedWebhooksWithHttpInfo(start, count, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountFailedWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | This parameter sets the number from which you want to get entities | [optional] [default to 0] |
| **count** | **int?** | This parameter sets the entity amount that has to be retrieved. Max allowed count&#x3D;250 | [optional] [default to 10] |
| **ids** | **string?** | List of сomma-separated webhook ids | [optional]  |

### Return type

[**AccountFailedWebhooks200Response**](AccountFailedWebhooks200Response.md)

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

<a id="accountsupportedplatforms"></a>
# **AccountSupportedPlatforms**
> AccountSupportedPlatforms200Response AccountSupportedPlatforms ()

account.supported_platforms

Use this method to retrieve a list of supported platforms and the sets of parameters required for connecting to each of them. Note: some platforms may have multiple connection methods so that the response will contain multiple sets of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AccountSupportedPlatformsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.api2cart.local.com/v1.1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new AccountApi(config);

            try
            {
                // account.supported_platforms
                AccountSupportedPlatforms200Response result = apiInstance.AccountSupportedPlatforms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.AccountSupportedPlatforms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountSupportedPlatformsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // account.supported_platforms
    ApiResponse<AccountSupportedPlatforms200Response> response = apiInstance.AccountSupportedPlatformsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountSupportedPlatformsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AccountSupportedPlatforms200Response**](AccountSupportedPlatforms200Response.md)

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

