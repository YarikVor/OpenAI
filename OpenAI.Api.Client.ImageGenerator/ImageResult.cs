using Newtonsoft.Json;

namespace OpenAI.Api.Client.ImageGenerator;

public class ImageResult
{
    [JsonProperty("url")]
    public string Url;
    
    [JsonProperty("b64_json")]
    public string Base64Json;
}