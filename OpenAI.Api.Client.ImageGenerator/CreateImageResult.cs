using Newtonsoft.Json;

namespace OpenAI.Api.Client.ImageGenerator;

public class CreateImageResult
{
    [JsonProperty("created")]
    public int Created;

    [JsonProperty("data")]
    public List<ImageResult> Data;
}