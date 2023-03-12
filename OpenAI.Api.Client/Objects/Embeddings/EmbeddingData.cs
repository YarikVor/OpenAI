using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class EmbeddingData
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("embedding")]
    public List<double> Embedding;

    [JsonProperty("index")]
    public int Index;
}