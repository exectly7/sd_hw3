using AnalysisService.Entities.Models;

namespace AnalysisService.UseCases.Reports;

public interface IReportRepository
{
    Report? GetByWorkId(Guid workId);
}