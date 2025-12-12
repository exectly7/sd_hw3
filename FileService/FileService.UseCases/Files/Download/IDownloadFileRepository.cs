using File = FileService.Enteties.Models.File;

namespace FileService.UseCases.Files.Download;

public interface IDownloadFileRepository
{
    public File Get(Guid fileId);
}