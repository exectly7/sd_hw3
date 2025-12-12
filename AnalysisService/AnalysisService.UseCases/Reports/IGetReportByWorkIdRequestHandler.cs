namespace AnalysisService.UseCases.Reports;

public interface IGetReportByWorkIdRequestHandler
{
    GetReportByWorkIdResponse? Handle(GetReportByWorkIdRequest request);
}