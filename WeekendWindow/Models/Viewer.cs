using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeekendWindow.Models
{
    public class Viewer
    {
        public int ViewerId { get; set; }
        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? HomeLocationId { get; set; }
        public string ViewerPhone { get; set; }
        public int NotificationDay { get; set; }
        public string ViewerAddress { get; set; }
        public string ViewerCity { get; set; }
        public string ViewerState { get; set; }
        public string ViewerZip { get; set; }
        public string ViewerLong { get; set; }
        public string ViewerLat { get; set; }
        public WWindow WWindow { get; set; }

    }
}
