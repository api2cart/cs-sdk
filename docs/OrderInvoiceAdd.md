# Org.OpenAPITools.Model.OrderInvoiceAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Defines the order to invoice | [optional] 
**StoreId** | **string** | Defines the store of the order. The store of the order is taken when not specified | [optional] 
**Items** | [**List&lt;OrderInvoiceAddItemsInner&gt;**](OrderInvoiceAddItemsInner.md) | Defines the items of the order to invoice and their quantities. Everything not invoiced yet is invoiced when not specified | [optional] 
**Comment** | **string** | Defines the comment of the invoice | [optional] 
**SendNotifications** | **bool** | Send the invoice to the customer by email | [optional] [default to false]
**IsOnline** | **bool** | Defines whether the invoice captures the payment online, through the payment method, when the method supports it. The payment is captured offline when false | [optional] [default to true]
**OrderStatus** | **string** | Defines the order status that creates the invoice. Only a status that creates an invoice is accepted. The status of an accepted payment is taken when not specified | [optional] 
**ShipmentId** | **string** | Defines the shipment of the order the document is for. Required when the order was shipped in several shipments | [optional] 
**Number** | **string** | Defines the number of the invoice or credit note as printed on the document | [optional] 
**DocumentType** | **string** | Defines whether the document is an invoice or a credit note for a refund or return | [optional] [default to "invoice"]
**TransactionId** | **string** | Defines the refund or return transaction the credit note is issued for. Required when document_type is credit_note | [optional] 
**TotalPrice** | **decimal** | Defines the total amount of the document, VAT included. When specified, it must match the total the store calculated for the order or shipment. For sellers with VAT Calculation Service Option 2 Amazon requires both total_price and tax_price, otherwise it rejects the feed after processing | [optional] 
**TaxPrice** | **decimal** | Defines the total VAT amount of the document. When specified, it must match the VAT the store calculated for the order or shipment. For sellers with VAT Calculation Service Option 2 Amazon requires both total_price and tax_price, otherwise it rejects the feed after processing | [optional] 
**Url** | **string** | Defines the public URL of the PDF document. Required if content is not specified | [optional] 
**Content** | **string** | Defines the PDF document encoded in base64. Required if url is not specified | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

