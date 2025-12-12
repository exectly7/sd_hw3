using File = FileService.Enteties.Models.File;

namespace FileService.UseCases.Files.Upload;

public interface IUploadFileRepository
{
    public void Add(File file);
}