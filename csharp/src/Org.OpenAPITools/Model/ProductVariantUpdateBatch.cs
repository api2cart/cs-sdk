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
    /// ProductVariantUpdateBatch
    /// </summary>
    [DataContract(Name = "ProductVariantUpdateBatch")]
    public partial class ProductVariantUpdateBatch : IValidatableObject
    {
        /// <summary>
        ///  Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt;
        /// </summary>
        /// <value> Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NestedItemsUpdateBehaviourEnum
        {
            /// <summary>
            /// Enum Replace for value: replace
            /// </summary>
            [EnumMember(Value = "replace")]
            Replace = 1,

            /// <summary>
            /// Enum Merge for value: merge
            /// </summary>
            [EnumMember(Value = "merge")]
            Merge = 2
        }


        /// <summary>
        ///  Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt;
        /// </summary>
        /// <value> Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt;</value>
        [DataMember(Name = "nested_items_update_behaviour", EmitDefaultValue = false)]
        public NestedItemsUpdateBehaviourEnum? NestedItemsUpdateBehaviour { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantUpdateBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductVariantUpdateBatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantUpdateBatch" /> class.
        /// </summary>
        /// <param name="nestedItemsUpdateBehaviour"> Determines how updates to nested items should be handled.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;  Values description:  &lt;div style&#x3D;\&quot;margin-left: 2%; padding-top: 2%\&quot;&gt;    &lt;div style&#x3D;\&quot;font-size:85%\&quot;&gt;      &lt;b&gt;  replace&lt;/b&gt;: This option indicates that the nested items should be completely replaced with the new data provided. &lt;/br&gt;      &lt;b&gt;  merge&lt;/b&gt;: With this option, updates to nested items are merged with the existing data. &lt;/br&gt;    &lt;/div&gt;  &lt;/div&gt;&lt;/div&gt; (default to NestedItemsUpdateBehaviourEnum.Replace).</param>
        /// <param name="clearCache">clearCache (default to false).</param>
        /// <param name="reindex">reindex (default to false).</param>
        /// <param name="payload">Contains an array of product objects. The list of properties may vary depending on the specific platform. (required).</param>
        public ProductVariantUpdateBatch(NestedItemsUpdateBehaviourEnum? nestedItemsUpdateBehaviour = NestedItemsUpdateBehaviourEnum.Replace, bool clearCache = false, bool reindex = false, List<ProductVariantUpdateBatchPayloadInner> payload = default(List<ProductVariantUpdateBatchPayloadInner>))
        {
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for ProductVariantUpdateBatch and cannot be null");
            }
            this.Payload = payload;
            this.NestedItemsUpdateBehaviour = nestedItemsUpdateBehaviour;
            this.ClearCache = clearCache;
            this.Reindex = reindex;
        }

        /// <summary>
        /// Gets or Sets ClearCache
        /// </summary>
        [DataMember(Name = "clear_cache", EmitDefaultValue = true)]
        public bool ClearCache { get; set; }

        /// <summary>
        /// Gets or Sets Reindex
        /// </summary>
        [DataMember(Name = "reindex", EmitDefaultValue = true)]
        public bool Reindex { get; set; }

        /// <summary>
        /// Contains an array of product objects. The list of properties may vary depending on the specific platform.
        /// </summary>
        /// <value>Contains an array of product objects. The list of properties may vary depending on the specific platform.</value>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductVariantUpdateBatchPayloadInner> Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductVariantUpdateBatch {\n");
            sb.Append("  NestedItemsUpdateBehaviour: ").Append(NestedItemsUpdateBehaviour).Append("\n");
            sb.Append("  ClearCache: ").Append(ClearCache).Append("\n");
            sb.Append("  Reindex: ").Append(Reindex).Append("\n");
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
