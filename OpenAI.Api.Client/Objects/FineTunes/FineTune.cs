using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class FineTune
{
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("object")]
    public string Object;

    [JsonProperty("model")]
    public string Model;

    [JsonProperty("created_at")]
    public int CreatedAt;

    [JsonProperty("fine_tuned_model")]
    public object FineTunedModel;

    [JsonProperty("hyperparams")]
    public Hyperparams Hyperparams;

    [JsonProperty("organization_id")]
    public string OrganizationId;

    [JsonProperty("result_files")]
    public List<object> ResultFiles;

    [JsonProperty("status")]
    public string Status;

    [JsonProperty("validation_files")]
    public List<object> ValidationFiles;

    [JsonProperty("training_files")]
    public List<object> TrainingFiles;

    [JsonProperty("updated_at")]
    public int UpdatedAt;
}