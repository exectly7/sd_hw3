using FileService.UseCases.Files.Download;
using FileService.UseCases.Files.Upload;
using Microsoft.Extensions.DependencyInjection;

namespace FileService.UseCases;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IDownloadFileRequestHandler, DownloadFileRequestHandler>();
        services.AddScoped<IUploadFileRequestHandler, UploadFileRequestHandler>();
        return services;
    }
}