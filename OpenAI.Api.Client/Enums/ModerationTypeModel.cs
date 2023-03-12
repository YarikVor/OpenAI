using System.ComponentModel;

namespace OpenAI.Api.Client;

public enum ModerationTypeModel
{
    [Description("text-moderation-latest")]
    Latest,
    
    [Description("text-moderation-stable")]
    Stable
}