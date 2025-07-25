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
    /// OrderTotal
    /// </summary>
    [DataContract(Name = "Order_Total")]
    public partial class OrderTotal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTotal" /> class.
        /// </summary>
        /// <param name="subtotalExTax">subtotalExTax.</param>
        /// <param name="wrappingExTax">wrappingExTax.</param>
        /// <param name="shippingExTax">shippingExTax.</param>
        /// <param name="totalDiscount">totalDiscount.</param>
        /// <param name="totalTax">totalTax.</param>
        /// <param name="total">total.</param>
        /// <param name="totalPaid">totalPaid.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public OrderTotal(decimal subtotalExTax = default(decimal), decimal? wrappingExTax = default(decimal?), decimal shippingExTax = default(decimal), decimal totalDiscount = default(decimal), decimal totalTax = default(decimal), decimal total = default(decimal), decimal? totalPaid = default(decimal?), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.SubtotalExTax = subtotalExTax;
            this.WrappingExTax = wrappingExTax;
            this.ShippingExTax = shippingExTax;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.Total = total;
            this.TotalPaid = totalPaid;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets SubtotalExTax
        /// </summary>
        [DataMember(Name = "subtotal_ex_tax", EmitDefaultValue = false)]
        public decimal SubtotalExTax { get; set; }

        /// <summary>
        /// Gets or Sets WrappingExTax
        /// </summary>
        [DataMember(Name = "wrapping_ex_tax", EmitDefaultValue = true)]
        public decimal? WrappingExTax { get; set; }

        /// <summary>
        /// Gets or Sets ShippingExTax
        /// </summary>
        [DataMember(Name = "shipping_ex_tax", EmitDefaultValue = false)]
        public decimal ShippingExTax { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscount
        /// </summary>
        [DataMember(Name = "total_discount", EmitDefaultValue = false)]
        public decimal TotalDiscount { get; set; }

        /// <summary>
        /// Gets or Sets TotalTax
        /// </summary>
        [DataMember(Name = "total_tax", EmitDefaultValue = false)]
        public decimal TotalTax { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or Sets TotalPaid
        /// </summary>
        [DataMember(Name = "total_paid", EmitDefaultValue = true)]
        public decimal? TotalPaid { get; set; }

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
            sb.Append("class OrderTotal {\n");
            sb.Append("  SubtotalExTax: ").Append(SubtotalExTax).Append("\n");
            sb.Append("  WrappingExTax: ").Append(WrappingExTax).Append("\n");
            sb.Append("  ShippingExTax: ").Append(ShippingExTax).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
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
