using FileService.UseCases.Files.Download;
using File = FileService.Enteties.Models.File;

namespace FileService.Infrastructure.Data.Files;

public class DownloadFileRepository : IDownloadFileRepository
{
    public File? Get(Guid id)
    {
        var directory = Directory.GetCurrentDirectory();
        var path = Path.Combine(directory, id.ToString());

        if (!System.IO.File.Exists(path))
        {
            return null;
        }

        var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

        return new File(id, stream);
    }
}