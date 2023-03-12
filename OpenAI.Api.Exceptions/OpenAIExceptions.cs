using System.Net;

namespace OpenAI.Api.Exceptions;

public static class OpenAIExceptions
{
    public static void ThrowsIfError(HttpStatusCode statusCode)
    {

        if (statusCode == HttpStatusCode.Unauthorized)
        {
            throw new OpenAIInvalidApiKey();
        }
        
    }
}