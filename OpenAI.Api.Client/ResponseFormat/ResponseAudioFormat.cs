using System.ComponentModel;

namespace OpenAI.Api.Client;

public enum ResponseFileFormat
{
    [Description("json")]
    Json,
    
    [Description("text")]
    Text,
    
    [Description("src")]
    Srt,
    
    [Description("verbose_json")]
    VerboseJson,
    
    [Description("vtt")]
    Vtt
}