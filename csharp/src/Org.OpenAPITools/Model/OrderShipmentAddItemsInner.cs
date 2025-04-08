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
    /// OrderShipmentAddItemsInner
    /// </summary>
    [DataContract(Name = "OrderShipmentAdd_items_inner")]
    public partial class OrderShipmentAddItemsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShipmentAddItemsInner" /> class.
        /// </summary>
        /// <param name="orderProductId">orderProductId.</param>
        /// <param name="quantity">quantity.</param>
        public OrderShipmentAddItemsInner(string orderProductId = default(string), decimal quantity = default(decimal))
        {
            this.OrderProductId = orderProductId;
            this.Quantity = quantity;
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
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderShipmentAddItemsInner {\n");
            sb.Append("  OrderProductId: ").Append(OrderProductId).Append("\n");
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
