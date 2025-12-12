namespace FileService.UseCases.Files.Upload;

internal sealed class UploadFileRequestHandler(IUploadFileRepository repository) : IUploadFileRequestHandler
{
    public UploadFileResponse Handle(UploadFileRequest request)
    {
        var file = request.ToEntity();
        repository.Add(file);
        return file.ToUploadResponse();
    }
}