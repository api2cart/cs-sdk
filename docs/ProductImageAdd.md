# Org.OpenAPITools.Model.ProductImageAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Defines image&#39;s types that are specified by comma-separated list | 
**ImageName** | **string** | Defines image&#39;s name | 
**ProductId** | **string** | Defines product id where the image should be added | [optional] 
**ProductVariantId** | **string** | Defines product&#39;s variants specified by variant id | [optional] 
**VariantIds** | **string** | Defines product&#39;s variants ids | [optional] 
**OptionValueIds** | **string** | Defines product&#39;s option values ids | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**LangId** | **string** | Add product image on specified language id | [optional] 
**Url** | **string** | Defines URL of the image that has to be added | [optional] 
**Content** | **string** | Content(body) encoded in base64 of image file | [optional] 
**Label** | **string** | Defines alternative text that has to be attached to the picture | [optional] 
**Mime** | **string** | Mime type of image http://en.wikipedia.org/wiki/Internet_media_type. | [optional] 
**Position** | **int** | Defines image’s position in the list | [optional] [default to 0]
**UseLatestApiVersion** | **bool** | Use the latest platform API version | [optional] [default to false]
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

