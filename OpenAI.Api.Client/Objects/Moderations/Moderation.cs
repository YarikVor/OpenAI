using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class Moderation
{
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("model")]
    public string Model;

    [JsonProperty("results")]
    public List<ModerationResult> Results;
}