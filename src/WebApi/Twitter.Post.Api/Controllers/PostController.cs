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
   [HttpGet("GetPost")]
    public async Task<IActionResult> GetPost(string _id) =>
        Ok(await _mediator.Send(new GetPostQuery {_id = _id}));   

   [HttpPost("UpdatePost")]
    public async Task<IActionResult> UpdatePost(UpdatePostCommand updateCommandPost) =>
       Ok(await _mediator.Send(updateCommandPost ));

   [HttpDelete("DeletePost")]
    public async Task<IActionResult> DeletePost(string _id) =>
        Ok(await _mediator.Send(new DeletPostQuery {_id = _id}));        
}