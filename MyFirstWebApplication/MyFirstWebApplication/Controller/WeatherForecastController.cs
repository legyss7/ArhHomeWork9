using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        //kestrel web-сервер Microsoft

        private WeatherForecastHolder _weatherForecastHolder;

        public WeatherForecastController(
            WeatherForecastHolder weatherForecastHolder)
        {
            _weatherForecastHolder = weatherForecastHolder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] DateTime date, 
            [FromQuery] int temperatureC)
        {
            _weatherForecastHolder.Add(date, temperatureC);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date,
            [FromQuery] int temperatureC)
        {
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date,
            [FromQuery] int temperatureC)
        {
            return Ok();
        }

        [HttpGet("get")]
        public IActionResult Get(
            [FromQuery] DateTime dateForm,
            [FromQuery] DateTime dateTo)
        {
            List<WeatherForecast> list = _weatherForecastHolder.Get(dateForm, dateTo);
            return Ok(list);
        }

    }
}
