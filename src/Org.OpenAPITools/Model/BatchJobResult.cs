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
    /// BatchJobResult
    /// </summary>
    [DataContract(Name = "Batch_Job_Result")]
    public partial class BatchJobResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobResult" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="jobName">jobName.</param>
        /// <param name="itemsProcessed">itemsProcessed.</param>
        /// <param name="itemsSucceed">itemsSucceed.</param>
        /// <param name="items">items.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public BatchJobResult(int jobId = default(int), string jobName = default(string), int itemsProcessed = default(int), int itemsSucceed = default(int), List<BatchJobResultItem> items = default(List<BatchJobResultItem>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.JobId = jobId;
            this.JobName = jobName;
            this.ItemsProcessed = itemsProcessed;
            this.ItemsSucceed = itemsSucceed;
            this.Items = items;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "job_id", EmitDefaultValue = false)]
        public int JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobName
        /// </summary>
        [DataMember(Name = "job_name", EmitDefaultValue = false)]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or Sets ItemsProcessed
        /// </summary>
        [DataMember(Name = "items_processed", EmitDefaultValue = false)]
        public int ItemsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets ItemsSucceed
        /// </summary>
        [DataMember(Name = "items_succeed", EmitDefaultValue = false)]
        public int ItemsSucceed { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<BatchJobResultItem> Items { get; set; }

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
            sb.Append("class BatchJobResult {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  ItemsProcessed: ").Append(ItemsProcessed).Append("\n");
            sb.Append("  ItemsSucceed: ").Append(ItemsSucceed).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
