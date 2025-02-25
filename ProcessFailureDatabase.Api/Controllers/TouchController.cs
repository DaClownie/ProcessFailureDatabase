using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFailureDatabase.Api.Services;

namespace ProcessFailureDatabase.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "User")]
public class TouchController : ControllerBase
{
    private readonly ITouchService _touchService;

    public TouchController(ITouchService touchService)
    {
        _touchService = touchService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult> Post()
    {
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult> Put()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<ActionResult> Delete()
    {
        return Ok();
    }
}