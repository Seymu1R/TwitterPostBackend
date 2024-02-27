using System.Net;
using AutoMapper;
using MediatR;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Application.Wrappers;
using Twitter.Post.Domain.Entities;

namespace Twitter.Post.Application
{
    class CreatePostCommandHadler : IRequestHandler<CreatePostCommand , BaseResponse>
{

    readonly IMapper _mapper;
    readonly IPostRepository _postRepository;
    public CreatePostCommandHadler(IMapper mapper, IPostRepository postRepository)
    {
        _mapper = mapper;
        _postRepository = postRepository;
    }

        public async Task<BaseResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            Twitter.Post.Domain.Entities.Post post = _mapper.Map<Twitter.Post.Domain.Entities.Post>(request); 
            
            await _postRepository.AddAsync(post);

            return new BaseResponse {Message  = "Post Created", StatusCode = (int)HttpStatusCode.Created};
        }
    }
}
