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
    /// Shipment
    /// </summary>
    [DataContract(Name = "Shipment")]
    public partial class Shipment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="name">name.</param>
        /// <param name="warehouseId">warehouseId.</param>
        /// <param name="shipmentProvider">shipmentProvider.</param>
        /// <param name="trackingNumbers">trackingNumbers.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedTime">modifiedTime.</param>
        /// <param name="items">items.</param>
        /// <param name="isShipped">isShipped.</param>
        /// <param name="deliveredAt">deliveredAt.</param>
        /// <param name="additionalFields">additionalFields.</param>
        /// <param name="customFields">customFields.</param>
        public Shipment(string id = default(string), string orderId = default(string), string name = default(string), string warehouseId = default(string), string shipmentProvider = default(string), List<ShipmentTrackingNumber> trackingNumbers = default(List<ShipmentTrackingNumber>), A2CDateTime createdAt = default(A2CDateTime), A2CDateTime modifiedTime = default(A2CDateTime), List<ShipmentItem> items = default(List<ShipmentItem>), bool? isShipped = default(bool?), A2CDateTime deliveredAt = default(A2CDateTime), Object additionalFields = default(Object), Object customFields = default(Object))
        {
            this.Id = id;
            this.OrderId = orderId;
            this.Name = name;
            this.WarehouseId = warehouseId;
            this.ShipmentProvider = shipmentProvider;
            this.TrackingNumbers = trackingNumbers;
            this.CreatedAt = createdAt;
            this.ModifiedTime = modifiedTime;
            this.Items = items;
            this.IsShipped = isShipped;
            this.DeliveredAt = deliveredAt;
            this.AdditionalFields = additionalFields;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name = "warehouse_id", EmitDefaultValue = true)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentProvider
        /// </summary>
        [DataMember(Name = "shipment_provider", EmitDefaultValue = true)]
        public string ShipmentProvider { get; set; }

        /// <summary>
        /// Gets or Sets TrackingNumbers
        /// </summary>
        [DataMember(Name = "tracking_numbers", EmitDefaultValue = false)]
        public List<ShipmentTrackingNumber> TrackingNumbers { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public A2CDateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedTime
        /// </summary>
        [DataMember(Name = "modified_time", EmitDefaultValue = true)]
        public A2CDateTime ModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<ShipmentItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets IsShipped
        /// </summary>
        [DataMember(Name = "is_shipped", EmitDefaultValue = true)]
        public bool? IsShipped { get; set; }

        /// <summary>
        /// Gets or Sets DeliveredAt
        /// </summary>
        [DataMember(Name = "delivered_at", EmitDefaultValue = true)]
        public A2CDateTime DeliveredAt { get; set; }

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
            sb.Append("class Shipment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  ShipmentProvider: ").Append(ShipmentProvider).Append("\n");
            sb.Append("  TrackingNumbers: ").Append(TrackingNumbers).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  IsShipped: ").Append(IsShipped).Append("\n");
            sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
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
