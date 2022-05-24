using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu/")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercent([FromRoute] DateTimeOffset fromTime, [FromRoute] DateTimeOffset toTime, [FromRoute] int percentile)
        {
            return Ok();
        }

        [HttpGet("/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsByTime([FromRoute] DateTimeOffset fromTime, [FromRoute] DateTimeOffset toTime)
        {
            return Ok();
        }

    }
}
