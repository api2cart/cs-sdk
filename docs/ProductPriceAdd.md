# Org.OpenAPITools.Model.ProductPriceAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | Defines the product to which the price has to be added | [optional] 
**GroupPrices** | [**List&lt;ProductAddGroupPricesInner&gt;**](ProductAddGroupPricesInner.md) | Defines product&#39;s group prices | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

