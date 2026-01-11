# Org.OpenAPITools.Model.ProductVariantDeleteBatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClearCache** | **bool** |  | [optional] [default to false]
**Reindex** | **bool** |  | [optional] [default to false]
**Payload** | [**List&lt;ProductVariantDeleteBatchPayloadInner&gt;**](ProductVariantDeleteBatchPayloadInner.md) | Contains an array of product variant deletion requests, each including the product ID and variant ID. The list of properties may vary depending on the specific platform. | 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

