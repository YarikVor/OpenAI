using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class ListFineTuneEvents
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("data")]
    public List<FineTuneEvent> Data;
}