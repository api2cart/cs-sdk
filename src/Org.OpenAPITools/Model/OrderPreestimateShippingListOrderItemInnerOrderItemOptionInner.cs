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
    /// OrderPreestimateShippingListOrderItemInnerOrderItemOptionInner
    /// </summary>
    [DataContract(Name = "OrderPreestimateShippingList_order_item_inner_order_item_option_inner")]
    public partial class OrderPreestimateShippingListOrderItemInnerOrderItemOptionInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPreestimateShippingListOrderItemInnerOrderItemOptionInner" /> class.
        /// </summary>
        /// <param name="orderItemOptionName">Ordered Product Option Name. Where x is order item ID, y is order item option ID.</param>
        /// <param name="orderItemOptionId">Product Option ID. Where x is order item ID, y is order item option ID.</param>
        /// <param name="orderItemOptionValue">Ordered product option value Where x is order item ID, y - order item option ID.</param>
        /// <param name="orderItemOptionValueId">Product option value ID, where x is order item ID, y - order item option ID.</param>
        /// <param name="orderItemOptionUsedInCombinations">Product option used in combinations flag, where x is order item ID, y - order item option ID.</param>
        public OrderPreestimateShippingListOrderItemInnerOrderItemOptionInner(string orderItemOptionName = default(string), string orderItemOptionId = default(string), string orderItemOptionValue = default(string), string orderItemOptionValueId = default(string), bool orderItemOptionUsedInCombinations = default(bool))
        {
            this.OrderItemOptionName = orderItemOptionName;
            this.OrderItemOptionId = orderItemOptionId;
            this.OrderItemOptionValue = orderItemOptionValue;
            this.OrderItemOptionValueId = orderItemOptionValueId;
            this.OrderItemOptionUsedInCombinations = orderItemOptionUsedInCombinations;
        }

        /// <summary>
        /// Ordered Product Option Name. Where x is order item ID, y is order item option ID
        /// </summary>
        /// <value>Ordered Product Option Name. Where x is order item ID, y is order item option ID</value>
        /*
        <example>Color</example>
        */
        [DataMember(Name = "order_item_option_name", EmitDefaultValue = false)]
        public string OrderItemOptionName { get; set; }

        /// <summary>
        /// Product Option ID. Where x is order item ID, y is order item option ID
        /// </summary>
        /// <value>Product Option ID. Where x is order item ID, y is order item option ID</value>
        /*
        <example>12</example>
        */
        [DataMember(Name = "order_item_option_id", EmitDefaultValue = false)]
        public string OrderItemOptionId { get; set; }

        /// <summary>
        /// Ordered product option value Where x is order item ID, y - order item option ID
        /// </summary>
        /// <value>Ordered product option value Where x is order item ID, y - order item option ID</value>
        /*
        <example>green</example>
        */
        [DataMember(Name = "order_item_option_value", EmitDefaultValue = false)]
        public string OrderItemOptionValue { get; set; }

        /// <summary>
        /// Product option value ID, where x is order item ID, y - order item option ID
        /// </summary>
        /// <value>Product option value ID, where x is order item ID, y - order item option ID</value>
        /*
        <example>13</example>
        */
        [DataMember(Name = "order_item_option_value_id", EmitDefaultValue = false)]
        public string OrderItemOptionValueId { get; set; }

        /// <summary>
        /// Product option used in combinations flag, where x is order item ID, y - order item option ID
        /// </summary>
        /// <value>Product option used in combinations flag, where x is order item ID, y - order item option ID</value>
        [DataMember(Name = "order_item_option_used_in_combinations", EmitDefaultValue = true)]
        public bool OrderItemOptionUsedInCombinations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderPreestimateShippingListOrderItemInnerOrderItemOptionInner {\n");
            sb.Append("  OrderItemOptionName: ").Append(OrderItemOptionName).Append("\n");
            sb.Append("  OrderItemOptionId: ").Append(OrderItemOptionId).Append("\n");
            sb.Append("  OrderItemOptionValue: ").Append(OrderItemOptionValue).Append("\n");
            sb.Append("  OrderItemOptionValueId: ").Append(OrderItemOptionValueId).Append("\n");
            sb.Append("  OrderItemOptionUsedInCombinations: ").Append(OrderItemOptionUsedInCombinations).Append("\n");
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
