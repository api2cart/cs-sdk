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
    /// OrderShipmentAdd200Response
    /// </summary>
    [DataContract(Name = "OrderShipmentAdd_200_response")]
    public partial class OrderShipmentAdd200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShipmentAdd200Response" /> class.
        /// </summary>
        /// <param name="returnCode">returnCode.</param>
        /// <param name="returnMessage">returnMessage.</param>
        /// <param name="result">result.</param>
        public OrderShipmentAdd200Response(int returnCode = default(int), string returnMessage = default(string), OrderShipmentAdd200ResponseResult result = default(OrderShipmentAdd200ResponseResult))
        {
            this.ReturnCode = returnCode;
            this.ReturnMessage = returnMessage;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets ReturnCode
        /// </summary>
        [DataMember(Name = "return_code", EmitDefaultValue = false)]
        public int ReturnCode { get; set; }

        /// <summary>
        /// Gets or Sets ReturnMessage
        /// </summary>
        [DataMember(Name = "return_message", EmitDefaultValue = false)]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public OrderShipmentAdd200ResponseResult Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderShipmentAdd200Response {\n");
            sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  ReturnMessage: ").Append(ReturnMessage).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
