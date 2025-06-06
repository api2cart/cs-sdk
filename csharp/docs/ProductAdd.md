# Org.OpenAPITools.Model.ProductAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Defines product&#39;s name that has to be added | 
**Model** | **string** | Defines product&#39;s model that has to be added | 
**Sku** | **string** | Defines product&#39;s sku that has to be added | [optional] 
**Description** | **string** | Defines product&#39;s description that has to be added | 
**Price** | **decimal** | Defines product&#39;s price that has to be added | 
**OldPrice** | **decimal** | Defines product&#39;s old price | [optional] 
**SpecialPrice** | **decimal** | Defines product&#39;s model that has to be added | [optional] 
**CostPrice** | **decimal** | Defines new product&#39;s cost price | [optional] 
**FixedCostShippingPrice** | **decimal** | Specifies product&#39;s fixed cost shipping price | [optional] 
**SpriceCreate** | **string** | Defines the date of special price creation | [optional] 
**SpriceModified** | **string** | Defines the date of special price modification | [optional] 
**SpriceExpire** | **string** | Defines the term of special price offer duration | [optional] 
**TierPrices** | [**List&lt;ProductAddTierPricesInner&gt;**](ProductAddTierPricesInner.md) | Defines product&#39;s tier prices | [optional] 
**GroupPrices** | [**List&lt;ProductAddGroupPricesInner&gt;**](ProductAddGroupPricesInner.md) | Defines product&#39;s group prices | [optional] 
**AvailableForView** | **bool** | Specifies the set of visible/invisible products for users | [optional] [default to true]
**AvailableForSale** | **bool** | Specifies the set of visible/invisible products for sale | [optional] [default to true]
**Weight** | **decimal** | Weight | [optional] [default to 0M]
**Width** | **decimal** | Defines product&#39;s width | [optional] 
**Height** | **decimal** | Defines product&#39;s height | [optional] 
**Length** | **decimal** | Defines product&#39;s length | [optional] 
**WeightUnit** | **string** | Weight Unit | [optional] 
**DimensionsUnit** | **string** | Weight Unit | [optional] 
**ShortDescription** | **string** | Defines short description | [optional] 
**WarehouseId** | **string** | This parameter is used for selecting a warehouse where you need to set/modify a product quantity. | [optional] 
**BackorderStatus** | **string** | Set backorder status | [optional] 
**Quantity** | **decimal** | Defines product&#39;s quantity that has to be added | [optional] [default to 0M]
**Downloadable** | **bool** | Defines whether the product is downloadable | [optional] [default to false]
**WholesalePrice** | **decimal** | Defines product&#39;s sale price | [optional] 
**CreatedAt** | **string** | Defines the date of entity creation | [optional] 
**Manufacturer** | **string** | Defines product&#39;s manufacturer | [optional] 
**ManufacturerId** | **string** | Defines product&#39;s manufacturer by manufacturer_id | [optional] 
**CategoriesIds** | **string** | Defines product add that is specified by comma-separated categories id | [optional] 
**RelatedProductsIds** | **string** | Defines product&#39;s related products ids that has to be added | [optional] 
**UpSellProductsIds** | **string** | Defines product&#39;s up-sell products ids that has to be added | [optional] 
**CrossSellProductsIds** | **string** | Defines product&#39;s cross-sell products ids that has to be added | [optional] 
**TaxClassId** | **string** | Defines tax classes where entity has to be added | [optional] 
**Type** | **string** | Defines product&#39;s type | [optional] [default to "simple"]
**MetaTitle** | **string** | Defines unique meta title for each entity | [optional] 
**MetaKeywords** | **string** | Defines unique meta keywords for each entity | [optional] 
**MetaDescription** | **string** | Defines unique meta description of a entity | [optional] 
**Url** | **string** | Defines unique product&#39;s URL | [optional] 
**LangId** | **string** | Language id | [optional] 
**StoresIds** | **string** | Assign product to the stores that is specified by comma-separated stores&#39; id | [optional] 
**CategoryId** | **string** | Defines product add that is specified by category id | [optional] 
**ViewedCount** | **int** | Specifies the number of product&#39;s reviews | [optional] [default to 0]
**OrderedCount** | **int** | Defines how many times the product was ordered | [optional] [default to 0]
**AttributeSetName** | **string** | Defines product’s attribute set name in Magento | [optional] [default to "Default"]
**AttributeName** | **string** | Defines product’s attribute name separated with a comma in Magento | [optional] 
**ShippingTemplateId** | **int** | The numeric ID of the shipping template associated with the products in Etsy. You can find possible values in the \&quot;cart.info\&quot; API method response, in the field shipping_zones[]-&gt;id. | [optional] [default to 0]
**ProductionPartnerIds** | **string** | Defines product&#39;s production partner ids that has to be added | [optional] 
**Condition** | **string** | The human-readable label for the condition (e.g., \&quot;New\&quot;). | [optional] 
**ListingDuration** | **string** | Describes the number of days the seller wants the listing to be active. Look at cart.info method response for allowed values. | [optional] 
**ListingType** | **string** | Indicates the selling format of the marketplace listing. | [optional] [default to "FixedPrice"]
**PaymentMethods** | **List&lt;string&gt;** | Identifies the payment method (such as PayPal) that the seller will accept when the buyer pays for the item. Look at cart.info method response for allowed values.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;Param structure:&lt;div style&#x3D;\&quot;margin-left: 2%;\&quot;&gt;&lt;code style&#x3D;\&quot;padding:0; background-color:#ffffff;font-size:85%;font-family:monospace;\&quot;&gt;payment_methods[0] &#x3D; string&lt;/br&gt;payment_methods[1] &#x3D; string&lt;/br&gt;&lt;/code&gt;&lt;/div&gt;&lt;/div&gt; | [optional] 
**ReturnAccepted** | **bool** | Indicates whether the seller allows the buyer to return the item. | [optional] 
**ShippingDetails** | [**List&lt;ProductAddShippingDetailsInner&gt;**](ProductAddShippingDetailsInner.md) | The shipping details, including flat and calculated shipping costs and shipping insurance costs. Look at cart.info method response for allowed values.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;Param structure:&lt;div style&#x3D;\&quot;margin-left: 2%;\&quot;&gt;&lt;code style&#x3D;\&quot;padding:0; background-color:#ffffff;font-size:85%;font-family:monospace;\&quot;&gt;shipping_details[0][&lt;b&gt;shipping_type&lt;/b&gt;] &#x3D; string &lt;/br&gt;shipping_details[0][&lt;b&gt;shipping_service&lt;/b&gt;] &#x3D; string&lt;/br&gt;shipping_details[0][&lt;b&gt;shipping_cost&lt;/b&gt;] &#x3D; decimal&lt;/br&gt;shipping_details[1][&lt;b&gt;shipping_type&lt;/b&gt;] &#x3D; string &lt;/br&gt;shipping_details[1][&lt;b&gt;shipping_service&lt;/b&gt;] &#x3D; string&lt;/br&gt;shipping_details[1][&lt;b&gt;shipping_cost&lt;/b&gt;] &#x3D; decimal&lt;/br&gt;&lt;/code&gt;&lt;/div&gt;&lt;/div&gt; | [optional] 
**PaypalEmail** | **string** | Valid PayPal email address for the PayPal account that the seller will use if they offer PayPal as a payment method for the listing. | [optional] 
**SellerProfiles** | [**ProductAddSellerProfiles**](ProductAddSellerProfiles.md) |  | [optional] 
**PackageDetails** | [**ProductAddPackageDetails**](ProductAddPackageDetails.md) |  | [optional] 
**BestOffer** | [**ProductAddBestOffer**](ProductAddBestOffer.md) |  | [optional] 
**SalesTax** | [**ProductAddSalesTax**](ProductAddSalesTax.md) |  | [optional] 
**Barcode** | **string** | A barcode is a unique code composed of numbers used as a product identifier. | [optional] 
**Upc** | **string** | Universal Product Code. A UPC (UPC-A) is a commonly used identifer for many different products. | [optional] 
**Ean** | **string** | European Article Number. An EAN is a unique 8 or 13-digit identifier that many industries (such as book publishers) use to identify products. | [optional] 
**Isbn** | **string** | International Standard Book Number. An ISBN is a unique identifier for books. | [optional] 
**Specifics** | [**List&lt;ProductAddSpecificsInner&gt;**](ProductAddSpecificsInner.md) | An array of Item Specific Name/Value pairs used by the seller to provide descriptive details of an item in a structured manner.         The list of possible specifications can be obtained using the category.info method (additional_fields-&gt;product_specifics).         &lt;b&gt;The structure of the parameter is different for specific platforms.&lt;/b&gt; | [optional] 
**ImageUrl** | **string** | Image Url | [optional] 
**ImageName** | **string** | Defines image&#39;s name | [optional] 
**ReservePrice** | **decimal** | Defines reserve price value | [optional] 
**BuyitnowPrice** | **decimal** | Defines buy it now value | [optional] 
**ConditionDescription** | **string** | Detailed description of the product condition. | [optional] 
**AuctionConfidentialityLevel** | **string** | This allows buyers to remain anonymous when the bid or buy an item. | [optional] 
**AvailFrom** | **string** | Allows to schedule a time in the future that the item becomes available. The value should be greater than the current date and time. | [optional] 
**Tags** | **string** | Product tags | [optional] 
**ClearCache** | **bool** | Is cache clear required | [optional] [default to true]
**Asin** | **string** | Amazon Standard Identification Number. | [optional] 
**Gtin** | **string** | Global Trade Item Number. An GTIN is an identifier for trade items. | [optional] 
**Mpn** | **string** | Manufacturer Part Number. A MPN is an identifier of a particular part design or material used. | [optional] 
**Taxable** | **bool** | Specifies whether a tax is charged | [optional] [default to true]
**Visible** | **string** | Set visibility status | [optional] 
**Status** | **string** | Defines product&#39;s status | [optional] 
**SeoUrl** | **string** | Defines unique URL for SEO | [optional] 
**ProductClass** | **string** | A categorization for the product | [optional] 
**ProductType** | **string** | A categorization for the product | [optional] 
**MarketplaceItemProperties** | **string** | String containing the JSON representation of the supplied data | [optional] 
**ManageStock** | **bool** | Defines inventory tracking for product | [optional] 
**HarmonizedSystemCode** | **string** | Harmonized System Code. An HSC is a 6-digit identifier that allows participating countries to classify traded goods on a common basis for customs purposes | [optional] 
**CountryOfOrigin** | **string** | The country where the inventory item was made | [optional] 
**Files** | [**List&lt;ProductAddFilesInner&gt;**](ProductAddFilesInner.md) | File Url | [optional] 
**SearchKeywords** | **string** | Defines unique search keywords | [optional] 
**StoreId** | **string** | Store Id | [optional] 
**BrandName** | **string** | Defines product brand name | [optional] 
**IsVirtual** | **bool** | Defines whether the product is virtual | [optional] [default to false]
**IsFreeShipping** | **bool** | Specifies product&#39;s free shipping flag that has to be added | [optional] 
**InStock** | **bool** | Set stock status | [optional] 
**DeliveryCode** | **string** | The delivery promise that applies to offer | [optional] 
**ProductReference** | **string** | Groups all variations, that you want to combine into one product. | [optional] 
**DeliveryType** | **string** | Defines the type of the delivery. | [optional] 
**DeliveryTime** | **int** | Defines delivery time in days. | [optional] 
**SizeChart** | [**ProductAddSizeChart**](ProductAddSizeChart.md) |  | [optional] 
**Certifications** | [**List&lt;ProductAddCertificationsInner&gt;**](ProductAddCertificationsInner.md) | An array of product certifications. The list of possible certifications can be obtained using the \&quot;&lt;i&gt;category.info&lt;/i&gt;\&quot; method (&lt;i&gt;additional_fields-&gt;rules-&gt;product_certifications&lt;/i&gt;). | [optional] 
**DeliveryOptionIds** | **string** | Defines delivery options for product by ids. | [optional] 
**ManufacturerInfo** | [**ProductAddManufacturerInfo**](ProductAddManufacturerInfo.md) |  | [optional] 
**WhenMade** | **string** | An enumerated string for the era in which the maker made the product. | [optional] [default to "made_to_order"]
**IsSupply** | **bool** | If true, it indicates the product as a supply, otherwise it indicates that it is a finished product. | [optional] [default to true]
**Materials** | **List&lt;string&gt;** | A list of material strings for materials used in the product. | [optional] 
**AutoRenew** | **bool** | When true, automatically renews a listing upon its expiration. | [optional] [default to false]
**AllowDisplayCondition** | **bool** | Flag used to determine whether the product condition is shown to the customer on the product page. | [optional] 
**MinOrderQuantity** | **decimal** | The minimum quantity an order must contain, to be eligible to purchase this product. | [optional] 
**MaxOrderQuantity** | **decimal** | The maximum quantity an order can contain when purchasing the product. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

