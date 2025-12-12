using FileService.Infrastructure.Data.Files;
using FileService.UseCases.Files.Download;
using FileService.UseCases.Files.Upload;
using Microsoft.Extensions.DependencyInjection;

namespace FileService.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUploadFileRepository, UploadFileRepository>();
        services.AddScoped<IDownloadFileRepository, DownloadFileRepository>();
        return services;
    }
}