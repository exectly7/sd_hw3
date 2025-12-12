using AnalysisService.UseCases.Works;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace AnalysisService.Presentation;

public static class WorksEndpoints
{
    public static WebApplication MapWorksEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/works")
            .WithTags("works");

        group.MapUploadWork();

        return app;
    }

    private static RouteGroupBuilder MapUploadWork(this RouteGroupBuilder group)
    {
        group.MapPost("", (UploadWorkRequest request, IUploadWorkRequestHandler handler) =>
            {
                var response = handler.Handle(request);
                return Results.Ok(response);
            })
            .WithName("UploadWork")
            .WithSummary("Register student work")
            .WithDescription("Registers student work for analysis");

        return group;
    }
}