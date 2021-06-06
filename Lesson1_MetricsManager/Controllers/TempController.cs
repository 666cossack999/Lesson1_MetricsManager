using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;



namespace Lesson1_MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private readonly IValuesHolder _holder;

        public TempController(IValuesHolder holder)
        {
            _holder = holder;
        }
        /// <summary>
        /// делает запись о температуре в указанное время
        /// </summary>
        /// <param name="tempС">Формат температуры 00</param>
        /// <param name="time">Формат времени HH:mm:ss</param>
        [HttpPost("create")]
        public IActionResult Create([FromQuery] string tempС, DateTime time)
        {
            _holder.Add(tempС, time);
            return Ok();
        }

        /// <summary>
        /// читает список показателей температуры за указанный промежуток времени
        /// </summary>
        /// <param name="firstTime">Формат времени HH:mm:ss</param>
        /// <param name="secondTime">Формат времени HH:mm:ss</param>
        [HttpGet("read")]
        public IActionResult Read([FromQuery] DateTime firstTime, [FromQuery] DateTime secondTime)
        {

            return Ok(_holder.Get(firstTime,secondTime));
        }

        /// <summary>
        /// редактирует показатель температуры в указанное время
        /// </summary>
        /// <param name="tempC">Формат температуры 00</param>
        /// <param name="time">Формат времени HH:mm:ss</param>
        [HttpPut("update")]
        public IActionResult Update([FromQuery] string tempC, [FromQuery] DateTime time)
        {
            _holder.Update(tempC, time);
            return Ok();
        }

        /// <summary>
        /// Удаляет показатели температуры в указанный промежуток времени
        /// </summary>
        /// <param name="firstTime">Формат времени HH:mm:ss</param>
        /// <param name="secondTime">Формат времени HH:mm:ss</param>
        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime firstTime, [FromQuery] DateTime secondTime)
        {
            _holder.Delete(firstTime, secondTime);
           return Ok();
        }
    }

}

