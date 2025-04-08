# Org.OpenAPITools.Model.OrderReturnUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnId** | **string** | Return ID | 
**OrderId** | **string** | Defines the order id | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**ItemRestock** | **bool** | Boolean, whether or not to add the line items back to the store inventory. | [optional] [default to false]
**ReturnStatusId** | **string** | Defines return request status | [optional] 
**StaffNote** | **string** | Specifies staff note | [optional] 
**Comment** | **string** | Specifies return comment | [optional] 
**SendNotifications** | **bool** | Send notifications to customer after order was created | [optional] [default to false]
**RejectReason** | **string** | Defines return reject reason | [optional] 
**OrderProducts** | [**List&lt;OrderReturnUpdateOrderProductsInner&gt;**](OrderReturnUpdateOrderProductsInner.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

