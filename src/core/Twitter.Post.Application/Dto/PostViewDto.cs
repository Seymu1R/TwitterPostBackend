namespace Twitter.Post.Application.Dto;

public class PostViewDto
{   
    public string _id { get; set; }
    public string Text { get; set; }
    public string? Media { get; set; }
    public ulong RepostCount { get; set; }
    public ulong ReplyCount { get; set; }
    public ulong LikeCount { get; set; }
    public ulong BookmarkCount { get; set; }
    public ulong View { get; set; }
    public DateTime CreatedAt { get; set; }

}