namespace AnalysisService.UseCases.Reports;

internal sealed class GetReportByWorkIdRequestHandler(IReportRepository reportRepository)
    : IGetReportByWorkIdRequestHandler
{
    public GetReportByWorkIdResponse? Handle(GetReportByWorkIdRequest request)
    {
        var report = reportRepository.GetByWorkId(request.WorkId);

        if (report is null)
        {
            return null;
        }

        return new GetReportByWorkIdResponse(
            report.WorkId,
            report.IsPlagiarism,
            report.CreatedAt
        );
    }
}