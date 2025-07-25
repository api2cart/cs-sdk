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
    /// Basket
    /// </summary>
    [DataContract(Name = "Basket")]
    public partial class Basket : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Basket" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="basketUrl">basketUrl.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="basketProducts">basketProducts.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public Basket(string id = default(string), BaseCustomer customer = default(BaseCustomer), string basketUrl = default(string), A2CDateTime createdAt = default(A2CDateTime), A2CDateTime modifiedAt = default(A2CDateTime), Currency currency = default(Currency), List<BasketItem> basketProducts = default(List<BasketItem>), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.Customer = customer;
            this.BasketUrl = basketUrl;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Currency = currency;
            this.BasketProducts = basketProducts;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public BaseCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets BasketUrl
        /// </summary>
        [DataMember(Name = "basket_url", EmitDefaultValue = true)]
        public string BasketUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public A2CDateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name = "modified_at", EmitDefaultValue = true)]
        public A2CDateTime ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency Currency { get; set; }

        /// <summary>
        /// Gets or Sets BasketProducts
        /// </summary>
        [DataMember(Name = "basket_products", EmitDefaultValue = false)]
        public List<BasketItem> BasketProducts { get; set; }

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
            sb.Append("class Basket {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  BasketUrl: ").Append(BasketUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BasketProducts: ").Append(BasketProducts).Append("\n");
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
