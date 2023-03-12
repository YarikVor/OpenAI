using System.ComponentModel;

namespace OpenAI.Api.Client;

public enum OpenAIObjectType
{
    [Description("Model")]              
    ModelElement,
    
    [Description("text_completion")]
    TextCompletion,
    
    [Description("chat.completion")]
    ChatCompletion,
    
    [Description("list")]
    ListElement,
    
    [Description("embedding")]
    Embedding,
    
    [Description("file")]
    FileElement,
    
    [Description("fine-tune")]
    FineTune,
    
    [Description("fine-tune-event")]
    FineTuneEvent,
    
    [Description("curie")]
    Curie,
    
    [Description("text-moderation-001")]
    TextModeration,
    
    [Description("engine")]
    EngineElement,
}