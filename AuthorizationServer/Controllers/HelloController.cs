using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Abstractions;
using OpenIddict.Server.AspNetCore;

namespace AuthorizationServer.Controllers;

public class HelloController: Controller
{
    [Authorize]
    [HttpGet("~/hello/world")]
    public IActionResult HelloWorld()
    {
        return Ok(new
        {
            Hello = "World"
        });
    }
}