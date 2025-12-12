using AnalysisService.Infrastructure.Data;
using AnalysisService.Infrastructure.Data.Reports;
using AnalysisService.Infrastructure.Data.Works;
using AnalysisService.UseCases.Reports;
using AnalysisService.UseCases.Works;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnalysisService.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AnalysisDb");

        services.AddDbContext<AnalysisDbContext>(options =>
            options.UseNpgsql(connectionString));

        services.AddScoped<IUploadWorkRepository, EfUploadWorkRepository>();
        services.AddScoped<IReportRepository, EfReportRepository>();
        return services;
    }
}