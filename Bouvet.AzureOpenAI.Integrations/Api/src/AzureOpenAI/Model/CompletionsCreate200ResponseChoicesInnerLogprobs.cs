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
    /// CompletionsCreate200ResponseChoicesInnerLogprobs
    /// </summary>
    [DataContract(Name = "Completions_Create_200_response_choices_inner_logprobs")]
    public partial class CompletionsCreate200ResponseChoicesInnerLogprobs : IEquatable<CompletionsCreate200ResponseChoicesInnerLogprobs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreate200ResponseChoicesInnerLogprobs" /> class.
        /// </summary>
        /// <param name="tokens">tokens.</param>
        /// <param name="tokenLogprobs">tokenLogprobs.</param>
        /// <param name="topLogprobs">topLogprobs.</param>
        /// <param name="textOffset">textOffset.</param>
        public CompletionsCreate200ResponseChoicesInnerLogprobs(List<string> tokens = default(List<string>), List<decimal> tokenLogprobs = default(List<decimal>), List<Dictionary<string, decimal>> topLogprobs = default(List<Dictionary<string, decimal>>), List<int> textOffset = default(List<int>))
        {
            this.Tokens = tokens;
            this.TokenLogprobs = tokenLogprobs;
            this.TopLogprobs = topLogprobs;
            this.TextOffset = textOffset;
        }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", EmitDefaultValue = true)]
        public List<string> Tokens { get; set; }

        /// <summary>
        /// Gets or Sets TokenLogprobs
        /// </summary>
        [DataMember(Name = "token_logprobs", EmitDefaultValue = true)]
        public List<decimal> TokenLogprobs { get; set; }

        /// <summary>
        /// Gets or Sets TopLogprobs
        /// </summary>
        [DataMember(Name = "top_logprobs", EmitDefaultValue = true)]
        public List<Dictionary<string, decimal>> TopLogprobs { get; set; }

        /// <summary>
        /// Gets or Sets TextOffset
        /// </summary>
        [DataMember(Name = "text_offset", EmitDefaultValue = true)]
        public List<int> TextOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompletionsCreate200ResponseChoicesInnerLogprobs {\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  TokenLogprobs: ").Append(TokenLogprobs).Append("\n");
            sb.Append("  TopLogprobs: ").Append(TopLogprobs).Append("\n");
            sb.Append("  TextOffset: ").Append(TextOffset).Append("\n");
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
            return this.Equals(input as CompletionsCreate200ResponseChoicesInnerLogprobs);
        }

        /// <summary>
        /// Returns true if CompletionsCreate200ResponseChoicesInnerLogprobs instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionsCreate200ResponseChoicesInnerLogprobs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionsCreate200ResponseChoicesInnerLogprobs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) && 
                (
                    this.TokenLogprobs == input.TokenLogprobs ||
                    this.TokenLogprobs != null &&
                    input.TokenLogprobs != null &&
                    this.TokenLogprobs.SequenceEqual(input.TokenLogprobs)
                ) && 
                (
                    this.TopLogprobs == input.TopLogprobs ||
                    this.TopLogprobs != null &&
                    input.TopLogprobs != null &&
                    this.TopLogprobs.SequenceEqual(input.TopLogprobs)
                ) && 
                (
                    this.TextOffset == input.TextOffset ||
                    this.TextOffset != null &&
                    input.TextOffset != null &&
                    this.TextOffset.SequenceEqual(input.TextOffset)
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
                if (this.Tokens != null)
                {
                    hashCode = (hashCode * 59) + this.Tokens.GetHashCode();
                }
                if (this.TokenLogprobs != null)
                {
                    hashCode = (hashCode * 59) + this.TokenLogprobs.GetHashCode();
                }
                if (this.TopLogprobs != null)
                {
                    hashCode = (hashCode * 59) + this.TopLogprobs.GetHashCode();
                }
                if (this.TextOffset != null)
                {
                    hashCode = (hashCode * 59) + this.TextOffset.GetHashCode();
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
