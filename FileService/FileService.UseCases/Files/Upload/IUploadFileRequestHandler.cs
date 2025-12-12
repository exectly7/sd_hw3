namespace FileService.UseCases.Files.Upload;

public interface IUploadFileRequestHandler
{
    UploadFileResponse Handle(UploadFileRequest request);
}