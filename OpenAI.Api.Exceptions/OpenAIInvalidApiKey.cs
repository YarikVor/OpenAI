using System.Net;

namespace OpenAI.Api.Exceptions;

public class OpenAIInvalidApiKey : OpenAIClientException
{
    public OpenAIInvalidApiKey() : base(
        "Incorrect API key provided. Ensure the API key used is correct, clear your browser cache, or generate a new one.",
        null,
        HttpStatusCode.Unauthorized)
    {
    }
}