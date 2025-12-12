namespace AnalysisService.UseCases.Reports;

public sealed record GetReportByWorkIdResponse(
    Guid WorkId,
    bool IsPlagiarism,
    DateTime CreatedAt
);