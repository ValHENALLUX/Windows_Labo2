using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_meteo.Model
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public string WeatherDescription { get; set; }
        public double WindSpeed { get; set; }
        
        /*
        public WeatherForecast(DateTime date, double minTemp, double maxTemp, string weatherDescription, double windSpeed)
        {
            Date = date;
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            WeatherDescription = weatherDescription;
            WindSpeed = windSpeed;
        }*/
    }
}
