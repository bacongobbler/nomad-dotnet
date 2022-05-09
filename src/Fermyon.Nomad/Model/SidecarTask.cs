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
    /// SidecarTask
    /// </summary>
    [DataContract(Name = "SidecarTask")]
    public partial class SidecarTask : IEquatable<SidecarTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SidecarTask" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="driver">driver.</param>
        /// <param name="env">env.</param>
        /// <param name="killSignal">killSignal.</param>
        /// <param name="killTimeout">killTimeout.</param>
        /// <param name="logConfig">logConfig.</param>
        /// <param name="meta">meta.</param>
        /// <param name="name">name.</param>
        /// <param name="resources">resources.</param>
        /// <param name="shutdownDelay">shutdownDelay.</param>
        /// <param name="user">user.</param>
        public SidecarTask(Dictionary<string, Object> config = default(Dictionary<string, Object>), string driver = default(string), Dictionary<string, string> env = default(Dictionary<string, string>), string killSignal = default(string), long killTimeout = default(long), LogConfig logConfig = default(LogConfig), Dictionary<string, string> meta = default(Dictionary<string, string>), string name = default(string), Resources resources = default(Resources), long? shutdownDelay = default(long?), string user = default(string))
        {
            this.Config = config;
            this.Driver = driver;
            this.Env = env;
            this.KillSignal = killSignal;
            this.KillTimeout = killTimeout;
            this.LogConfig = logConfig;
            this.Meta = meta;
            this.Name = name;
            this.Resources = resources;
            this.ShutdownDelay = shutdownDelay;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "Config", EmitDefaultValue = false)]
        public Dictionary<string, Object> Config { get; set; }

        /// <summary>
        /// Gets or Sets Driver
        /// </summary>
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
        public string Driver { get; set; }

        /// <summary>
        /// Gets or Sets Env
        /// </summary>
        [DataMember(Name = "Env", EmitDefaultValue = false)]
        public Dictionary<string, string> Env { get; set; }

        /// <summary>
        /// Gets or Sets KillSignal
        /// </summary>
        [DataMember(Name = "KillSignal", EmitDefaultValue = false)]
        public string KillSignal { get; set; }

        /// <summary>
        /// Gets or Sets KillTimeout
        /// </summary>
        [DataMember(Name = "KillTimeout", EmitDefaultValue = false)]
        public long KillTimeout { get; set; }

        /// <summary>
        /// Gets or Sets LogConfig
        /// </summary>
        [DataMember(Name = "LogConfig", EmitDefaultValue = false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "Meta", EmitDefaultValue = false)]
        public Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "Resources", EmitDefaultValue = false)]
        public Resources Resources { get; set; }

        /// <summary>
        /// Gets or Sets ShutdownDelay
        /// </summary>
        [DataMember(Name = "ShutdownDelay", EmitDefaultValue = false)]
        public long? ShutdownDelay { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "User", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SidecarTask {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  KillSignal: ").Append(KillSignal).Append("\n");
            sb.Append("  KillTimeout: ").Append(KillTimeout).Append("\n");
            sb.Append("  LogConfig: ").Append(LogConfig).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  ShutdownDelay: ").Append(ShutdownDelay).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as SidecarTask);
        }

        /// <summary>
        /// Returns true if SidecarTask instances are equal
        /// </summary>
        /// <param name="input">Instance of SidecarTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SidecarTask input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
                ) && 
                (
                    this.Env == input.Env ||
                    this.Env != null &&
                    input.Env != null &&
                    this.Env.SequenceEqual(input.Env)
                ) && 
                (
                    this.KillSignal == input.KillSignal ||
                    (this.KillSignal != null &&
                    this.KillSignal.Equals(input.KillSignal))
                ) && 
                (
                    this.KillTimeout == input.KillTimeout ||
                    this.KillTimeout.Equals(input.KillTimeout)
                ) && 
                (
                    this.LogConfig == input.LogConfig ||
                    (this.LogConfig != null &&
                    this.LogConfig.Equals(input.LogConfig))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Resources == input.Resources ||
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
                ) && 
                (
                    this.ShutdownDelay == input.ShutdownDelay ||
                    this.ShutdownDelay.Equals(input.ShutdownDelay)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.Driver != null)
                {
                    hashCode = (hashCode * 59) + this.Driver.GetHashCode();
                }
                if (this.Env != null)
                {
                    hashCode = (hashCode * 59) + this.Env.GetHashCode();
                }
                if (this.KillSignal != null)
                {
                    hashCode = (hashCode * 59) + this.KillSignal.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KillTimeout.GetHashCode();
                if (this.LogConfig != null)
                {
                    hashCode = (hashCode * 59) + this.LogConfig.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShutdownDelay.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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
