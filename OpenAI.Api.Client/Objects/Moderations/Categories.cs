using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class Categories
{
    [JsonProperty("hate")]
    public bool Hate;

    [JsonProperty("hate/threatening")]
    public bool HateThreatening;

    [JsonProperty("self-harm")]
    public bool SelfHarm;

    [JsonProperty("sexual")]
    public bool Sexual;

    [JsonProperty("sexual/minors")]
    public bool SexualMinors;

    [JsonProperty("violence")]
    public bool Violence;

    [JsonProperty("violence/graphic")]
    public bool ViolenceGraphic;
}