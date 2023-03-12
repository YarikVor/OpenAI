using Newtonsoft.Json;
using OpenAI.Api.Client.Usages;

namespace OpenAI.Api.Client;

public class EmbeddingResult
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("data")]
    public List<EmbeddingData> Data;

    [JsonProperty("model")]
    public string Model;

    [JsonProperty("usage")]
    public Usage Usage;
}