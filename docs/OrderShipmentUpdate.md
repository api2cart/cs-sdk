# Org.OpenAPITools.Model.OrderShipmentUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentId** | **string** | Shipment id indicates the number of delivery | 
**OrderId** | **string** | Defines the order that will be updated | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**ShipmentProvider** | **string** | Defines company name that provide tracking of shipment | [optional] 
**TrackingNumbers** | [**List&lt;OrderShipmentAddTrackingNumbersInner&gt;**](OrderShipmentAddTrackingNumbersInner.md) | Defines shipment&#39;s tracking numbers that have to be added&lt;/br&gt; How set tracking numbers to appropriate carrier:&lt;ul&gt;&lt;li&gt;tracking_numbers[]&#x3D;a2c.demo1,a2c.demo2 - set default carrier&lt;/li&gt;&lt;li&gt;tracking_numbers[&lt;b&gt;carrier_id&lt;/b&gt;]&#x3D;a2c.demo - set appropriate carrier&lt;/li&gt;&lt;/ul&gt;To get the list of carriers IDs that are available in your store, use the &lt;a href &#x3D; \&quot;https://api2cart.com/docs/#/cart/CartInfo\&quot;&gt;cart.info&lt;/a &gt; method | [optional] 
**TrackingLink** | **string** | Defines custom tracking link | [optional] 
**IsShipped** | **bool** | Defines shipment&#39;s status | [optional] [default to true]
**DeliveredAt** | **string** | Defines the date of delivery | [optional] 
**Replace** | **bool** | Allows rewrite tracking numbers | [optional] [default to true]
**SendNotifications** | **bool** | Send notifications to customer after order was created | [optional] [default to false]
**TrackingProvider** | **string** | Defines name of the company which provides shipment tracking | [optional] 
**Items** | [**List&lt;OrderShipmentAddItemsInner&gt;**](OrderShipmentAddItemsInner.md) | Defines items in the order that will be shipped | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

