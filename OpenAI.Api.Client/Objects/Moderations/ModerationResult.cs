using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class ModerationResult
{
    [JsonProperty("categories")]
    public Categories Categories;

    [JsonProperty("category_scores")]
    public CategoryScores CategoryScores;

    [JsonProperty("flagged")]
    public bool Flagged;
}