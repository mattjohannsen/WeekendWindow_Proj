using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class Location
    {

        public int LocationId { get; set; }
        [ForeignKey("LocationViewerId")]
        public int LocationViewerId { get; set; } //Location property
        public int ViewerId { get; set; } //Viewer property
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        [ForeignKey("LocationStateId")]
        public int LocationStateId { get; set; } //Location property
        public int StateId { get; set; } //State property
        public string LocationZip { get; set; }
        public string LocationLong { get; set; }
        public string LocationLat { get; set; }
        public bool IsHomeLocation { get; set; }

    }
}
