using AutoMapper;
using MediatR;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Application.Wrappers;


namespace Twitter.Post.Application.Features.Queries;

public class GetAllPostQueryHandler : IRequestHandler<GetAllPostQuery, ServiceResponse<ICollection<PostViewDto>>>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public GetAllPostQueryHandler(IMapper mapper, IPostRepository postRepository)
    {
        _mapper = mapper;
        _postRepository = postRepository;
    }
    public async Task<ServiceResponse<ICollection<PostViewDto>>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
    {
            var rawPosts = await _postRepository.GetAllAsync();

            var posts = _mapper.Map<ICollection<PostViewDto>>(rawPosts);

            return new ServiceResponse<ICollection<PostViewDto>>(posts) { Message = "Data fetched!", StatusCode = 200};
    }
}
