using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class ChoiceComplete
{
    [JsonProperty("text")]
    public string Text;

    [JsonProperty("index")]
    public int Index;

    [JsonProperty("logprobs")]
    public object Logprobs;

    [JsonProperty("finish_reason")]
    public string FinishReason;
}