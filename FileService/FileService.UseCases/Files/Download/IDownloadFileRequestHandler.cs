namespace FileService.UseCases.Files.Download;

public interface IDownloadFileRequestHandler
{
    DownloadFileResponse Handle(DownloadFileRequest request);
}