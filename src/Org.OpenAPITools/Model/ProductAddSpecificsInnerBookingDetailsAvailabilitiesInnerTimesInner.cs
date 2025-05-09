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
    /// ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner
    /// </summary>
    [DataContract(Name = "ProductAdd_specifics_inner_booking_details_availabilities_inner_times_inner")]
    public partial class ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner" /> class.
        /// </summary>
        /// <param name="from">The starting time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt; (required).</param>
        /// <param name="to">The ending time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt; (required).</param>
        public ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner(string from = default(string), string to = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner and cannot be null");
            }
            this.To = to;
        }

        /// <summary>
        /// The starting time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt;
        /// </summary>
        /// <value>The starting time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt;</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// The ending time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt;
        /// </summary>
        /// <value>The ending time of the of available booking slot in 24 hours format. Required if &lt;code&gt;type&#x3D;date_time&lt;/code&gt;</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            if (this.From != null) {
                // From (string) pattern
                Regex regexFrom = new Regex(@"^(?:[01]\d|2[0-3]):[0-5]\d$", RegexOptions.CultureInvariant);
                if (!regexFrom.Match(this.From).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, must match a pattern of " + regexFrom, new [] { "From" });
                }
            }

            if (this.To != null) {
                // To (string) pattern
                Regex regexTo = new Regex(@"^(?:[01]\d|2[0-3]):[0-5]\d$", RegexOptions.CultureInvariant);
                if (!regexTo.Match(this.To).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, must match a pattern of " + regexTo, new [] { "To" });
                }
            }

            yield break;
        }
    }

}
