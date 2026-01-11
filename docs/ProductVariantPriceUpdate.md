# Org.OpenAPITools.Model.ProductVariantPriceUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Defines the variant where the price has to be updated | [optional] 
**ProductId** | **string** | Product id | [optional] 
**GroupPrices** | [**List&lt;ProductPriceUpdateGroupPricesInner&gt;**](ProductPriceUpdateGroupPricesInner.md) | Defines variants&#39;s group prices | 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

