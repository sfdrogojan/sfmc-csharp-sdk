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
    /// DeleteSendDefinitionResponse
    /// </summary>
    [DataContract]
    public partial class DeleteSendDefinitionResponse :  IEquatable<DeleteSendDefinitionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSendDefinitionResponse" /> class.
        /// </summary>
        /// <param name="message">The response message.</param>
        /// <param name="requestId">The ID of the request.</param>
        /// <param name="deletedDefinitionKey">The key of the deleted definition.</param>
        public DeleteSendDefinitionResponse(string message = default(string), string requestId = default(string), string deletedDefinitionKey = default(string))
        {
            this.Message = message;
            this.RequestId = requestId;
            this.DeletedDefinitionKey = deletedDefinitionKey;
        }
        
        /// <summary>
        /// The response message
        /// </summary>
        /// <value>The response message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The key of the deleted definition
        /// </summary>
        /// <value>The key of the deleted definition</value>
        [DataMember(Name="deletedDefinitionKey", EmitDefaultValue=false)]
        public string DeletedDefinitionKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSendDefinitionResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  DeletedDefinitionKey: ").Append(DeletedDefinitionKey).Append("\n");
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
            return this.Equals(input as DeleteSendDefinitionResponse);
        }

        /// <summary>
        /// Returns true if DeleteSendDefinitionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteSendDefinitionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteSendDefinitionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.DeletedDefinitionKey == input.DeletedDefinitionKey ||
                    (this.DeletedDefinitionKey != null &&
                    this.DeletedDefinitionKey.Equals(input.DeletedDefinitionKey))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.DeletedDefinitionKey != null)
                    hashCode = hashCode * 59 + this.DeletedDefinitionKey.GetHashCode();
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