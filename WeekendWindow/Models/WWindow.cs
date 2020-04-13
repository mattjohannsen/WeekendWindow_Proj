using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class WWindow
    {
        public int WWindowId { get; set; }

        [ForeignKey("ViewerLocation")]
        public int WeekendLocationId { get; set; } 
        public ViewerLocation ViewerLocation { get; set; } 
        public DateTime? SaturdayDate { get; set; }
        public DateTime? SundayDate { get; set; }
        public int SaturdayWeatherId { get; set; }
        public int SundayWeatherId { get; set; }
        public int WeekendAttitudeId { get; set; }
        public bool WantLodging { get; set; }
        public string WeekendLodgingId { get; set; }
        public int TravelRadiusId { get; set; }

    }
}
