/*
 * Azure OpenAI Service API
 *
 * Azure OpenAI APIs for completions and search
 *
 * The version of the OpenAPI document: 2023-09-01-preview
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace AzureOpenAI.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
