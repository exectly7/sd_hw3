using FileService.UseCases.Files.Upload;
using File = FileService.Enteties.Models.File;

namespace FileService.Infrastructure.Data.Files;

public class UploadFileRepository : IUploadFileRepository
{
    public void Add(File file)
    {
        var directory = Directory.GetCurrentDirectory();
        var path = Path.Combine(directory, file.Id.ToString());
        using var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
        file.Content.CopyTo(stream);
    }
}