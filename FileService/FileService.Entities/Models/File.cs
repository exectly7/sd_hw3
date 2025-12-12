namespace FileService.Enteties.Models;

public sealed class File(Guid id, Stream content)
{
    public Guid Id { get; } = id;
    public Stream Content { get; } = content;
}