/*
 * API2Cart OpenAPI
 *
 * API2Cart
 *
 * The version of the OpenAPI document: 1.1
 * Contact: contact@api2cart.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ProductVariantUpdateBatchPayloadInner
    /// </summary>
    [DataContract(Name = "ProductVariantUpdateBatch_payload_inner")]
    public partial class ProductVariantUpdateBatchPayloadInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantUpdateBatchPayloadInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductVariantUpdateBatchPayloadInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantUpdateBatchPayloadInner" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="productId">productId (required).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="sku">sku.</param>
        /// <param name="upc">upc.</param>
        /// <param name="mpn">mpn.</param>
        /// <param name="gtin">gtin.</param>
        /// <param name="isbn">isbn.</param>
        /// <param name="status">status.</param>
        /// <param name="price">price.</param>
        /// <param name="specialPrice">specialPrice.</param>
        /// <param name="costPrice">costPrice.</param>
        /// <param name="retailPrice">retailPrice.</param>
        /// <param name="advancedPrices">If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;..</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="reserveQuantity">reserveQuantity.</param>
        /// <param name="increaseQuantity">increaseQuantity.</param>
        /// <param name="reduceQuantity">reduceQuantity.</param>
        /// <param name="warehouseId">warehouseId.</param>
        /// <param name="manufacturerId">manufacturerId.</param>
        /// <param name="weight">weight.</param>
        /// <param name="height">height.</param>
        /// <param name="length">length.</param>
        /// <param name="width">width.</param>
        /// <param name="storeId">storeId.</param>
        /// <param name="langId">langId.</param>
        /// <param name="taxClassId">taxClassId.</param>
        /// <param name="backorderStatus">backorderStatus.</param>
        /// <param name="visible">visible.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="inStock">inStock.</param>
        /// <param name="isVirtual">isVirtual.</param>
        /// <param name="downloadable">downloadable.</param>
        /// <param name="manageStock">manageStock.</param>
        /// <param name="isFreeShipping">isFreeShipping.</param>
        /// <param name="seoUrl">seoUrl.</param>
        /// <param name="metaTitle">metaTitle.</param>
        /// <param name="metaDescription">metaDescription.</param>
        /// <param name="metaKeywords">metaKeywords.</param>
        /// <param name="categoriesIds">If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;..</param>
        /// <param name="storesIds">storesIds.</param>
        /// <param name="images">The passed items will completely replace the original items.</param>
        /// <param name="productImagesIds">productImagesIds.</param>
        /// <param name="relatedProductsIds">If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;..</param>
        /// <param name="upSellProductsIds">If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;..</param>
        /// <param name="crossSellProductsIds">If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;..</param>
        public ProductVariantUpdateBatchPayloadInner(string id = default(string), string productId = default(string), string name = default(string), string description = default(string), string shortDescription = default(string), string sku = default(string), string upc = default(string), string mpn = default(string), string gtin = default(string), string isbn = default(string), string status = default(string), decimal price = default(decimal), decimal specialPrice = default(decimal), decimal costPrice = default(decimal), decimal retailPrice = default(decimal), List<ProductUpdateBatchPayloadInnerAdvancedPricesInner> advancedPrices = default(List<ProductUpdateBatchPayloadInnerAdvancedPricesInner>), decimal quantity = default(decimal), decimal reserveQuantity = default(decimal), decimal increaseQuantity = default(decimal), decimal reduceQuantity = default(decimal), string warehouseId = default(string), string manufacturerId = default(string), decimal weight = default(decimal), decimal height = default(decimal), decimal length = default(decimal), decimal width = default(decimal), string storeId = default(string), string langId = default(string), string taxClassId = default(string), string backorderStatus = default(string), string visible = default(string), bool isDefault = default(bool), bool inStock = default(bool), bool isVirtual = default(bool), bool downloadable = default(bool), bool manageStock = default(bool), bool isFreeShipping = default(bool), string seoUrl = default(string), string metaTitle = default(string), string metaDescription = default(string), List<string> metaKeywords = default(List<string>), List<string> categoriesIds = default(List<string>), List<string> storesIds = default(List<string>), List<ProductAddBatchPayloadInnerImagesInner> images = default(List<ProductAddBatchPayloadInnerImagesInner>), List<string> productImagesIds = default(List<string>), List<string> relatedProductsIds = default(List<string>), List<string> upSellProductsIds = default(List<string>), List<string> crossSellProductsIds = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ProductVariantUpdateBatchPayloadInner and cannot be null");
            }
            this.Id = id;
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new ArgumentNullException("productId is a required property for ProductVariantUpdateBatchPayloadInner and cannot be null");
            }
            this.ProductId = productId;
            this.Name = name;
            this.Description = description;
            this.ShortDescription = shortDescription;
            this.Sku = sku;
            this.Upc = upc;
            this.Mpn = mpn;
            this.Gtin = gtin;
            this.Isbn = isbn;
            this.Status = status;
            this.Price = price;
            this.SpecialPrice = specialPrice;
            this.CostPrice = costPrice;
            this.RetailPrice = retailPrice;
            this.AdvancedPrices = advancedPrices;
            this.Quantity = quantity;
            this.ReserveQuantity = reserveQuantity;
            this.IncreaseQuantity = increaseQuantity;
            this.ReduceQuantity = reduceQuantity;
            this.WarehouseId = warehouseId;
            this.ManufacturerId = manufacturerId;
            this.Weight = weight;
            this.Height = height;
            this.Length = length;
            this.Width = width;
            this.StoreId = storeId;
            this.LangId = langId;
            this.TaxClassId = taxClassId;
            this.BackorderStatus = backorderStatus;
            this.Visible = visible;
            this.IsDefault = isDefault;
            this.InStock = inStock;
            this.IsVirtual = isVirtual;
            this.Downloadable = downloadable;
            this.ManageStock = manageStock;
            this.IsFreeShipping = isFreeShipping;
            this.SeoUrl = seoUrl;
            this.MetaTitle = metaTitle;
            this.MetaDescription = metaDescription;
            this.MetaKeywords = metaKeywords;
            this.CategoriesIds = categoriesIds;
            this.StoresIds = storesIds;
            this.Images = images;
            this.ProductImagesIds = productImagesIds;
            this.RelatedProductsIds = relatedProductsIds;
            this.UpSellProductsIds = upSellProductsIds;
            this.CrossSellProductsIds = crossSellProductsIds;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name = "product_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "short_description", EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        public string Upc { get; set; }

        /// <summary>
        /// Gets or Sets Mpn
        /// </summary>
        [DataMember(Name = "mpn", EmitDefaultValue = false)]
        public string Mpn { get; set; }

        /// <summary>
        /// Gets or Sets Gtin
        /// </summary>
        [DataMember(Name = "gtin", EmitDefaultValue = false)]
        public string Gtin { get; set; }

        /// <summary>
        /// Gets or Sets Isbn
        /// </summary>
        [DataMember(Name = "isbn", EmitDefaultValue = false)]
        public string Isbn { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets SpecialPrice
        /// </summary>
        [DataMember(Name = "special_price", EmitDefaultValue = false)]
        public decimal SpecialPrice { get; set; }

        /// <summary>
        /// Gets or Sets CostPrice
        /// </summary>
        [DataMember(Name = "cost_price", EmitDefaultValue = false)]
        public decimal CostPrice { get; set; }

        /// <summary>
        /// Gets or Sets RetailPrice
        /// </summary>
        [DataMember(Name = "retail_price", EmitDefaultValue = false)]
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.
        /// </summary>
        /// <value>If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.</value>
        [DataMember(Name = "advanced_prices", EmitDefaultValue = false)]
        public List<ProductUpdateBatchPayloadInnerAdvancedPricesInner> AdvancedPrices { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ReserveQuantity
        /// </summary>
        [DataMember(Name = "reserve_quantity", EmitDefaultValue = false)]
        public decimal ReserveQuantity { get; set; }

        /// <summary>
        /// Gets or Sets IncreaseQuantity
        /// </summary>
        [DataMember(Name = "increase_quantity", EmitDefaultValue = false)]
        public decimal IncreaseQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ReduceQuantity
        /// </summary>
        [DataMember(Name = "reduce_quantity", EmitDefaultValue = false)]
        public decimal ReduceQuantity { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name = "warehouse_id", EmitDefaultValue = false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerId
        /// </summary>
        [DataMember(Name = "manufacturer_id", EmitDefaultValue = false)]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets LangId
        /// </summary>
        [DataMember(Name = "lang_id", EmitDefaultValue = false)]
        public string LangId { get; set; }

        /// <summary>
        /// Gets or Sets TaxClassId
        /// </summary>
        [DataMember(Name = "tax_class_id", EmitDefaultValue = false)]
        public string TaxClassId { get; set; }

        /// <summary>
        /// Gets or Sets BackorderStatus
        /// </summary>
        [DataMember(Name = "backorder_status", EmitDefaultValue = false)]
        public string BackorderStatus { get; set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = false)]
        public string Visible { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets InStock
        /// </summary>
        [DataMember(Name = "in_stock", EmitDefaultValue = true)]
        public bool InStock { get; set; }

        /// <summary>
        /// Gets or Sets IsVirtual
        /// </summary>
        [DataMember(Name = "is_virtual", EmitDefaultValue = true)]
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Gets or Sets Downloadable
        /// </summary>
        [DataMember(Name = "downloadable", EmitDefaultValue = true)]
        public bool Downloadable { get; set; }

        /// <summary>
        /// Gets or Sets ManageStock
        /// </summary>
        [DataMember(Name = "manage_stock", EmitDefaultValue = true)]
        public bool ManageStock { get; set; }

        /// <summary>
        /// Gets or Sets IsFreeShipping
        /// </summary>
        [DataMember(Name = "is_free_shipping", EmitDefaultValue = true)]
        public bool IsFreeShipping { get; set; }

        /// <summary>
        /// Gets or Sets SeoUrl
        /// </summary>
        [DataMember(Name = "seo_url", EmitDefaultValue = false)]
        public string SeoUrl { get; set; }

        /// <summary>
        /// Gets or Sets MetaTitle
        /// </summary>
        [DataMember(Name = "meta_title", EmitDefaultValue = false)]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or Sets MetaDescription
        /// </summary>
        [DataMember(Name = "meta_description", EmitDefaultValue = false)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or Sets MetaKeywords
        /// </summary>
        [DataMember(Name = "meta_keywords", EmitDefaultValue = false)]
        public List<string> MetaKeywords { get; set; }

        /// <summary>
        /// If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.
        /// </summary>
        /// <value>If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.</value>
        [DataMember(Name = "categories_ids", EmitDefaultValue = false)]
        public List<string> CategoriesIds { get; set; }

        /// <summary>
        /// Gets or Sets StoresIds
        /// </summary>
        [DataMember(Name = "stores_ids", EmitDefaultValue = false)]
        public List<string> StoresIds { get; set; }

        /// <summary>
        /// The passed items will completely replace the original items
        /// </summary>
        /// <value>The passed items will completely replace the original items</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<ProductAddBatchPayloadInnerImagesInner> Images { get; set; }

        /// <summary>
        /// Gets or Sets ProductImagesIds
        /// </summary>
        [DataMember(Name = "product_images_ids", EmitDefaultValue = false)]
        public List<string> ProductImagesIds { get; set; }

        /// <summary>
        /// If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.
        /// </summary>
        /// <value>If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.</value>
        [DataMember(Name = "related_products_ids", EmitDefaultValue = false)]
        public List<string> RelatedProductsIds { get; set; }

        /// <summary>
        /// If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.
        /// </summary>
        /// <value>If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.</value>
        [DataMember(Name = "up_sell_products_ids", EmitDefaultValue = false)]
        public List<string> UpSellProductsIds { get; set; }

        /// <summary>
        /// If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.
        /// </summary>
        /// <value>If an empty array is passed, all entries will be deleted when the &#39;nested_items_update_behaviour&#39; parameter is set to &#39;replace&#39;.</value>
        [DataMember(Name = "cross_sell_products_ids", EmitDefaultValue = false)]
        public List<string> CrossSellProductsIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductVariantUpdateBatchPayloadInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  Mpn: ").Append(Mpn).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Isbn: ").Append(Isbn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SpecialPrice: ").Append(SpecialPrice).Append("\n");
            sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  AdvancedPrices: ").Append(AdvancedPrices).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReserveQuantity: ").Append(ReserveQuantity).Append("\n");
            sb.Append("  IncreaseQuantity: ").Append(IncreaseQuantity).Append("\n");
            sb.Append("  ReduceQuantity: ").Append(ReduceQuantity).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  ManufacturerId: ").Append(ManufacturerId).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  LangId: ").Append(LangId).Append("\n");
            sb.Append("  TaxClassId: ").Append(TaxClassId).Append("\n");
            sb.Append("  BackorderStatus: ").Append(BackorderStatus).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  InStock: ").Append(InStock).Append("\n");
            sb.Append("  IsVirtual: ").Append(IsVirtual).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  ManageStock: ").Append(ManageStock).Append("\n");
            sb.Append("  IsFreeShipping: ").Append(IsFreeShipping).Append("\n");
            sb.Append("  SeoUrl: ").Append(SeoUrl).Append("\n");
            sb.Append("  MetaTitle: ").Append(MetaTitle).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  CategoriesIds: ").Append(CategoriesIds).Append("\n");
            sb.Append("  StoresIds: ").Append(StoresIds).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ProductImagesIds: ").Append(ProductImagesIds).Append("\n");
            sb.Append("  RelatedProductsIds: ").Append(RelatedProductsIds).Append("\n");
            sb.Append("  UpSellProductsIds: ").Append(UpSellProductsIds).Append("\n");
            sb.Append("  CrossSellProductsIds: ").Append(CrossSellProductsIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
