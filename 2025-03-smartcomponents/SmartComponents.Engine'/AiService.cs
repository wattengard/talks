using System.Collections;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Microsoft.Extensions.AI;
using OllamaSharp;
using OllamaSharp.Models;
using OllamaSharp.Models.Chat;

namespace SmartComponents.Engine
{
    public class AiService(OllamaApiClient.Configuration config) : IAiService
    {
        private OllamaApiClient _ollama = new(config);

        public async Task<T?> CreateObject<T>(string prompt)
        {
            var schema = AIJsonUtilities.CreateJsonSchema(typeof(T));

            var request = new GenerateRequest()
            {
                Format = schema,
                System = "You are an AI assistant building objects from text",
                Prompt = prompt
            };

            var returnable = new StringBuilder();
            await foreach (var stream in _ollama.GenerateAsync(request))
            {
                returnable.Append(stream!.Response);
            }

            return JsonSerializer.Deserialize<T>(returnable.ToString(), JsonSerializerOptions.Web);
        }

        public async Task<T?> ManipulateObject<T>(T inputObject, string prompt)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Converters = { new JsonStringEnumConverter() },
                PropertyNameCaseInsensitive = true
            };
            
            var schema = AIJsonUtilities.CreateJsonSchema(typeof(T));
            var inputObjectJson = JsonSerializer.Serialize(inputObject, options);

            var request = new GenerateRequest()
            {
                Format = schema,
                System = "You are an AI assistant building objects from text",
                Prompt = $"""
                          Using the following json as input data:
                          {inputObjectJson}
                          {prompt}
                          """
            };

            var returnable = new StringBuilder();
            await foreach (var stream in _ollama.GenerateAsync(request))
            {
                if (!string.IsNullOrWhiteSpace(stream!.Response)) returnable.Append(stream!.Response);
            }

            var returnableString = returnable.ToString();
            var returnableObject = JsonSerializer.Deserialize<T>(returnableString, options);
            return returnableObject;
        }
    }

    public interface IAiService
    {
        Task<T?> ManipulateObject<T>(T inputObject, string prompt);
        Task<T?> CreateObject<T>(string prompt);
    }
}
