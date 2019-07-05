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
    /// ResponseGetEmailSendStatusForRecipient
    /// </summary>
    [DataContract]
    public partial class ResponseGetEmailSendStatusForRecipient :  IEquatable<ResponseGetEmailSendStatusForRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGetEmailSendStatusForRecipient" /> class.
        /// </summary>
        /// <param name="requestId">The ID of the request.</param>
        /// <param name="eventCategoryType">The status of the message.</param>
        /// <param name="timestamp">The date the ....</param>
        /// <param name="compositeId">The Id of ....</param>
        /// <param name="info">info.</param>
        public ResponseGetEmailSendStatusForRecipient(string requestId = default(string), string eventCategoryType = default(string), DateTime? timestamp = default(DateTime?), string compositeId = default(string), ResponseGetEmailSendStatusForRecipientInfo info = default(ResponseGetEmailSendStatusForRecipientInfo))
        {
            this.RequestId = requestId;
            this.EventCategoryType = eventCategoryType;
            this.Timestamp = timestamp;
            this.CompositeId = compositeId;
            this.Info = info;
        }
        
        /// <summary>
        /// The ID of the request
        /// </summary>
        /// <value>The ID of the request</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the message
        /// </summary>
        /// <value>The status of the message</value>
        [DataMember(Name="eventCategoryType", EmitDefaultValue=false)]
        public string EventCategoryType { get; set; }

        /// <summary>
        /// The date the ...
        /// </summary>
        /// <value>The date the ...</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The Id of ...
        /// </summary>
        /// <value>The Id of ...</value>
        [DataMember(Name="compositeId", EmitDefaultValue=false)]
        public string CompositeId { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public ResponseGetEmailSendStatusForRecipientInfo Info { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseGetEmailSendStatusForRecipient {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  EventCategoryType: ").Append(EventCategoryType).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  CompositeId: ").Append(CompositeId).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(input as ResponseGetEmailSendStatusForRecipient);
        }

        /// <summary>
        /// Returns true if ResponseGetEmailSendStatusForRecipient instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseGetEmailSendStatusForRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseGetEmailSendStatusForRecipient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.EventCategoryType == input.EventCategoryType ||
                    (this.EventCategoryType != null &&
                    this.EventCategoryType.Equals(input.EventCategoryType))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.CompositeId == input.CompositeId ||
                    (this.CompositeId != null &&
                    this.CompositeId.Equals(input.CompositeId))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.EventCategoryType != null)
                    hashCode = hashCode * 59 + this.EventCategoryType.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.CompositeId != null)
                    hashCode = hashCode * 59 + this.CompositeId.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
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
