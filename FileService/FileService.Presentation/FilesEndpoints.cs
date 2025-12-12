using FileService.UseCases.Files.Download;
using FileService.UseCases.Files.Upload;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace FileService.Presentation;

public static class FilesEndpoints
{
    public static WebApplication MapFilesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/files")
            .WithTags("files");

        group.MapUploadFile();
        group.MapDownloadFile();
        return app;
    }
    
    private static RouteGroupBuilder MapUploadFile(this RouteGroupBuilder group)
    {
        group.MapPost("", async (IFormFile file, IUploadFileRequestHandler handler) =>
            {
                await using var stream = file.OpenReadStream();

                var request = new UploadFileRequest(
                    stream,
                    file.ContentType
                );

                var response = handler.Handle(request);

                return Results.Ok(response);
            })
            .WithName("UploadFile")
            .WithSummary("Upload a new file")
            .WithDescription("Uploads a new file to storage")
            .DisableAntiforgery();
    
        return group;
    }
    
    private static RouteGroupBuilder MapDownloadFile(this RouteGroupBuilder group)
    {
        group.MapGet("/{id:guid}", (Guid id, IDownloadFileRequestHandler handler) =>
            {
                var response = handler.Handle(new DownloadFileRequest(id));

                return Results.File(
                    response.Content,
                    fileDownloadName: id.ToString()
                );
            })
            .WithName("DownloadFile")
            .WithSummary("Download file by id")
            .WithDescription("Downloads a file stored under given id");

        return group;
    }
}
