using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WeekendWindow.Models;

namespace WeekendWindow.ViewModels
{
    public class MapViewModel
    {
        public NearbyPlaces NearbyPlaces { get; set; }
        public Viewer Viewer { get; set; }
        public List<SelectListItem> GPAttitudes { get; set; }
        [NotMapped]
        public GooglePlacesAttitude SelectedGPA { get; set; }
        public List<SelectListItem> Attitudes { get; set; }
        [NotMapped]
        public Attitude SelectedAttitude { get; set; }
        public List<SelectListItem> GooglePlaces { get; set; }
        [NotMapped]
        public GooglePlaces SelectedPlace { get; set; }
    }
}
