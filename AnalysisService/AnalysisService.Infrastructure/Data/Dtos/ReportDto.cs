namespace AnalysisService.Infrastructure.Data.Dtos;

public sealed record ReportDto (
    Guid WorkId,
    bool IsPlagiarism,
    DateTime CreatedAt
);