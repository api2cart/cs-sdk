# Org.OpenAPITools.Model.CartCouponAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Coupon code | 
**ActionType** | **string** | Coupon discount type | 
**ActionApplyTo** | **string** | Defines where discount should be applied | 
**ActionScope** | **string** | Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once. | 
**ActionAmount** | **decimal** | Defines the discount amount value. | 
**Codes** | **List&lt;string&gt;** | Entity codes | [optional] 
**Name** | **string** | Coupon name | [optional] 
**DateStart** | **string** | Date start | [optional] [default to "now"]
**DateEnd** | **string** | Defines when discount code will be expired. | [optional] 
**UsageLimit** | **int** | Usage limit for coupon. | [optional] 
**UsageLimitPerCustomer** | **int** | Usage limit per customer. | [optional] 
**ActionConditionEntity** | **string** | Defines entity for action condition. | [optional] 
**ActionConditionKey** | **string** | Defines entity attribute code for action condition. | [optional] 
**ActionConditionOperator** | **string** | Defines condition operator. | [optional] 
**ActionConditionValue** | **string** | Defines condition attribute value/s. Can be comma separated string. | [optional] 
**IncludeTax** | **bool** | Indicates whether to apply a discount for taxes. | [optional] [default to false]
**StoreId** | **string** | Store Id | [optional] 
**FreeCashOnDelivery** | **bool** | Defines whether the coupon provides free cash on delivery | [optional] 
**CustomerId** | **string** | Retrieves orders specified by customer id | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

