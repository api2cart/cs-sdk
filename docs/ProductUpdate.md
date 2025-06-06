# Org.OpenAPITools.Model.ProductUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Defines product id that has to be updated | [optional] 
**Model** | **string** | Defines product model that has to be updated | [optional] 
**Sku** | **string** | Defines new product&#39;s sku | [optional] 
**Name** | **string** | Defines product&#39;s name that has to be updated | [optional] 
**Description** | **string** | Defines new product&#39;s description | [optional] 
**ShortDescription** | **string** | Defines short description | [optional] 
**Price** | **decimal** | Defines new product&#39;s price | [optional] 
**OldPrice** | **decimal** | Defines product&#39;s old price | [optional] 
**SpecialPrice** | **decimal** | Defines new product&#39;s special price | [optional] 
**SpriceCreate** | **string** | Defines the date of special price creation | [optional] 
**SpriceExpire** | **string** | Defines the term of special price offer duration | [optional] 
**CostPrice** | **decimal** | Defines new product&#39;s cost price | [optional] 
**FixedCostShippingPrice** | **decimal** | Specifies product&#39;s fixed cost shipping price | [optional] 
**RetailPrice** | **decimal** | Defines new product&#39;s retail price | [optional] 
**TierPrices** | [**List&lt;ProductAddTierPricesInner&gt;**](ProductAddTierPricesInner.md) | Defines product&#39;s tier prices | [optional] 
**ReservePrice** | **decimal** | Defines reserve price value | [optional] 
**BuyitnowPrice** | **decimal** | Defines buy it now value | [optional] 
**Taxable** | **bool** | Specifies whether a tax is charged | [optional] [default to true]
**TaxClassId** | **string** | Defines tax classes where entity has to be added | [optional] 
**Type** | **string** | Defines product&#39;s type | [optional] 
**Status** | **string** | Defines product&#39;s status | [optional] 
**Condition** | **string** | The human-readable label for the condition (e.g., \&quot;New\&quot;). | [optional] 
**Visible** | **string** | Set visibility status | [optional] 
**InStock** | **bool** | Set stock status | [optional] 
**Avail** | **bool** | Defines category&#39;s visibility status | [optional] [default to true]
**AvailFrom** | **string** | Allows to schedule a time in the future that the item becomes available. The value should be greater than the current date and time. | [optional] 
**ProductClass** | **string** | A categorization for the product | [optional] 
**AvailableForView** | **bool** | Specifies the set of visible/invisible products for users | [optional] 
**StoresIds** | **string** | Assign product to the stores that is specified by comma-separated stores&#39; id | [optional] 
**StoreId** | **string** | Defines store id where the product should be found | [optional] 
**LangId** | **string** | Language id | [optional] 
**Quantity** | **decimal** | Defines new product&#39;s quantity | [optional] 
**ReserveQuantity** | **decimal** | This parameter allows to reserve/unreserve product quantity. | [optional] 
**ManageStock** | **bool** | Defines inventory tracking for product | [optional] 
**BackorderStatus** | **string** | Set backorder status | [optional] 
**IncreaseQuantity** | **decimal** | Defines the incremental changes in product quantity | [optional] 
**ReduceQuantity** | **decimal** | Defines the decrement changes in product quantity | [optional] 
**WarehouseId** | **string** | This parameter is used for selecting a warehouse where you need to set/modify a product quantity. | [optional] 
**Weight** | **decimal** | Weight | [optional] 
**WeightUnit** | **string** | Weight Unit | [optional] 
**Height** | **decimal** | Defines product&#39;s height | [optional] 
**Length** | **decimal** | Defines product&#39;s length | [optional] 
**Width** | **decimal** | Defines product&#39;s width | [optional] 
**DimensionsUnit** | **string** | Weight Unit | [optional] 
**IsVirtual** | **bool** | Defines whether the product is virtual | [optional] [default to false]
**IsFreeShipping** | **bool** | Specifies product free shipping flag that has to be updated | [optional] 
**Gtin** | **string** | Global Trade Item Number. An GTIN is an identifier for trade items. | [optional] 
**Upc** | **string** | Universal Product Code. A UPC (UPC-A) is a commonly used identifer for many different products. | [optional] 
**Mpn** | **string** | Manufacturer Part Number. A MPN is an identifier of a particular part design or material used. | [optional] 
**Ean** | **string** | European Article Number. An EAN is a unique 8 or 13-digit identifier that many industries (such as book publishers) use to identify products. | [optional] 
**Isbn** | **string** | International Standard Book Number. An ISBN is a unique identifier for books. | [optional] 
**Barcode** | **string** | A barcode is a unique code composed of numbers used as a product identifier. | [optional] 
**Manufacturer** | **string** | Defines product&#39;s manufacturer | [optional] 
**ManufacturerId** | **string** | Defines product&#39;s manufacturer by manufacturer_id | [optional] 
**CategoriesIds** | **string** | Defines product add that is specified by comma-separated categories id | [optional] 
**RelatedProductsIds** | **string** | Defines product related products ids that has to be updated | [optional] 
**UpSellProductsIds** | **string** | Defines product up-sell products ids that has to be updated | [optional] 
**CrossSellProductsIds** | **string** | Defines product cross-sells products ids that has to be updated | [optional] 
**MetaTitle** | **string** | Defines unique meta title for each entity | [optional] 
**MetaKeywords** | **string** | Defines unique meta keywords for each entity | [optional] 
**MetaDescription** | **string** | Defines unique meta description of a entity | [optional] 
**SeoUrl** | **string** | Defines unique URL for SEO | [optional] 
**SearchKeywords** | **string** | Defines unique search keywords | [optional] 
**Tags** | **string** | Product tags | [optional] 
**DeliveryCode** | **string** | The delivery promise that applies to offer | [optional] 
**PackageDetails** | [**ProductAddPackageDetails**](ProductAddPackageDetails.md) |  | [optional] 
**CountryOfOrigin** | **string** | The country where the inventory item was made | [optional] 
**HarmonizedSystemCode** | **string** | Harmonized System Code. An HSC is a 6-digit identifier that allows participating countries to classify traded goods on a common basis for customs purposes | [optional] 
**ShippingTemplateId** | **int** | The numeric ID of the shipping template associated with the products in Etsy. You can find possible values in the \&quot;cart.info\&quot; API method response, in the field shipping_zones[]-&gt;id. | [optional] [default to 0]
**WhenMade** | **string** | An enumerated string for the era in which the maker made the product. | [optional] [default to "made_to_order"]
**IsSupply** | **bool** | If true, it indicates the product as a supply, otherwise it indicates that it is a finished product. | [optional] [default to true]
**Downloadable** | **bool** | Defines whether the product is downloadable | [optional] [default to false]
**Materials** | **List&lt;string&gt;** | A list of material strings for materials used in the product. | [optional] 
**AutoRenew** | **bool** | When true, automatically renews a listing upon its expiration. | [optional] [default to false]
**OnSale** | **bool** | Set whether the product on sale | [optional] [default to false]
**ProductionPartnerIds** | **string** | Defines product production partner ids that has to be updated | [optional] 
**ManufacturerInfo** | [**ProductAddManufacturerInfo**](ProductAddManufacturerInfo.md) |  | [optional] 
**ReportRequestId** | **string** | Report request id | [optional] 
**DisableReportCache** | **bool** | Disable report cache for current request | [optional] [default to false]
**Reindex** | **bool** | Is reindex required | [optional] [default to true]
**ClearCache** | **bool** | Is cache clear required | [optional] [default to true]
**CheckProcessStatus** | **bool** | Disable or enable check process status. Please note that the response will be slower due to additional requests to the store. | [optional] [default to false]
**Specifics** | [**List&lt;ProductAddSpecificsInner&gt;**](ProductAddSpecificsInner.md) | An array of Item Specific Name/Value pairs used by the seller to provide descriptive details of an item in a structured manner.         The list of possible specifications can be obtained using the category.info method (additional_fields-&gt;product_specifics).         &lt;b&gt;The structure of the parameter is different for specific platforms.&lt;/b&gt; | [optional] 
**ShopSectionId** | **int** | Add Shop Section Id | [optional] 
**PersonalizationDetails** | [**ProductAddPersonalizationDetails**](ProductAddPersonalizationDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

