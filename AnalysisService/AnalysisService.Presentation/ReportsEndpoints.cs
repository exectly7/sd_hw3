using AnalysisService.UseCases.Reports;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AnalysisService.Presentation;

public static class ReportsEndpoints
{
    public static WebApplication MapReportsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/reports")
            .WithTags("Reports");

        group.MapGet("/{workId:guid}", async (
                Guid workId,
                IGetReportByWorkIdRequestHandler handler) =>
            {
                var request = new GetReportByWorkIdRequest(workId);
                var response = handler.Handle(request);

                return Results.Ok(response);
            })
            .WithName("GetReportByWorkId")
            .WithSummary("Get plagiarism report by work ID")
            .WithDescription("Returns the plagiarism analysis report for a given work");

        return app;
    }
}