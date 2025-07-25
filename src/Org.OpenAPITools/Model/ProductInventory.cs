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
    /// ProductInventory
    /// </summary>
    [DataContract(Name = "Product_Inventory")]
    public partial class ProductInventory : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductInventory" /> class.
        /// </summary>
        /// <param name="warehouseId">warehouseId.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="inStock">inStock.</param>
        /// <param name="priority">priority.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ProductInventory(string warehouseId = default(string), decimal quantity = default(decimal), bool? inStock = default(bool?), int? priority = default(int?), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.WarehouseId = warehouseId;
            this.Quantity = quantity;
            this.InStock = inStock;
            this.Priority = priority;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name = "warehouse_id", EmitDefaultValue = false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets InStock
        /// </summary>
        [DataMember(Name = "in_stock", EmitDefaultValue = true)]
        public bool? InStock { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public int? Priority { get; set; }

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
            sb.Append("class ProductInventory {\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  InStock: ").Append(InStock).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
