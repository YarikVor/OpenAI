using System.ComponentModel;

namespace OpenAI.Api.Client.ImageGenerator;

public enum ImageFormat
{
    [Description("url")]
    Url,
    
    [Description("b64_json")]
    Base64Json,
}