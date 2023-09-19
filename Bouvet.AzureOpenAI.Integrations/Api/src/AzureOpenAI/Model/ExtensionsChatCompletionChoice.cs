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
    /// ExtensionsChatCompletionChoice
    /// </summary>
    [DataContract(Name = "extensionsChatCompletionChoice")]
    public partial class ExtensionsChatCompletionChoice : IEquatable<ExtensionsChatCompletionChoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="finishReason">finishReason.</param>
        /// <param name="message">message.</param>
        public ExtensionsChatCompletionChoice(int index = default(int), string finishReason = default(string), Message message = default(Message))
        {
            this.Index = index;
            this.FinishReason = finishReason;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets FinishReason
        /// </summary>
        [DataMember(Name = "finish_reason", EmitDefaultValue = true)]
        public string FinishReason { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public Message Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtensionsChatCompletionChoice {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FinishReason: ").Append(FinishReason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ExtensionsChatCompletionChoice);
        }

        /// <summary>
        /// Returns true if ExtensionsChatCompletionChoice instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionsChatCompletionChoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionsChatCompletionChoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.FinishReason == input.FinishReason ||
                    (this.FinishReason != null &&
                    this.FinishReason.Equals(input.FinishReason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.FinishReason != null)
                {
                    hashCode = (hashCode * 59) + this.FinishReason.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
