using AnalysisService.UseCases.Reports;
using Microsoft.Extensions.DependencyInjection;

namespace AnalysisService.UseCases;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddHttpClient<Works.IFileServiceClient, Works.FileServiceClient>(client =>
        {
            client.BaseAddress = new Uri("http://file-service:8080");
        });

        services.AddScoped<Works.IUploadWorkRequestHandler, Works.UploadWorkRequestHandler>();
        services.AddScoped<IGetReportByWorkIdRequestHandler, GetReportByWorkIdRequestHandler>();

        return services;
    }
}