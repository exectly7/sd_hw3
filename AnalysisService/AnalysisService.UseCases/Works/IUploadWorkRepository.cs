using AnalysisService.Entities.Models;

namespace AnalysisService.UseCases.Works;

public interface IUploadWorkRepository
{
    void Add(Work work);
    void AddReport(Report report);
    public bool Exists(string hash, int taskId, int studentId);
}