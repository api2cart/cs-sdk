# Org.OpenAPITools.Model.OrderPreestimateShippingList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **string** | Store Id | [optional] 
**WarehouseId** | **string** | This parameter is used for selecting a warehouse where you need to set/modify a product quantity. | [optional] 
**CustomerEmail** | **string** | Retrieves orders specified by customer email | [optional] 
**CustomerId** | **string** | Retrieves orders specified by customer id | [optional] 
**ShippAddress1** | **string** | Specifies first shipping address | [optional] 
**ShippCity** | **string** | Specifies shipping city | [optional] 
**ShippPostcode** | **string** | Specifies shipping postcode | [optional] 
**ShippState** | **string** | Specifies shipping state code | [optional] 
**ShippCountry** | **string** | Specifies shipping country code | 
**Params** | **string** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] [default to "force_all"]
**Exclude** | **string** | Set this parameter in order to choose which entity fields you want to ignore. Works only if parameter &#x60;params&#x60; equal force_all | [optional] 
**OrderItem** | [**List&lt;OrderPreestimateShippingListOrderItemInner&gt;**](OrderPreestimateShippingListOrderItemInner.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

