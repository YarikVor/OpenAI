namespace OpenAI.Api.Client.ImageGenerator;

public static class ImageGeneratorRequestBuilderMethods
{
    public static ImageGeneratorRequestBuilder AsImageGenerator(
        this OpenAIClient client,
        string prompt
    )
    {
        return new ImageGeneratorRequestBuilder(client).Clear(prompt);
    }
}