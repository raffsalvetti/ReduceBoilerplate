using Microsoft.AspNetCore.Mvc;

namespace SimpleApi2.Controllers;

[ApiController, Route("api/[controller]/[action]")]
public class MyApiController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("SimpleApi2 - GET");
    }
}