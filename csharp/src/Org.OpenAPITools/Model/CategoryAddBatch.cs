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
    /// CategoryAddBatch
    /// </summary>
    [DataContract(Name = "CategoryAddBatch")]
    public partial class CategoryAddBatch : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryAddBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryAddBatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryAddBatch" /> class.
        /// </summary>
        /// <param name="payload">Contains an array of categories objects. The list of properties may vary depending on the specific platform. (required).</param>
        public CategoryAddBatch(List<CategoryAddBatchPayloadInner> payload = default(List<CategoryAddBatchPayloadInner>))
        {
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for CategoryAddBatch and cannot be null");
            }
            this.Payload = payload;
        }

        /// <summary>
        /// Contains an array of categories objects. The list of properties may vary depending on the specific platform.
        /// </summary>
        /// <value>Contains an array of categories objects. The list of properties may vary depending on the specific platform.</value>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public List<CategoryAddBatchPayloadInner> Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CategoryAddBatch {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
