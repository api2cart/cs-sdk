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
    /// CustomerAddressAdd
    /// </summary>
    [DataContract(Name = "CustomerAddressAdd")]
    public partial class CustomerAddressAdd : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressAdd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerAddressAdd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressAdd" /> class.
        /// </summary>
        /// <param name="customerId">Defines customer id (required).</param>
        /// <param name="storeId">Store Id.</param>
        /// <param name="firstName">Defines customer&#39;s address first name.</param>
        /// <param name="lastName">Defines customer&#39;s address last name.</param>
        /// <param name="company">Defines customer&#39;s address company.</param>
        /// <param name="address1">Specifies customer&#39;s address address1 (required).</param>
        /// <param name="address2">Specifies customer&#39;s address address2.</param>
        /// <param name="city">Specifies customer&#39;s address city (required).</param>
        /// <param name="country">Specifies customer&#39;s address ISO code or name of country (required).</param>
        /// <param name="state">Specifies customer&#39;s address ISO code or name of state.</param>
        /// <param name="postcode">Specifies customer&#39;s address postcode (required).</param>
        /// <param name="identificationNumber">Specifies the national ID card number of this person, or a unique tax identification number for customer&#39;s address.</param>
        /// <param name="types">Specifies customer&#39;s address types.</param>
        /// <param name="varDefault">Specifies whether the customer&#39;s address is used by default.</param>
        /// <param name="phone">Defines customer&#39;s address phone number.</param>
        /// <param name="phoneMobile">Defines customer&#39;s address mobile phone number.</param>
        /// <param name="fax">Defines customer&#39;s address fax.</param>
        /// <param name="website">Defines Link to customer&#39;s address website.</param>
        /// <param name="gender">Defines customer&#39;s address gender.</param>
        /// <param name="taxId">Add Tax Id.</param>
        /// <param name="alias">Specifies customer&#39;s alias in the address book.</param>
        public CustomerAddressAdd(string customerId = default(string), string storeId = default(string), string firstName = default(string), string lastName = default(string), string company = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string country = default(string), string state = default(string), string postcode = default(string), string identificationNumber = default(string), List<string> types = default(List<string>), bool varDefault = default(bool), string phone = default(string), string phoneMobile = default(string), string fax = default(string), string website = default(string), string gender = default(string), string taxId = default(string), string alias = default(string))
        {
            // to ensure "customerId" is required (not null)
            if (customerId == null)
            {
                throw new ArgumentNullException("customerId is a required property for CustomerAddressAdd and cannot be null");
            }
            this.CustomerId = customerId;
            // to ensure "address1" is required (not null)
            if (address1 == null)
            {
                throw new ArgumentNullException("address1 is a required property for CustomerAddressAdd and cannot be null");
            }
            this.Address1 = address1;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for CustomerAddressAdd and cannot be null");
            }
            this.City = city;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for CustomerAddressAdd and cannot be null");
            }
            this.Country = country;
            // to ensure "postcode" is required (not null)
            if (postcode == null)
            {
                throw new ArgumentNullException("postcode is a required property for CustomerAddressAdd and cannot be null");
            }
            this.Postcode = postcode;
            this.StoreId = storeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.Address2 = address2;
            this.State = state;
            this.IdentificationNumber = identificationNumber;
            this.Types = types;
            this.Default = varDefault;
            this.Phone = phone;
            this.PhoneMobile = phoneMobile;
            this.Fax = fax;
            this.Website = website;
            this.Gender = gender;
            this.TaxId = taxId;
            this.Alias = alias;
        }

        /// <summary>
        /// Defines customer id
        /// </summary>
        /// <value>Defines customer id</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerId { get; set; }

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
        /// Defines customer&#39;s address first name
        /// </summary>
        /// <value>Defines customer&#39;s address first name</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Defines customer&#39;s address last name
        /// </summary>
        /// <value>Defines customer&#39;s address last name</value>
        /*
        <example>Smith</example>
        */
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Defines customer&#39;s address company
        /// </summary>
        /// <value>Defines customer&#39;s address company</value>
        /*
        <example>Apple</example>
        */
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address address1
        /// </summary>
        /// <value>Specifies customer&#39;s address address1</value>
        /*
        <example>Green str. 35</example>
        */
        [DataMember(Name = "address1", IsRequired = true, EmitDefaultValue = true)]
        public string Address1 { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address address2
        /// </summary>
        /// <value>Specifies customer&#39;s address address2</value>
        /*
        <example>Green str. 35</example>
        */
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address city
        /// </summary>
        /// <value>Specifies customer&#39;s address city</value>
        /*
        <example>Chicago</example>
        */
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address ISO code or name of country
        /// </summary>
        /// <value>Specifies customer&#39;s address ISO code or name of country</value>
        /*
        <example>US</example>
        */
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address ISO code or name of state
        /// </summary>
        /// <value>Specifies customer&#39;s address ISO code or name of state</value>
        /*
        <example>IL</example>
        */
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address postcode
        /// </summary>
        /// <value>Specifies customer&#39;s address postcode</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "postcode", IsRequired = true, EmitDefaultValue = true)]
        public string Postcode { get; set; }

        /// <summary>
        /// Specifies the national ID card number of this person, or a unique tax identification number for customer&#39;s address
        /// </summary>
        /// <value>Specifies the national ID card number of this person, or a unique tax identification number for customer&#39;s address</value>
        /*
        <example>&#x60;123-456-7890&#x60;</example>
        */
        [DataMember(Name = "identification_number", EmitDefaultValue = false)]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Specifies customer&#39;s address types
        /// </summary>
        /// <value>Specifies customer&#39;s address types</value>
        /*
        <example>types[0]&#x3D;billing&amp;types[1]&#x3D;shipping</example>
        */
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Specifies whether the customer&#39;s address is used by default
        /// </summary>
        /// <value>Specifies whether the customer&#39;s address is used by default</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Defines customer&#39;s address phone number
        /// </summary>
        /// <value>Defines customer&#39;s address phone number</value>
        /*
        <example>56686868654</example>
        */
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Defines customer&#39;s address mobile phone number
        /// </summary>
        /// <value>Defines customer&#39;s address mobile phone number</value>
        /*
        <example>56686868654</example>
        */
        [DataMember(Name = "phone_mobile", EmitDefaultValue = false)]
        public string PhoneMobile { get; set; }

        /// <summary>
        /// Defines customer&#39;s address fax
        /// </summary>
        /// <value>Defines customer&#39;s address fax</value>
        /*
        <example>54545787</example>
        */
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Defines Link to customer&#39;s address website
        /// </summary>
        /// <value>Defines Link to customer&#39;s address website</value>
        /*
        <example>http://api2cart.com</example>
        */
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// Defines customer&#39;s address gender
        /// </summary>
        /// <value>Defines customer&#39;s address gender</value>
        /*
        <example>male</example>
        */
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Add Tax Id
        /// </summary>
        /// <value>Add Tax Id</value>
        /*
        <example>&#x60;12345678&#x60;</example>
        */
        [DataMember(Name = "tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Specifies customer&#39;s alias in the address book
        /// </summary>
        /// <value>Specifies customer&#39;s alias in the address book</value>
        /*
        <example>Address alias</example>
        */
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerAddressAdd {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  IdentificationNumber: ").Append(IdentificationNumber).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneMobile: ").Append(PhoneMobile).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
