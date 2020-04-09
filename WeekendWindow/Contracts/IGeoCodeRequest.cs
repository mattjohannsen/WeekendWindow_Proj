using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekendWindow.Models;

namespace WeekendWindow.Contracts
{
    public interface IGeoCodeRequest
    {
        Task<GeoLocation> GetGeoLocation(string address);
    }
}
