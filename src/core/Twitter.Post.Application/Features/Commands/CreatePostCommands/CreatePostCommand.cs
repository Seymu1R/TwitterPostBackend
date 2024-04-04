
using MediatR;
using Twitter.Post.Application.Wrappers;
using Twitter.Post.Domain.Entities;

namespace Twitter.Post.Application
{
  public class CreatePostCommand : IRequest<BaseResponse> 
  {
    public string  Text { get; set; }
    public string? Media { get; set; }
    public string? ParentId { get; set; }
  }
}


