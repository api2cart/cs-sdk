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
    /// ProductOptionItem
    /// </summary>
    [DataContract(Name = "Product_Option_Item")]
    public partial class ProductOptionItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="productOptionItemId">productOptionItemId.</param>
        /// <param name="name">name.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="price">price.</param>
        /// <param name="weight">weight.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="typePrice">typePrice.</param>
        /// <param name="sku">sku.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ProductOptionItem(string id = default(string), string productOptionItemId = default(string), string name = default(string), int sortOrder = default(int), string price = default(string), string weight = default(string), int quantity = default(int), string typePrice = default(string), string sku = default(string), bool isDefault = default(bool), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.ProductOptionItemId = productOptionItemId;
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Price = price;
            this.Weight = weight;
            this.Quantity = quantity;
            this.TypePrice = typePrice;
            this.Sku = sku;
            this.IsDefault = isDefault;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductOptionItemId
        /// </summary>
        [DataMember(Name = "product_option_item_id", EmitDefaultValue = false)]
        public string ProductOptionItemId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sort_order", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public string Weight { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets TypePrice
        /// </summary>
        [DataMember(Name = "type_price", EmitDefaultValue = false)]
        public string TypePrice { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFields
        /// </summary>
        [DataMember(Name = "additional_fields", EmitDefaultValue = false)]
        public Object AdditionalFields { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductOptionItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductOptionItemId: ").Append(ProductOptionItemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TypePrice: ").Append(TypePrice).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  AdditionalFields: ").Append(AdditionalFields).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
