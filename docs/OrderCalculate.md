# Org.OpenAPITools.Model.OrderCalculate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerEmail** | **string** | Defines the customer specified by email for whom the order needs to be calculated | 
**CurrencyId** | **string** | Currency Id | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**Coupons** | **List&lt;string&gt;** | Coupons that will be applied to order. If the order isn&#39;t eligible for any given discount code or there is no discount with such a code it will be skipped during calculation | [optional] 
**ShippFirstName** | **string** | Specifies shipping first name | 
**ShippLastName** | **string** | Specifies shipping last name | 
**ShippAddress1** | **string** | Specifies first shipping address | 
**ShippAddress2** | **string** | Specifies second address line of a shipping street address | [optional] 
**ShippCity** | **string** | Specifies shipping city | 
**ShippPostcode** | **string** | Specifies shipping postcode | 
**ShippState** | **string** | Specifies shipping state code | [optional] 
**ShippCountry** | **string** | Specifies shipping country code | 
**ShippCompany** | **string** | Specifies shipping company | [optional] 
**ShippPhone** | **string** | Specifies shipping phone | [optional] 
**BillFirstName** | **string** | Specifies billing first name | [optional] 
**BillLastName** | **string** | Specifies billing last name | [optional] 
**BillAddress1** | **string** | Specifies first billing address | [optional] 
**BillAddress2** | **string** | Specifies second billing address | [optional] 
**BillCity** | **string** | Specifies billing city | [optional] 
**BillPostcode** | **string** | Specifies billing postcode | [optional] 
**BillState** | **string** | Specifies billing state code | [optional] 
**BillCountry** | **string** | Specifies billing country code | [optional] 
**BillCompany** | **string** | Specifies billing company | [optional] 
**BillPhone** | **string** | Specifies billing phone | [optional] 
**ResponseFields** | **string** | Set this parameter in order to choose which entity fields you want to retrieve | [optional] 
**OrderItem** | [**List&lt;OrderCalculateOrderItemInner&gt;**](OrderCalculateOrderItemInner.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

