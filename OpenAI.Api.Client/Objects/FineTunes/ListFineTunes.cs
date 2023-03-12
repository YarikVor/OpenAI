using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class ListFineTunes
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("data")]
    public List<FineTune> Data;
}