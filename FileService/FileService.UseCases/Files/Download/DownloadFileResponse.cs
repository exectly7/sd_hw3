namespace FileService.UseCases.Files.Download;

public sealed record DownloadFileResponse (
    Stream Content
);