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
    /// RequestCreateSmsDefinitionSubscriptions
    /// </summary>
    [DataContract]
    public partial class RequestCreateSmsDefinitionSubscriptions :  IEquatable<RequestCreateSmsDefinitionSubscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreateSmsDefinitionSubscriptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestCreateSmsDefinitionSubscriptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreateSmsDefinitionSubscriptions" /> class.
        /// </summary>
        /// <param name="shortCode">The short code for the mobile transmissions for each message on this definition. (required).</param>
        /// <param name="countryCode">The country code associated with the shortCode for the mobile transmissions for each message on this definition. (required).</param>
        /// <param name="keyword">The keyword used to track messages..</param>
        /// <param name="autoAddSubscriber">Permits adding a recipient as subscriber against the shortCode using contactKey. When false, the message is rejected if contactKey does not exist as a subscriber. Default is true. (default to true).</param>
        public RequestCreateSmsDefinitionSubscriptions(string shortCode = default(string), string countryCode = default(string), string keyword = default(string), bool? autoAddSubscriber = true)
        {
            // to ensure "shortCode" is required (not null)
            if (shortCode == null)
            {
                throw new InvalidDataException("shortCode is a required property for RequestCreateSmsDefinitionSubscriptions and cannot be null");
            }
            else
            {
                this.ShortCode = shortCode;
            }
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for RequestCreateSmsDefinitionSubscriptions and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }
            this.Keyword = keyword;
            // use default value if no "autoAddSubscriber" provided
            if (autoAddSubscriber == null)
            {
                this.AutoAddSubscriber = true;
            }
            else
            {
                this.AutoAddSubscriber = autoAddSubscriber;
            }
        }
        
        /// <summary>
        /// The short code for the mobile transmissions for each message on this definition.
        /// </summary>
        /// <value>The short code for the mobile transmissions for each message on this definition.</value>
        [DataMember(Name="shortCode", EmitDefaultValue=false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// The country code associated with the shortCode for the mobile transmissions for each message on this definition.
        /// </summary>
        /// <value>The country code associated with the shortCode for the mobile transmissions for each message on this definition.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The keyword used to track messages.
        /// </summary>
        /// <value>The keyword used to track messages.</value>
        [DataMember(Name="keyword", EmitDefaultValue=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// Permits adding a recipient as subscriber against the shortCode using contactKey. When false, the message is rejected if contactKey does not exist as a subscriber. Default is true.
        /// </summary>
        /// <value>Permits adding a recipient as subscriber against the shortCode using contactKey. When false, the message is rejected if contactKey does not exist as a subscriber. Default is true.</value>
        [DataMember(Name="autoAddSubscriber", EmitDefaultValue=false)]
        public bool? AutoAddSubscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestCreateSmsDefinitionSubscriptions {\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  AutoAddSubscriber: ").Append(AutoAddSubscriber).Append("\n");
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
            return this.Equals(input as RequestCreateSmsDefinitionSubscriptions);
        }

        /// <summary>
        /// Returns true if RequestCreateSmsDefinitionSubscriptions instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestCreateSmsDefinitionSubscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestCreateSmsDefinitionSubscriptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.AutoAddSubscriber == input.AutoAddSubscriber ||
                    (this.AutoAddSubscriber != null &&
                    this.AutoAddSubscriber.Equals(input.AutoAddSubscriber))
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
                if (this.ShortCode != null)
                    hashCode = hashCode * 59 + this.ShortCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Keyword != null)
                    hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.AutoAddSubscriber != null)
                    hashCode = hashCode * 59 + this.AutoAddSubscriber.GetHashCode();
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
