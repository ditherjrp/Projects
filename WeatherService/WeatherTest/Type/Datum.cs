using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherTest.Type
{
    [Serializable]
    public class Datum
    {
        public string moonrise_ts { get; set; }
        public string wind_cdir { get; set; }
        public string rh { get; set; }
        public string pres { get; set; }
        public string sunset_ts { get; set; }
        public string ozone { get; set; }
        public string moon_phase { get; set; }
        public string wind_gust_spd { get; set; }
        public string snow_depth { get; set; }
        public string clouds { get; set; }
        public string ts { get; set; }
        public string sunrise_ts { get; set; }
        public string app_min_temp { get; set; }
        public string wind_spd { get; set; }
        public string pop { get; set; }
        public string wind_cdir_full { get; set; }
        public string slp { get; set; }
        public string app_max_temp { get; set; }
        public string vis { get; set; }
        public string dewpt { get; set; }
        public string snow { get; set; }
        public string uv { get; set; }
        public string valid_date { get; set; }
        public string wind_dir { get; set; }
        public object max_dhi { get; set; }
        public string clouds_hi { get; set; }
        public string precip { get; set; }
        public Weather weather { get; set; }
        public string max_temp { get; set; }
        public string moonset_ts { get; set; }
        public string datetime { get; set; }
        public string temp { get; set; }
        public string min_temp { get; set; }
        public string clouds_mid { get; set; }
        public string clouds_low { get; set; }
    }
}