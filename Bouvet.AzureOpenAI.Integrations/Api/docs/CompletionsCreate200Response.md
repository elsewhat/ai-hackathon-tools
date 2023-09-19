# AzureOpenAI.Model.CompletionsCreate200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**VarObject** | **string** |  | 
**Created** | **int** |  | 
**Model** | **string** |  | 
**PromptFilterResults** | [**List&lt;PromptFilterResult&gt;**](PromptFilterResult.md) | Content filtering results for zero or more prompts in the request. In a streaming request, results for different prompts may arrive at different times or in different orders. | [optional] 
**Choices** | [**List&lt;CompletionsCreate200ResponseChoicesInner&gt;**](CompletionsCreate200ResponseChoicesInner.md) |  | 
**Usage** | [**CompletionsCreate200ResponseUsage**](CompletionsCreate200ResponseUsage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

