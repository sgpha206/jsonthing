using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;

namespace jsonreal
{
    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var phoenixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            WriteLine(jsonString);

            string phoenixstring = JsonSerializer.Serialize(phoenixForecast);
            WriteLine(phoenixstring);

            WeatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(phoenixstring);
            WriteLine(w.Summary);

            ReadKey();
        }
    }
}

