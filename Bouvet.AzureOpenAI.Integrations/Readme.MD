# Generate API stub generation
Run repo in devcontainer in Visual Studio Code

Download API contracts from https://learn.microsoft.com/en-us/azure/ai-services/openai/reference  + https://github.com/Azure/azure-rest-api-specs/tree/main/specification/cognitiveservices/data-plane/AzureOpenAI/inference/preview

Update servers endpoint in API contract ?

Run 
`openapi-generator generate -g csharp -i 2023-09-01-preview_inference.json -o ./Api -c config.yml`

Profit!!