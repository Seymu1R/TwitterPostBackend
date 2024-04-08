using Microsoft.AspNetCore.Mvc;
using Twitter.Post.Application.Interfaces.Repository;
using MediatR;
using Twitter.Post.Application;
using Twitter.Post.Application.Features.Queries;

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
    [HttpGet("GetAllPosts")]
    public async Task<IActionResult> GetAllPosts( ) =>
       Ok(await _mediator.Send(new GetAllPostQuery { }));
    [HttpGet("GetDiscount")]
    public async Task<IActionResult> GetDiscount(string id) =>
        Ok(await this.mediator.Send(new GetDiscountCommand { id }));   

    
}