using Microsoft.AspNetCore.Mvc;
using Twitter.Post.Application.Interfaces.Repository;
using MediatR;
using Twitter.Post.Application;

namespace Twitter.Post.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
   readonly IMediator _mediator;

    public PostController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("CreatePost")]
    public async Task<IActionResult> CreatePost(CreatePostCommand createCommandPost) =>
       Ok(await _mediator.Send(createCommandPost));      
    
}