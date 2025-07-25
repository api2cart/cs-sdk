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
    /// ModelResponseOrderStatusList
    /// </summary>
    [DataContract(Name = "Model_Response_Order_Status_List")]
    public partial class ModelResponseOrderStatusList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseOrderStatusList" /> class.
        /// </summary>
        /// <param name="returnCode">returnCode.</param>
        /// <param name="returnMessage">returnMessage.</param>
        /// <param name="pagination">pagination.</param>
        /// <param name="result">result.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public ModelResponseOrderStatusList(int? returnCode = default(int?), string returnMessage = default(string), Pagination pagination = default(Pagination), ResponseOrderStatusListResult result = default(ResponseOrderStatusListResult), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.ReturnCode = returnCode;
            this.ReturnMessage = returnMessage;
            this.Pagination = pagination;
            this.Result = result;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets ReturnCode
        /// </summary>
        [DataMember(Name = "return_code", EmitDefaultValue = true)]
        public int? ReturnCode { get; set; }

        /// <summary>
        /// Gets or Sets ReturnMessage
        /// </summary>
        [DataMember(Name = "return_message", EmitDefaultValue = true)]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = true)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public ResponseOrderStatusListResult Result { get; set; }

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
            sb.Append("class ModelResponseOrderStatusList {\n");
            sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  ReturnMessage: ").Append(ReturnMessage).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
