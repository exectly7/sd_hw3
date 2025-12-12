namespace FileService.UseCases.Files.Upload;

public sealed record UploadFileRequest (
    Stream Content,
    string FileType
);