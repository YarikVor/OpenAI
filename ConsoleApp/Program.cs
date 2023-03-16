// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using OpenAI.Api.Client;
using OpenAI.Api.Client.Completions;
using OpenAI.Api.Client.Models;

using System.Linq;
using System.Text;
using OpenAI.Api.Client.Chats;
using OpenAI.Api.Client.Editor;
using OpenAI.Api.Client.ImageGenerator;

Console.InputEncoding = Console.OutputEncoding = Encoding.Unicode;

const string API_KEY = "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";

OpenAIClient client = OpenAIClient.Create(API_KEY);

var chat = client.AsChat(ChatModel.Turbo).SetMaxTokens(64);

while (true)
{
    Console.Write("[client]: ");

    string inputText = Console.ReadLine();

    if (string.IsNullOrEmpty(inputText))
        return;

    var result = await chat.AddMessage(inputText).Send();
    
    Console.WriteLine($"[assistant]: {result.Choices[0].Message.Content}");
}

