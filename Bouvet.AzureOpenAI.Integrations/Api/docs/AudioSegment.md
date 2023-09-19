# AzureOpenAI.Model.AudioSegment
Transcription or translation segment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Segment identifier. | [optional] 
**Seek** | **decimal** | Offset of the segment. | [optional] 
**Start** | **decimal** | Segment start offset. | [optional] 
**End** | **decimal** | Segment end offset. | [optional] 
**Text** | **string** | Segment text. | [optional] 
**Tokens** | **List&lt;decimal&gt;** | Tokens of the text. | [optional] 
**Temperature** | **decimal** | Temperature. | [optional] 
**AvgLogprob** | **decimal** | Average log probability. | [optional] 
**CompressionRatio** | **decimal** | Compression ratio. | [optional] 
**NoSpeechProb** | **decimal** | Probability of &#39;no speech&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

