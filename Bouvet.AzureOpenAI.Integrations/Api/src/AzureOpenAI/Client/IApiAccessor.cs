/*
 * Azure OpenAI Service API
 *
 * Azure OpenAI APIs for completions and search
 *
 * The version of the OpenAPI document: 2023-09-01-preview
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace AzureOpenAI.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        string GetBasePath();

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }
    }
}
