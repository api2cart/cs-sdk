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
    /// CartCatalogPriceRulesCount200ResponseResult
    /// </summary>
    [DataContract(Name = "CartCatalogPriceRulesCount_200_response_result")]
    public partial class CartCatalogPriceRulesCount200ResponseResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCatalogPriceRulesCount200ResponseResult" /> class.
        /// </summary>
        /// <param name="catalogPriceRulesCount">catalogPriceRulesCount.</param>
        public CartCatalogPriceRulesCount200ResponseResult(string catalogPriceRulesCount = default(string))
        {
            this.CatalogPriceRulesCount = catalogPriceRulesCount;
        }

        /// <summary>
        /// Gets or Sets CatalogPriceRulesCount
        /// </summary>
        [DataMember(Name = "catalog_price_rules_count", EmitDefaultValue = false)]
        public string CatalogPriceRulesCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartCatalogPriceRulesCount200ResponseResult {\n");
            sb.Append("  CatalogPriceRulesCount: ").Append(CatalogPriceRulesCount).Append("\n");
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
