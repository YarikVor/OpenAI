using System.ComponentModel;

namespace OpenAI.Api.Client;

public enum ResponseImageFormat
{
    [Description("url")]
    Url,
    
    [Description("b64_json")]
    Base64Json
}