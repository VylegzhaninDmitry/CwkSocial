using Cwk.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController: Controller
{
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetById(int id)
    {
        var post = new Post { Id = id, Text = "Hello world!"};

        return Ok(post);
    }
}