using System;

namespace PetroWebApiTemplate
{
    /// <summary>
    /// The Weather Forecast
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temp in celsius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// How accurate is the weather forecast
        /// </summary>
        public Controllers.AccuracyType Accuracy { get; set; }

        /// <summary>
        /// Temp in fahrenheit
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// A summary of the weather
        /// </summary>
        public string Summary { get; set; }
    }
}
