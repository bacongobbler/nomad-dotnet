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
    /// NodeCpuResources
    /// </summary>
    [DataContract(Name = "NodeCpuResources")]
    public partial class NodeCpuResources : IEquatable<NodeCpuResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeCpuResources" /> class.
        /// </summary>
        /// <param name="cpuShares">cpuShares.</param>
        /// <param name="reservableCpuCores">reservableCpuCores.</param>
        /// <param name="totalCpuCores">totalCpuCores.</param>
        public NodeCpuResources(long cpuShares = default(long), List<int> reservableCpuCores = default(List<int>), int totalCpuCores = default(int))
        {
            this.CpuShares = cpuShares;
            this.ReservableCpuCores = reservableCpuCores;
            this.TotalCpuCores = totalCpuCores;
        }

        /// <summary>
        /// Gets or Sets CpuShares
        /// </summary>
        [DataMember(Name = "CpuShares", EmitDefaultValue = false)]
        public long CpuShares { get; set; }

        /// <summary>
        /// Gets or Sets ReservableCpuCores
        /// </summary>
        [DataMember(Name = "ReservableCpuCores", EmitDefaultValue = false)]
        public List<int> ReservableCpuCores { get; set; }

        /// <summary>
        /// Gets or Sets TotalCpuCores
        /// </summary>
        [DataMember(Name = "TotalCpuCores", EmitDefaultValue = false)]
        public int TotalCpuCores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeCpuResources {\n");
            sb.Append("  CpuShares: ").Append(CpuShares).Append("\n");
            sb.Append("  ReservableCpuCores: ").Append(ReservableCpuCores).Append("\n");
            sb.Append("  TotalCpuCores: ").Append(TotalCpuCores).Append("\n");
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
            return this.Equals(input as NodeCpuResources);
        }

        /// <summary>
        /// Returns true if NodeCpuResources instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeCpuResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeCpuResources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CpuShares == input.CpuShares ||
                    this.CpuShares.Equals(input.CpuShares)
                ) && 
                (
                    this.ReservableCpuCores == input.ReservableCpuCores ||
                    this.ReservableCpuCores != null &&
                    input.ReservableCpuCores != null &&
                    this.ReservableCpuCores.SequenceEqual(input.ReservableCpuCores)
                ) && 
                (
                    this.TotalCpuCores == input.TotalCpuCores ||
                    this.TotalCpuCores.Equals(input.TotalCpuCores)
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
                hashCode = (hashCode * 59) + this.CpuShares.GetHashCode();
                if (this.ReservableCpuCores != null)
                {
                    hashCode = (hashCode * 59) + this.ReservableCpuCores.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCpuCores.GetHashCode();
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
            // TotalCpuCores (int) maximum
            if (this.TotalCpuCores > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalCpuCores, must be a value less than or equal to 65535.", new [] { "TotalCpuCores" });
            }

            // TotalCpuCores (int) minimum
            if (this.TotalCpuCores < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalCpuCores, must be a value greater than or equal to 0.", new [] { "TotalCpuCores" });
            }

            yield break;
        }
    }

}
