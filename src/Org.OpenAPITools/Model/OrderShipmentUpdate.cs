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
    /// OrderShipmentUpdate
    /// </summary>
    [DataContract(Name = "OrderShipmentUpdate")]
    public partial class OrderShipmentUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShipmentUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderShipmentUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderShipmentUpdate" /> class.
        /// </summary>
        /// <param name="shipmentId">Shipment id indicates the number of delivery (required).</param>
        /// <param name="orderId">Defines the order that will be updated.</param>
        /// <param name="storeId">Store Id.</param>
        /// <param name="shipmentProvider">Defines company name that provide tracking of shipment.</param>
        /// <param name="trackingNumbers">Defines shipment&#39;s tracking numbers that have to be added&lt;/br&gt; How set tracking numbers to appropriate carrier:&lt;ul&gt;&lt;li&gt;tracking_numbers[]&#x3D;a2c.demo1,a2c.demo2 - set default carrier&lt;/li&gt;&lt;li&gt;tracking_numbers[&lt;b&gt;carrier_id&lt;/b&gt;]&#x3D;a2c.demo - set appropriate carrier&lt;/li&gt;&lt;/ul&gt;To get the list of carriers IDs that are available in your store, use the &lt;a href &#x3D; \&quot;https://api2cart.com/docs/#/cart/CartInfo\&quot;&gt;cart.info&lt;/a &gt; method.</param>
        /// <param name="trackingLink">Defines custom tracking link.</param>
        /// <param name="isShipped">Defines shipment&#39;s status (default to true).</param>
        /// <param name="deliveredAt">Defines the date of delivery.</param>
        /// <param name="replace">Allows rewrite tracking numbers (default to true).</param>
        /// <param name="sendNotifications">Send notifications to customer after order was created (default to false).</param>
        /// <param name="trackingProvider">Defines name of the company which provides shipment tracking.</param>
        /// <param name="items">Defines items in the order that will be shipped.</param>
        public OrderShipmentUpdate(string shipmentId = default(string), string orderId = default(string), string storeId = default(string), string shipmentProvider = default(string), List<OrderShipmentAddTrackingNumbersInner> trackingNumbers = default(List<OrderShipmentAddTrackingNumbersInner>), string trackingLink = default(string), bool isShipped = true, string deliveredAt = default(string), bool replace = true, bool sendNotifications = false, string trackingProvider = default(string), List<OrderShipmentAddItemsInner> items = default(List<OrderShipmentAddItemsInner>))
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new ArgumentNullException("shipmentId is a required property for OrderShipmentUpdate and cannot be null");
            }
            this.ShipmentId = shipmentId;
            this.OrderId = orderId;
            this.StoreId = storeId;
            this.ShipmentProvider = shipmentProvider;
            this.TrackingNumbers = trackingNumbers;
            this.TrackingLink = trackingLink;
            this.IsShipped = isShipped;
            this.DeliveredAt = deliveredAt;
            this.Replace = replace;
            this.SendNotifications = sendNotifications;
            this.TrackingProvider = trackingProvider;
            this.Items = items;
        }

        /// <summary>
        /// Shipment id indicates the number of delivery
        /// </summary>
        /// <value>Shipment id indicates the number of delivery</value>
        /*
        <example>200000002</example>
        */
        [DataMember(Name = "shipment_id", IsRequired = true, EmitDefaultValue = true)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Defines the order that will be updated
        /// </summary>
        /// <value>Defines the order that will be updated</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

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
        /// Defines company name that provide tracking of shipment
        /// </summary>
        /// <value>Defines company name that provide tracking of shipment</value>
        /*
        <example>UPS</example>
        */
        [DataMember(Name = "shipment_provider", EmitDefaultValue = false)]
        public string ShipmentProvider { get; set; }

        /// <summary>
        /// Defines shipment&#39;s tracking numbers that have to be added&lt;/br&gt; How set tracking numbers to appropriate carrier:&lt;ul&gt;&lt;li&gt;tracking_numbers[]&#x3D;a2c.demo1,a2c.demo2 - set default carrier&lt;/li&gt;&lt;li&gt;tracking_numbers[&lt;b&gt;carrier_id&lt;/b&gt;]&#x3D;a2c.demo - set appropriate carrier&lt;/li&gt;&lt;/ul&gt;To get the list of carriers IDs that are available in your store, use the &lt;a href &#x3D; \&quot;https://api2cart.com/docs/#/cart/CartInfo\&quot;&gt;cart.info&lt;/a &gt; method
        /// </summary>
        /// <value>Defines shipment&#39;s tracking numbers that have to be added&lt;/br&gt; How set tracking numbers to appropriate carrier:&lt;ul&gt;&lt;li&gt;tracking_numbers[]&#x3D;a2c.demo1,a2c.demo2 - set default carrier&lt;/li&gt;&lt;li&gt;tracking_numbers[&lt;b&gt;carrier_id&lt;/b&gt;]&#x3D;a2c.demo - set appropriate carrier&lt;/li&gt;&lt;/ul&gt;To get the list of carriers IDs that are available in your store, use the &lt;a href &#x3D; \&quot;https://api2cart.com/docs/#/cart/CartInfo\&quot;&gt;cart.info&lt;/a &gt; method</value>
        [DataMember(Name = "tracking_numbers", EmitDefaultValue = false)]
        public List<OrderShipmentAddTrackingNumbersInner> TrackingNumbers { get; set; }

        /// <summary>
        /// Defines custom tracking link
        /// </summary>
        /// <value>Defines custom tracking link</value>
        /*
        <example>http://example.com?someParam&#x3D;value</example>
        */
        [DataMember(Name = "tracking_link", EmitDefaultValue = false)]
        public string TrackingLink { get; set; }

        /// <summary>
        /// Defines shipment&#39;s status
        /// </summary>
        /// <value>Defines shipment&#39;s status</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "is_shipped", EmitDefaultValue = true)]
        public bool IsShipped { get; set; }

        /// <summary>
        /// Defines the date of delivery
        /// </summary>
        /// <value>Defines the date of delivery</value>
        /*
        <example>2024-08-25T23:56:12+00:00</example>
        */
        [DataMember(Name = "delivered_at", EmitDefaultValue = false)]
        public string DeliveredAt { get; set; }

        /// <summary>
        /// Allows rewrite tracking numbers
        /// </summary>
        /// <value>Allows rewrite tracking numbers</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "replace", EmitDefaultValue = true)]
        public bool Replace { get; set; }

        /// <summary>
        /// Send notifications to customer after order was created
        /// </summary>
        /// <value>Send notifications to customer after order was created</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "send_notifications", EmitDefaultValue = true)]
        public bool SendNotifications { get; set; }

        /// <summary>
        /// Defines name of the company which provides shipment tracking
        /// </summary>
        /// <value>Defines name of the company which provides shipment tracking</value>
        /*
        <example>Custom tracker</example>
        */
        [DataMember(Name = "tracking_provider", EmitDefaultValue = false)]
        public string TrackingProvider { get; set; }

        /// <summary>
        /// Defines items in the order that will be shipped
        /// </summary>
        /// <value>Defines items in the order that will be shipped</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderShipmentAddItemsInner> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderShipmentUpdate {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  ShipmentProvider: ").Append(ShipmentProvider).Append("\n");
            sb.Append("  TrackingNumbers: ").Append(TrackingNumbers).Append("\n");
            sb.Append("  TrackingLink: ").Append(TrackingLink).Append("\n");
            sb.Append("  IsShipped: ").Append(IsShipped).Append("\n");
            sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
            sb.Append("  Replace: ").Append(Replace).Append("\n");
            sb.Append("  SendNotifications: ").Append(SendNotifications).Append("\n");
            sb.Append("  TrackingProvider: ").Append(TrackingProvider).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
