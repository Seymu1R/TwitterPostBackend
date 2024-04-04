using Twitter.Post.Domain.Common;

namespace Twitter.Post.Domain.Entities;

public class Post : BaseEntity
{
    public string Text { get; set; }
    public string? Media { get; set; }
    public ulong RepostCount { get; set; }
    public ulong ReplyCount { get; set; }
    public ulong LikeCount { get; set; }
    public ulong BookmarkCount { get; set; }
    public ulong View { get; set; }
    public Post Parent { get; set; }
    public string? ParentId { get; set; }
    public ICollection<Post> Children { get; set; }
}
