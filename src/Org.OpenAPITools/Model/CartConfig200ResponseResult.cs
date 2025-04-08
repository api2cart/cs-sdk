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
    /// CartConfig200ResponseResult
    /// </summary>
    [DataContract(Name = "CartConfig_200_response_result")]
    public partial class CartConfig200ResponseResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartConfig200ResponseResult" /> class.
        /// </summary>
        /// <param name="storeName">storeName.</param>
        /// <param name="storeUrl">storeUrl.</param>
        /// <param name="dbPrefix">dbPrefix.</param>
        public CartConfig200ResponseResult(string storeName = default(string), string storeUrl = default(string), string dbPrefix = default(string))
        {
            this.StoreName = storeName;
            this.StoreUrl = storeUrl;
            this.DbPrefix = dbPrefix;
        }

        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Gets or Sets StoreUrl
        /// </summary>
        [DataMember(Name = "store_url", EmitDefaultValue = false)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// Gets or Sets DbPrefix
        /// </summary>
        [DataMember(Name = "db_prefix", EmitDefaultValue = false)]
        public string DbPrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartConfig200ResponseResult {\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  StoreUrl: ").Append(StoreUrl).Append("\n");
            sb.Append("  DbPrefix: ").Append(DbPrefix).Append("\n");
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
