using AnalysisService.Entities.Models;
using AnalysisService.Infrastructure.Data.Dtos;
using AnalysisService.UseCases.Works;

namespace AnalysisService.Infrastructure.Data.Works;

internal sealed class EfUploadWorkRepository(AnalysisDbContext dbContext) : IUploadWorkRepository
{
    public void Add(Work work)
    {
        var dto = new WorkDto(
            work.Id,
            work.StudentId,
            work.TaskId,
            work.FileId,
            work.Hash,
            work.Created
        );

        dbContext.Works.Add(dto);
        dbContext.SaveChanges();
    }

    public void AddReport(Report report)
    {
        var dto = new ReportDto(
            report.WorkId,
            report.IsPlagiarism,
            report.CreatedAt
        );

        dbContext.Reports.Add(dto);
        dbContext.SaveChanges();
    }

    public bool Exists(string hash, int taskId, int studentId)
    {
        return dbContext.Works.Any(w =>
            w.Hash == hash &&
            w.TaskId == taskId &&
            w.StudentId != studentId
        );
    }
}