using AnalysisService.Entities.Models;

namespace AnalysisService.UseCases.Works;

internal static class WorkMapper
{
    public static Work ToEntity(this UploadWorkRequest request)
    {
        return new Work(
            id: Guid.NewGuid(),
            studentId: request.StudentId,
            taskId: request.TaskId,
            fileId: request.FileId,
            hash: string.Empty,
            created: DateTime.UtcNow
        );
    }

    public static UploadWorkResponse ToDto(this Work work)
    {
        return new UploadWorkResponse(work.Id);
    }
}