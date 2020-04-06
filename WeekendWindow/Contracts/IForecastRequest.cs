using System;
using System.Collections.Generic;
using System.Linq;
using WeekendWindow.Models;
using System.Threading.Tasks;



namespace WeekendWindow.Contracts
{
    public interface IForecastRequest
    {
        Task<WeatherForecast> GetWeatherForecast();
    }
}
