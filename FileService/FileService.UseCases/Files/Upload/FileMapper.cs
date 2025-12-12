using File = FileService.Enteties.Models.File;

namespace FileService.UseCases.Files.Upload;

internal static class UploadFileMapper
{
    public static File ToEntity(this UploadFileRequest request) =>
        new (Guid.NewGuid(), request.Content);
    
    public static UploadFileResponse ToUploadResponse(this File file) =>
        new (file.Id);
}