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
    /// CompletionsCreateRequest
    /// </summary>
    [DataContract(Name = "Completions_Create_request")]
    public partial class CompletionsCreateRequest : IEquatable<CompletionsCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateRequest" /> class.
        /// </summary>
        /// <param name="prompt">prompt.</param>
        /// <param name="maxTokens">The token count of your prompt plus max_tokens cannot exceed the model&#39;s context length. Most models have a context length of 2048 tokens (except for the newest models, which support 4096). Has minimum of 0. (default to 16).</param>
        /// <param name="temperature">What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 (argmax sampling) for ones with a well-defined answer. We generally recommend altering this or top_p but not both. (default to 1M).</param>
        /// <param name="topP">An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both. (default to 1M).</param>
        /// <param name="logitBias">Defaults to null. Modify the likelihood of specified tokens appearing in the completion. Accepts a json object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this tokenizer tool (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token. As an example, you can pass {\&quot;50256\&quot; &amp;#58; -100} to prevent the &lt;|endoftext|&gt; token from being generated..</param>
        /// <param name="user">A unique identifier representing your end-user, which can help monitoring and detecting abuse.</param>
        /// <param name="n">How many completions to generate for each prompt. Minimum of 1 and maximum of 128 allowed. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop. (default to 1).</param>
        /// <param name="stream">Whether to stream back partial progress. If set, tokens will be sent as data-only server-sent events as they become available, with the stream terminated by a data: [DONE] message. (default to false).</param>
        /// <param name="logprobs">Include the log probabilities on the logprobs most likely tokens, as well the chosen tokens. For example, if logprobs is 5, the API will return a list of the 5 most likely tokens. The API will always return the logprob of the sampled token, so there may be up to logprobs+1 elements in the response. Minimum of 0 and maximum of 5 allowed..</param>
        /// <param name="suffix">The suffix that comes after a completion of inserted text..</param>
        /// <param name="echo">Echo back the prompt in addition to the completion (default to false).</param>
        /// <param name="stop">stop.</param>
        /// <param name="completionConfig">completionConfig.</param>
        /// <param name="presencePenalty">Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#39;s likelihood to talk about new topics. (default to 0M).</param>
        /// <param name="frequencyPenalty">Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#39;s likelihood to repeat the same line verbatim. (default to 0M).</param>
        /// <param name="bestOf">Generates best_of completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed. When used with n, best_of controls the number of candidate completions and n specifies how many to return - best_of must be greater than n. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop. Has maximum value of 128..</param>
        public CompletionsCreateRequest(CompletionsCreateRequestPrompt prompt = default(CompletionsCreateRequestPrompt), int? maxTokens = 16, decimal? temperature = 1M, decimal? topP = 1M, Object logitBias = default(Object), string user = default(string), int? n = 1, bool? stream = false, int? logprobs = default(int?), string suffix = default(string), bool? echo = false, CompletionsCreateRequestStop stop = default(CompletionsCreateRequestStop), string completionConfig = default(string), decimal presencePenalty = 0M, decimal frequencyPenalty = 0M, int bestOf = default(int))
        {
            this.Prompt = prompt;
            // use default value if no "maxTokens" provided
            this.MaxTokens = maxTokens ?? 16;
            // use default value if no "temperature" provided
            this.Temperature = temperature ?? 1M;
            // use default value if no "topP" provided
            this.TopP = topP ?? 1M;
            this.LogitBias = logitBias;
            this.User = user;
            // use default value if no "n" provided
            this.N = n ?? 1;
            // use default value if no "stream" provided
            this.Stream = stream ?? false;
            this.Logprobs = logprobs;
            this.Suffix = suffix;
            // use default value if no "echo" provided
            this.Echo = echo ?? false;
            this.Stop = stop;
            this.CompletionConfig = completionConfig;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.BestOf = bestOf;
        }

        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name = "prompt", EmitDefaultValue = true)]
        public CompletionsCreateRequestPrompt Prompt { get; set; }

        /// <summary>
        /// The token count of your prompt plus max_tokens cannot exceed the model&#39;s context length. Most models have a context length of 2048 tokens (except for the newest models, which support 4096). Has minimum of 0.
        /// </summary>
        /// <value>The token count of your prompt plus max_tokens cannot exceed the model&#39;s context length. Most models have a context length of 2048 tokens (except for the newest models, which support 4096). Has minimum of 0.</value>
        /// <example>16</example>
        [DataMember(Name = "max_tokens", EmitDefaultValue = true)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 (argmax sampling) for ones with a well-defined answer. We generally recommend altering this or top_p but not both.
        /// </summary>
        /// <value>What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 (argmax sampling) for ones with a well-defined answer. We generally recommend altering this or top_p but not both.</value>
        /// <example>1</example>
        [DataMember(Name = "temperature", EmitDefaultValue = true)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.
        /// </summary>
        /// <value>An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.</value>
        /// <example>1</example>
        [DataMember(Name = "top_p", EmitDefaultValue = true)]
        public decimal? TopP { get; set; }

        /// <summary>
        /// Defaults to null. Modify the likelihood of specified tokens appearing in the completion. Accepts a json object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this tokenizer tool (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token. As an example, you can pass {\&quot;50256\&quot; &amp;#58; -100} to prevent the &lt;|endoftext|&gt; token from being generated.
        /// </summary>
        /// <value>Defaults to null. Modify the likelihood of specified tokens appearing in the completion. Accepts a json object that maps tokens (specified by their token ID in the GPT tokenizer) to an associated bias value from -100 to 100. You can use this tokenizer tool (which works for both GPT-2 and GPT-3) to convert text to token IDs. Mathematically, the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model, but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should result in a ban or exclusive selection of the relevant token. As an example, you can pass {\&quot;50256\&quot; &amp;#58; -100} to prevent the &lt;|endoftext|&gt; token from being generated.</value>
        [DataMember(Name = "logit_bias", EmitDefaultValue = true)]
        public Object LogitBias { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help monitoring and detecting abuse
        /// </summary>
        /// <value>A unique identifier representing your end-user, which can help monitoring and detecting abuse</value>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// How many completions to generate for each prompt. Minimum of 1 and maximum of 128 allowed. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop.
        /// </summary>
        /// <value>How many completions to generate for each prompt. Minimum of 1 and maximum of 128 allowed. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop.</value>
        /// <example>1</example>
        [DataMember(Name = "n", EmitDefaultValue = true)]
        public int? N { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-sent events as they become available, with the stream terminated by a data: [DONE] message.
        /// </summary>
        /// <value>Whether to stream back partial progress. If set, tokens will be sent as data-only server-sent events as they become available, with the stream terminated by a data: [DONE] message.</value>
        [DataMember(Name = "stream", EmitDefaultValue = true)]
        public bool? Stream { get; set; }

        /// <summary>
        /// Include the log probabilities on the logprobs most likely tokens, as well the chosen tokens. For example, if logprobs is 5, the API will return a list of the 5 most likely tokens. The API will always return the logprob of the sampled token, so there may be up to logprobs+1 elements in the response. Minimum of 0 and maximum of 5 allowed.
        /// </summary>
        /// <value>Include the log probabilities on the logprobs most likely tokens, as well the chosen tokens. For example, if logprobs is 5, the API will return a list of the 5 most likely tokens. The API will always return the logprob of the sampled token, so there may be up to logprobs+1 elements in the response. Minimum of 0 and maximum of 5 allowed.</value>
        [DataMember(Name = "logprobs", EmitDefaultValue = true)]
        public int? Logprobs { get; set; }

        /// <summary>
        /// The suffix that comes after a completion of inserted text.
        /// </summary>
        /// <value>The suffix that comes after a completion of inserted text.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Echo back the prompt in addition to the completion
        /// </summary>
        /// <value>Echo back the prompt in addition to the completion</value>
        [DataMember(Name = "echo", EmitDefaultValue = true)]
        public bool? Echo { get; set; }

        /// <summary>
        /// Gets or Sets Stop
        /// </summary>
        [DataMember(Name = "stop", EmitDefaultValue = true)]
        public CompletionsCreateRequestStop Stop { get; set; }

        /// <summary>
        /// Gets or Sets CompletionConfig
        /// </summary>
        [DataMember(Name = "completion_config", EmitDefaultValue = true)]
        public string CompletionConfig { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#39;s likelihood to talk about new topics.
        /// </summary>
        /// <value>Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&#39;s likelihood to talk about new topics.</value>
        [DataMember(Name = "presence_penalty", EmitDefaultValue = true)]
        public decimal PresencePenalty { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#39;s likelihood to repeat the same line verbatim.
        /// </summary>
        /// <value>Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&#39;s likelihood to repeat the same line verbatim.</value>
        [DataMember(Name = "frequency_penalty", EmitDefaultValue = true)]
        public decimal FrequencyPenalty { get; set; }

        /// <summary>
        /// Generates best_of completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed. When used with n, best_of controls the number of candidate completions and n specifies how many to return - best_of must be greater than n. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop. Has maximum value of 128.
        /// </summary>
        /// <value>Generates best_of completions server-side and returns the \&quot;best\&quot; (the one with the highest log probability per token). Results cannot be streamed. When used with n, best_of controls the number of candidate completions and n specifies how many to return - best_of must be greater than n. Note: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop. Has maximum value of 128.</value>
        [DataMember(Name = "best_of", EmitDefaultValue = true)]
        public int BestOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompletionsCreateRequest {\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  MaxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  TopP: ").Append(TopP).Append("\n");
            sb.Append("  LogitBias: ").Append(LogitBias).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  Logprobs: ").Append(Logprobs).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Echo: ").Append(Echo).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  CompletionConfig: ").Append(CompletionConfig).Append("\n");
            sb.Append("  PresencePenalty: ").Append(PresencePenalty).Append("\n");
            sb.Append("  FrequencyPenalty: ").Append(FrequencyPenalty).Append("\n");
            sb.Append("  BestOf: ").Append(BestOf).Append("\n");
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
            return this.Equals(input as CompletionsCreateRequest);
        }

        /// <summary>
        /// Returns true if CompletionsCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionsCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionsCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.MaxTokens == input.MaxTokens ||
                    (this.MaxTokens != null &&
                    this.MaxTokens.Equals(input.MaxTokens))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.TopP == input.TopP ||
                    (this.TopP != null &&
                    this.TopP.Equals(input.TopP))
                ) && 
                (
                    this.LogitBias == input.LogitBias ||
                    (this.LogitBias != null &&
                    this.LogitBias.Equals(input.LogitBias))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.Logprobs == input.Logprobs ||
                    (this.Logprobs != null &&
                    this.Logprobs.Equals(input.Logprobs))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Echo == input.Echo ||
                    (this.Echo != null &&
                    this.Echo.Equals(input.Echo))
                ) && 
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) && 
                (
                    this.CompletionConfig == input.CompletionConfig ||
                    (this.CompletionConfig != null &&
                    this.CompletionConfig.Equals(input.CompletionConfig))
                ) && 
                (
                    this.PresencePenalty == input.PresencePenalty ||
                    this.PresencePenalty.Equals(input.PresencePenalty)
                ) && 
                (
                    this.FrequencyPenalty == input.FrequencyPenalty ||
                    this.FrequencyPenalty.Equals(input.FrequencyPenalty)
                ) && 
                (
                    this.BestOf == input.BestOf ||
                    this.BestOf.Equals(input.BestOf)
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
                if (this.Prompt != null)
                {
                    hashCode = (hashCode * 59) + this.Prompt.GetHashCode();
                }
                if (this.MaxTokens != null)
                {
                    hashCode = (hashCode * 59) + this.MaxTokens.GetHashCode();
                }
                if (this.Temperature != null)
                {
                    hashCode = (hashCode * 59) + this.Temperature.GetHashCode();
                }
                if (this.TopP != null)
                {
                    hashCode = (hashCode * 59) + this.TopP.GetHashCode();
                }
                if (this.LogitBias != null)
                {
                    hashCode = (hashCode * 59) + this.LogitBias.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.N != null)
                {
                    hashCode = (hashCode * 59) + this.N.GetHashCode();
                }
                if (this.Stream != null)
                {
                    hashCode = (hashCode * 59) + this.Stream.GetHashCode();
                }
                if (this.Logprobs != null)
                {
                    hashCode = (hashCode * 59) + this.Logprobs.GetHashCode();
                }
                if (this.Suffix != null)
                {
                    hashCode = (hashCode * 59) + this.Suffix.GetHashCode();
                }
                if (this.Echo != null)
                {
                    hashCode = (hashCode * 59) + this.Echo.GetHashCode();
                }
                if (this.Stop != null)
                {
                    hashCode = (hashCode * 59) + this.Stop.GetHashCode();
                }
                if (this.CompletionConfig != null)
                {
                    hashCode = (hashCode * 59) + this.CompletionConfig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PresencePenalty.GetHashCode();
                hashCode = (hashCode * 59) + this.FrequencyPenalty.GetHashCode();
                hashCode = (hashCode * 59) + this.BestOf.GetHashCode();
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
