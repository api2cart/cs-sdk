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
    /// WebhookEvents200ResponseResultEventsInner
    /// </summary>
    [DataContract(Name = "WebhookEvents_200_response_result_events_inner")]
    public partial class WebhookEvents200ResponseResultEventsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvents200ResponseResultEventsInner" /> class.
        /// </summary>
        /// <param name="webhookName">webhookName.</param>
        /// <param name="entity">entity.</param>
        /// <param name="action">action.</param>
        public WebhookEvents200ResponseResultEventsInner(string webhookName = default(string), string entity = default(string), string action = default(string))
        {
            this.WebhookName = webhookName;
            this.Entity = entity;
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets WebhookName
        /// </summary>
        [DataMember(Name = "webhook_name", EmitDefaultValue = false)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string Entity { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookEvents200ResponseResultEventsInner {\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
