# AzureOpenAI.Api.DefaultApi

All URIs are relative to *https://your-resource-name.openai.azure.com/openai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatCompletionsCreate**](DefaultApi.md#chatcompletionscreate) | **POST** /deployments/{deployment-id}/chat/completions | Creates a completion for the chat message |
| [**CompletionsCreate**](DefaultApi.md#completionscreate) | **POST** /deployments/{deployment-id}/completions | Creates a completion for the provided prompt, parameters and chosen model. |
| [**EmbeddingsCreate**](DefaultApi.md#embeddingscreate) | **POST** /deployments/{deployment-id}/embeddings | Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms. |
| [**ExtensionsChatCompletionsCreate**](DefaultApi.md#extensionschatcompletionscreate) | **POST** /deployments/{deployment-id}/extensions/chat/completions | Using extensions to creates a completion for the chat messages. |
| [**TranscriptionsCreate**](DefaultApi.md#transcriptionscreate) | **POST** /deployments/{deployment-id}/audio/transcriptions | Transcribes audio into the input language. |
| [**TranslationsCreate**](DefaultApi.md#translationscreate) | **POST** /deployments/{deployment-id}/audio/translations | Transcribes and translates input audio into English text. |

<a id="chatcompletionscreate"></a>
# **ChatCompletionsCreate**
> CreateChatCompletionResponse ChatCompletionsCreate (string deploymentId, string apiVersion, CreateChatCompletionRequest createChatCompletionRequest)

Creates a completion for the chat message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class ChatCompletionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = "deploymentId_example";  // string | 
            var apiVersion = 2023-09-01-preview;  // string | 
            var createChatCompletionRequest = new CreateChatCompletionRequest(); // CreateChatCompletionRequest | 

            try
            {
                // Creates a completion for the chat message
                CreateChatCompletionResponse result = apiInstance.ChatCompletionsCreate(deploymentId, apiVersion, createChatCompletionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ChatCompletionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatCompletionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a completion for the chat message
    ApiResponse<CreateChatCompletionResponse> response = apiInstance.ChatCompletionsCreateWithHttpInfo(deploymentId, apiVersion, createChatCompletionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ChatCompletionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** |  |  |
| **apiVersion** | **string** |  |  |
| **createChatCompletionRequest** | [**CreateChatCompletionRequest**](CreateChatCompletionRequest.md) |  |  |

### Return type

[**CreateChatCompletionResponse**](CreateChatCompletionResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * apim-request-id - Request ID for troubleshooting purposes <br>  |
| **0** | Service unavailable |  * apim-request-id - Request ID for troubleshooting purposes <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="completionscreate"></a>
# **CompletionsCreate**
> CompletionsCreate200Response CompletionsCreate (string deploymentId, string apiVersion, CompletionsCreateRequest completionsCreateRequest)

Creates a completion for the provided prompt, parameters and chosen model.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class CompletionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = davinci;  // string | 
            var apiVersion = 2023-09-01-preview;  // string | 
            var completionsCreateRequest = new CompletionsCreateRequest(); // CompletionsCreateRequest | 

            try
            {
                // Creates a completion for the provided prompt, parameters and chosen model.
                CompletionsCreate200Response result = apiInstance.CompletionsCreate(deploymentId, apiVersion, completionsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CompletionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompletionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a completion for the provided prompt, parameters and chosen model.
    ApiResponse<CompletionsCreate200Response> response = apiInstance.CompletionsCreateWithHttpInfo(deploymentId, apiVersion, completionsCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CompletionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** |  |  |
| **apiVersion** | **string** |  |  |
| **completionsCreateRequest** | [**CompletionsCreateRequest**](CompletionsCreateRequest.md) |  |  |

### Return type

[**CompletionsCreate200Response**](CompletionsCreate200Response.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * apim-request-id - Request ID for troubleshooting purposes <br>  |
| **0** | Service unavailable |  * apim-request-id - Request ID for troubleshooting purposes <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="embeddingscreate"></a>
# **EmbeddingsCreate**
> EmbeddingsCreate200Response EmbeddingsCreate (string deploymentId, string apiVersion, Dictionary<string, Object> requestBody)

Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class EmbeddingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = ada-search-index-v1;  // string | The deployment id of the model which was deployed.
            var apiVersion = 2023-09-01-preview;  // string | 
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 

            try
            {
                // Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
                EmbeddingsCreate200Response result = apiInstance.EmbeddingsCreate(deploymentId, apiVersion, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmbeddingsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmbeddingsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
    ApiResponse<EmbeddingsCreate200Response> response = apiInstance.EmbeddingsCreateWithHttpInfo(deploymentId, apiVersion, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EmbeddingsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** | The deployment id of the model which was deployed. |  |
| **apiVersion** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) |  |  |

### Return type

[**EmbeddingsCreate200Response**](EmbeddingsCreate200Response.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extensionschatcompletionscreate"></a>
# **ExtensionsChatCompletionsCreate**
> ExtensionsChatCompletionsResponse ExtensionsChatCompletionsCreate (string deploymentId, string apiVersion, ExtensionsChatCompletionsRequest extensionsChatCompletionsRequest)

Using extensions to creates a completion for the chat messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class ExtensionsChatCompletionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = "deploymentId_example";  // string | 
            var apiVersion = 2023-09-01-preview;  // string | 
            var extensionsChatCompletionsRequest = new ExtensionsChatCompletionsRequest(); // ExtensionsChatCompletionsRequest | 

            try
            {
                // Using extensions to creates a completion for the chat messages.
                ExtensionsChatCompletionsResponse result = apiInstance.ExtensionsChatCompletionsCreate(deploymentId, apiVersion, extensionsChatCompletionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ExtensionsChatCompletionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtensionsChatCompletionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Using extensions to creates a completion for the chat messages.
    ApiResponse<ExtensionsChatCompletionsResponse> response = apiInstance.ExtensionsChatCompletionsCreateWithHttpInfo(deploymentId, apiVersion, extensionsChatCompletionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ExtensionsChatCompletionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** |  |  |
| **apiVersion** | **string** |  |  |
| **extensionsChatCompletionsRequest** | [**ExtensionsChatCompletionsRequest**](ExtensionsChatCompletionsRequest.md) |  |  |

### Return type

[**ExtensionsChatCompletionsResponse**](ExtensionsChatCompletionsResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * apim-request-id - Request ID for troubleshooting purposes <br>  |
| **0** | Service unavailable |  * apim-request-id - Request ID for troubleshooting purposes <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="transcriptionscreate"></a>
# **TranscriptionsCreate**
> TranscriptionsCreate200Response TranscriptionsCreate (string deploymentId, string apiVersion, System.IO.Stream file, string? prompt = null, ResponseFormat? responseFormat = null, decimal? temperature = null, string? language = null)

Transcribes audio into the input language.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class TranscriptionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = whisper;  // string | 
            var apiVersion = 2023-05-20-preview;  // string | Api version.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The audio file object to transcribe.
            var prompt = "prompt_example";  // string? | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language. (optional) 
            var responseFormat = new ResponseFormat?(); // ResponseFormat? |  (optional) 
            var temperature = 0MD;  // decimal? | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit. (optional)  (default to 0M)
            var language = "language_example";  // string? | The language of the input audio. Supplying the input language in ISO-639-1 format will improve accuracy and latency. (optional) 

            try
            {
                // Transcribes audio into the input language.
                TranscriptionsCreate200Response result = apiInstance.TranscriptionsCreate(deploymentId, apiVersion, file, prompt, responseFormat, temperature, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TranscriptionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranscriptionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transcribes audio into the input language.
    ApiResponse<TranscriptionsCreate200Response> response = apiInstance.TranscriptionsCreateWithHttpInfo(deploymentId, apiVersion, file, prompt, responseFormat, temperature, language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TranscriptionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** |  |  |
| **apiVersion** | **string** | Api version. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | The audio file object to transcribe. |  |
| **prompt** | **string?** | An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language. | [optional]  |
| **responseFormat** | [**ResponseFormat?**](ResponseFormat?.md) |  | [optional]  |
| **temperature** | **decimal?** | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit. | [optional] [default to 0M] |
| **language** | **string?** | The language of the input audio. Supplying the input language in ISO-639-1 format will improve accuracy and latency. | [optional]  |

### Return type

[**TranscriptionsCreate200Response**](TranscriptionsCreate200Response.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="translationscreate"></a>
# **TranslationsCreate**
> TranscriptionsCreate200Response TranslationsCreate (string deploymentId, string apiVersion, System.IO.Stream file, string? prompt = null, ResponseFormat? responseFormat = null, decimal? temperature = null)

Transcribes and translates input audio into English text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AzureOpenAI.Api;
using AzureOpenAI.Client;
using AzureOpenAI.Model;

namespace Example
{
    public class TranslationsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-resource-name.openai.azure.com/openai";
            // Configure API key authorization: apiKey
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure OAuth2 access token for authorization: bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deploymentId = whisper;  // string | 
            var apiVersion = 2023-05-20-preview;  // string | Api version.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The audio file to translate.
            var prompt = "prompt_example";  // string? | An optional text to guide the model's style or continue a previous audio segment. The prompt should be in English. (optional) 
            var responseFormat = new ResponseFormat?(); // ResponseFormat? |  (optional) 
            var temperature = 0MD;  // decimal? | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit. (optional)  (default to 0M)

            try
            {
                // Transcribes and translates input audio into English text.
                TranscriptionsCreate200Response result = apiInstance.TranslationsCreate(deploymentId, apiVersion, file, prompt, responseFormat, temperature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TranslationsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslationsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transcribes and translates input audio into English text.
    ApiResponse<TranscriptionsCreate200Response> response = apiInstance.TranslationsCreateWithHttpInfo(deploymentId, apiVersion, file, prompt, responseFormat, temperature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TranslationsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentId** | **string** |  |  |
| **apiVersion** | **string** | Api version. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | The audio file to translate. |  |
| **prompt** | **string?** | An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should be in English. | [optional]  |
| **responseFormat** | [**ResponseFormat?**](ResponseFormat?.md) |  | [optional]  |
| **temperature** | **decimal?** | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit. | [optional] [default to 0M] |

### Return type

[**TranscriptionsCreate200Response**](TranscriptionsCreate200Response.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

