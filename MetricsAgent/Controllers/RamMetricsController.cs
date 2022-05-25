using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/ram/available")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("available")]
        public IActionResult GetMetrics(string available)
        {
            return Ok();
        }
    }
}
