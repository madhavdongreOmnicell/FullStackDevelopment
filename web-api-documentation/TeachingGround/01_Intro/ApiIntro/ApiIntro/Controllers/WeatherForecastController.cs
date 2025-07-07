using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> _weatherForecasts = new List<WeatherForecast>();

        [HttpGet()]
        public IActionResult GetWeather()
        {
            return new JsonResult(_weatherForecasts);
        }

        [HttpPost]
        public IActionResult Post(WeatherForecast model)
        {
            model.Id = _weatherForecasts.Count + 1;
            _weatherForecasts.Add(model);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        public IActionResult Put(int id, WeatherForecast model)
        {
            var record = _weatherForecasts.FirstOrDefault(x => x.Id == id);
            if(record != null)
            {
                record.Summary = model.Summary;
                record.TemperatureC = model.TemperatureC;
                return Ok();
            }

            return NotFound();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var record = _weatherForecasts.FirstOrDefault(x => x.Id == id);
            if (record != null)
            {
                _weatherForecasts.Remove(record);
                return Ok();
            }

            return NotFound();
        }
    }
}