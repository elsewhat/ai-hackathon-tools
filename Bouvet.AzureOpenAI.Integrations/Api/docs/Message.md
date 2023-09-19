# AzureOpenAI.Model.Message
A chat message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | The index of the message in the conversation. | [optional] 
**Role** | **string** | The role of the author of this message. | 
**Recipient** | **string** | The recipient of the message in the format of &lt;namespace&gt;.&lt;operation&gt;. Present if and only if the recipient is tool. | [optional] 
**Content** | **string** | The contents of the message | 
**EndTurn** | **bool** | Whether the message ends the turn. | [optional] 
**Context** | [**MessageContext**](MessageContext.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

