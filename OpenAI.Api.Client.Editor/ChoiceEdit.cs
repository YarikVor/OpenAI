using Newtonsoft.Json;

namespace OpenAI.Api.Client.Editor;

public class ChoiceEdit
{
    [JsonProperty("text")]
    public string Text;

    [JsonProperty("index")]
    public int Index;
}