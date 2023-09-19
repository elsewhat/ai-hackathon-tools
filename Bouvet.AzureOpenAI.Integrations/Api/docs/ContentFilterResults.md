# AzureOpenAI.Model.ContentFilterResults
Information about the content filtering category (hate, sexual, violence, self_harm), if it has been detected, as well as the severity level (very_low, low, medium, high-scale that determines the intensity and risk level of harmful content) and if it has been filtered or not.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sexual** | [**ContentFilterResult**](ContentFilterResult.md) |  | [optional] 
**Violence** | [**ContentFilterResult**](ContentFilterResult.md) |  | [optional] 
**Hate** | [**ContentFilterResult**](ContentFilterResult.md) |  | [optional] 
**SelfHarm** | [**ContentFilterResult**](ContentFilterResult.md) |  | [optional] 
**Error** | [**ErrorBase**](ErrorBase.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

