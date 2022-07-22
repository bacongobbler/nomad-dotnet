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
    /// DeploymentState
    /// </summary>
    [DataContract(Name = "DeploymentState")]
    public partial class DeploymentState : IEquatable<DeploymentState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentState" /> class.
        /// </summary>
        /// <param name="autoRevert">autoRevert.</param>
        /// <param name="desiredCanaries">desiredCanaries.</param>
        /// <param name="desiredTotal">desiredTotal.</param>
        /// <param name="healthyAllocs">healthyAllocs.</param>
        /// <param name="placedAllocs">placedAllocs.</param>
        /// <param name="placedCanaries">placedCanaries.</param>
        /// <param name="progressDeadline">progressDeadline.</param>
        /// <param name="promoted">promoted.</param>
        /// <param name="requireProgressBy">requireProgressBy.</param>
        /// <param name="unhealthyAllocs">unhealthyAllocs.</param>
        public DeploymentState(bool autoRevert = default(bool), int desiredCanaries = default(int), int desiredTotal = default(int), int healthyAllocs = default(int), int placedAllocs = default(int), List<string> placedCanaries = default(List<string>), long progressDeadline = default(long), bool promoted = default(bool), DateTime requireProgressBy = default(DateTime), int unhealthyAllocs = default(int))
        {
            this.AutoRevert = autoRevert;
            this.DesiredCanaries = desiredCanaries;
            this.DesiredTotal = desiredTotal;
            this.HealthyAllocs = healthyAllocs;
            this.PlacedAllocs = placedAllocs;
            this.PlacedCanaries = placedCanaries;
            this.ProgressDeadline = progressDeadline;
            this.Promoted = promoted;
            this.RequireProgressBy = requireProgressBy;
            this.UnhealthyAllocs = unhealthyAllocs;
        }

        /// <summary>
        /// Gets or Sets AutoRevert
        /// </summary>
        [DataMember(Name = "AutoRevert", EmitDefaultValue = true)]
        public bool AutoRevert { get; set; }

        /// <summary>
        /// Gets or Sets DesiredCanaries
        /// </summary>
        [DataMember(Name = "DesiredCanaries", EmitDefaultValue = false)]
        public int DesiredCanaries { get; set; }

        /// <summary>
        /// Gets or Sets DesiredTotal
        /// </summary>
        [DataMember(Name = "DesiredTotal", EmitDefaultValue = false)]
        public int DesiredTotal { get; set; }

        /// <summary>
        /// Gets or Sets HealthyAllocs
        /// </summary>
        [DataMember(Name = "HealthyAllocs", EmitDefaultValue = false)]
        public int HealthyAllocs { get; set; }

        /// <summary>
        /// Gets or Sets PlacedAllocs
        /// </summary>
        [DataMember(Name = "PlacedAllocs", EmitDefaultValue = false)]
        public int PlacedAllocs { get; set; }

        /// <summary>
        /// Gets or Sets PlacedCanaries
        /// </summary>
        [DataMember(Name = "PlacedCanaries", EmitDefaultValue = false)]
        public List<string> PlacedCanaries { get; set; }

        /// <summary>
        /// Gets or Sets ProgressDeadline
        /// </summary>
        [DataMember(Name = "ProgressDeadline", EmitDefaultValue = false)]
        public long ProgressDeadline { get; set; }

        /// <summary>
        /// Gets or Sets Promoted
        /// </summary>
        [DataMember(Name = "Promoted", EmitDefaultValue = true)]
        public bool Promoted { get; set; }

        /// <summary>
        /// Gets or Sets RequireProgressBy
        /// </summary>
        [DataMember(Name = "RequireProgressBy", EmitDefaultValue = false)]
        public DateTime RequireProgressBy { get; set; }

        /// <summary>
        /// Gets or Sets UnhealthyAllocs
        /// </summary>
        [DataMember(Name = "UnhealthyAllocs", EmitDefaultValue = false)]
        public int UnhealthyAllocs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeploymentState {\n");
            sb.Append("  AutoRevert: ").Append(AutoRevert).Append("\n");
            sb.Append("  DesiredCanaries: ").Append(DesiredCanaries).Append("\n");
            sb.Append("  DesiredTotal: ").Append(DesiredTotal).Append("\n");
            sb.Append("  HealthyAllocs: ").Append(HealthyAllocs).Append("\n");
            sb.Append("  PlacedAllocs: ").Append(PlacedAllocs).Append("\n");
            sb.Append("  PlacedCanaries: ").Append(PlacedCanaries).Append("\n");
            sb.Append("  ProgressDeadline: ").Append(ProgressDeadline).Append("\n");
            sb.Append("  Promoted: ").Append(Promoted).Append("\n");
            sb.Append("  RequireProgressBy: ").Append(RequireProgressBy).Append("\n");
            sb.Append("  UnhealthyAllocs: ").Append(UnhealthyAllocs).Append("\n");
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
            return this.Equals(input as DeploymentState);
        }

        /// <summary>
        /// Returns true if DeploymentState instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutoRevert == input.AutoRevert ||
                    this.AutoRevert.Equals(input.AutoRevert)
                ) && 
                (
                    this.DesiredCanaries == input.DesiredCanaries ||
                    this.DesiredCanaries.Equals(input.DesiredCanaries)
                ) && 
                (
                    this.DesiredTotal == input.DesiredTotal ||
                    this.DesiredTotal.Equals(input.DesiredTotal)
                ) && 
                (
                    this.HealthyAllocs == input.HealthyAllocs ||
                    this.HealthyAllocs.Equals(input.HealthyAllocs)
                ) && 
                (
                    this.PlacedAllocs == input.PlacedAllocs ||
                    this.PlacedAllocs.Equals(input.PlacedAllocs)
                ) && 
                (
                    this.PlacedCanaries == input.PlacedCanaries ||
                    this.PlacedCanaries != null &&
                    input.PlacedCanaries != null &&
                    this.PlacedCanaries.SequenceEqual(input.PlacedCanaries)
                ) && 
                (
                    this.ProgressDeadline == input.ProgressDeadline ||
                    this.ProgressDeadline.Equals(input.ProgressDeadline)
                ) && 
                (
                    this.Promoted == input.Promoted ||
                    this.Promoted.Equals(input.Promoted)
                ) && 
                (
                    this.RequireProgressBy == input.RequireProgressBy ||
                    (this.RequireProgressBy != null &&
                    this.RequireProgressBy.Equals(input.RequireProgressBy))
                ) && 
                (
                    this.UnhealthyAllocs == input.UnhealthyAllocs ||
                    this.UnhealthyAllocs.Equals(input.UnhealthyAllocs)
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
                hashCode = (hashCode * 59) + this.AutoRevert.GetHashCode();
                hashCode = (hashCode * 59) + this.DesiredCanaries.GetHashCode();
                hashCode = (hashCode * 59) + this.DesiredTotal.GetHashCode();
                hashCode = (hashCode * 59) + this.HealthyAllocs.GetHashCode();
                hashCode = (hashCode * 59) + this.PlacedAllocs.GetHashCode();
                if (this.PlacedCanaries != null)
                {
                    hashCode = (hashCode * 59) + this.PlacedCanaries.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProgressDeadline.GetHashCode();
                hashCode = (hashCode * 59) + this.Promoted.GetHashCode();
                if (this.RequireProgressBy != null)
                {
                    hashCode = (hashCode * 59) + this.RequireProgressBy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnhealthyAllocs.GetHashCode();
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
