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
        public int GPAGooglePlacesId { get; set; } //GooglePlacesAttitude property
        public GooglePlaces GooglePlaces { get; set; } //GooglePlaces class
        [ForeignKey("Attitude")]
        public int GPAAttitudeId { get; set; } //GooglePlacesAttitude property
        public Attitude Attitude { get; set; } //Attitude class
    }
}
