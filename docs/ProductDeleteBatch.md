# Org.OpenAPITools.Model.ProductDeleteBatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payload** | [**List&lt;ProductDeleteBatchPayloadInner&gt;**](ProductDeleteBatchPayloadInner.md) | Contains an array of product deletion requests, each including the product ID. | 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

