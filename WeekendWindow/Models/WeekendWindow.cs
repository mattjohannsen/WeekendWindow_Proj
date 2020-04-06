using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class WWindow
    {
        public int WeekendWindowId { get; set; }
        [ForeignKey("WWViewerId")]
        public int WWViewerId { get; set; } //Weekend Window property
        public int ViewerId { get; set; } //Viewer property
        [ForeignKey("WeekendLocationId")]
        public int WeekendLocationId { get; set; } //Weekend Window property
        public int LocationId { get; set; } //Location property
        public DateTime? SaturdayDate { get; set; }
        public DateTime? SundayDate { get; set; }
        public int SaturdayWeatherId { get; set; }
        public int SundayWeatherId { get; set; }
        public int WeekendAttitudeId { get; set; }
        public bool WantLodging { get; set; }
        public int WeekendLodgingId { get; set; }
        public int TravelRadiusId { get; set; }

    }
}
