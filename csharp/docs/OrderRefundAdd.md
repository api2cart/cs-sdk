# Org.OpenAPITools.Model.OrderRefundAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Defines the order for which the refund will be created. | [optional] 
**Items** | [**List&lt;OrderRefundAddItemsInner&gt;**](OrderRefundAddItemsInner.md) | Defines items in the order that will be refunded | [optional] 
**TotalPrice** | **decimal** | Defines order refund amount. | [optional] 
**ShippingPrice** | **decimal** | Defines refund shipping amount. | [optional] 
**FeePrice** | **decimal** | Specifies refund&#39;s fee price | [optional] 
**Message** | **string** | Refund reason, or some else message which assigned to refund. | [optional] 
**ItemRestock** | **bool** | Boolean, whether or not to add the line items back to the store inventory. | [optional] [default to false]
**SendNotifications** | **bool** | Send notifications to customer after refund was created | [optional] [default to false]
**Date** | **string** | Specifies an order creation date in format Y-m-d H:i:s | [optional] 
**IsOnline** | **bool** | Indicates whether refund type is online | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

