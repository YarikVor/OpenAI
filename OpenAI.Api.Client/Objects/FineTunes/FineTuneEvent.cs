using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class FineTuneEvent
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("created_at")]
    public int CreatedAt;

    [JsonProperty("level")]
    public string Level;

    [JsonProperty("message")]
    public string Message;
}