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
    /// ProductVariantImageAdd
    /// </summary>
    [DataContract(Name = "ProductVariantImageAdd")]
    public partial class ProductVariantImageAdd : IValidatableObject
    {
        /// <summary>
        /// Defines image&#39;s types that are specified by comma-separated list
        /// </summary>
        /// <value>Defines image&#39;s types that are specified by comma-separated list</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Small for value: small
            /// </summary>
            [EnumMember(Value = "small")]
            Small = 1,

            /// <summary>
            /// Enum Base for value: base
            /// </summary>
            [EnumMember(Value = "base")]
            Base = 2,

            /// <summary>
            /// Enum Additional for value: additional
            /// </summary>
            [EnumMember(Value = "additional")]
            Additional = 3,

            /// <summary>
            /// Enum Thumbnail for value: thumbnail
            /// </summary>
            [EnumMember(Value = "thumbnail")]
            Thumbnail = 4
        }


        /// <summary>
        /// Defines image&#39;s types that are specified by comma-separated list
        /// </summary>
        /// <value>Defines image&#39;s types that are specified by comma-separated list</value>
        /*
        <example>base</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantImageAdd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductVariantImageAdd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantImageAdd" /> class.
        /// </summary>
        /// <param name="productId">Defines product id where the variant image has to be added.</param>
        /// <param name="productVariantId">Defines product&#39;s variants specified by variant id (required).</param>
        /// <param name="imageName">Defines image&#39;s name (required).</param>
        /// <param name="type">Defines image&#39;s types that are specified by comma-separated list (required) (default to TypeEnum.Base).</param>
        /// <param name="url">Defines URL of the image that has to be added.</param>
        /// <param name="content">Content(body) encoded in base64 of image file.</param>
        /// <param name="label">Defines alternative text that has to be attached to the picture.</param>
        /// <param name="mime">Mime type of image http://en.wikipedia.org/wiki/Internet_media_type..</param>
        /// <param name="position">Defines image’s position in the list (default to 0).</param>
        /// <param name="storeId">Store Id.</param>
        /// <param name="optionId">Defines option id of the product variant for which the image will be added.</param>
        public ProductVariantImageAdd(string productId = default(string), string productVariantId = default(string), string imageName = default(string), TypeEnum type = TypeEnum.Base, string url = default(string), string content = default(string), string label = default(string), string mime = default(string), int position = 0, string storeId = default(string), string optionId = default(string))
        {
            // to ensure "productVariantId" is required (not null)
            if (productVariantId == null)
            {
                throw new ArgumentNullException("productVariantId is a required property for ProductVariantImageAdd and cannot be null");
            }
            this.ProductVariantId = productVariantId;
            // to ensure "imageName" is required (not null)
            if (imageName == null)
            {
                throw new ArgumentNullException("imageName is a required property for ProductVariantImageAdd and cannot be null");
            }
            this.ImageName = imageName;
            this.Type = type;
            this.ProductId = productId;
            this.Url = url;
            this.Content = content;
            this.Label = label;
            this.Mime = mime;
            this.Position = position;
            this.StoreId = storeId;
            this.OptionId = optionId;
        }

        /// <summary>
        /// Defines product id where the variant image has to be added
        /// </summary>
        /// <value>Defines product id where the variant image has to be added</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Defines product&#39;s variants specified by variant id
        /// </summary>
        /// <value>Defines product&#39;s variants specified by variant id</value>
        /*
        <example>45</example>
        */
        [DataMember(Name = "product_variant_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProductVariantId { get; set; }

        /// <summary>
        /// Defines image&#39;s name
        /// </summary>
        /// <value>Defines image&#39;s name</value>
        /*
        <example>abibas.png</example>
        */
        [DataMember(Name = "image_name", IsRequired = true, EmitDefaultValue = true)]
        public string ImageName { get; set; }

        /// <summary>
        /// Defines URL of the image that has to be added
        /// </summary>
        /// <value>Defines URL of the image that has to be added</value>
        /*
        <example>http://docs.api2cart.com/img/logo.png</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Content(body) encoded in base64 of image file
        /// </summary>
        /// <value>Content(body) encoded in base64 of image file</value>
        /*
        <example>/9j/4AAQSkZ...gD/2Q&#x3D;&#x3D;</example>
        */
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Defines alternative text that has to be attached to the picture
        /// </summary>
        /// <value>Defines alternative text that has to be attached to the picture</value>
        /*
        <example>This cool image</example>
        */
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Mime type of image http://en.wikipedia.org/wiki/Internet_media_type.
        /// </summary>
        /// <value>Mime type of image http://en.wikipedia.org/wiki/Internet_media_type.</value>
        /*
        <example>image/jpeg</example>
        */
        [DataMember(Name = "mime", EmitDefaultValue = false)]
        public string Mime { get; set; }

        /// <summary>
        /// Defines image’s position in the list
        /// </summary>
        /// <value>Defines image’s position in the list</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int Position { get; set; }

        /// <summary>
        /// Store Id
        /// </summary>
        /// <value>Store Id</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Defines option id of the product variant for which the image will be added
        /// </summary>
        /// <value>Defines option id of the product variant for which the image will be added</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "option_id", EmitDefaultValue = false)]
        public string OptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductVariantImageAdd {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductVariantId: ").Append(ProductVariantId).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  OptionId: ").Append(OptionId).Append("\n");
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
