using System.Security.Cryptography;
using AnalysisService.Entities.Models;

namespace AnalysisService.UseCases.Works;

internal sealed class UploadWorkRequestHandler(
    IUploadWorkRepository repository,
    IFileServiceClient fileServiceClient)
    : IUploadWorkRequestHandler
{
    public UploadWorkResponse Handle(UploadWorkRequest request)
    {
        var work = request.ToEntity();
        
        using var stream = fileServiceClient.GetContent(work.FileId);
        work.Hash = ComputeSha256(stream);
        var report = new Report(work.Id, repository.Exists(work.Hash, work.TaskId, work.StudentId), DateTime.UtcNow);
        repository.AddReport(report);
        repository.Add(work);
        return work.ToDto();
    }

    private static string ComputeSha256(Stream stream)
    {
        using var sha = SHA256.Create();
        var hashBytes = sha.ComputeHash(stream);
        return Convert.ToHexString(hashBytes);
    }
}