namespace AnalysisService.UseCases.Works;

internal sealed class FileServiceClient(HttpClient httpClient) : IFileServiceClient
{
    public Stream GetContent(Guid fileId)
    {
        var response = httpClient.GetAsync($"/files/{fileId}").Result;
        response.EnsureSuccessStatusCode();

        return response.Content.ReadAsStreamAsync().Result;
    }
}