using System.ComponentModel;

namespace OpenAI.Api.Client.Editor;

public enum EditModel
{
    [Description("text-davinci-edit-001")]
    Text,
    
    [Description("code-davinci-edit-001")]
    Code,
}