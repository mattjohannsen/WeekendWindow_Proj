using Microsoft.AspNetCore.Identity;
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
        public string NotificationDay { get; set; }

    }
}
