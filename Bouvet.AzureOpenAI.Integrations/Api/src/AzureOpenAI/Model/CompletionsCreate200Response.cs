/*
 * Azure OpenAI Service API
 *
 * Azure OpenAI APIs for completions and search
 *
 * The version of the OpenAPI document: 2023-09-01-preview
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
using OpenAPIDateConverter = AzureOpenAI.Client.OpenAPIDateConverter;

namespace AzureOpenAI.Model
{
    /// <summary>
    /// CompletionsCreate200Response
    /// </summary>
    [DataContract(Name = "Completions_Create_200_response")]
    public partial class CompletionsCreate200Response : IEquatable<CompletionsCreate200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreate200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompletionsCreate200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreate200Response" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="model">model (required).</param>
        /// <param name="promptFilterResults">Content filtering results for zero or more prompts in the request. In a streaming request, results for different prompts may arrive at different times or in different orders..</param>
        /// <param name="choices">choices (required).</param>
        /// <param name="usage">usage.</param>
        public CompletionsCreate200Response(string id = default(string), string varObject = default(string), int created = default(int), string model = default(string), List<PromptFilterResult> promptFilterResults = default(List<PromptFilterResult>), List<CompletionsCreate200ResponseChoicesInner> choices = default(List<CompletionsCreate200ResponseChoicesInner>), CompletionsCreate200ResponseUsage usage = default(CompletionsCreate200ResponseUsage))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CompletionsCreate200Response and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CompletionsCreate200Response and cannot be null");
            }
            this.VarObject = varObject;
            this.Created = created;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for CompletionsCreate200Response and cannot be null");
            }
            this.Model = model;
            // to ensure "choices" is required (not null)
            if (choices == null)
            {
                throw new ArgumentNullException("choices is a required property for CompletionsCreate200Response and cannot be null");
            }
            this.Choices = choices;
            this.PromptFilterResults = promptFilterResults;
            this.Usage = usage;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public int Created { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// Content filtering results for zero or more prompts in the request. In a streaming request, results for different prompts may arrive at different times or in different orders.
        /// </summary>
        /// <value>Content filtering results for zero or more prompts in the request. In a streaming request, results for different prompts may arrive at different times or in different orders.</value>
        [DataMember(Name = "prompt_filter_results", EmitDefaultValue = true)]
        public List<PromptFilterResult> PromptFilterResults { get; set; }

        /// <summary>
        /// Gets or Sets Choices
        /// </summary>
        [DataMember(Name = "choices", IsRequired = true, EmitDefaultValue = true)]
        public List<CompletionsCreate200ResponseChoicesInner> Choices { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = true)]
        public CompletionsCreate200ResponseUsage Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompletionsCreate200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  PromptFilterResults: ").Append(PromptFilterResults).Append("\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
            return this.Equals(input as CompletionsCreate200Response);
        }

        /// <summary>
        /// Returns true if CompletionsCreate200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionsCreate200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionsCreate200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.Created == input.Created ||
                    this.Created.Equals(input.Created)
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.PromptFilterResults == input.PromptFilterResults ||
                    this.PromptFilterResults != null &&
                    input.PromptFilterResults != null &&
                    this.PromptFilterResults.SequenceEqual(input.PromptFilterResults)
                ) && 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Created.GetHashCode();
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.PromptFilterResults != null)
                {
                    hashCode = (hashCode * 59) + this.PromptFilterResults.GetHashCode();
                }
                if (this.Choices != null)
                {
                    hashCode = (hashCode * 59) + this.Choices.GetHashCode();
                }
                if (this.Usage != null)
                {
                    hashCode = (hashCode * 59) + this.Usage.GetHashCode();
                }
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
