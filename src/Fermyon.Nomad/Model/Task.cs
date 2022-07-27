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
    /// Task
    /// </summary>
    [DataContract(Name = "Task")]
    public partial class Task : IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="affinities">affinities.</param>
        /// <param name="artifacts">artifacts.</param>
        /// <param name="cSIPluginConfig">cSIPluginConfig.</param>
        /// <param name="config">config.</param>
        /// <param name="constraints">constraints.</param>
        /// <param name="dispatchPayload">dispatchPayload.</param>
        /// <param name="driver">driver.</param>
        /// <param name="env">env.</param>
        /// <param name="killSignal">killSignal.</param>
        /// <param name="killTimeout">killTimeout.</param>
        /// <param name="kind">kind.</param>
        /// <param name="leader">leader.</param>
        /// <param name="lifecycle">lifecycle.</param>
        /// <param name="logConfig">logConfig.</param>
        /// <param name="meta">meta.</param>
        /// <param name="name">name.</param>
        /// <param name="resources">resources.</param>
        /// <param name="restartPolicy">restartPolicy.</param>
        /// <param name="scalingPolicies">scalingPolicies.</param>
        /// <param name="services">services.</param>
        /// <param name="shutdownDelay">shutdownDelay.</param>
        /// <param name="templates">templates.</param>
        /// <param name="user">user.</param>
        /// <param name="vault">vault.</param>
        /// <param name="volumeMounts">volumeMounts.</param>
        public Task(List<Affinity> affinities = default(List<Affinity>), List<TaskArtifact> artifacts = default(List<TaskArtifact>), TaskCSIPluginConfig cSIPluginConfig = default(TaskCSIPluginConfig), Dictionary<string, Object> config = default(Dictionary<string, Object>), List<Constraint> constraints = default(List<Constraint>), DispatchPayloadConfig dispatchPayload = default(DispatchPayloadConfig), string driver = default(string), Dictionary<string, string> env = default(Dictionary<string, string>), string killSignal = default(string), long killTimeout = default(long), string kind = default(string), bool leader = default(bool), TaskLifecycle lifecycle = default(TaskLifecycle), LogConfig logConfig = default(LogConfig), Dictionary<string, string> meta = default(Dictionary<string, string>), string name = default(string), Resources resources = default(Resources), RestartPolicy restartPolicy = default(RestartPolicy), List<ScalingPolicy> scalingPolicies = default(List<ScalingPolicy>), List<Service> services = default(List<Service>), long shutdownDelay = default(long), List<Template> templates = default(List<Template>), string user = default(string), Vault vault = default(Vault), List<VolumeMount> volumeMounts = default(List<VolumeMount>))
        {
            this.Affinities = affinities;
            this.Artifacts = artifacts;
            this.CSIPluginConfig = cSIPluginConfig;
            this.Config = config;
            this.Constraints = constraints;
            this.DispatchPayload = dispatchPayload;
            this.Driver = driver;
            this.Env = env;
            this.KillSignal = killSignal;
            this.KillTimeout = killTimeout;
            this.Kind = kind;
            this.Leader = leader;
            this.Lifecycle = lifecycle;
            this.LogConfig = logConfig;
            this.Meta = meta;
            this.Name = name;
            this.Resources = resources;
            this.RestartPolicy = restartPolicy;
            this.ScalingPolicies = scalingPolicies;
            this.Services = services;
            this.ShutdownDelay = shutdownDelay;
            this.Templates = templates;
            this.User = user;
            this.Vault = vault;
            this.VolumeMounts = volumeMounts;
        }

        /// <summary>
        /// Gets or Sets Affinities
        /// </summary>
        [DataMember(Name = "Affinities", EmitDefaultValue = false)]
        public List<Affinity> Affinities { get; set; }

        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name = "Artifacts", EmitDefaultValue = false)]
        public List<TaskArtifact> Artifacts { get; set; }

        /// <summary>
        /// Gets or Sets CSIPluginConfig
        /// </summary>
        [DataMember(Name = "CSIPluginConfig", EmitDefaultValue = false)]
        public TaskCSIPluginConfig CSIPluginConfig { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "Config", EmitDefaultValue = false)]
        public Dictionary<string, Object> Config { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name = "Constraints", EmitDefaultValue = false)]
        public List<Constraint> Constraints { get; set; }

        /// <summary>
        /// Gets or Sets DispatchPayload
        /// </summary>
        [DataMember(Name = "DispatchPayload", EmitDefaultValue = false)]
        public DispatchPayloadConfig DispatchPayload { get; set; }

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
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "Kind", EmitDefaultValue = false)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Leader
        /// </summary>
        [DataMember(Name = "Leader", EmitDefaultValue = true)]
        public bool Leader { get; set; }

        /// <summary>
        /// Gets or Sets Lifecycle
        /// </summary>
        [DataMember(Name = "Lifecycle", EmitDefaultValue = false)]
        public TaskLifecycle Lifecycle { get; set; }

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
        /// Gets or Sets RestartPolicy
        /// </summary>
        [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
        public RestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// Gets or Sets ScalingPolicies
        /// </summary>
        [DataMember(Name = "ScalingPolicies", EmitDefaultValue = false)]
        public List<ScalingPolicy> ScalingPolicies { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "Services", EmitDefaultValue = false)]
        public List<Service> Services { get; set; }

        /// <summary>
        /// Gets or Sets ShutdownDelay
        /// </summary>
        [DataMember(Name = "ShutdownDelay", EmitDefaultValue = false)]
        public long ShutdownDelay { get; set; }

        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name = "Templates", EmitDefaultValue = false)]
        public List<Template> Templates { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "User", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Vault
        /// </summary>
        [DataMember(Name = "Vault", EmitDefaultValue = false)]
        public Vault Vault { get; set; }

        /// <summary>
        /// Gets or Sets VolumeMounts
        /// </summary>
        [DataMember(Name = "VolumeMounts", EmitDefaultValue = false)]
        public List<VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Affinities: ").Append(Affinities).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  CSIPluginConfig: ").Append(CSIPluginConfig).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  DispatchPayload: ").Append(DispatchPayload).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  KillSignal: ").Append(KillSignal).Append("\n");
            sb.Append("  KillTimeout: ").Append(KillTimeout).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Leader: ").Append(Leader).Append("\n");
            sb.Append("  Lifecycle: ").Append(Lifecycle).Append("\n");
            sb.Append("  LogConfig: ").Append(LogConfig).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("  ScalingPolicies: ").Append(ScalingPolicies).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  ShutdownDelay: ").Append(ShutdownDelay).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
            sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Affinities == input.Affinities ||
                    this.Affinities != null &&
                    input.Affinities != null &&
                    this.Affinities.SequenceEqual(input.Affinities)
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
                ) && 
                (
                    this.CSIPluginConfig == input.CSIPluginConfig ||
                    (this.CSIPluginConfig != null &&
                    this.CSIPluginConfig.Equals(input.CSIPluginConfig))
                ) && 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    this.Constraints != null &&
                    input.Constraints != null &&
                    this.Constraints.SequenceEqual(input.Constraints)
                ) && 
                (
                    this.DispatchPayload == input.DispatchPayload ||
                    (this.DispatchPayload != null &&
                    this.DispatchPayload.Equals(input.DispatchPayload))
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
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Leader == input.Leader ||
                    this.Leader.Equals(input.Leader)
                ) && 
                (
                    this.Lifecycle == input.Lifecycle ||
                    (this.Lifecycle != null &&
                    this.Lifecycle.Equals(input.Lifecycle))
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
                    this.RestartPolicy == input.RestartPolicy ||
                    (this.RestartPolicy != null &&
                    this.RestartPolicy.Equals(input.RestartPolicy))
                ) && 
                (
                    this.ScalingPolicies == input.ScalingPolicies ||
                    this.ScalingPolicies != null &&
                    input.ScalingPolicies != null &&
                    this.ScalingPolicies.SequenceEqual(input.ScalingPolicies)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.ShutdownDelay == input.ShutdownDelay ||
                    this.ShutdownDelay.Equals(input.ShutdownDelay)
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Vault == input.Vault ||
                    (this.Vault != null &&
                    this.Vault.Equals(input.Vault))
                ) && 
                (
                    this.VolumeMounts == input.VolumeMounts ||
                    this.VolumeMounts != null &&
                    input.VolumeMounts != null &&
                    this.VolumeMounts.SequenceEqual(input.VolumeMounts)
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
                if (this.Affinities != null)
                {
                    hashCode = (hashCode * 59) + this.Affinities.GetHashCode();
                }
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
                }
                if (this.CSIPluginConfig != null)
                {
                    hashCode = (hashCode * 59) + this.CSIPluginConfig.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.Constraints != null)
                {
                    hashCode = (hashCode * 59) + this.Constraints.GetHashCode();
                }
                if (this.DispatchPayload != null)
                {
                    hashCode = (hashCode * 59) + this.DispatchPayload.GetHashCode();
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
                if (this.Kind != null)
                {
                    hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Leader.GetHashCode();
                if (this.Lifecycle != null)
                {
                    hashCode = (hashCode * 59) + this.Lifecycle.GetHashCode();
                }
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
                if (this.RestartPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.RestartPolicy.GetHashCode();
                }
                if (this.ScalingPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.ScalingPolicies.GetHashCode();
                }
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShutdownDelay.GetHashCode();
                if (this.Templates != null)
                {
                    hashCode = (hashCode * 59) + this.Templates.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Vault != null)
                {
                    hashCode = (hashCode * 59) + this.Vault.GetHashCode();
                }
                if (this.VolumeMounts != null)
                {
                    hashCode = (hashCode * 59) + this.VolumeMounts.GetHashCode();
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
