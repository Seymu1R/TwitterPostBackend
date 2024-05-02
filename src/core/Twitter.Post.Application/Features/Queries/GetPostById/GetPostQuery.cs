using MediatR;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Wrappers;

namespace Twitter.Post.Application.Features.Queries;

public class GetPostQuery : IRequest<ServiceResponse<PostViewDto>>    
{
   public string _id { get; set; }
}