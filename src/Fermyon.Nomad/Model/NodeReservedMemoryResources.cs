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
    /// NodeReservedMemoryResources
    /// </summary>
    [DataContract(Name = "NodeReservedMemoryResources")]
    public partial class NodeReservedMemoryResources : IEquatable<NodeReservedMemoryResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeReservedMemoryResources" /> class.
        /// </summary>
        /// <param name="memoryMB">memoryMB.</param>
        public NodeReservedMemoryResources(int memoryMB = default(int))
        {
            this.MemoryMB = memoryMB;
        }

        /// <summary>
        /// Gets or Sets MemoryMB
        /// </summary>
        [DataMember(Name = "MemoryMB", EmitDefaultValue = false)]
        public int MemoryMB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeReservedMemoryResources {\n");
            sb.Append("  MemoryMB: ").Append(MemoryMB).Append("\n");
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
            return this.Equals(input as NodeReservedMemoryResources);
        }

        /// <summary>
        /// Returns true if NodeReservedMemoryResources instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeReservedMemoryResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeReservedMemoryResources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MemoryMB == input.MemoryMB ||
                    this.MemoryMB.Equals(input.MemoryMB)
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
                hashCode = (hashCode * 59) + this.MemoryMB.GetHashCode();
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
            // MemoryMB (int) maximum
            if (this.MemoryMB > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MemoryMB, must be a value less than or equal to 384.", new [] { "MemoryMB" });
            }

            // MemoryMB (int) minimum
            if (this.MemoryMB < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MemoryMB, must be a value greater than or equal to 0.", new [] { "MemoryMB" });
            }

            yield break;
        }
    }

}
