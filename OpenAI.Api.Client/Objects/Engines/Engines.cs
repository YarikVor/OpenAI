using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class Engines
{
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("object")]
    public string Object;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("ready")]
    public bool Ready;
}