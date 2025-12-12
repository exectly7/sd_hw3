namespace AnalysisService.UseCases.Works;

public sealed record UploadWorkRequest(
    int StudentId,
    int TaskId,
    Guid FileId
);