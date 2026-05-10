# Org.OpenAPITools.Model.OrderShipmentEventAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentId** | **string** | Defines the shipment to which the tracking event will be added | 
**OrderId** | **string** | Defines the order to which the shipment belongs | [optional] 
**Status** | **string** | Defines the tracking event status (e.g. in_transit, delivered, out_for_delivery) | 
**StoreId** | **string** | Store Id | [optional] 
**Address1** | **string** | Specifies the street address of the event location | [optional] 
**City** | **string** | Specifies city | [optional] 
**Country** | **string** | Specifies ISO code or name of country | [optional] 
**State** | **string** | Specifies ISO code or name of state | [optional] 
**Postcode** | **string** | Specifies postcode | [optional] 
**Message** | **string** | Defines a message associated with the tracking event. | [optional] 
**Latitude** | **decimal** | Latitude coordinate of the event location. | [optional] 
**Longitude** | **decimal** | Longitude coordinate of the event location. | [optional] 
**CreatedAt** | **string** | Defines the date of entity creation | [optional] 
**EstimatedDeliveryAt** | **string** | Estimated delivery date and time in ISO 8601 format. | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

