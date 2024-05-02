using MediatR;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Wrappers;

namespace Twitter.Post.Application.Features.Queries;

public class DeletPostQuery : IRequest<BaseResponse>
{
    public string _id { get; set; }

}