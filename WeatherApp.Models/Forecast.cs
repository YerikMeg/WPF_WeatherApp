﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Models
{
    public class Forecast
    {
        [JsonProperty("forecastday")]
        public IList<ForecastDay> ForecastDay { get; set; }
    }
}
