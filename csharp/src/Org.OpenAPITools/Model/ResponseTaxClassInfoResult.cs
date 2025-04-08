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
    /// ResponseTaxClassInfoResult
    /// </summary>
    [DataContract(Name = "Response_Tax_Class_Info_Result")]
    public partial class ResponseTaxClassInfoResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTaxClassInfoResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="avail">avail.</param>
        /// <param name="tax">tax.</param>
        /// <param name="taxType">taxType.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="taxRates">taxRates.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ResponseTaxClassInfoResult(string id = default(string), string name = default(string), bool avail = default(bool), decimal tax = default(decimal), int taxType = default(int), A2CDateTime createdAt = default(A2CDateTime), A2CDateTime modifiedAt = default(A2CDateTime), List<TaxClassRate> taxRates = default(List<TaxClassRate>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.Name = name;
            this.Avail = avail;
            this.Tax = tax;
            this.TaxType = taxType;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.TaxRates = taxRates;
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
        /// Gets or Sets Avail
        /// </summary>
        [DataMember(Name = "avail", EmitDefaultValue = true)]
        public bool Avail { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [DataMember(Name = "tax_type", EmitDefaultValue = false)]
        public int TaxType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public A2CDateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name = "modified_at", EmitDefaultValue = false)]
        public A2CDateTime ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets TaxRates
        /// </summary>
        [DataMember(Name = "tax_rates", EmitDefaultValue = false)]
        public List<TaxClassRate> TaxRates { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFields
        /// </summary>
        [DataMember(Name = "additional_fields", EmitDefaultValue = false)]
        public Object AdditionalFields { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseTaxClassInfoResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Avail: ").Append(Avail).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
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
