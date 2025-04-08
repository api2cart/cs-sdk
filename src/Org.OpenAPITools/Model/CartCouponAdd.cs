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
    /// CartCouponAdd
    /// </summary>
    [DataContract(Name = "CartCouponAdd")]
    public partial class CartCouponAdd : IValidatableObject
    {
        /// <summary>
        /// Coupon discount type
        /// </summary>
        /// <value>Coupon discount type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Enum Percent for value: percent
            /// </summary>
            [EnumMember(Value = "percent")]
            Percent = 1,

            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 2
        }


        /// <summary>
        /// Coupon discount type
        /// </summary>
        /// <value>Coupon discount type</value>
        /*
        <example>percent</example>
        */
        [DataMember(Name = "action_type", IsRequired = true, EmitDefaultValue = true)]
        public ActionTypeEnum ActionType { get; set; }
        /// <summary>
        /// Defines where discount should be applied
        /// </summary>
        /// <value>Defines where discount should be applied</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionApplyToEnum
        {
            /// <summary>
            /// Enum OrderTotal for value: order_total
            /// </summary>
            [EnumMember(Value = "order_total")]
            OrderTotal = 1,

            /// <summary>
            /// Enum ItemPrice for value: item_price
            /// </summary>
            [EnumMember(Value = "item_price")]
            ItemPrice = 2,

            /// <summary>
            /// Enum Shipping for value: shipping
            /// </summary>
            [EnumMember(Value = "shipping")]
            Shipping = 3
        }


        /// <summary>
        /// Defines where discount should be applied
        /// </summary>
        /// <value>Defines where discount should be applied</value>
        /*
        <example>order_total</example>
        */
        [DataMember(Name = "action_apply_to", IsRequired = true, EmitDefaultValue = true)]
        public ActionApplyToEnum ActionApplyTo { get; set; }
        /// <summary>
        /// Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once.
        /// </summary>
        /// <value>Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionScopeEnum
        {
            /// <summary>
            /// Enum Order for value: order
            /// </summary>
            [EnumMember(Value = "order")]
            Order = 1,

            /// <summary>
            /// Enum MatchingItems for value: matching_items
            /// </summary>
            [EnumMember(Value = "matching_items")]
            MatchingItems = 2
        }


        /// <summary>
        /// Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once.
        /// </summary>
        /// <value>Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once.</value>
        /*
        <example>matching_items</example>
        */
        [DataMember(Name = "action_scope", IsRequired = true, EmitDefaultValue = true)]
        public ActionScopeEnum ActionScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCouponAdd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CartCouponAdd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCouponAdd" /> class.
        /// </summary>
        /// <param name="storeId">Store Id.</param>
        /// <param name="code">Coupon code (required).</param>
        /// <param name="name">Coupon name.</param>
        /// <param name="codes">Entity codes.</param>
        /// <param name="actionType">Coupon discount type (required).</param>
        /// <param name="actionApplyTo">Defines where discount should be applied (required).</param>
        /// <param name="actionScope">Specify how discount should be applied. If scope&#x3D;matching_items, then discount will be applied to each of the items that match action conditions. Scope order means that discount will be applied once. (required).</param>
        /// <param name="actionAmount">Defines the discount amount value. (required).</param>
        /// <param name="dateStart">Date start (default to &quot;now&quot;).</param>
        /// <param name="dateEnd">Defines when discount code will be expired..</param>
        /// <param name="usageLimit">Usage limit for coupon..</param>
        /// <param name="usageLimitPerCustomer">Usage limit per customer..</param>
        /// <param name="actionConditionEntity">Defines entity for action condition..</param>
        /// <param name="actionConditionKey">Defines entity attribute code for action condition..</param>
        /// <param name="actionConditionOperator">Defines condition operator..</param>
        /// <param name="actionConditionValue">Defines condition attribute value/s. Can be comma separated string..</param>
        /// <param name="includeTax">Indicates whether to apply a discount for taxes. (default to false).</param>
        public CartCouponAdd(string storeId = default(string), string code = default(string), string name = default(string), List<string> codes = default(List<string>), ActionTypeEnum actionType = default(ActionTypeEnum), ActionApplyToEnum actionApplyTo = default(ActionApplyToEnum), ActionScopeEnum actionScope = default(ActionScopeEnum), decimal actionAmount = default(decimal), string dateStart = @"now", string dateEnd = default(string), int usageLimit = default(int), int usageLimitPerCustomer = default(int), string actionConditionEntity = default(string), string actionConditionKey = default(string), string actionConditionOperator = default(string), string actionConditionValue = default(string), bool includeTax = false)
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for CartCouponAdd and cannot be null");
            }
            this.Code = code;
            this.ActionType = actionType;
            this.ActionApplyTo = actionApplyTo;
            this.ActionScope = actionScope;
            this.ActionAmount = actionAmount;
            this.StoreId = storeId;
            this.Name = name;
            this.Codes = codes;
            // use default value if no "dateStart" provided
            this.DateStart = dateStart ?? @"now";
            this.DateEnd = dateEnd;
            this.UsageLimit = usageLimit;
            this.UsageLimitPerCustomer = usageLimitPerCustomer;
            this.ActionConditionEntity = actionConditionEntity;
            this.ActionConditionKey = actionConditionKey;
            this.ActionConditionOperator = actionConditionOperator;
            this.ActionConditionValue = actionConditionValue;
            this.IncludeTax = includeTax;
        }

        /// <summary>
        /// Store Id
        /// </summary>
        /// <value>Store Id</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Coupon code
        /// </summary>
        /// <value>Coupon code</value>
        /*
        <example>000_BIG_SALE_000</example>
        */
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Coupon name
        /// </summary>
        /// <value>Coupon name</value>
        /*
        <example>Sale! -30%</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Entity codes
        /// </summary>
        /// <value>Entity codes</value>
        /*
        <example>codes[0]&#x3D;000_BIG_SALE_000&amp;codes[1]&#x3D;000_BIG_SALE_001&amp;codes[2]&#x3D;000_BIG_SALE_002</example>
        */
        [DataMember(Name = "codes", EmitDefaultValue = false)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Defines the discount amount value.
        /// </summary>
        /// <value>Defines the discount amount value.</value>
        /*
        <example>15.5</example>
        */
        [DataMember(Name = "action_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal ActionAmount { get; set; }

        /// <summary>
        /// Date start
        /// </summary>
        /// <value>Date start</value>
        /*
        <example>2019-12-29 06:44:30</example>
        */
        [DataMember(Name = "date_start", EmitDefaultValue = false)]
        public string DateStart { get; set; }

        /// <summary>
        /// Defines when discount code will be expired.
        /// </summary>
        /// <value>Defines when discount code will be expired.</value>
        /*
        <example>2020-01-05 01:00:00</example>
        */
        [DataMember(Name = "date_end", EmitDefaultValue = false)]
        public string DateEnd { get; set; }

        /// <summary>
        /// Usage limit for coupon.
        /// </summary>
        /// <value>Usage limit for coupon.</value>
        /*
        <example>99</example>
        */
        [DataMember(Name = "usage_limit", EmitDefaultValue = false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// Usage limit per customer.
        /// </summary>
        /// <value>Usage limit per customer.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "usage_limit_per_customer", EmitDefaultValue = false)]
        public int UsageLimitPerCustomer { get; set; }

        /// <summary>
        /// Defines entity for action condition.
        /// </summary>
        /// <value>Defines entity for action condition.</value>
        /*
        <example>order</example>
        */
        [DataMember(Name = "action_condition_entity", EmitDefaultValue = false)]
        public string ActionConditionEntity { get; set; }

        /// <summary>
        /// Defines entity attribute code for action condition.
        /// </summary>
        /// <value>Defines entity attribute code for action condition.</value>
        /*
        <example>product_id</example>
        */
        [DataMember(Name = "action_condition_key", EmitDefaultValue = false)]
        public string ActionConditionKey { get; set; }

        /// <summary>
        /// Defines condition operator.
        /// </summary>
        /// <value>Defines condition operator.</value>
        /*
        <example>ONE_OF</example>
        */
        [DataMember(Name = "action_condition_operator", EmitDefaultValue = false)]
        public string ActionConditionOperator { get; set; }

        /// <summary>
        /// Defines condition attribute value/s. Can be comma separated string.
        /// </summary>
        /// <value>Defines condition attribute value/s. Can be comma separated string.</value>
        /*
        <example>17834222,45466663</example>
        */
        [DataMember(Name = "action_condition_value", EmitDefaultValue = false)]
        public string ActionConditionValue { get; set; }

        /// <summary>
        /// Indicates whether to apply a discount for taxes.
        /// </summary>
        /// <value>Indicates whether to apply a discount for taxes.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "include_tax", EmitDefaultValue = true)]
        public bool IncludeTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartCouponAdd {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  ActionApplyTo: ").Append(ActionApplyTo).Append("\n");
            sb.Append("  ActionScope: ").Append(ActionScope).Append("\n");
            sb.Append("  ActionAmount: ").Append(ActionAmount).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  UsageLimitPerCustomer: ").Append(UsageLimitPerCustomer).Append("\n");
            sb.Append("  ActionConditionEntity: ").Append(ActionConditionEntity).Append("\n");
            sb.Append("  ActionConditionKey: ").Append(ActionConditionKey).Append("\n");
            sb.Append("  ActionConditionOperator: ").Append(ActionConditionOperator).Append("\n");
            sb.Append("  ActionConditionValue: ").Append(ActionConditionValue).Append("\n");
            sb.Append("  IncludeTax: ").Append(IncludeTax).Append("\n");
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
