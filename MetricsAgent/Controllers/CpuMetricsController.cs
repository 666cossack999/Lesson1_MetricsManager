using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu/")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetMetricsByPercent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] int percentile)
        {
            return Ok();
        }

        [HttpGet("/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsByTime([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}
