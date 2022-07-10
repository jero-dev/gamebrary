using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("health")]
        public ActionResult HealthCheck() => Ok("I'm alive!");
    }
}