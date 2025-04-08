# Org.OpenAPITools.Model.ProductVariantUpdateBatchPayloadInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**ProductId** | **string** |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ShortDescription** | **string** |  | [optional] 
**Sku** | **string** |  | [optional] 
**Upc** | **string** |  | [optional] 
**Mpn** | **string** |  | [optional] 
**Gtin** | **string** |  | [optional] 
**Isbn** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**Price** | **decimal** |  | [optional] 
**SpecialPrice** | **decimal** |  | [optional] 
**CostPrice** | **decimal** |  | [optional] 
**RetailPrice** | **decimal** |  | [optional] 
**AdvancedPrices** | [**List&lt;ProductUpdateBatchPayloadInnerAdvancedPricesInner&gt;**](ProductUpdateBatchPayloadInnerAdvancedPricesInner.md) | If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;. | [optional] 
**Quantity** | **decimal** |  | [optional] 
**ReserveQuantity** | **decimal** |  | [optional] 
**IncreaseQuantity** | **decimal** |  | [optional] 
**ReduceQuantity** | **decimal** |  | [optional] 
**WarehouseId** | **string** |  | [optional] 
**ManufacturerId** | **string** |  | [optional] 
**Weight** | **decimal** |  | [optional] 
**Height** | **decimal** |  | [optional] 
**Length** | **decimal** |  | [optional] 
**Width** | **decimal** |  | [optional] 
**StoreId** | **string** |  | [optional] 
**LangId** | **string** |  | [optional] 
**TaxClassId** | **string** |  | [optional] 
**BackorderStatus** | **string** |  | [optional] 
**Visible** | **string** |  | [optional] 
**IsDefault** | **bool** |  | [optional] 
**InStock** | **bool** |  | [optional] 
**IsVirtual** | **bool** |  | [optional] 
**Downloadable** | **bool** |  | [optional] 
**ManageStock** | **bool** |  | [optional] 
**IsFreeShipping** | **bool** |  | [optional] 
**SeoUrl** | **string** |  | [optional] 
**MetaTitle** | **string** |  | [optional] 
**MetaDescription** | **string** |  | [optional] 
**MetaKeywords** | **List&lt;string&gt;** |  | [optional] 
**CategoriesIds** | **List&lt;string&gt;** | If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;. | [optional] 
**StoresIds** | **List&lt;string&gt;** |  | [optional] 
**Images** | [**List&lt;ProductAddBatchPayloadInnerImagesInner&gt;**](ProductAddBatchPayloadInnerImagesInner.md) | The passed items will completely replace the original items | [optional] 
**ProductImagesIds** | **List&lt;string&gt;** |  | [optional] 
**RelatedProductsIds** | **List&lt;string&gt;** | If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;. | [optional] 
**UpSellProductsIds** | **List&lt;string&gt;** | If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;. | [optional] 
**CrossSellProductsIds** | **List&lt;string&gt;** | If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

