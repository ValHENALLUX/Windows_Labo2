using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_meteo.Model
{
    public class Forecast
    {
        public string CityName { get; set; }
        public IEnumerable<WeatherForecast> WeatherForecast { get; set; }


    }
}
