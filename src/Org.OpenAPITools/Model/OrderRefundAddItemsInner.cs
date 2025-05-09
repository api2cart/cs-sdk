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
    /// OrderRefundAddItemsInner
    /// </summary>
    [DataContract(Name = "OrderRefundAdd_items_inner")]
    public partial class OrderRefundAddItemsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefundAddItemsInner" /> class.
        /// </summary>
        /// <param name="orderProductId">orderProductId.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="price">price.</param>
        public OrderRefundAddItemsInner(string orderProductId = default(string), int quantity = default(int), decimal price = default(decimal))
        {
            this.OrderProductId = orderProductId;
            this.Quantity = quantity;
            this.Price = price;
        }

        /// <summary>
        /// Gets or Sets OrderProductId
        /// </summary>
        [DataMember(Name = "order_product_id", EmitDefaultValue = false)]
        public string OrderProductId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRefundAddItemsInner {\n");
            sb.Append("  OrderProductId: ").Append(OrderProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
