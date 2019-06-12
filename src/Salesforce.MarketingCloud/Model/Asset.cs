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
    /// Asset
    /// </summary>
    [DataContract]
    public partial class Asset :  IEquatable<Asset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Asset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">The id of the asset.</param>
        /// <param name="customerKey">Reference to customer&#39;s private ID/name for the asset (required).</param>
        /// <param name="contentType">The type that the content attribute will be in.</param>
        /// <param name="data">Property bag containing the asset data.</param>
        /// <param name="assetType">assetType (required).</param>
        /// <param name="version">The version of the asset.</param>
        /// <param name="locked">Specifies if the asset can be modified or not.</param>
        /// <param name="fileProperties">Stores the different properties that this asset refers to if it is a file type.</param>
        /// <param name="name">Name of the asset, set by the client (required).</param>
        /// <param name="description">Description of the asset, set by the client (required).</param>
        /// <param name="category">ID of the category the asset belongs to.</param>
        /// <param name="tags">List of tags associated with the asset.</param>
        /// <param name="content">The actual content of the asset.</param>
        /// <param name="design">Fallback for display when neither content nor supercontent are provided.</param>
        /// <param name="superContent">Content that supersedes content in terms of display.</param>
        /// <param name="customFields">Custom fields within an asset.</param>
        /// <param name="views">Views within an asset.</param>
        /// <param name="blocks">Blocks within the asset.</param>
        /// <param name="minBlocks">Minimum number of blocks within an asset.</param>
        /// <param name="maxBlocks">Maximum number of blocks within an asset.</param>
        /// <param name="channels">List of channels that are allowed to use this asset.</param>
        /// <param name="allowedBlocks">List of blocks that are allowed in the asset.</param>
        /// <param name="slots">Slots within the asset.</param>
        /// <param name="businessUnitAvailability">A dictionary of member IDs that have been granted access to the asset.</param>
        /// <param name="sharingProperties">Allows you to share content with one or more business units that have Content Builder Sharing enabled. See &lt;a href&#x3D;\&quot;sharing.htm\&quot;&gt;Sharing&lt;/a&gt; for additional information..</param>
        /// <param name="sharingPropertiesSharedWith">List of MID IDs the asset is shared with.</param>
        /// <param name="sharingPropertiesSharingType">Indicates the permission that you are granting to the list of MIDs in sharedWith. Possible values are view, edit, or local..</param>
        /// <param name="template">Template the asset follows.</param>
        /// <param name="file">Base64-encoded string of a file associated with an asset.</param>
        /// <param name="generateFrom">Tells the sending compiler what view to use for generating this view&#39;s content.</param>
        public Asset(decimal? id = default(decimal?), string customerKey = default(string), string contentType = default(string), Object data = default(Object), AssetType assetType = default(AssetType), decimal? version = default(decimal?), bool? locked = default(bool?), Object fileProperties = default(Object), string name = default(string), string description = default(string), Object category = default(Object), List<string> tags = default(List<string>), string content = default(string), string design = default(string), string superContent = default(string), Object customFields = default(Object), Object views = default(Object), Object blocks = default(Object), decimal? minBlocks = default(decimal?), decimal? maxBlocks = default(decimal?), Object channels = default(Object), List<string> allowedBlocks = default(List<string>), Object slots = default(Object), Object businessUnitAvailability = default(Object), Object sharingProperties = default(Object), Object sharingPropertiesSharedWith = default(Object), string sharingPropertiesSharingType = default(string), Object template = default(Object), string file = default(string), string generateFrom = default(string))
        {
            // to ensure "customerKey" is required (not null)
            if (customerKey == null)
            {
                throw new InvalidDataException("customerKey is a required property for Asset and cannot be null");
            }
            else
            {
                this.CustomerKey = customerKey;
            }
            // to ensure "assetType" is required (not null)
            if (assetType == null)
            {
                throw new InvalidDataException("assetType is a required property for Asset and cannot be null");
            }
            else
            {
                this.AssetType = assetType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Asset and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Asset and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.Id = id;
            this.ContentType = contentType;
            this.Data = data;
            this.Version = version;
            this.Locked = locked;
            this.FileProperties = fileProperties;
            this.Category = category;
            this.Tags = tags;
            this.Content = content;
            this.Design = design;
            this.SuperContent = superContent;
            this.CustomFields = customFields;
            this.Views = views;
            this.Blocks = blocks;
            this.MinBlocks = minBlocks;
            this.MaxBlocks = maxBlocks;
            this.Channels = channels;
            this.AllowedBlocks = allowedBlocks;
            this.Slots = slots;
            this.BusinessUnitAvailability = businessUnitAvailability;
            this.SharingProperties = sharingProperties;
            this.SharingPropertiesSharedWith = sharingPropertiesSharedWith;
            this.SharingPropertiesSharingType = sharingPropertiesSharingType;
            this.Template = template;
            this.File = file;
            this.GenerateFrom = generateFrom;
        }
        
        /// <summary>
        /// The id of the asset
        /// </summary>
        /// <value>The id of the asset</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Reference to customer&#39;s private ID/name for the asset
        /// </summary>
        /// <value>Reference to customer&#39;s private ID/name for the asset</value>
        [DataMember(Name="CustomerKey", EmitDefaultValue=false)]
        public string CustomerKey { get; set; }

        /// <summary>
        /// The type that the content attribute will be in
        /// </summary>
        /// <value>The type that the content attribute will be in</value>
        [DataMember(Name="ContentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Property bag containing the asset data
        /// </summary>
        /// <value>Property bag containing the asset data</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>
        [DataMember(Name="AssetType", EmitDefaultValue=false)]
        public AssetType AssetType { get; set; }

        /// <summary>
        /// The version of the asset
        /// </summary>
        /// <value>The version of the asset</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// Specifies if the asset can be modified or not
        /// </summary>
        /// <value>Specifies if the asset can be modified or not</value>
        [DataMember(Name="Locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Stores the different properties that this asset refers to if it is a file type
        /// </summary>
        /// <value>Stores the different properties that this asset refers to if it is a file type</value>
        [DataMember(Name="FileProperties", EmitDefaultValue=false)]
        public Object FileProperties { get; set; }

        /// <summary>
        /// Name of the asset, set by the client
        /// </summary>
        /// <value>Name of the asset, set by the client</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the asset, set by the client
        /// </summary>
        /// <value>Description of the asset, set by the client</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the category the asset belongs to
        /// </summary>
        /// <value>ID of the category the asset belongs to</value>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public Object Category { get; set; }

        /// <summary>
        /// List of tags associated with the asset
        /// </summary>
        /// <value>List of tags associated with the asset</value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The actual content of the asset
        /// </summary>
        /// <value>The actual content of the asset</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Fallback for display when neither content nor supercontent are provided
        /// </summary>
        /// <value>Fallback for display when neither content nor supercontent are provided</value>
        [DataMember(Name="Design", EmitDefaultValue=false)]
        public string Design { get; set; }

        /// <summary>
        /// Content that supersedes content in terms of display
        /// </summary>
        /// <value>Content that supersedes content in terms of display</value>
        [DataMember(Name="SuperContent", EmitDefaultValue=false)]
        public string SuperContent { get; set; }

        /// <summary>
        /// Custom fields within an asset
        /// </summary>
        /// <value>Custom fields within an asset</value>
        [DataMember(Name="CustomFields", EmitDefaultValue=false)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Views within an asset
        /// </summary>
        /// <value>Views within an asset</value>
        [DataMember(Name="Views", EmitDefaultValue=false)]
        public Object Views { get; set; }

        /// <summary>
        /// Blocks within the asset
        /// </summary>
        /// <value>Blocks within the asset</value>
        [DataMember(Name="Blocks", EmitDefaultValue=false)]
        public Object Blocks { get; set; }

        /// <summary>
        /// Minimum number of blocks within an asset
        /// </summary>
        /// <value>Minimum number of blocks within an asset</value>
        [DataMember(Name="MinBlocks", EmitDefaultValue=false)]
        public decimal? MinBlocks { get; set; }

        /// <summary>
        /// Maximum number of blocks within an asset
        /// </summary>
        /// <value>Maximum number of blocks within an asset</value>
        [DataMember(Name="MaxBlocks", EmitDefaultValue=false)]
        public decimal? MaxBlocks { get; set; }

        /// <summary>
        /// List of channels that are allowed to use this asset
        /// </summary>
        /// <value>List of channels that are allowed to use this asset</value>
        [DataMember(Name="Channels", EmitDefaultValue=false)]
        public Object Channels { get; set; }

        /// <summary>
        /// List of blocks that are allowed in the asset
        /// </summary>
        /// <value>List of blocks that are allowed in the asset</value>
        [DataMember(Name="AllowedBlocks", EmitDefaultValue=false)]
        public List<string> AllowedBlocks { get; set; }

        /// <summary>
        /// Slots within the asset
        /// </summary>
        /// <value>Slots within the asset</value>
        [DataMember(Name="Slots", EmitDefaultValue=false)]
        public Object Slots { get; set; }

        /// <summary>
        /// A dictionary of member IDs that have been granted access to the asset
        /// </summary>
        /// <value>A dictionary of member IDs that have been granted access to the asset</value>
        [DataMember(Name="BusinessUnitAvailability", EmitDefaultValue=false)]
        public Object BusinessUnitAvailability { get; set; }

        /// <summary>
        /// Allows you to share content with one or more business units that have Content Builder Sharing enabled. See &lt;a href&#x3D;\&quot;sharing.htm\&quot;&gt;Sharing&lt;/a&gt; for additional information.
        /// </summary>
        /// <value>Allows you to share content with one or more business units that have Content Builder Sharing enabled. See &lt;a href&#x3D;\&quot;sharing.htm\&quot;&gt;Sharing&lt;/a&gt; for additional information.</value>
        [DataMember(Name="sharingProperties", EmitDefaultValue=false)]
        public Object SharingProperties { get; set; }

        /// <summary>
        /// List of MID IDs the asset is shared with
        /// </summary>
        /// <value>List of MID IDs the asset is shared with</value>
        [DataMember(Name="sharingProperties.sharedWith", EmitDefaultValue=false)]
        public Object SharingPropertiesSharedWith { get; set; }

        /// <summary>
        /// Indicates the permission that you are granting to the list of MIDs in sharedWith. Possible values are view, edit, or local.
        /// </summary>
        /// <value>Indicates the permission that you are granting to the list of MIDs in sharedWith. Possible values are view, edit, or local.</value>
        [DataMember(Name="sharingProperties.sharingType", EmitDefaultValue=false)]
        public string SharingPropertiesSharingType { get; set; }

        /// <summary>
        /// Template the asset follows
        /// </summary>
        /// <value>Template the asset follows</value>
        [DataMember(Name="Template", EmitDefaultValue=false)]
        public Object Template { get; set; }

        /// <summary>
        /// Base64-encoded string of a file associated with an asset
        /// </summary>
        /// <value>Base64-encoded string of a file associated with an asset</value>
        [DataMember(Name="File", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// Tells the sending compiler what view to use for generating this view&#39;s content
        /// </summary>
        /// <value>Tells the sending compiler what view to use for generating this view&#39;s content</value>
        [DataMember(Name="GenerateFrom", EmitDefaultValue=false)]
        public string GenerateFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerKey: ").Append(CustomerKey).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  FileProperties: ").Append(FileProperties).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
            sb.Append("  SuperContent: ").Append(SuperContent).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  MinBlocks: ").Append(MinBlocks).Append("\n");
            sb.Append("  MaxBlocks: ").Append(MaxBlocks).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  AllowedBlocks: ").Append(AllowedBlocks).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
            sb.Append("  BusinessUnitAvailability: ").Append(BusinessUnitAvailability).Append("\n");
            sb.Append("  SharingProperties: ").Append(SharingProperties).Append("\n");
            sb.Append("  SharingPropertiesSharedWith: ").Append(SharingPropertiesSharedWith).Append("\n");
            sb.Append("  SharingPropertiesSharingType: ").Append(SharingPropertiesSharingType).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  GenerateFrom: ").Append(GenerateFrom).Append("\n");
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
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CustomerKey == input.CustomerKey ||
                    (this.CustomerKey != null &&
                    this.CustomerKey.Equals(input.CustomerKey))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.FileProperties == input.FileProperties ||
                    (this.FileProperties != null &&
                    this.FileProperties.Equals(input.FileProperties))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Design == input.Design ||
                    (this.Design != null &&
                    this.Design.Equals(input.Design))
                ) && 
                (
                    this.SuperContent == input.SuperContent ||
                    (this.SuperContent != null &&
                    this.SuperContent.Equals(input.SuperContent))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    (this.Blocks != null &&
                    this.Blocks.Equals(input.Blocks))
                ) && 
                (
                    this.MinBlocks == input.MinBlocks ||
                    (this.MinBlocks != null &&
                    this.MinBlocks.Equals(input.MinBlocks))
                ) && 
                (
                    this.MaxBlocks == input.MaxBlocks ||
                    (this.MaxBlocks != null &&
                    this.MaxBlocks.Equals(input.MaxBlocks))
                ) && 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
                ) && 
                (
                    this.AllowedBlocks == input.AllowedBlocks ||
                    this.AllowedBlocks != null &&
                    this.AllowedBlocks.SequenceEqual(input.AllowedBlocks)
                ) && 
                (
                    this.Slots == input.Slots ||
                    (this.Slots != null &&
                    this.Slots.Equals(input.Slots))
                ) && 
                (
                    this.BusinessUnitAvailability == input.BusinessUnitAvailability ||
                    (this.BusinessUnitAvailability != null &&
                    this.BusinessUnitAvailability.Equals(input.BusinessUnitAvailability))
                ) && 
                (
                    this.SharingProperties == input.SharingProperties ||
                    (this.SharingProperties != null &&
                    this.SharingProperties.Equals(input.SharingProperties))
                ) && 
                (
                    this.SharingPropertiesSharedWith == input.SharingPropertiesSharedWith ||
                    (this.SharingPropertiesSharedWith != null &&
                    this.SharingPropertiesSharedWith.Equals(input.SharingPropertiesSharedWith))
                ) && 
                (
                    this.SharingPropertiesSharingType == input.SharingPropertiesSharingType ||
                    (this.SharingPropertiesSharingType != null &&
                    this.SharingPropertiesSharingType.Equals(input.SharingPropertiesSharingType))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.GenerateFrom == input.GenerateFrom ||
                    (this.GenerateFrom != null &&
                    this.GenerateFrom.Equals(input.GenerateFrom))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CustomerKey != null)
                    hashCode = hashCode * 59 + this.CustomerKey.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.AssetType != null)
                    hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.FileProperties != null)
                    hashCode = hashCode * 59 + this.FileProperties.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Design != null)
                    hashCode = hashCode * 59 + this.Design.GetHashCode();
                if (this.SuperContent != null)
                    hashCode = hashCode * 59 + this.SuperContent.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.Blocks != null)
                    hashCode = hashCode * 59 + this.Blocks.GetHashCode();
                if (this.MinBlocks != null)
                    hashCode = hashCode * 59 + this.MinBlocks.GetHashCode();
                if (this.MaxBlocks != null)
                    hashCode = hashCode * 59 + this.MaxBlocks.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.AllowedBlocks != null)
                    hashCode = hashCode * 59 + this.AllowedBlocks.GetHashCode();
                if (this.Slots != null)
                    hashCode = hashCode * 59 + this.Slots.GetHashCode();
                if (this.BusinessUnitAvailability != null)
                    hashCode = hashCode * 59 + this.BusinessUnitAvailability.GetHashCode();
                if (this.SharingProperties != null)
                    hashCode = hashCode * 59 + this.SharingProperties.GetHashCode();
                if (this.SharingPropertiesSharedWith != null)
                    hashCode = hashCode * 59 + this.SharingPropertiesSharedWith.GetHashCode();
                if (this.SharingPropertiesSharingType != null)
                    hashCode = hashCode * 59 + this.SharingPropertiesSharingType.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.GenerateFrom != null)
                    hashCode = hashCode * 59 + this.GenerateFrom.GetHashCode();
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
