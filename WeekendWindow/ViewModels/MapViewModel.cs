using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekendWindow.Models;

namespace WeekendWindow.ViewModels
{
    public class MapViewModel
    {
        public NearbyPlaces NearbyPlaces { get; set; }
        public Viewer Viewer { get; set; }
    }
}
