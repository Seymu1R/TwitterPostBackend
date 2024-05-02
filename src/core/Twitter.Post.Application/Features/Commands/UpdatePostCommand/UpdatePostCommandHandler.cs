using System.Net;
using AutoMapper;
using MediatR;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Application.Wrappers;

namespace Twitter.Post.Application
{
    class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, BaseResponse>
    {
        readonly IMapper _mapper;
        readonly IPostRepository _postRepository;
        public UpdatePostCommandHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }


        public async Task<BaseResponse> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            Twitter.Post.Domain.Entities.Post post = _mapper.Map<Twitter.Post.Domain.Entities.Post>(request); 
            
            await _postRepository.UpdateAsync(post);

            return new BaseResponse {Message = "Post Updated!" , StatusCode = (int)HttpStatusCode.OK };
        }

    }
}