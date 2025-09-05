using Microsoft.AspNetCore.Mvc;

namespace OrquestradorApi.Controllers;
[Route("api/orquestrador")]
[ApiController]
public class OrquestradorController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> GetEndpoint()
    {
        return Ok("Hello World, ASP.NET Core WebAPI. Get Route!");
    }
}
