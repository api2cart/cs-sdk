# Org.OpenAPITools.Model.CustomerUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Entity id | [optional] 
**GroupId** | **string** | Customer group_id | [optional] 
**GroupIds** | **string** | Groups that will be assigned to a customer | [optional] 
**Group** | **string** | Defines the group where the customer | [optional] 
**Email** | **string** | Defines customer&#39;s email | [optional] 
**Phone** | **string** | Defines customer&#39;s phone number | [optional] 
**FirstName** | **string** | Defines customer&#39;s first name | [optional] 
**LastName** | **string** | Defines customer&#39;s last name | [optional] 
**BirthDay** | **string** | Defines customer&#39;s birthday | [optional] 
**NewsLetterSubscription** | **bool** | Defines whether the newsletter subscription is available for the user | [optional] 
**Consents** | [**List&lt;CustomerAddConsentsInner&gt;**](CustomerAddConsentsInner.md) | Defines consents to notifications | [optional] 
**Tags** | **string** | Customer tags | [optional] 
**Gender** | **string** | Defines customer&#39;s gender | [optional] 
**Note** | **string** | The customer note. | [optional] 
**Status** | **string** | Defines customer&#39;s status | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**IdempotencyKey** | **string** | A unique identifier associated with a specific request. Repeated requests with the same &lt;strong&gt;idempotency_key&lt;/strong&gt; return a cached response without re-executing the business logic. &lt;strong&gt;Please note that the cache lifetime is 15 minutes.&lt;/strong&gt; | [optional] 
**Address** | [**List&lt;CustomerUpdateAddressInner&gt;**](CustomerUpdateAddressInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

