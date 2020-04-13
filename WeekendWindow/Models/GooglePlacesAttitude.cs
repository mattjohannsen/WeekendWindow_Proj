using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class GooglePlacesAttitude
    {
        public int GooglePlacesAttitudeId { get; set; }
        [ForeignKey("GooglePlaces")]
        public int GPAGooglePlacesId { get; set; } 
        public GooglePlaces GooglePlaces { get; set; }
        [ForeignKey("Attitude")]
        public int GPAAttitudeId { get; set; }
        public Attitude Attitude { get; set; } 
    }
}
