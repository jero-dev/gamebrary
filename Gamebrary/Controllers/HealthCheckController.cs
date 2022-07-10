using Microsoft.AspNetCore.Mvc;

namespace Gamebrary.Controllers
{
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("health")]
        public ActionResult HealthCheck()
        {
            return Ok("I'm alive!");
        }
    }
}