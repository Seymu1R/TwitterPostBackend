using AutoMapper;
using Twitter.Post.Application.Dto;
using Twitter.Post.Application.Features.Queries;
namespace Twitter.Post.Application
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreatePostCommand, Domain.Entities.Post>().ReverseMap();
            CreateMap<Domain.Entities.Post, PostViewDto>().ReverseMap();
            CreateMap<UpdatePostCommand, Domain.Entities.Post>().ReverseMap();


        }
    }
}