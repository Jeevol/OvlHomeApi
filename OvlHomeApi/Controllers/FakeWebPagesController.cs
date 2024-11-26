using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OvlHomeApi.Controllers;

[ApiController]
[Route("/")]
public class FakeWebPagesController() : Controller
{
    [HttpGet, HttpGet("index.html")]
    public ContentResult GetIndex() => new()
    {
        Content = System.IO.File.ReadAllText("FakePages/index.html"),
        ContentType = "text/html"
    };

    [HttpGet("robots.txt")]
    public ContentResult GetRobotsTxt() => new()
    {
        Content = "User-agent: *\r\nDisallow: /",
        ContentType = "text/plain"
    };

    [HttpGet("token"), HttpGet("token.html")]
    public ContentResult GetToken() => new()
    {
        Content = System.IO.File.ReadAllText("FakePages/token.html"),
        ContentType = "text/html"
    };

    [HttpGet("token-provide"), HttpGet("token-provide.html")]
    public ContentResult GetTokenProvide() => new()
    {
        Content = System.IO.File.ReadAllText("FakePages/token-provide.html"),
        ContentType = "text/html"
    };
}
