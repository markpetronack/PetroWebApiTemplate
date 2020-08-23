using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PetroWebApiTemplate.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccuracyType
    {
        /// <summary>
        /// Inaccuate forecast
        /// </summary>
        Inaccurate,
        /// <summary>
        /// Accuate forecast
        /// </summary>
        Accurate,
        /// <summary>
        /// 50% accuate forecast
        /// </summary>
        HalfAccurate
    }

    /// <summary>
    /// A default weather forecast controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get random weather forecasts
        /// </summary>
        /// <returns>A collection of weather forecasts</returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Accuracy = (AccuracyType)rng.Next(0, 3),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
