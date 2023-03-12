using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class CategoryScores
{
    [JsonProperty("hate")]
    public double Hate;

    [JsonProperty("hate/threatening")]
    public double HateThreatening;

    [JsonProperty("self-harm")]
    public double SelfHarm;

    [JsonProperty("sexual")]
    public double Sexual;

    [JsonProperty("sexual/minors")]
    public double SexualMinors;

    [JsonProperty("violence")]
    public double Violence;

    [JsonProperty("violence/graphic")]
    public double ViolenceGraphic;
}