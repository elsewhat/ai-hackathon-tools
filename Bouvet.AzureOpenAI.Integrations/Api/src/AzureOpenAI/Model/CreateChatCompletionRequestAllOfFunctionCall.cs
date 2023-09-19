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
using System.Reflection;

namespace AzureOpenAI.Model
{
    /// <summary>
    /// Controls how the model responds to function calls. \&quot;none\&quot; means the model does not call a function, and responds to the end-user. \&quot;auto\&quot; means the model can pick between an end-user or calling a function.  Specifying a particular function via &#x60;{\&quot;name\&quot;:\\ \&quot;my_function\&quot;}&#x60; forces the model to call that function. \&quot;none\&quot; is the default when no functions are present. \&quot;auto\&quot; is the default if functions are present.
    /// </summary>
    [JsonConverter(typeof(CreateChatCompletionRequestAllOfFunctionCallJsonConverter))]
    [DataContract(Name = "createChatCompletionRequest_allOf_function_call")]
    public partial class CreateChatCompletionRequestAllOfFunctionCall : AbstractOpenAPISchema, IEquatable<CreateChatCompletionRequestAllOfFunctionCall>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestAllOfFunctionCall" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public CreateChatCompletionRequestAllOfFunctionCall(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestAllOfFunctionCall" /> class
        /// with the <see cref="CreateChatCompletionRequestAllOfFunctionCallOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateChatCompletionRequestAllOfFunctionCallOneOf.</param>
        public CreateChatCompletionRequestAllOfFunctionCall(CreateChatCompletionRequestAllOfFunctionCallOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CreateChatCompletionRequestAllOfFunctionCallOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CreateChatCompletionRequestAllOfFunctionCallOneOf, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CreateChatCompletionRequestAllOfFunctionCallOneOf`. If the actual instance is not `CreateChatCompletionRequestAllOfFunctionCallOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateChatCompletionRequestAllOfFunctionCallOneOf</returns>
        public CreateChatCompletionRequestAllOfFunctionCallOneOf GetCreateChatCompletionRequestAllOfFunctionCallOneOf()
        {
            return (CreateChatCompletionRequestAllOfFunctionCallOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChatCompletionRequestAllOfFunctionCall {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, CreateChatCompletionRequestAllOfFunctionCall.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateChatCompletionRequestAllOfFunctionCall
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateChatCompletionRequestAllOfFunctionCall</returns>
        public static CreateChatCompletionRequestAllOfFunctionCall FromJson(string jsonString)
        {
            CreateChatCompletionRequestAllOfFunctionCall newCreateChatCompletionRequestAllOfFunctionCall = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateChatCompletionRequestAllOfFunctionCall;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CreateChatCompletionRequestAllOfFunctionCallOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newCreateChatCompletionRequestAllOfFunctionCall = new CreateChatCompletionRequestAllOfFunctionCall(JsonConvert.DeserializeObject<CreateChatCompletionRequestAllOfFunctionCallOneOf>(jsonString, CreateChatCompletionRequestAllOfFunctionCall.SerializerSettings));
                }
                else
                {
                    newCreateChatCompletionRequestAllOfFunctionCall = new CreateChatCompletionRequestAllOfFunctionCall(JsonConvert.DeserializeObject<CreateChatCompletionRequestAllOfFunctionCallOneOf>(jsonString, CreateChatCompletionRequestAllOfFunctionCall.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateChatCompletionRequestAllOfFunctionCallOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateChatCompletionRequestAllOfFunctionCallOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newCreateChatCompletionRequestAllOfFunctionCall = new CreateChatCompletionRequestAllOfFunctionCall(JsonConvert.DeserializeObject<string>(jsonString, CreateChatCompletionRequestAllOfFunctionCall.SerializerSettings));
                }
                else
                {
                    newCreateChatCompletionRequestAllOfFunctionCall = new CreateChatCompletionRequestAllOfFunctionCall(JsonConvert.DeserializeObject<string>(jsonString, CreateChatCompletionRequestAllOfFunctionCall.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCreateChatCompletionRequestAllOfFunctionCall;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateChatCompletionRequestAllOfFunctionCall);
        }

        /// <summary>
        /// Returns true if CreateChatCompletionRequestAllOfFunctionCall instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateChatCompletionRequestAllOfFunctionCall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChatCompletionRequestAllOfFunctionCall input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for CreateChatCompletionRequestAllOfFunctionCall
    /// </summary>
    public class CreateChatCompletionRequestAllOfFunctionCallJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateChatCompletionRequestAllOfFunctionCall).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return CreateChatCompletionRequestAllOfFunctionCall.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}