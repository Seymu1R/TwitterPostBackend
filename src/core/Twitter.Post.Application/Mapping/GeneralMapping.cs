using AutoMapper;
namespace Twitter.Post.Application
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreatePostCommand, Domain.Entities.Post>().ReverseMap();

        }
    }
}