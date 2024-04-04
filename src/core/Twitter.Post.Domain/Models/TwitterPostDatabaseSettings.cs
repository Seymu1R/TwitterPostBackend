namespace Twitter.Post.Domain.Models;

public class TwitterPostDatabaseSettings
{
    public string? ConnectionString { get; set; } = null!;

    public string? DatabaseName { get; set; } = null!;

    public string? PostCollectionName { get; set; } = null!;
}