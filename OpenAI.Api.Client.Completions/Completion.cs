using Newtonsoft.Json;
using OpenAI.Api.Client.Usages;

namespace OpenAI.Api.Client.Completions;

public class Completion
{
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("object")]
    public string Object;

    [JsonProperty("created")]
    public int Created;

    [JsonProperty("model")]
    public string Model;

    [JsonProperty("choices")]
    public List<ChoiceComplete> Choices;

    [JsonProperty("usage")]
    public Usage Usage;
}