using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherTest.Type
{
    [Serializable]
    public class Weather
    {
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }
    }
}