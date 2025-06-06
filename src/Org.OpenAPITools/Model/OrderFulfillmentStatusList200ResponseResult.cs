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
    /// OrderFulfillmentStatusList200ResponseResult
    /// </summary>
    [DataContract(Name = "OrderFulfillmentStatusList_200_response_result")]
    public partial class OrderFulfillmentStatusList200ResponseResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentStatusList200ResponseResult" /> class.
        /// </summary>
        /// <param name="orderFulfillmentStatuses">orderFulfillmentStatuses.</param>
        public OrderFulfillmentStatusList200ResponseResult(List<OrderFinancialStatusList200ResponseResultOrderFinancialStatusesInner> orderFulfillmentStatuses = default(List<OrderFinancialStatusList200ResponseResultOrderFinancialStatusesInner>))
        {
            this.OrderFulfillmentStatuses = orderFulfillmentStatuses;
        }

        /// <summary>
        /// Gets or Sets OrderFulfillmentStatuses
        /// </summary>
        [DataMember(Name = "order_fulfillment_statuses", EmitDefaultValue = false)]
        public List<OrderFinancialStatusList200ResponseResultOrderFinancialStatusesInner> OrderFulfillmentStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderFulfillmentStatusList200ResponseResult {\n");
            sb.Append("  OrderFulfillmentStatuses: ").Append(OrderFulfillmentStatuses).Append("\n");
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
