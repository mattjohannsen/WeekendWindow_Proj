using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeekendWindow.Models;

namespace WeekendWindow.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Models.Viewer> Viewers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<IdentityRole>()
				.HasData(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    },
                    new IdentityRole
                    {
                        Name = "Viewer",
                        NormalizedName = "VIEWER",
                    }
                );
		}

		public DbSet<WeekendWindow.Models.Location> Location { get; set; }
	}
}
