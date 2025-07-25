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
    /// OrderTransaction
    /// </summary>
    [DataContract(Name = "Order_Transaction")]
    public partial class OrderTransaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTransaction" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="referenceNumber">referenceNumber.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="settlementCurrency">settlementCurrency.</param>
        /// <param name="settlementAmount">settlementAmount.</param>
        /// <param name="settlementCreatedTime">settlementCreatedTime.</param>
        /// <param name="cardBrand">cardBrand.</param>
        /// <param name="cardBin">cardBin.</param>
        /// <param name="cardLastFour">cardLastFour.</param>
        /// <param name="avsStreetRespCode">avsStreetRespCode.</param>
        /// <param name="avsPostalRespCode">avsPostalRespCode.</param>
        /// <param name="avsMessage">avsMessage.</param>
        /// <param name="cvvCode">cvvCode.</param>
        /// <param name="cvvMessage">cvvMessage.</param>
        /// <param name="isTestMode">isTestMode.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public OrderTransaction(string id = default(string), string transactionId = default(string), string orderId = default(string), string parentId = default(string), string description = default(string), string status = default(string), string gateway = default(string), string referenceNumber = default(string), string currency = default(string), decimal? amount = default(decimal?), A2CDateTime createdTime = default(A2CDateTime), string settlementCurrency = default(string), decimal? settlementAmount = default(decimal?), A2CDateTime settlementCreatedTime = default(A2CDateTime), string cardBrand = default(string), string cardBin = default(string), string cardLastFour = default(string), string avsStreetRespCode = default(string), string avsPostalRespCode = default(string), string avsMessage = default(string), string cvvCode = default(string), string cvvMessage = default(string), bool? isTestMode = default(bool?), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.TransactionId = transactionId;
            this.OrderId = orderId;
            this.ParentId = parentId;
            this.Description = description;
            this.Status = status;
            this.Gateway = gateway;
            this.ReferenceNumber = referenceNumber;
            this.Currency = currency;
            this.Amount = amount;
            this.CreatedTime = createdTime;
            this.SettlementCurrency = settlementCurrency;
            this.SettlementAmount = settlementAmount;
            this.SettlementCreatedTime = settlementCreatedTime;
            this.CardBrand = cardBrand;
            this.CardBin = cardBin;
            this.CardLastFour = cardLastFour;
            this.AvsStreetRespCode = avsStreetRespCode;
            this.AvsPostalRespCode = avsPostalRespCode;
            this.AvsMessage = avsMessage;
            this.CvvCode = cvvCode;
            this.CvvMessage = cvvMessage;
            this.IsTestMode = isTestMode;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transaction_id", EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Gateway
        /// </summary>
        [DataMember(Name = "gateway", EmitDefaultValue = true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "reference_number", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time", EmitDefaultValue = true)]
        public A2CDateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets SettlementCurrency
        /// </summary>
        [DataMember(Name = "settlement_currency", EmitDefaultValue = true)]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Gets or Sets SettlementAmount
        /// </summary>
        [DataMember(Name = "settlement_amount", EmitDefaultValue = true)]
        public decimal? SettlementAmount { get; set; }

        /// <summary>
        /// Gets or Sets SettlementCreatedTime
        /// </summary>
        [DataMember(Name = "settlement_created_time", EmitDefaultValue = true)]
        public A2CDateTime SettlementCreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets CardBrand
        /// </summary>
        [DataMember(Name = "card_brand", EmitDefaultValue = true)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Gets or Sets CardBin
        /// </summary>
        [DataMember(Name = "card_bin", EmitDefaultValue = true)]
        public string CardBin { get; set; }

        /// <summary>
        /// Gets or Sets CardLastFour
        /// </summary>
        [DataMember(Name = "card_last_four", EmitDefaultValue = true)]
        public string CardLastFour { get; set; }

        /// <summary>
        /// Gets or Sets AvsStreetRespCode
        /// </summary>
        [DataMember(Name = "avs_street_resp_code", EmitDefaultValue = true)]
        public string AvsStreetRespCode { get; set; }

        /// <summary>
        /// Gets or Sets AvsPostalRespCode
        /// </summary>
        [DataMember(Name = "avs_postal_resp_code", EmitDefaultValue = true)]
        public string AvsPostalRespCode { get; set; }

        /// <summary>
        /// Gets or Sets AvsMessage
        /// </summary>
        [DataMember(Name = "avs_message", EmitDefaultValue = true)]
        public string AvsMessage { get; set; }

        /// <summary>
        /// Gets or Sets CvvCode
        /// </summary>
        [DataMember(Name = "cvv_code", EmitDefaultValue = true)]
        public string CvvCode { get; set; }

        /// <summary>
        /// Gets or Sets CvvMessage
        /// </summary>
        [DataMember(Name = "cvv_message", EmitDefaultValue = true)]
        public string CvvMessage { get; set; }

        /// <summary>
        /// Gets or Sets IsTestMode
        /// </summary>
        [DataMember(Name = "is_test_mode", EmitDefaultValue = true)]
        public bool? IsTestMode { get; set; }

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
            sb.Append("class OrderTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  SettlementAmount: ").Append(SettlementAmount).Append("\n");
            sb.Append("  SettlementCreatedTime: ").Append(SettlementCreatedTime).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  CardBin: ").Append(CardBin).Append("\n");
            sb.Append("  CardLastFour: ").Append(CardLastFour).Append("\n");
            sb.Append("  AvsStreetRespCode: ").Append(AvsStreetRespCode).Append("\n");
            sb.Append("  AvsPostalRespCode: ").Append(AvsPostalRespCode).Append("\n");
            sb.Append("  AvsMessage: ").Append(AvsMessage).Append("\n");
            sb.Append("  CvvCode: ").Append(CvvCode).Append("\n");
            sb.Append("  CvvMessage: ").Append(CvvMessage).Append("\n");
            sb.Append("  IsTestMode: ").Append(IsTestMode).Append("\n");
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
