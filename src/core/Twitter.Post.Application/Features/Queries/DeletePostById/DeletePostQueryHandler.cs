using System.Net;
using AutoMapper;
using MediatR;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Application.Wrappers;


namespace Twitter.Post.Application.Features.Queries;

public class DeletePostQueryHandler : IRequestHandler<DeletPostQuery, BaseResponse>
{
    private readonly IPostRepository _postRepository;

    public DeletePostQueryHandler(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<BaseResponse> Handle(DeletPostQuery request, CancellationToken cancellationToken)
    {
        await _postRepository.DeleteItemAsync(request._id);
        return new BaseResponse {Message = "ProductCommerce deleted!", StatusCode = (int)HttpStatusCode.OK};        
    }
}
