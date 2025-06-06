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
    /// The price at which Best Offers are automatically accepted.&lt;hr&gt;&lt;div style&#x3D;\&quot;font-style:normal\&quot;&gt;Param structure:&lt;div style&#x3D;\&quot;margin-left: 2%;\&quot;&gt;&lt;code style&#x3D;\&quot;padding:0; background-color:#ffffff;font-size:85%;font-family:monospace;\&quot;&gt;best_offer[&lt;b&gt;minimum_offer_price&lt;/b&gt;] &#x3D; decimal&lt;/br&gt;best_offer[&lt;b&gt;auto_accept_price&lt;/b&gt;] &#x3D; decimal&lt;/br&gt;&lt;/code&gt;&lt;/div&gt;&lt;/div&gt;
    /// </summary>
    [DataContract(Name = "ProductAdd_best_offer")]
    public partial class ProductAddBestOffer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddBestOffer" /> class.
        /// </summary>
        /// <param name="minimumOfferPrice">minimumOfferPrice.</param>
        /// <param name="autoAcceptPrice">autoAcceptPrice.</param>
        public ProductAddBestOffer(decimal minimumOfferPrice = default(decimal), decimal autoAcceptPrice = default(decimal))
        {
            this.MinimumOfferPrice = minimumOfferPrice;
            this.AutoAcceptPrice = autoAcceptPrice;
        }

        /// <summary>
        /// Gets or Sets MinimumOfferPrice
        /// </summary>
        [DataMember(Name = "minimum_offer_price", EmitDefaultValue = false)]
        public decimal MinimumOfferPrice { get; set; }

        /// <summary>
        /// Gets or Sets AutoAcceptPrice
        /// </summary>
        [DataMember(Name = "auto_accept_price", EmitDefaultValue = false)]
        public decimal AutoAcceptPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAddBestOffer {\n");
            sb.Append("  MinimumOfferPrice: ").Append(MinimumOfferPrice).Append("\n");
            sb.Append("  AutoAcceptPrice: ").Append(AutoAcceptPrice).Append("\n");
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
