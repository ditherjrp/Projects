using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherTest.Type
{
    [Serializable]
    public class Forecast
    {
        public List<Datum> data { get; set; }
        public string city_name { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public string lat { get; set; }
        public string country_code { get; set; }
        public string state_code { get; set; }
    }
}