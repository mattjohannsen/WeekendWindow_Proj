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
            builder.Entity<State>()
                .HasData(
                    new State { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL" },
                    new State { StateId = 2, StateName = "Alaska", StateAbbreviation = "AK" },
                    new State { StateId = 3, StateName = "Arizona", StateAbbreviation = "AZ" },
                    new State { StateId = 4, StateName = "Arkansas", StateAbbreviation = "AR" },
                    new State { StateId = 5, StateName = "California", StateAbbreviation = "CA" },
                    new State { StateId = 6, StateName = "Colorado", StateAbbreviation = "CO" },
                    new State { StateId = 7, StateName = "Connecticut", StateAbbreviation = "CT" },
                    new State { StateId = 8, StateName = "Delaware", StateAbbreviation = "DE" },
                    new State { StateId = 9, StateName = "Florida", StateAbbreviation = "FL" },
                    new State { StateId = 10, StateName = "Georgia", StateAbbreviation = "GA" },
                    new State { StateId = 11, StateName = "Hawaii", StateAbbreviation = "HI" },
                    new State { StateId = 12, StateName = "Idaho", StateAbbreviation = "ID" },
                    new State { StateId = 13, StateName = "Illinois", StateAbbreviation = "IL" },
                    new State { StateId = 14, StateName = "Indiana", StateAbbreviation = "IN" },
                    new State { StateId = 15, StateName = "Iowa", StateAbbreviation = "IA" },
                    new State { StateId = 16, StateName = "Kansas", StateAbbreviation = "KS" },
                    new State { StateId = 17, StateName = "Kentucky", StateAbbreviation = "KY" },
                    new State { StateId = 18, StateName = "Louisiana", StateAbbreviation = "LA" },
                    new State { StateId = 19, StateName = "Maine", StateAbbreviation = "ME" },
                    new State { StateId = 20, StateName = "Maryland", StateAbbreviation = "MD" },
                    new State { StateId = 21, StateName = "Massachusetts", StateAbbreviation = "MA" },
                    new State { StateId = 22, StateName = "Michigan", StateAbbreviation = "MI" },
                    new State { StateId = 23, StateName = "Minnesota", StateAbbreviation = "MN" },
                    new State { StateId = 24, StateName = "Mississippi", StateAbbreviation = "MS" },
                    new State { StateId = 25, StateName = "Missouri", StateAbbreviation = "MO" },
                    new State { StateId = 26, StateName = "Montana", StateAbbreviation = "MT" },
                    new State { StateId = 27, StateName = "Nebraska", StateAbbreviation = "NE" },
                    new State { StateId = 28, StateName = "Nevada", StateAbbreviation = "NV" },
                    new State { StateId = 29, StateName = "New Hampshire", StateAbbreviation = "NH" },
                    new State { StateId = 30, StateName = "New Jersey", StateAbbreviation = "NJ" },
                    new State { StateId = 31, StateName = "New Mexico", StateAbbreviation = "NM" },
                    new State { StateId = 32, StateName = "New York", StateAbbreviation = "NY" },
                    new State { StateId = 33, StateName = "North Carolina", StateAbbreviation = "NC" },
                    new State { StateId = 34, StateName = "North Dakota", StateAbbreviation = "ND" },
                    new State { StateId = 35, StateName = "Ohio", StateAbbreviation = "OH" },
                    new State { StateId = 36, StateName = "Oklahoma", StateAbbreviation = "OK" },
                    new State { StateId = 37, StateName = "Oregon", StateAbbreviation = "OR" },
                    new State { StateId = 38, StateName = "Pennsylvania", StateAbbreviation = "PA" },
                    new State { StateId = 39, StateName = "Rhode Island", StateAbbreviation = "RI" },
                    new State { StateId = 40, StateName = "South Carolina", StateAbbreviation = "SC" },
                    new State { StateId = 41, StateName = "South Dakota", StateAbbreviation = "SD" },
                    new State { StateId = 42, StateName = "Tennessee", StateAbbreviation = "TN" },
                    new State { StateId = 43, StateName = "Texas", StateAbbreviation = "TX" },
                    new State { StateId = 44, StateName = "Utah", StateAbbreviation = "UT" },
                    new State { StateId = 45, StateName = "Vermont", StateAbbreviation = "VT" },
                    new State { StateId = 46, StateName = "Virginia", StateAbbreviation = "VA" },
                    new State { StateId = 47, StateName = "Washington", StateAbbreviation = "WA" },
                    new State { StateId = 48, StateName = "West Virginia", StateAbbreviation = "WV" },
                    new State { StateId = 49, StateName = "Wisconsin", StateAbbreviation = "WI" },
                    new State { StateId = 50, StateName = "Wyoming", StateAbbreviation = "WY" },
                    new State { StateId = 51, StateName = "District of Columbia", StateAbbreviation = "DC" }
                );
            builder.Entity<Attitude>()
                .HasData(
                    new Attitude { AttitudeId = 1, AttitudeName = "Party" },
                    new Attitude { AttitudeId = 2, AttitudeName = "Family" },
                    new Attitude { AttitudeId = 3, AttitudeName = "Romantic" },
                    new Attitude { AttitudeId = 4, AttitudeName = "Kids" },
                    new Attitude { AttitudeId = 5, AttitudeName = "Sight See" },
                    new Attitude { AttitudeId = 6, AttitudeName = "Culture" },
                    new Attitude { AttitudeId = 7, AttitudeName = "Relax" }
                );
            builder.Entity<TravelRadius>()
                .HasData(
                    new TravelRadius { TravelRadiusId = 1, RadiusMiles = 1, RadiumMeters = 1600},
                    new TravelRadius { TravelRadiusId = 2, RadiusMiles = 5, RadiumMeters = 8000 },
                    new TravelRadius { TravelRadiusId = 3, RadiusMiles = 10, RadiumMeters = 16000 },
                    new TravelRadius { TravelRadiusId = 4, RadiusMiles = 30, RadiumMeters = 50000 }
                );
            builder.Entity<GooglePlaces>()
                .HasData(
                    new GooglePlaces { GooglePlacesId = 1, GooglePlacesType = "amusement_park", GooglePlacesDisplay = "Amusement Park", IsOutdoors = true },
                    new GooglePlaces { GooglePlacesId = 2, GooglePlacesType = "aquarium", GooglePlacesDisplay = "Aquarium", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 3, GooglePlacesType = "art_gallery", GooglePlacesDisplay = "Art Gallery", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 4, GooglePlacesType = "bar", GooglePlacesDisplay = "Bar", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 5, GooglePlacesType = "bowling_alley", GooglePlacesDisplay = "Bowling Alley", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 6, GooglePlacesType = "café", GooglePlacesDisplay = "Café", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 7, GooglePlacesType = "campground", GooglePlacesDisplay = "Campground", IsOutdoors = true },
                    new GooglePlaces { GooglePlacesId = 8, GooglePlacesType = "casino", GooglePlacesDisplay = "Casino", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 9, GooglePlacesType = "gym", GooglePlacesDisplay = "Gym", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 10, GooglePlacesType = "library", GooglePlacesDisplay = "Library", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 11, GooglePlacesType = "lodging", GooglePlacesDisplay = "Lodging", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 12, GooglePlacesType = "movie_theater", GooglePlacesDisplay = "Movie Theater", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 13, GooglePlacesType = "museum", GooglePlacesDisplay = "Museum", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 14, GooglePlacesType = "night_club", GooglePlacesDisplay = "Night Club", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 15, GooglePlacesType = "park", GooglePlacesDisplay = "Park", IsOutdoors = true },
                    new GooglePlaces { GooglePlacesId = 16, GooglePlacesType = "restaurant", GooglePlacesDisplay = "Restaurant", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 17, GooglePlacesType = "shopping_mall", GooglePlacesDisplay = "Shopping Mall", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 18, GooglePlacesType = "spa", GooglePlacesDisplay = "Spa", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 19, GooglePlacesType = "stadium", GooglePlacesDisplay = "Stadium", IsOutdoors = true },
                    new GooglePlaces { GooglePlacesId = 20, GooglePlacesType = "tourist_attraction", GooglePlacesDisplay = "Tourist Attraction", IsOutdoors = false },
                    new GooglePlaces { GooglePlacesId = 21, GooglePlacesType = "zoo", GooglePlacesDisplay = "Zoo", IsOutdoors = true }
                );
            builder.Entity<GooglePlacesAttitude>()
                .HasData(
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 1, GPAGooglePlacesId = 1, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 2, GPAGooglePlacesId = 1, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 3, GPAGooglePlacesId = 1, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 4, GPAGooglePlacesId = 1, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 5, GPAGooglePlacesId = 1, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 6, GPAGooglePlacesId = 1, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 7, GPAGooglePlacesId = 1, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 8, GPAGooglePlacesId = 2, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 9, GPAGooglePlacesId = 2, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 10, GPAGooglePlacesId = 2, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 11, GPAGooglePlacesId = 2, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 12, GPAGooglePlacesId = 2, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 13, GPAGooglePlacesId = 3, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 14, GPAGooglePlacesId = 3, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 15, GPAGooglePlacesId = 3, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 16, GPAGooglePlacesId = 3, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 17, GPAGooglePlacesId = 3, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 18, GPAGooglePlacesId = 4, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 19, GPAGooglePlacesId = 4, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 20, GPAGooglePlacesId = 5, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 21, GPAGooglePlacesId = 5, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 22, GPAGooglePlacesId = 5, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 23, GPAGooglePlacesId = 5, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 24, GPAGooglePlacesId = 6, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 25, GPAGooglePlacesId = 6, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 26, GPAGooglePlacesId = 7, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 27, GPAGooglePlacesId = 7, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 28, GPAGooglePlacesId = 7, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 29, GPAGooglePlacesId = 7, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 30, GPAGooglePlacesId = 8, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 31, GPAGooglePlacesId = 8, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 32, GPAGooglePlacesId = 8, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 33, GPAGooglePlacesId = 9, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 34, GPAGooglePlacesId = 10, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 35, GPAGooglePlacesId = 10, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 36, GPAGooglePlacesId = 10, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 37, GPAGooglePlacesId = 10, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 38, GPAGooglePlacesId = 12, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 39, GPAGooglePlacesId = 12, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 40, GPAGooglePlacesId = 12, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 41, GPAGooglePlacesId = 12, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 42, GPAGooglePlacesId = 13, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 43, GPAGooglePlacesId = 13, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 44, GPAGooglePlacesId = 13, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 45, GPAGooglePlacesId = 13, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 46, GPAGooglePlacesId = 13, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 47, GPAGooglePlacesId = 13, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 48, GPAGooglePlacesId = 14, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 49, GPAGooglePlacesId = 14, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 50, GPAGooglePlacesId = 15, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 51, GPAGooglePlacesId = 15, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 52, GPAGooglePlacesId = 15, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 53, GPAGooglePlacesId = 15, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 54, GPAGooglePlacesId = 15, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 55, GPAGooglePlacesId = 16, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 56, GPAGooglePlacesId = 16, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 57, GPAGooglePlacesId = 16, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 58, GPAGooglePlacesId = 16, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 59, GPAGooglePlacesId = 16, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 60, GPAGooglePlacesId = 16, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 61, GPAGooglePlacesId = 16, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 62, GPAGooglePlacesId = 17, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 63, GPAGooglePlacesId = 17, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 64, GPAGooglePlacesId = 17, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 65, GPAGooglePlacesId = 18, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 66, GPAGooglePlacesId = 18, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 67, GPAGooglePlacesId = 19, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 68, GPAGooglePlacesId = 19, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 69, GPAGooglePlacesId = 19, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 70, GPAGooglePlacesId = 19, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 71, GPAGooglePlacesId = 19, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 72, GPAGooglePlacesId = 19, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 73, GPAGooglePlacesId = 19, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 74, GPAGooglePlacesId = 20, GPAAttitudeId = 1 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 75, GPAGooglePlacesId = 20, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 76, GPAGooglePlacesId = 20, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 77, GPAGooglePlacesId = 20, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 78, GPAGooglePlacesId = 20, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 79, GPAGooglePlacesId = 20, GPAAttitudeId = 6 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 80, GPAGooglePlacesId = 20, GPAAttitudeId = 7 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 81, GPAGooglePlacesId = 1, GPAAttitudeId = 2 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 82, GPAGooglePlacesId = 1, GPAAttitudeId = 3 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 83, GPAGooglePlacesId = 1, GPAAttitudeId = 4 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 84, GPAGooglePlacesId = 1, GPAAttitudeId = 5 },
                    new GooglePlacesAttitude { GooglePlacesAttitudeId = 85, GPAGooglePlacesId = 1, GPAAttitudeId = 7 }
                );
        }
        public DbSet<Models.Viewer> Viewers { get; set; }
        public DbSet<Models.ViewerLocation> ViewerLocation { get; set; }
        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.State> State { get; set; }
        public DbSet<Models.Attitude> Attitude { get; set; }
        public DbSet<Models.TravelRadius> TravelRadius { get; set; }
        public DbSet<Models.GooglePlaces> GooglePlaces { get; set; }
        public DbSet<Models.GooglePlacesAttitude> GooglePlacesAttitude { get; set; }
        public DbSet<WeekendWindow.Models.NearbyPlaces> NearbyPlaces { get; set; }
        public DbSet<WeekendWindow.Models.WeatherForecast> WeatherForecast { get; set; }
    }
}
