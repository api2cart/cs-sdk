# Org.OpenAPITools.Model.CartCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CartId** | **string** | Store’s identifier which you can get from cart_list method | 
**StoreUrl** | **string** | A web address of a store that you would like to connect to API2Cart | [optional] 
**BridgeUrl** | **string** | This parameter allows to set up store with custom bridge url (also you must use store_root parameter if a bridge folder is not in the root folder of the store) | [optional] 
**StoreRoot** | **string** | Absolute path to the store root directory (used with \&quot;bridge_url\&quot; parameter) | [optional] 
**StoreKey** | **string** | Set this parameter if bridge is already uploaded to store | [optional] 
**SharedSecret** | **string** | Shared secret | [optional] 
**ValidateVersion** | **bool** | Specify if api2cart should validate cart version | [optional] [default to false]
**Verify** | **bool** | Enables or disables cart&#39;s verification | [optional] [default to true]
**DbTablesPrefix** | **string** | DB tables prefix | [optional] 
**UserAgent** | **string** | This parameter allows you to set your custom user agent, which will be used in requests to the store. Please use it cautiously, as the store&#39;s firewall may block specific values. | [optional] 
**FtpHost** | **string** | FTP connection host | [optional] 
**FtpUser** | **string** | FTP User | [optional] 
**FtpPassword** | **string** | FTP Password | [optional] 
**FtpPort** | **int** | FTP Port | [optional] 
**FtpStoreDir** | **string** | FTP Store dir | [optional] 
**ApiKey3dcart** | **string** | 3DCart API Key | [optional] 
**AdminAccount** | **string** | It&#39;s a BigCommerce account for which API is enabled | [optional] 
**ApiPath** | **string** | BigCommerce API URL | [optional] 
**ApiKeyBigcommerce** | **string** | Bigcommerce API Key | [optional] 
**ClientId** | **string** | Client ID of the requesting app | [optional] 
**AccessToken** | **string** | Access token authorizing the app to access resources on behalf of a user | [optional] 
**Context** | **string** | API Path section unique to the store | [optional] 
**AccessToken** | **string** | Access token authorizing the app to access resources on behalf of a user | [optional] 
**ApiKeyShopify** | **string** | Shopify API Key | [optional] 
**ApiPassword** | **string** | Shopify API Password | [optional] 
**AccessTokenShopify** | **string** | Access token authorizing the app to access resources on behalf of a user | [optional] 
**ApiKey** | **string** | Neto API Key | [optional] 
**ApiUsername** | **string** | Neto User Name | [optional] 
**EncryptedPassword** | **string** | Volusion API Password | [optional] 
**Login** | **string** | It&#39;s a Volusion account for which API is enabled | [optional] 
**ApiUserAdnsf** | **string** | It&#39;s a AspDotNetStorefront account for which API is available | [optional] 
**ApiPass** | **string** | AspDotNetStorefront API Password | [optional] 
**PrivateKey** | **string** | 3DCart Application Private Key | [optional] 
**AppToken** | **string** | 3DCart Token from Application | [optional] 
**EtsyKeystring** | **string** | Etsy keystring | [optional] 
**EtsySharedSecret** | **string** | Etsy shared secret | [optional] 
**TokenSecret** | **string** | Secret token authorizing the app to access resources on behalf of a user | [optional] 
**EtsyClientId** | **string** | Etsy Client Id | [optional] 
**EtsyRefreshToken** | **string** | Etsy Refresh token | [optional] 
**EbayClientId** | **string** | Application ID (AppID). | [optional] 
**EbayClientSecret** | **string** | Shared Secret from eBay application | [optional] 
**EbayRuname** | **string** | The RuName value that eBay assigns to your application. | [optional] 
**EbayAccessToken** | **string** | Used to authenticate API requests. | [optional] 
**EbayRefreshToken** | **string** | Used to renew the access token. | [optional] 
**EbayEnvironment** | **string** | eBay environment | [optional] [default to "production"]
**EbaySiteId** | **int** | eBay global ID | [optional] [default to 0]
**DwClientId** | **string** | Demandware client id | [optional] 
**DwApiPass** | **string** | Demandware api password | [optional] 
**DemandwareUserName** | **string** | Demandware user name | [optional] 
**DemandwareUserPassword** | **string** | Demandware user password | [optional] 
**StoreId** | **string** | Store Id | 
**SellerId** | **string** | Seller Id | [optional] 
**VarEnvironment** | **string** |  | [optional] [default to "production"]
**HybrisClientId** | **string** | Omni Commerce Connector Client ID | [optional] 
**HybrisClientSecret** | **string** | Omni Commerce Connector Client Secret | [optional] 
**HybrisUsername** | **string** | User Name | [optional] 
**HybrisPassword** | **string** | User password | [optional] 
**HybrisWebsites** | [**List&lt;AccountCartAddHybrisWebsitesInner&gt;**](AccountCartAddHybrisWebsitesInner.md) | Websites to stores mapping data | [optional] 
**WalmartClientId** | **string** | Walmart client ID. For the region &#39;ca&#39; use Consumer ID | [optional] 
**WalmartClientSecret** | **string** | Walmart client secret. For the region &#39;ca&#39; use Private Key | [optional] 
**WalmartEnvironment** | **string** | Walmart environment | [optional] [default to "production"]
**WalmartChannelType** | **string** | Walmart WM_CONSUMER.CHANNEL.TYPE header | [optional] 
**WalmartRegion** | **string** | Walmart region | [optional] [default to "us"]
**LightspeedApiKey** | **string** | LightSpeed api key | [optional] 
**LightspeedApiSecret** | **string** | LightSpeed api secret | [optional] 
**ShoplazzaAccessToken** | **string** | Access token authorizing the app to access resources on behalf of a user | [optional] 
**ShoplazzaSharedSecret** | **string** | Shared secret | [optional] 
**ShopwareAccessKey** | **string** | Shopware access key | [optional] 
**ShopwareApiKey** | **string** | Shopware api key | [optional] 
**ShopwareApiSecret** | **string** | Shopware client secret access key | [optional] 
**CommercehqApiKey** | **string** | CommerceHQ api key | [optional] 
**CommercehqApiPassword** | **string** | CommerceHQ api password | [optional] 
**Var3dcartPrivateKey** | **string** | 3DCart Private Key | [optional] 
**Var3dcartAccessToken** | **string** | 3DCart Token | [optional] 
**WcConsumerKey** | **string** | Woocommerce consumer key | [optional] 
**WcConsumerSecret** | **string** | Woocommerce consumer secret | [optional] 
**MagentoConsumerKey** | **string** | Magento Consumer Key | [optional] 
**MagentoConsumerSecret** | **string** | Magento Consumer Secret | [optional] 
**MagentoAccessToken** | **string** | Magento Access Token | [optional] 
**MagentoTokenSecret** | **string** | Magento Token Secret | [optional] 
**PrestashopWebserviceKey** | **string** | Prestashop webservice key | [optional] 
**WixAppId** | **string** | Wix App ID | 
**WixAppSecretKey** | **string** | Wix App Secret Key | 
**WixInstanceId** | **string** | Wix Instance ID | [optional] 
**WixRefreshToken** | **string** | Wix refresh token | [optional] 
**MercadoLibreAppId** | **string** | Mercado Libre App ID | [optional] 
**MercadoLibreAppSecretKey** | **string** | Mercado Libre App Secret Key | [optional] 
**MercadoLibreRefreshToken** | **string** | Mercado Libre Refresh Token | [optional] 
**ZidClientId** | **int** | Zid Client ID | [optional] 
**ZidClientSecret** | **string** | Zid Client Secret | [optional] 
**ZidAccessToken** | **string** | Zid Access Token | [optional] 
**ZidAuthorization** | **string** | Zid Authorization | [optional] 
**ZidRefreshToken** | **string** | Zid refresh token | [optional] 
**FlipkartClientId** | **string** | Flipkart Client ID | [optional] 
**FlipkartClientSecret** | **string** | Flipkart Client Secret | [optional] 
**AllegroClientId** | **string** | Allegro Client ID | [optional] 
**AllegroClientSecret** | **string** | Allegro Client Secret | [optional] 
**AllegroAccessToken** | **string** | Allegro Access Token | [optional] 
**AllegroRefreshToken** | **string** | Allegro Refresh Token | [optional] 
**AllegroEnvironment** | **string** | Allegro Environment | [optional] [default to "production"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

