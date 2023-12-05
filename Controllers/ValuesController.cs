using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace RateLimit1.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("Basic")]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}
