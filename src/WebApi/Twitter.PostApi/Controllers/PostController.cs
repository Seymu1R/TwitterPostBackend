using Microsoft.AspNetCore.Mvc;
using Twitter.Post.Application.Interfaces.Repository;
using MediatR;

namespace Twitter.PostApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostRepository postRepository;
    readonly IMediator mediator;

    public PostController(IPostRepository repository)
    {
        this.postRepository = repository;
    }
    
    
}