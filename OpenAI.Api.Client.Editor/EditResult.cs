using Newtonsoft.Json;
using OpenAI.Api.Client.Usages;

namespace OpenAI.Api.Client.Editor;

public class EditResult
{
    [JsonProperty("object")]
    public string Object;

    [JsonProperty("created")]
    public int Created;

    [JsonProperty("choices")]
    public List<ChoiceEdit> Choices;

    [JsonProperty("usage")]
    public Usage Usage;
}