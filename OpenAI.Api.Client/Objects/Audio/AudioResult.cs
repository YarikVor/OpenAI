using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class AudioResult
{
    [JsonProperty("text")]
    public string Text;
}