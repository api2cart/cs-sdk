# Org.OpenAPITools.Model.ProductTaxAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | Defines products specified by product id | [optional] 
**Name** | **string** | Defines tax class name where tax has to be added | 
**TaxRates** | [**List&lt;ProductTaxAddTaxRatesInner&gt;**](ProductTaxAddTaxRatesInner.md) | Defines tax rates of specified tax classes | 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

