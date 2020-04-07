using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeekendWindow.Contracts;
using WeekendWindow.Models;

namespace WeekendWindow.Services
{
    public class ForecastRequest : IForecastRequest
    {
        public ForecastRequest()
        {

        }
        public async Task<WeatherForecast> GetWeatherForecast()
        {
            string url = $"https://api.weatherbit.io/v2.0/forecast/daily?postal_code=53072&country=US&units=I&key={APIKEYS.weatherbitKey}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
               

                string json = await response.Content.ReadAsStringAsync();
                
                WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(json);

                

                return forecast;
                
            }
            return null;
        }

    }
}
