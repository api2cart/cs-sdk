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
    /// ProductOptionValueAssign200ResponseResult
    /// </summary>
    [DataContract(Name = "ProductOptionValueAssign_200_response_result")]
    public partial class ProductOptionValueAssign200ResponseResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValueAssign200ResponseResult" /> class.
        /// </summary>
        /// <param name="productOptionValueId">productOptionValueId.</param>
        public ProductOptionValueAssign200ResponseResult(string productOptionValueId = default(string))
        {
            this.ProductOptionValueId = productOptionValueId;
        }

        /// <summary>
        /// Gets or Sets ProductOptionValueId
        /// </summary>
        [DataMember(Name = "product_option_value_id", EmitDefaultValue = false)]
        public string ProductOptionValueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductOptionValueAssign200ResponseResult {\n");
            sb.Append("  ProductOptionValueId: ").Append(ProductOptionValueId).Append("\n");
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
