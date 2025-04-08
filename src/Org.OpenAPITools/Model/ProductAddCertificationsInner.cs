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
    /// ProductAddCertificationsInner
    /// </summary>
    [DataContract(Name = "ProductAdd_certifications_inner")]
    public partial class ProductAddCertificationsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddCertificationsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductAddCertificationsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddCertificationsInner" /> class.
        /// </summary>
        /// <param name="id">Certification ID (required).</param>
        /// <param name="images">Certification images.</param>
        /// <param name="files">Certification files.</param>
        public ProductAddCertificationsInner(string id = default(string), List<ProductAddCertificationsInnerImagesInner> images = default(List<ProductAddCertificationsInnerImagesInner>), List<ProductAddCertificationsInnerFilesInner> files = default(List<ProductAddCertificationsInnerFilesInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ProductAddCertificationsInner and cannot be null");
            }
            this.Id = id;
            this.Images = images;
            this.Files = files;
        }

        /// <summary>
        /// Certification ID
        /// </summary>
        /// <value>Certification ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Certification images
        /// </summary>
        /// <value>Certification images</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<ProductAddCertificationsInnerImagesInner> Images { get; set; }

        /// <summary>
        /// Certification files
        /// </summary>
        /// <value>Certification files</value>
        [DataMember(Name = "files", EmitDefaultValue = false)]
        public List<ProductAddCertificationsInnerFilesInner> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAddCertificationsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
