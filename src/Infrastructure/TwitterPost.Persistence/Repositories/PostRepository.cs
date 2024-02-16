using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Domain.Entities;

namespace TwitterPost.Persistance;
public class PostRepository : GenericRepostory<Post>, IPostRepository
{
    public PostRepository(ApplicationDbContext context) : base(context)
    {
    }
}