using AutoMapper;
using MediatR;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Features.Queries;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Application.Wrappers;


namespace Stock.Application.Features.Queries.GetDiscount
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery, ServiceResponse<PostViewDto>>
    {
        readonly IPostRepository _postRepository;
        readonly IMapper _mapper;

        public GetPostQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
           _postRepository = postRepository;
           _mapper = mapper;
        }

        public async Task<ServiceResponse<PostViewDto>> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            Twitter.Post.Domain.Entities.Post rawPost = await _postRepository.GetByIdAsync(request._id);

            var post = _mapper.Map<PostViewDto>(rawPost);

            return new ServiceResponse<PostViewDto>(post) { Message = "Data fetched!", StatusCode = 200};
        }
    }
}