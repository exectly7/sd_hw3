namespace FileService.UseCases.Files.Download;

public sealed record DownloadFileRequest (
    Guid FileId
);