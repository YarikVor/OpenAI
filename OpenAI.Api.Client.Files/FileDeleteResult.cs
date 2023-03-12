using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class FileDeleteResult
{
    [JsonProperty("id")] public string Id;

    [JsonProperty("object")] public string Object;

    [JsonProperty("deleted")] public bool Deleted;
}