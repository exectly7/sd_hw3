using File = FileService.Enteties.Models.File;

namespace FileService.UseCases.Files.Download;

internal static class DownloadFileMapper
{
    public static DownloadFileResponse ToDownloadResponse(this File file) =>
        new (file.Content);
}