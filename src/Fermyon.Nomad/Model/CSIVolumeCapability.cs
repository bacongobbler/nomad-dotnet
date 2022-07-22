/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
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
using OpenAPIDateConverter = Fermyon.Nomad.Client.OpenAPIDateConverter;

namespace Fermyon.Nomad.Model
{
    /// <summary>
    /// CSIVolumeCapability
    /// </summary>
    [DataContract(Name = "CSIVolumeCapability")]
    public partial class CSIVolumeCapability : IEquatable<CSIVolumeCapability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSIVolumeCapability" /> class.
        /// </summary>
        /// <param name="accessMode">accessMode.</param>
        /// <param name="attachmentMode">attachmentMode.</param>
        public CSIVolumeCapability(string accessMode = default(string), string attachmentMode = default(string))
        {
            this.AccessMode = accessMode;
            this.AttachmentMode = attachmentMode;
        }

        /// <summary>
        /// Gets or Sets AccessMode
        /// </summary>
        [DataMember(Name = "AccessMode", EmitDefaultValue = false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentMode
        /// </summary>
        [DataMember(Name = "AttachmentMode", EmitDefaultValue = false)]
        public string AttachmentMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CSIVolumeCapability {\n");
            sb.Append("  AccessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  AttachmentMode: ").Append(AttachmentMode).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CSIVolumeCapability);
        }

        /// <summary>
        /// Returns true if CSIVolumeCapability instances are equal
        /// </summary>
        /// <param name="input">Instance of CSIVolumeCapability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSIVolumeCapability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessMode == input.AccessMode ||
                    (this.AccessMode != null &&
                    this.AccessMode.Equals(input.AccessMode))
                ) && 
                (
                    this.AttachmentMode == input.AttachmentMode ||
                    (this.AttachmentMode != null &&
                    this.AttachmentMode.Equals(input.AttachmentMode))
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
                if (this.AccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.AccessMode.GetHashCode();
                }
                if (this.AttachmentMode != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentMode.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
