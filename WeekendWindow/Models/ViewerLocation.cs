using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class ViewerLocation
    {

        public int ViewerLocationId { get; set; }
        [ForeignKey("Viewer")]
        public int ViewerLocationViewerId { get; set; } 
        public Viewer Viewer { get; set; } 
        public string ViewerLocationName { get; set; }
        public string ViewerLocationAddress { get; set; }
        public string ViewerLocationCity { get; set; }
        [ForeignKey("State")]
        public int ViewerLocationStateId { get; set; } 
        public State State { get; set; } 
        public string ViewerLocationZip { get; set; }
        public string ViewerLocationLong { get; set; }
        public string ViewerLocationLat { get; set; }
        public bool ViewerIsHomeLocation { get; set; }

    }
}
