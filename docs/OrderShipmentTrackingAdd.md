# Org.OpenAPITools.Model.OrderShipmentTrackingAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Defines the order id | [optional] 
**ShipmentId** | **string** | Shipment id indicates the number of delivery | 
**CarrierId** | **string** | Defines tracking carrier id | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**TrackingProvider** | **string** | Defines name of the company which provides shipment tracking | [optional] 
**TrackingNumber** | **string** | Defines tracking number | 
**TrackingLink** | **string** | Defines custom tracking link | [optional] 
**SendNotifications** | **bool** | Send notifications to customer after tracking was created | [optional] [default to false]
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

