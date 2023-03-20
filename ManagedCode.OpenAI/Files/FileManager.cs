using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ManagedCode.OpenAI.Client;
using ManagedCode.OpenAI.Exceptions;

namespace ManagedCode.OpenAI.Files;

public class FileManager
{
    public const string URL_FILES = "files";

    public const string URL_FILE = "files/{0}";

    public const string URL_FILE_CONTEXT = "files/{0}/content";

    public const string FINE_TUNE = "fine-tune";

    private readonly OpenAIClient _client;

    internal FileManager(OpenAIClient client)
    {
        _client = client;
    }

    public async Task<FileListResult> ListAsync()
    {
        var httpResponseMessage = await _client.GetAsync(URL_FILES);

        OpenAIExceptions.ThrowsIfError(httpResponseMessage.StatusCode);

        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<FileListResult>(responseBody);

        return result;
    }

    // TODO: Upload file

    public async Task<FileInfo> UploadAsync(string fileName, HttpContent content)
    {
        MultipartFormDataContent multipartFormDataContent = new();

        multipartFormDataContent.Add(new StringContent(FINE_TUNE), "purpose");

        multipartFormDataContent.Add(content, "file", fileName);

        var httpResponseMessage = await _client.PostAsync(URL_FILES, multipartFormDataContent);

        OpenAIExceptions.ThrowsIfError(httpResponseMessage.StatusCode);

        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<FileInfo>(responseBody);


        return result;
    }


    public async Task<FileInfo> UploadAsync(string fileName, string content)
    {
        return await UploadAsync(fileName, new StringContent(content, Encoding.UTF8, "multipart/form-data"));
    }

    public async Task<FileInfo> UploadAsync(string fileName, Stream content)
    {
        return await UploadAsync(fileName, new StreamContent(content));
    }

    public async Task<FileDeleteResult> DeleteAsync(FileInfo file)
    {
        return await DeleteAsync(file.Id);
    }

    public async Task<FileDeleteResult> DeleteAsync(string fileId)
    {
        string resultUrl = string.Format(URL_FILE, fileId);

        var httpResponseMessage = await _client.DeleteAsync(resultUrl);

        OpenAIExceptions.ThrowsIfError(httpResponseMessage.StatusCode);

        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<FileDeleteResult>(responseBody);

        return result;
    }

    public async Task<FileInfo> RetrieveAsync(FileInfo file)
    {
        return await RetrieveAsync(file.Id);
    }

    public async Task<FileInfo> RetrieveAsync(string fileId)
    {
        string resultUrl = string.Format(URL_FILE, fileId);

        var httpResponseMessage = await _client.GetAsync(resultUrl);

        OpenAIExceptions.ThrowsIfError(httpResponseMessage.StatusCode);

        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<FileInfo>(responseBody);

        return result;
    }


    public async Task<Stream> ContentAsync(FileInfo info)
    {
        return await ContentAsync(info.Id);
    }

    public async Task<Stream> ContentAsync(string fileId)
    {
        string resultUrl = string.Format(URL_FILE_CONTEXT, fileId);

        var httpResponseMessage = await _client.GetAsync(resultUrl);

        OpenAIExceptions.ThrowsIfError(httpResponseMessage.StatusCode);

        return await httpResponseMessage.Content.ReadAsStreamAsync();
    }
}