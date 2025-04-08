# Org.OpenAPITools.Model.Order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**OrderId** | **string** |  | [optional] 
**BasketId** | **string** |  | [optional] 
**ChannelId** | **string** |  | [optional] 
**Customer** | [**BaseCustomer**](BaseCustomer.md) |  | [optional] 
**CreateAt** | [**A2CDateTime**](A2CDateTime.md) |  | [optional] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**ShippingAddress** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**BillingAddress** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**PaymentMethod** | [**OrderPaymentMethod**](OrderPaymentMethod.md) |  | [optional] 
**ShippingMethod** | [**OrderShippingMethod**](OrderShippingMethod.md) |  | [optional] 
**ShippingMethods** | [**List&lt;OrderShippingMethod&gt;**](OrderShippingMethod.md) |  | [optional] 
**Status** | [**OrderStatus**](OrderStatus.md) |  | [optional] 
**Totals** | [**OrderTotals**](OrderTotals.md) |  | [optional] 
**Total** | [**OrderTotal**](OrderTotal.md) |  | [optional] 
**Discounts** | [**List&lt;OrderTotalsNewDiscount&gt;**](OrderTotalsNewDiscount.md) |  | [optional] 
**OrderProducts** | [**List&lt;OrderItem&gt;**](OrderItem.md) |  | [optional] 
**Bundles** | [**List&lt;OrderItem&gt;**](OrderItem.md) |  | [optional] 
**ModifiedAt** | [**A2CDateTime**](A2CDateTime.md) |  | [optional] 
**FinishedTime** | [**A2CDateTime**](A2CDateTime.md) |  | [optional] 
**Comment** | **string** |  | [optional] 
**StoreId** | **string** |  | [optional] 
**WarehousesIds** | **List&lt;string&gt;** |  | [optional] 
**Refunds** | [**List&lt;OrderRefund&gt;**](OrderRefund.md) |  | [optional] 
**GiftMessage** | **string** |  | [optional] 
**OrderDetailsUrl** | **string** |  | [optional] 
**AdditionalFields** | **Object** |  | [optional] 
**CustomFields** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

