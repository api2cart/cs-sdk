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
    /// ProductAddShippingDetailsInner
    /// </summary>
    [DataContract(Name = "ProductAdd_shipping_details_inner")]
    public partial class ProductAddShippingDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddShippingDetailsInner" /> class.
        /// </summary>
        /// <param name="shippingType">shippingType.</param>
        /// <param name="shippingService">shippingService.</param>
        /// <param name="shippingCost">shippingCost.</param>
        public ProductAddShippingDetailsInner(string shippingType = default(string), string shippingService = default(string), decimal shippingCost = default(decimal))
        {
            this.ShippingType = shippingType;
            this.ShippingService = shippingService;
            this.ShippingCost = shippingCost;
        }

        /// <summary>
        /// Gets or Sets ShippingType
        /// </summary>
        [DataMember(Name = "shipping_type", EmitDefaultValue = false)]
        public string ShippingType { get; set; }

        /// <summary>
        /// Gets or Sets ShippingService
        /// </summary>
        [DataMember(Name = "shipping_service", EmitDefaultValue = false)]
        public string ShippingService { get; set; }

        /// <summary>
        /// Gets or Sets ShippingCost
        /// </summary>
        [DataMember(Name = "shipping_cost", EmitDefaultValue = false)]
        public decimal ShippingCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAddShippingDetailsInner {\n");
            sb.Append("  ShippingType: ").Append(ShippingType).Append("\n");
            sb.Append("  ShippingService: ").Append(ShippingService).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
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
