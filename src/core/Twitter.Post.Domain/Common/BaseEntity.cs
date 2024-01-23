using System.Runtime.InteropServices.JavaScript;

namespace Twitter.Post.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}