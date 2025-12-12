namespace AnalysisService.UseCases.Works;

public interface IFileServiceClient
{
    Stream GetContent(Guid fileId);
}