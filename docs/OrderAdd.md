# Org.OpenAPITools.Model.OrderAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Defines order&#39;s id | [optional] 
**OrderId** | **string** | Defines the order id if it is supported by the cart | [optional] 
**StoreId** | **string** | Defines store id where the order should be assigned | [optional] 
**ChannelId** | **string** | Channel ID | [optional] 
**OrderStatus** | **string** | Defines order status. | 
**FulfillmentStatus** | **string** | Create order with fulfillment status | [optional] 
**FinancialStatus** | **string** | Create order with financial status | [optional] 
**CustomerEmail** | **string** | Defines the customer specified by email for whom order has to be created | 
**CustomerFirstName** | **string** | Specifies customer&#39;s first name | [optional] 
**CustomerLastName** | **string** | Specifies customer’s last name | [optional] 
**CustomerPhone** | **string** | Specifies customer’s phone | [optional] 
**CustomerCountry** | **string** | Specifies customer&#39;s address ISO code or name of country | [optional] 
**CustomerBirthday** | **string** | Specifies customer’s birthday | [optional] 
**CustomerFax** | **string** | Specifies customer’s fax | [optional] 
**IsGuest** | **bool** | Indicates whether the customer is a guest customer | [optional] [default to false]
**OrderPaymentMethod** | **string** | Defines order payment method.&lt;br/&gt;Setting order_payment_method on Shopify will also change financial_status field value to &#39;paid&#39; | [optional] 
**TransactionId** | **string** | Payment transaction id | [optional] 
**Currency** | **string** | Currency code of order | [optional] 
**Date** | **string** | Specifies an order creation date in format Y-m-d H:i:s | [optional] 
**DateModified** | **string** | Specifies order&#39;s  modification date | [optional] 
**DateFinished** | **string** | Specifies order&#39;s  finished date | [optional] 
**BillFirstName** | **string** | Specifies billing first name | 
**BillLastName** | **string** | Specifies billing last name | 
**BillAddress1** | **string** | Specifies first billing address | 
**BillAddress2** | **string** | Specifies second billing address | [optional] 
**BillCity** | **string** | Specifies billing city | 
**BillPostcode** | **string** | Specifies billing postcode | 
**BillState** | **string** | Specifies billing state code | 
**BillCountry** | **string** | Specifies billing country code | 
**BillCompany** | **string** | Specifies billing company | [optional] 
**BillPhone** | **string** | Specifies billing phone | [optional] 
**BillFax** | **string** | Specifies billing fax | [optional] 
**ShippFirstName** | **string** | Specifies shipping first name | [optional] 
**ShippLastName** | **string** | Specifies shipping last name | [optional] 
**ShippAddress1** | **string** | Specifies first shipping address | [optional] 
**ShippAddress2** | **string** | Specifies second address line of a shipping street address | [optional] 
**ShippCity** | **string** | Specifies shipping city | [optional] 
**ShippPostcode** | **string** | Specifies shipping postcode | [optional] 
**ShippState** | **string** | Specifies shipping state code | [optional] 
**ShippCountry** | **string** | Specifies shipping country code | [optional] 
**ShippCompany** | **string** | Specifies shipping company | [optional] 
**ShippPhone** | **string** | Specifies shipping phone | [optional] 
**ShippFax** | **string** | Specifies shipping fax | [optional] 
**SubtotalPrice** | **decimal** | Total price of all ordered products multiplied by their number, excluding tax, shipping price and discounts | [optional] 
**TaxPrice** | **decimal** | The value of tax cost for order | [optional] [default to 0M]
**TotalPrice** | **decimal** | Defines order&#39;s total price | [optional] 
**TotalPaid** | **decimal** | Defines total paid amount for the order | [optional] 
**TotalWeight** | **int** | Defines the sum of all line item weights in grams for the order | [optional] 
**PricesIncTax** | **bool** | Indicates whether prices and subtotal includes tax. | [optional] [default to false]
**ShippingPrice** | **decimal** | Specifies order&#39;s shipping price | [optional] [default to 0M]
**ShippingTax** | **decimal** | Specifies order&#39;s shipping price tax | [optional] 
**Discount** | **decimal** | Specifies order&#39;s discount | [optional] 
**CouponDiscount** | **decimal** | Specifies order&#39;s coupon discount | [optional] 
**GiftCertificateDiscount** | **decimal** | Discounts for order with gift certificates | [optional] 
**OrderShippingMethod** | **string** | Defines order shipping method | [optional] 
**CarrierId** | **string** | Defines tracking carrier id | [optional] 
**WarehouseId** | **string** | This parameter is used for selecting a warehouse where you need to set/modify a product quantity. | [optional] 
**Coupons** | **List&lt;string&gt;** | Coupons that will be applied to order | [optional] 
**Tags** | **string** | Order tags | [optional] 
**Comment** | **string** | Specifies order comment | [optional] 
**AdminComment** | **string** | Specifies admin&#39;s order comment | [optional] 
**AdminPrivateComment** | **string** | Specifies private admin&#39;s order comment | [optional] 
**SendNotifications** | **bool** | Send notifications to customer after order was created | [optional] [default to false]
**SendAdminNotifications** | **bool** | Notify admin when new order was created. | [optional] [default to false]
**ExternalSource** | **string** | Identifying the system used to generate the order | [optional] 
**InventoryBehaviour** | **string** | The behaviour to use when updating inventory.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;Values description:&lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;&lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;&lt;b&gt;bypass&lt;/b&gt; &#x3D; Do not claim inventory &lt;/br&gt;&lt;/br&gt;&lt;b&gt;decrement_ignoring_policy&lt;/b&gt; &#x3D; Ignore the product&#39;s &lt;/br&gt; inventory policy and claim amounts&lt;/br&gt;&lt;/br&gt;&lt;b&gt;decrement_obeying_policy&lt;/b&gt; &#x3D;  Obey the product&#39;s &lt;/br&gt; inventory policy.&lt;/br&gt;&lt;/br&gt;&lt;/div&gt;&lt;/div&gt;&lt;/div&gt; | [optional] [default to "bypass"]
**CreateInvoice** | **bool** | Defines whether the invoice is created automatically along with the order | [optional] [default to false]
**NoteAttributes** | [**List&lt;OrderAddNoteAttributesInner&gt;**](OrderAddNoteAttributesInner.md) | Defines note attributes | [optional] 
**ClearCache** | **bool** | Is cache clear required | [optional] [default to true]
**Origin** | **string** | The source of the order | [optional] 
**FeePrice** | **decimal** | Specifies refund&#39;s fee price | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 
**OrderItem** | [**List&lt;OrderAddOrderItemInner&gt;**](OrderAddOrderItemInner.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

