using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class FileList
{
    [JsonProperty("data")]
    public List<FileInfo> Data;

    [JsonProperty("object")]
    public string Object;
}