# Org.OpenAPITools.Model.OrderAddOrderItemInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderItemId** | **string** | Defines orders specified by order item id | 
**OrderItemName** | **string** | Defines orders specified by order item name | 
**OrderItemModel** | **string** | Defines orders specified by order item model | [optional] 
**OrderItemPrice** | **decimal** | Defines orders specified by order item price | 
**OrderItemQuantity** | **int** | Defines orders specified by order item quantity | 
**OrderItemWeight** | **decimal** | Defines orders specified by order item weight | [optional] 
**OrderItemVariantId** | **string** | Ordered product variant. Where x is order item ID | [optional] 
**OrderItemTax** | **decimal** | Percentage of tax for product order | [optional] [default to 0M]
**OrderItemParent** | **int** | Index of the parent grouped/bundle product | [optional] 
**OrderItemParentOptionName** | **string** | Option name of the parent grouped/bundle product | [optional] 
**OrderItemAllowRefundItemsSeparately** | **bool** | Indicates whether subitems of the grouped/bundle product can be refunded separately | [optional] 
**OrderItemAllowShipItemsSeparately** | **bool** | Indicates whether subitems of the grouped/bundle product can be shipped separately | [optional] 
**OrderItemPriceIncludesTax** | **bool** | Defines if item price includes tax | [optional] [default to false]
**OrderItemOption** | [**List&lt;OrderAddOrderItemInnerOrderItemOptionInner&gt;**](OrderAddOrderItemInnerOrderItemOptionInner.md) |  | [optional] 
**OrderItemProperty** | [**List&lt;OrderAddOrderItemInnerOrderItemPropertyInner&gt;**](OrderAddOrderItemInnerOrderItemPropertyInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

