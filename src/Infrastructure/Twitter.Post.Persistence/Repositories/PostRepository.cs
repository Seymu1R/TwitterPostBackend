using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Domain.Entities;

namespace Twitter.Post.Persistance;
public class PostRepository : GenericRepostory<Twitter.Post.Domain.Entities.Post>, IPostRepository
{
    public PostRepository(ApplicationDbContext context) : base(context)
    {
    }
}