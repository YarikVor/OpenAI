using OpenAI.Api.Client.Models;

namespace OpenAI.Api.Client.Completions;

public static class CompletionsBuilderMethods
{
    public static CompletionsBuilder AsCompletions(this OpenAIClient client, string modelId)
    {
        return new CompletionsBuilder(client, modelId);
    }
    
    public static CompletionsBuilder AsCompletions(this OpenAIClient client, Model model)
    {
        return client.AsCompletions(model.Id);
    }
    
    public static CompletionsBuilder AsCompletions(this OpenAIClient client, CompletionModel model)
    {
        return client.AsCompletions(model.GetDescription());
    }
}