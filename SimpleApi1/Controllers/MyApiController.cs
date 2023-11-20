using Microsoft.AspNetCore.Mvc;

namespace SimpleApi1.Controllers;

[ApiController, Route("api/[controller]/[action]")]
public class MyApiController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("SimpleApi1 - GET");
    }
}