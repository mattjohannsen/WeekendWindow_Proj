using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeekendWindow.Contracts;
using WeekendWindow.Models;

namespace WeekendWindow.Services
{
    public class GeoLocationRequest : IGeoCodeRequest
    {
        public  GeoLocationRequest()
        {
            
                
        }
        public async Task<GeoLocation> GetGeoLocation(string address)
        {
           // address = 1600 + Amphitheatre + Parkway,+Mountain + View,+CA
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={APIKEYS.GoogleAPIKey}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                GeoLocation geoLocation = JsonConvert.DeserializeObject<GeoLocation>(json);
                return geoLocation;
            }
            return null;
        }
    }
}
