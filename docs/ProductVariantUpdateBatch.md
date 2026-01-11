# Org.OpenAPITools.Model.ProductVariantUpdateBatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NestedItemsUpdateBehaviour** | **string** |  Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt; | [optional] [default to NestedItemsUpdateBehaviourEnum.Replace]
**ClearCache** | **bool** |  | [optional] [default to false]
**Reindex** | **bool** |  | [optional] [default to false]
**Payload** | [**List&lt;ProductVariantUpdateBatchPayloadInner&gt;**](ProductVariantUpdateBatchPayloadInner.md) | Contains an array of product objects. The list of properties may vary depending on the specific platform. | 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

