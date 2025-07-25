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
    /// ProductAttribute
    /// </summary>
    [DataContract(Name = "Product_Attribute")]
    public partial class ProductAttribute : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAttribute" /> class.
        /// </summary>
        /// <param name="attributeId">attributeId.</param>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="langId">langId.</param>
        /// <param name="storeId">storeId.</param>
        /// <param name="value">value.</param>
        /// <param name="required">required.</param>
        /// <param name="visible">visible.</param>
        /// <param name="type">type.</param>
        /// <param name="position">position.</param>
        /// <param name="attributeGroupId">attributeGroupId.</param>
        /// <param name="productId">productId.</param>
        /// <param name="variantId">variantId.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ProductAttribute(string attributeId = default(string), string code = default(string), string name = default(string), string langId = default(string), string storeId = default(string), string value = default(string), bool? required = default(bool?), bool? visible = default(bool?), string type = default(string), int? position = default(int?), string attributeGroupId = default(string), string productId = default(string), string variantId = default(string), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.AttributeId = attributeId;
            this.Code = code;
            this.Name = name;
            this.LangId = langId;
            this.StoreId = storeId;
            this.Value = value;
            this.Required = required;
            this.Visible = visible;
            this.Type = type;
            this.Position = position;
            this.AttributeGroupId = attributeGroupId;
            this.ProductId = productId;
            this.VariantId = variantId;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets AttributeId
        /// </summary>
        [DataMember(Name = "attribute_id", EmitDefaultValue = false)]
        public string AttributeId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LangId
        /// </summary>
        [DataMember(Name = "lang_id", EmitDefaultValue = true)]
        public string LangId { get; set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name = "store_id", EmitDefaultValue = true)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = true)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets AttributeGroupId
        /// </summary>
        [DataMember(Name = "attribute_group_id", EmitDefaultValue = true)]
        public string AttributeGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name = "product_id", EmitDefaultValue = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets VariantId
        /// </summary>
        [DataMember(Name = "variant_id", EmitDefaultValue = true)]
        public string VariantId { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFields
        /// </summary>
        [DataMember(Name = "additional_fields", EmitDefaultValue = true)]
        public Object AdditionalFields { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAttribute {\n");
            sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LangId: ").Append(LangId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  AttributeGroupId: ").Append(AttributeGroupId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
