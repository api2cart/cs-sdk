# Org.OpenAPITools.Model.ProductOptionAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Defines option&#39;s name | 
**Type** | **string** | Defines option&#39;s type that has to be added | 
**ProductId** | **string** | Defines product id where the option should be added | [optional] 
**DefaultOptionValue** | **string** | Defines default option value that has to be added | [optional] 
**OptionValues** | **string** | Defines option values that has to be added | [optional] 
**Description** | **string** | Defines option&#39;s description | [optional] 
**Avail** | **bool** | Defines whether the option is available | [optional] [default to true]
**SortOrder** | **int** | Sort number in the list | [optional] [default to 0]
**Required** | **bool** | Defines if the option is required | [optional] [default to false]
**Values** | [**List&lt;ProductOptionAddValuesInner&gt;**](ProductOptionAddValuesInner.md) | An array of option values.&lt;/b&gt; | [optional] 
**ClearCache** | **bool** | Is cache clear required | [optional] [default to true]
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

