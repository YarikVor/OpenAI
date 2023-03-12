using System.ComponentModel;

namespace OpenAI.Api.Client;

public enum ImageResolution
{
    
    [Description("256x256")]
    Small,
    
    [Description("512x512")]
    Medium,
    
    [Description("1024x1024")]
    Large
}