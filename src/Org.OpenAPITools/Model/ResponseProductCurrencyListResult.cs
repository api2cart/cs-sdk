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
    /// ResponseProductCurrencyListResult
    /// </summary>
    [DataContract(Name = "Response_Product_Currency_List_Result")]
    public partial class ResponseProductCurrencyListResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseProductCurrencyListResult" /> class.
        /// </summary>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ResponseProductCurrencyListResult(int? totalCount = default(int?), List<Currency> currency = default(List<Currency>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.TotalCount = totalCount;
            this.Currency = currency;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "total_count", EmitDefaultValue = true)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public List<Currency> Currency { get; set; }

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
            sb.Append("class ResponseProductCurrencyListResult {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
