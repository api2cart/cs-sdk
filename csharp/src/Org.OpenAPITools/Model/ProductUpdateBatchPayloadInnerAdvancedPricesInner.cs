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
    /// ProductUpdateBatchPayloadInnerAdvancedPricesInner
    /// </summary>
    [DataContract(Name = "ProductUpdateBatch_payload_inner_advanced_prices_inner")]
    public partial class ProductUpdateBatchPayloadInnerAdvancedPricesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpdateBatchPayloadInnerAdvancedPricesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductUpdateBatchPayloadInnerAdvancedPricesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpdateBatchPayloadInnerAdvancedPricesInner" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="quantity">quantity (required).</param>
        public ProductUpdateBatchPayloadInnerAdvancedPricesInner(decimal value = default(decimal), int groupId = default(int), decimal quantity = default(decimal))
        {
            this.Value = value;
            this.Quantity = quantity;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductUpdateBatchPayloadInnerAdvancedPricesInner {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
