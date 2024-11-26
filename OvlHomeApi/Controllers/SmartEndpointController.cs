using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OvlHomeApi.Models;

namespace OvlHomeApi.Controllers;

[ApiController]
[Route("/api/yandex/v1.0")]
[Authorize]
public class SmartEndpointController(ILogger<SmartEndpointController> logger) : ControllerBase
{
    [AllowAnonymous]
    [HttpHead(Name = "SmartEndpointTest")]
    public IActionResult Get() => Ok();

    [HttpPost("user/unlink")]
    public IActionResult UnlinkAccounts([FromHeader(Name = "X-Request-Id")] string requestId)
    {
        logger.Log(LogLevel.Information, "{time} | UnlinkAccounts [{user}] - Id: {id}", DateTime.Now, User.Identity?.Name ?? "anonymous", requestId);
        return Ok(new Root { RequestId = requestId });
    }

    [HttpPost("user/link")]
    public IActionResult LinkAccounts([FromBody] string body)
    {
        logger.Log(LogLevel.Information, "{time} | LinkAccounts [{user}] - Body {body}", DateTime.Now, User.Identity?.Name ?? "anonymous", body);
        return Ok("Account linked");
    }
}
