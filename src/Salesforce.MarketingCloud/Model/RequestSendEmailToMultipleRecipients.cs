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
    /// RequestSendEmailToMultipleRecipients
    /// </summary>
    [DataContract]
    public partial class RequestSendEmailToMultipleRecipients :  IEquatable<RequestSendEmailToMultipleRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendEmailToMultipleRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestSendEmailToMultipleRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSendEmailToMultipleRecipients" /> class.
        /// </summary>
        /// <param name="definitionKey">Unique, user-generated key to access the definition object. (required).</param>
        /// <param name="recipients">Array of recipient objects that contain parameters and metadata for the recipients, such as send tracking and personalization attributes. Use this parameter to send to multiple recipients in one request. Use either the recipient or recipients parameter, but not both. (required).</param>
        /// <param name="attributes">attributes.</param>
        public RequestSendEmailToMultipleRecipients(string definitionKey = default(string), List<Recipient> recipients = default(List<Recipient>), Attributes attributes = default(Attributes))
        {
            // to ensure "definitionKey" is required (not null)
            if (definitionKey == null)
            {
                throw new InvalidDataException("definitionKey is a required property for RequestSendEmailToMultipleRecipients and cannot be null");
            }
            else
            {
                this.DefinitionKey = definitionKey;
            }
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for RequestSendEmailToMultipleRecipients and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// Unique, user-generated key to access the definition object.
        /// </summary>
        /// <value>Unique, user-generated key to access the definition object.</value>
        [DataMember(Name="definitionKey", EmitDefaultValue=false)]
        public string DefinitionKey { get; set; }

        /// <summary>
        /// Array of recipient objects that contain parameters and metadata for the recipients, such as send tracking and personalization attributes. Use this parameter to send to multiple recipients in one request. Use either the recipient or recipients parameter, but not both.
        /// </summary>
        /// <value>Array of recipient objects that contain parameters and metadata for the recipients, such as send tracking and personalization attributes. Use this parameter to send to multiple recipients in one request. Use either the recipient or recipients parameter, but not both.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<Recipient> Recipients { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestSendEmailToMultipleRecipients {\n");
            sb.Append("  DefinitionKey: ").Append(DefinitionKey).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as RequestSendEmailToMultipleRecipients);
        }

        /// <summary>
        /// Returns true if RequestSendEmailToMultipleRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestSendEmailToMultipleRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestSendEmailToMultipleRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefinitionKey == input.DefinitionKey ||
                    (this.DefinitionKey != null &&
                    this.DefinitionKey.Equals(input.DefinitionKey))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.DefinitionKey != null)
                    hashCode = hashCode * 59 + this.DefinitionKey.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
