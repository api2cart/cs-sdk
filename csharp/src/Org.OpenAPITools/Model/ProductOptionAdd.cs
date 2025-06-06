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
    /// ProductOptionAdd
    /// </summary>
    [DataContract(Name = "ProductOptionAdd")]
    public partial class ProductOptionAdd : IValidatableObject
    {
        /// <summary>
        /// Defines option&#39;s type that has to be added
        /// </summary>
        /// <value>Defines option&#39;s type that has to be added</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum OptionTypeSelect for value: option_type_select
            /// </summary>
            [EnumMember(Value = "option_type_select")]
            OptionTypeSelect = 1,

            /// <summary>
            /// Enum OptionTypeText for value: option_type_text
            /// </summary>
            [EnumMember(Value = "option_type_text")]
            OptionTypeText = 2,

            /// <summary>
            /// Enum OptionTypeRadio for value: option_type_radio
            /// </summary>
            [EnumMember(Value = "option_type_radio")]
            OptionTypeRadio = 3,

            /// <summary>
            /// Enum OptionTypeCheckbox for value: option_type_checkbox
            /// </summary>
            [EnumMember(Value = "option_type_checkbox")]
            OptionTypeCheckbox = 4,

            /// <summary>
            /// Enum OptionTypeTextarea for value: option_type_textarea
            /// </summary>
            [EnumMember(Value = "option_type_textarea")]
            OptionTypeTextarea = 5,

            /// <summary>
            /// Enum OptionTypeReadonly for value: option_type_readonly
            /// </summary>
            [EnumMember(Value = "option_type_readonly")]
            OptionTypeReadonly = 6,

            /// <summary>
            /// Enum OptionTypeMultiselect for value: option_type_multiselect
            /// </summary>
            [EnumMember(Value = "option_type_multiselect")]
            OptionTypeMultiselect = 7,

            /// <summary>
            /// Enum OptionTypeMulticheckbox for value: option_type_multicheckbox
            /// </summary>
            [EnumMember(Value = "option_type_multicheckbox")]
            OptionTypeMulticheckbox = 8,

            /// <summary>
            /// Enum OptionTypeFile for value: option_type_file
            /// </summary>
            [EnumMember(Value = "option_type_file")]
            OptionTypeFile = 9,

            /// <summary>
            /// Enum OptionTypeDate for value: option_type_date
            /// </summary>
            [EnumMember(Value = "option_type_date")]
            OptionTypeDate = 10,

            /// <summary>
            /// Enum OptionTypeDatetime for value: option_type_datetime
            /// </summary>
            [EnumMember(Value = "option_type_datetime")]
            OptionTypeDatetime = 11,

            /// <summary>
            /// Enum OptionTypeTime for value: option_type_time
            /// </summary>
            [EnumMember(Value = "option_type_time")]
            OptionTypeTime = 12
        }


        /// <summary>
        /// Defines option&#39;s type that has to be added
        /// </summary>
        /// <value>Defines option&#39;s type that has to be added</value>
        /*
        <example>option_type_select</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionAdd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductOptionAdd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionAdd" /> class.
        /// </summary>
        /// <param name="name">Defines option&#39;s name (required).</param>
        /// <param name="type">Defines option&#39;s type that has to be added (required).</param>
        /// <param name="productId">Defines product id where the option should be added.</param>
        /// <param name="defaultOptionValue">Defines default option value that has to be added.</param>
        /// <param name="optionValues">Defines option values that has to be added.</param>
        /// <param name="description">Defines option&#39;s description.</param>
        /// <param name="avail">Defines whether the option is available (default to true).</param>
        /// <param name="sortOrder">Sort number in the list (default to 0).</param>
        /// <param name="required">Defines if the option is required (default to false).</param>
        /// <param name="values">An array of option values.&lt;/b&gt;.</param>
        /// <param name="clearCache">Is cache clear required (default to true).</param>
        public ProductOptionAdd(string name = default(string), TypeEnum type = default(TypeEnum), string productId = default(string), string defaultOptionValue = default(string), string optionValues = default(string), string description = default(string), bool avail = true, int sortOrder = 0, bool required = false, List<ProductOptionAddValuesInner> values = default(List<ProductOptionAddValuesInner>), bool clearCache = true)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProductOptionAdd and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.ProductId = productId;
            this.DefaultOptionValue = defaultOptionValue;
            this.OptionValues = optionValues;
            this.Description = description;
            this.Avail = avail;
            this.SortOrder = sortOrder;
            this.Required = required;
            this.Values = values;
            this.ClearCache = clearCache;
        }

        /// <summary>
        /// Defines option&#39;s name
        /// </summary>
        /// <value>Defines option&#39;s name</value>
        /*
        <example>Color</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Defines product id where the option should be added
        /// </summary>
        /// <value>Defines product id where the option should be added</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Defines default option value that has to be added
        /// </summary>
        /// <value>Defines default option value that has to be added</value>
        /*
        <example>green</example>
        */
        [DataMember(Name = "default_option_value", EmitDefaultValue = false)]
        public string DefaultOptionValue { get; set; }

        /// <summary>
        /// Defines option values that has to be added
        /// </summary>
        /// <value>Defines option values that has to be added</value>
        /*
        <example>green,black,yellow</example>
        */
        [DataMember(Name = "option_values", EmitDefaultValue = false)]
        public string OptionValues { get; set; }

        /// <summary>
        /// Defines option&#39;s description
        /// </summary>
        /// <value>Defines option&#39;s description</value>
        /*
        <example>Product option</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Defines whether the option is available
        /// </summary>
        /// <value>Defines whether the option is available</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "avail", EmitDefaultValue = true)]
        public bool Avail { get; set; }

        /// <summary>
        /// Sort number in the list
        /// </summary>
        /// <value>Sort number in the list</value>
        /*
        <example>2</example>
        */
        [DataMember(Name = "sort_order", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Defines if the option is required
        /// </summary>
        /// <value>Defines if the option is required</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// An array of option values.&lt;/b&gt;
        /// </summary>
        /// <value>An array of option values.&lt;/b&gt;</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<ProductOptionAddValuesInner> Values { get; set; }

        /// <summary>
        /// Is cache clear required
        /// </summary>
        /// <value>Is cache clear required</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "clear_cache", EmitDefaultValue = true)]
        public bool ClearCache { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductOptionAdd {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  DefaultOptionValue: ").Append(DefaultOptionValue).Append("\n");
            sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Avail: ").Append(Avail).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ClearCache: ").Append(ClearCache).Append("\n");
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
