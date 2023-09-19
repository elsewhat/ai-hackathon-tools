# AzureOpenAI.Model.CreateChatCompletionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**VarObject** | **string** |  | 
**Created** | **int** |  | 
**Model** | **string** |  | 
**Usage** | [**ChatCompletionsResponseCommonUsage**](ChatCompletionsResponseCommonUsage.md) |  | [optional] 
**PromptFilterResults** | [**List&lt;PromptFilterResult&gt;**](PromptFilterResult.md) | Content filtering results for zero or more prompts in the request. In a streaming request, results for different prompts may arrive at different times or in different orders. | [optional] 
**Choices** | [**List&lt;CreateChatCompletionResponseAllOfChoicesInner&gt;**](CreateChatCompletionResponseAllOfChoicesInner.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

