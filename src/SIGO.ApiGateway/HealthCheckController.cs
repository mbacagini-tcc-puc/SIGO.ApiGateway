using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SIGO.ApiGateway
{
    [Route("health")]
    [ApiController]
    [AllowAnonymous]
    public class HealthCheckController : ControllerBase
    {
        public IActionResult Check()
        {
            return Ok();
        }
    }
}
