using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class GooglePlaces
    {
        public int GooglePlacesId { get; set; }
        public string GooglePlacesType { get; set; }
        public string GooglePlacesDisplay { get; set; }
        public bool IsOutdoors { get; set; }
    }
}
