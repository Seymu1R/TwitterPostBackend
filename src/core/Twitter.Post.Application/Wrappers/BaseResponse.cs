namespace Twitter.Post.Application.Wrappers;

public class BaseResponse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public int StatusCode { get; set; }
}