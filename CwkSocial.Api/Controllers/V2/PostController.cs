﻿using Asp.Versioning;
using Cwk.Domain.Aggregates.PostAggregate;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V2;

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class PostController: Controller
{
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetById(int id)
    {
        //var post = new Post { PostId = new Guid(), TextContent = "Hello v2!"};

        return Ok(id);
    }
}