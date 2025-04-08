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
    /// AccountFailedWebhooks200ResponseResult
    /// </summary>
    [DataContract(Name = "AccountFailedWebhooks_200_response_result")]
    public partial class AccountFailedWebhooks200ResponseResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountFailedWebhooks200ResponseResult" /> class.
        /// </summary>
        /// <param name="allFailedWebhook">allFailedWebhook.</param>
        /// <param name="webhook">webhook.</param>
        public AccountFailedWebhooks200ResponseResult(string allFailedWebhook = default(string), List<AccountFailedWebhooks200ResponseResultWebhookInner> webhook = default(List<AccountFailedWebhooks200ResponseResultWebhookInner>))
        {
            this.AllFailedWebhook = allFailedWebhook;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or Sets AllFailedWebhook
        /// </summary>
        [DataMember(Name = "all_failed_webhook", EmitDefaultValue = false)]
        public string AllFailedWebhook { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public List<AccountFailedWebhooks200ResponseResultWebhookInner> Webhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountFailedWebhooks200ResponseResult {\n");
            sb.Append("  AllFailedWebhook: ").Append(AllFailedWebhook).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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
