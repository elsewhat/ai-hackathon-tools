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
    /// Inner error with additional details.
    /// </summary>
    [DataContract(Name = "innerError")]
    public partial class InnerError : IEquatable<InnerError>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public InnerErrorCode? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerError" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="contentFilterResults">contentFilterResults.</param>
        public InnerError(InnerErrorCode? code = default(InnerErrorCode?), ContentFilterResults contentFilterResults = default(ContentFilterResults))
        {
            this.Code = code;
            this.ContentFilterResults = contentFilterResults;
        }

        /// <summary>
        /// Gets or Sets ContentFilterResults
        /// </summary>
        [DataMember(Name = "content_filter_results", EmitDefaultValue = true)]
        public ContentFilterResults ContentFilterResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InnerError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ContentFilterResults: ").Append(ContentFilterResults).Append("\n");
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
            return this.Equals(input as InnerError);
        }

        /// <summary>
        /// Returns true if InnerError instances are equal
        /// </summary>
        /// <param name="input">Instance of InnerError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InnerError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.ContentFilterResults == input.ContentFilterResults ||
                    (this.ContentFilterResults != null &&
                    this.ContentFilterResults.Equals(input.ContentFilterResults))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.ContentFilterResults != null)
                {
                    hashCode = (hashCode * 59) + this.ContentFilterResults.GetHashCode();
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
