# Org.OpenAPITools.Model.CustomerAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Defines customer&#39;s email | 
**FirstName** | **string** | Defines customer&#39;s first name | [optional] 
**LastName** | **string** | Defines customer&#39;s last name | [optional] 
**Password** | **string** | Defines customer&#39;s unique password | [optional] 
**Group** | **string** | Defines the group where the customer | [optional] 
**GroupId** | **string** | Customer group_id | [optional] 
**GroupIds** | **string** | Groups that will be assigned to a customer | [optional] 
**Status** | **string** | Defines customer&#39;s status | [optional] [default to "enabled"]
**CreatedTime** | **string** | Entity&#39;s date creation | [optional] 
**ModifiedTime** | **string** | Entity&#39;s date modification | [optional] 
**Login** | **string** | Specifies customer&#39;s login name | [optional] 
**LastLogin** | **string** | Defines customer&#39;s last login time | [optional] 
**BirthDay** | **string** | Defines customer&#39;s birthday | [optional] 
**NewsLetterSubscription** | **bool** | Defines whether the newsletter subscription is available for the user | [optional] 
**Consents** | [**List&lt;CustomerAddConsentsInner&gt;**](CustomerAddConsentsInner.md) | Defines consents to notifications | [optional] 
**Gender** | **string** | Defines customer&#39;s gender | [optional] 
**Website** | **string** | Link to customer website | [optional] 
**Fax** | **string** | Defines customer&#39;s fax | [optional] 
**Company** | **string** | Defines customer&#39;s company | [optional] 
**Phone** | **string** | Defines customer&#39;s phone number | [optional] 
**Note** | **string** | The customer note. | [optional] 
**Country** | **string** | Specifies ISO code or name of country | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**Address** | [**List&lt;CustomerAddAddressInner&gt;**](CustomerAddAddressInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

