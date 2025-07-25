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
    /// TaxClassRate
    /// </summary>
    [DataContract(Name = "TaxClass_Rate")]
    public partial class TaxClassRate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxClassRate" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="tax">tax.</param>
        /// <param name="taxType">taxType.</param>
        /// <param name="taxBasedOn">taxBasedOn.</param>
        /// <param name="countries">countries.</param>
        /// <param name="cities">cities.</param>
        /// <param name="address">address.</param>
        /// <param name="zipCodes">zipCodes.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public TaxClassRate(string id = default(string), string name = default(string), decimal tax = default(decimal), int taxType = default(int), string taxBasedOn = default(string), List<TaxClassCountries> countries = default(List<TaxClassCountries>), List<string> cities = default(List<string>), List<string> address = default(List<string>), List<TaxClassZipCodes> zipCodes = default(List<TaxClassZipCodes>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.Name = name;
            this.Tax = tax;
            this.TaxType = taxType;
            this.TaxBasedOn = taxBasedOn;
            this.Countries = countries;
            this.Cities = cities;
            this.Address = address;
            this.ZipCodes = zipCodes;
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
        /// Gets or Sets TaxBasedOn
        /// </summary>
        [DataMember(Name = "tax_based_on", EmitDefaultValue = false)]
        public string TaxBasedOn { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public List<TaxClassCountries> Countries { get; set; }

        /// <summary>
        /// Gets or Sets Cities
        /// </summary>
        [DataMember(Name = "cities", EmitDefaultValue = false)]
        public List<string> Cities { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Gets or Sets ZipCodes
        /// </summary>
        [DataMember(Name = "zip_codes", EmitDefaultValue = false)]
        public List<TaxClassZipCodes> ZipCodes { get; set; }

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
            sb.Append("class TaxClassRate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxBasedOn: ").Append(TaxBasedOn).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Cities: ").Append(Cities).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ZipCodes: ").Append(ZipCodes).Append("\n");
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
