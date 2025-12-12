namespace AnalysisService.UseCases.Works;

public interface IUploadWorkRequestHandler
{
    UploadWorkResponse Handle(UploadWorkRequest request);
}