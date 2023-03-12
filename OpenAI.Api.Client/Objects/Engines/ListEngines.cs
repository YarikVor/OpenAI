using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class ListEngines
{
    [JsonProperty("data")]
    public List<Engines> Data;

    [JsonProperty("object")]
    public string Object;
}