namespace Twitter.Post.Application.Wrappers;

public class BaseResponse
{
    public Guid Id { get; set; }
    public bool Success { get; set; }
    public String Message { get; set; }
    public int StatusCode { get; set; }
}