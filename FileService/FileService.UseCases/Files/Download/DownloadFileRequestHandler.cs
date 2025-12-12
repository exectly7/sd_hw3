namespace FileService.UseCases.Files.Download;

internal sealed class DownloadFileRequestHandler(IDownloadFileRepository repository) : IDownloadFileRequestHandler
{
    public DownloadFileResponse Handle(DownloadFileRequest request)
    {
        var guid = request.FileId;
        var file = repository.Get(guid);
        return file.ToDownloadResponse();
    }
}