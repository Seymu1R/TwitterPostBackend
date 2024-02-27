namespace Twitter.Post.Application.Dto;

public class PostViewDto
{
    #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string Text { get; set; }
    public string? Media { get; set; }
    public ulong RepostCount { get; set; }
    public ulong ReplyCount { get; set; }
    public ulong LikeCount { get; set; }
    public ulong BookmarkCount { get; set; }
    public ulong View { get; set; }
    public DateTime CreatedAt { get; set; }

}