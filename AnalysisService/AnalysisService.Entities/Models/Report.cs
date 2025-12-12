namespace AnalysisService.Entities.Models;

public sealed class Report(Guid workId, bool isPlagiarism, DateTime createdAt)
{
    public Guid WorkId { get; } = workId;
    public bool IsPlagiarism { get; } = isPlagiarism;
    public DateTime CreatedAt { get; } = createdAt;
}