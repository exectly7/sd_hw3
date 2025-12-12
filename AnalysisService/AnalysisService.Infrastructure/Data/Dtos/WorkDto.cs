namespace AnalysisService.Infrastructure.Data.Dtos;

public sealed record WorkDto(
    Guid Id,
    int StudentId,
    int TaskId,
    Guid FileId,
    string Hash,
    DateTime Created
);