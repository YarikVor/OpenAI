using Newtonsoft.Json;

namespace OpenAI.Api.Client.Models;

public class ListModels
{
    [JsonProperty("data")]
    public Model[] Models;

    [JsonProperty("object")]
    public string Object;
    
    
    
}