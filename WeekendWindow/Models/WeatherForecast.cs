
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeekendWindow.Models
{
    public class WeatherForecast
    {
        public int WeatherForecastId { get; set; }
        public Datum[] data { get; set; }
        public string city_name { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public string lat { get; set; }
        public string country_code { get; set; }
        public string state_code { get; set; }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

    public class Datum
    {
        public int DatumId { get; set; }
        public int moonrise_ts { get; set; }
        public string wind_cdir { get; set; }
        public int rh { get; set; }
        public float pres { get; set; }
        public float high_temp { get; set; }
        public int sunset_ts { get; set; }
        public float ozone { get; set; }
        public float moon_phase { get; set; }
        public float wind_gust_spd { get; set; }
        public float snow_depth { get; set; }
        public int clouds { get; set; }
        public int ts { get; set; }
        public int sunrise_ts { get; set; }
        public float app_min_temp { get; set; }
        public float wind_spd { get; set; }
        public int pop { get; set; }
        public string wind_cdir_full { get; set; }
        public float slp { get; set; }
        public float moon_phase_lunation { get; set; }
        public string valid_date { get; set; }
        public float app_max_temp { get; set; }
        public float vis { get; set; }
        public float dewpt { get; set; }
        public float snow { get; set; }
        public float uv { get; set; }
        public Weather weather { get; set; }
        public int wind_dir { get; set; }
        [NotMapped]
        public object max_dhi { get; set; }
        public int clouds_hi { get; set; }
        public float precip { get; set; }
        public float low_temp { get; set; }
        public float max_temp { get; set; }
        public int moonset_ts { get; set; }
        public string datetime { get; set; }
        public float temp { get; set; }
        public float min_temp { get; set; }
        public int clouds_mid { get; set; }
        public int clouds_low { get; set; }
    }

    public class Weather
    {
        public int WeatherId { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }
    }
}

