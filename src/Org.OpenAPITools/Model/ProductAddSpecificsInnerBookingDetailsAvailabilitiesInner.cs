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
    /// ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner
    /// </summary>
    [DataContract(Name = "ProductAdd_specifics_inner_booking_details_availabilities_inner")]
    public partial class ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner : IValidatableObject
    {
        /// <summary>
        /// Defines Day
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayEnum
        {
            /// <summary>
            /// Enum Sunday for value: sunday
            /// </summary>
            [EnumMember(Value = "sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: monday
            /// </summary>
            [EnumMember(Value = "monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: tuesday
            /// </summary>
            [EnumMember(Value = "tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: wednesday
            /// </summary>
            [EnumMember(Value = "wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: thursday
            /// </summary>
            [EnumMember(Value = "thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: friday
            /// </summary>
            [EnumMember(Value = "friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: saturday
            /// </summary>
            [EnumMember(Value = "saturday")]
            Saturday = 7
        }


        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", IsRequired = true, EmitDefaultValue = true)]
        public DayEnum Day { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner" /> class.
        /// </summary>
        /// <param name="day">day (required).</param>
        /// <param name="isAvailable">isAvailable (default to true).</param>
        /// <param name="times">times.</param>
        public ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner(DayEnum day = default(DayEnum), bool isAvailable = true, List<ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner> times = default(List<ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner>))
        {
            this.Day = day;
            this.IsAvailable = isAvailable;
            this.Times = times;
        }

        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name = "is_available", EmitDefaultValue = true)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Times
        /// </summary>
        [DataMember(Name = "times", EmitDefaultValue = false)]
        public List<ProductAddSpecificsInnerBookingDetailsAvailabilitiesInnerTimesInner> Times { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductAddSpecificsInnerBookingDetailsAvailabilitiesInner {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
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
