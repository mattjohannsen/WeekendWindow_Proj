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
    public class NearbyPlaceSearchRequest : INearbySearchRequest
    {
        public NearbyPlaceSearchRequest()
        {

        }

        public async Task<NearbyPlaces> GetNearbyPlaces(string type, string coords)
        {
            string url = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={coords}&radius=50000&type={type}&keyword=&key={APIKEYS.GoogleAPIKey}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                NearbyPlaces nearbyPlaces = JsonConvert.DeserializeObject<NearbyPlaces>(json);
                return nearbyPlaces;
            }
            return null;
        }
    }
}
