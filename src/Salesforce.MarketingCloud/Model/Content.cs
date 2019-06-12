/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Salesforce.MarketingCloud.Client.SwaggerDateConverter;

namespace Salesforce.MarketingCloud.Model
{
    /// <summary>
    /// Content
    /// </summary>
    [DataContract]
    public partial class Content :  IEquatable<Content>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Content() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="customerKey">Unique identifier of the content asset. (required).</param>
        public Content(string customerKey = default(string))
        {
            // to ensure "customerKey" is required (not null)
            if (customerKey == null)
            {
                throw new InvalidDataException("customerKey is a required property for Content and cannot be null");
            }
            else
            {
                this.CustomerKey = customerKey;
            }
        }
        
        /// <summary>
        /// Unique identifier of the content asset.
        /// </summary>
        /// <value>Unique identifier of the content asset.</value>
        [DataMember(Name="customerKey", EmitDefaultValue=false)]
        public string CustomerKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Content {\n");
            sb.Append("  CustomerKey: ").Append(CustomerKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Content);
        }

        /// <summary>
        /// Returns true if Content instances are equal
        /// </summary>
        /// <param name="input">Instance of Content to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Content input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerKey == input.CustomerKey ||
                    (this.CustomerKey != null &&
                    this.CustomerKey.Equals(input.CustomerKey))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CustomerKey != null)
                    hashCode = hashCode * 59 + this.CustomerKey.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
