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
    /// Brand
    /// </summary>
    [DataContract(Name = "Brand")]
    public partial class Brand : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Brand" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="modifiedTime">modifiedTime.</param>
        /// <param name="fullDescription">fullDescription.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="storesIds">storesIds.</param>
        /// <param name="active">active.</param>
        /// <param name="url">url.</param>
        /// <param name="metaTitle">metaTitle.</param>
        /// <param name="metaKeywords">metaKeywords.</param>
        /// <param name="metaDescription">metaDescription.</param>
        /// <param name="images">images.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public Brand(string id = default(string), string name = default(string), string createdTime = default(string), string modifiedTime = default(string), string fullDescription = default(string), string shortDescription = default(string), List<string> storesIds = default(List<string>), bool active = default(bool), string url = default(string), string metaTitle = default(string), string metaKeywords = default(string), string metaDescription = default(string), List<Image> images = default(List<Image>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.Name = name;
            this.CreatedTime = createdTime;
            this.ModifiedTime = modifiedTime;
            this.FullDescription = fullDescription;
            this.ShortDescription = shortDescription;
            this.StoresIds = storesIds;
            this.Active = active;
            this.Url = url;
            this.MetaTitle = metaTitle;
            this.MetaKeywords = metaKeywords;
            this.MetaDescription = metaDescription;
            this.Images = images;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time", EmitDefaultValue = true)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedTime
        /// </summary>
        [DataMember(Name = "modified_time", EmitDefaultValue = true)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets FullDescription
        /// </summary>
        [DataMember(Name = "full_description", EmitDefaultValue = true)]
        public string FullDescription { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "short_description", EmitDefaultValue = true)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets StoresIds
        /// </summary>
        [DataMember(Name = "stores_ids", EmitDefaultValue = false)]
        public List<string> StoresIds { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets MetaTitle
        /// </summary>
        [DataMember(Name = "meta_title", EmitDefaultValue = true)]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or Sets MetaKeywords
        /// </summary>
        [DataMember(Name = "meta_keywords", EmitDefaultValue = true)]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or Sets MetaDescription
        /// </summary>
        [DataMember(Name = "meta_description", EmitDefaultValue = true)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<Image> Images { get; set; }

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
            sb.Append("class Brand {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  FullDescription: ").Append(FullDescription).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  StoresIds: ").Append(StoresIds).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MetaTitle: ").Append(MetaTitle).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
