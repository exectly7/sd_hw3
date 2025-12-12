using AnalysisService.Entities.Models;
using AnalysisService.UseCases.Reports;

namespace AnalysisService.Infrastructure.Data.Reports;

internal sealed class EfReportRepository(AnalysisDbContext dbContext) : IReportRepository
{
    public Report? GetByWorkId(Guid workId)
    {
        var dto = dbContext.Reports.SingleOrDefault(r => r.WorkId == workId);

        return dto is null
            ? null
            : new Report(
                dto.WorkId,
                dto.IsPlagiarism,
                dto.CreatedAt
            );
    }
}