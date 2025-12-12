namespace AnalysisService.Entities.Models;

public class Work(Guid id, int studentId, int taskId, Guid fileId, string hash, DateTime created)
{
    public Guid Id { get; } = id;
    public int StudentId { get; } = studentId;
    public int TaskId { get; } = taskId;
    public Guid FileId { get; } = fileId;
    public string Hash { get; set; } = hash;
    public DateTime Created { get; } = created;
}