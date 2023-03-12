using Newtonsoft.Json;

namespace OpenAI.Api.Client;

public class Hyperparams
{
    [JsonProperty("batch_size")]
    public int BatchSize;

    [JsonProperty("learning_rate_multiplier")]
    public double LearningRateMultiplier;

    [JsonProperty("n_epochs")]
    public int NEpochs;

    [JsonProperty("prompt_loss_weight")]
    public double PromptLossWeight;
}