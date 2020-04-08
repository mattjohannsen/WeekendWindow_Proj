using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attitude",
                columns: table => new
                {
                    AttitudeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttitudeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attitude", x => x.AttitudeId);
                });

            migrationBuilder.CreateTable(
                name: "GooglePlaces",
                columns: table => new
                {
                    GooglePlacesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GooglePlacesType = table.Column<string>(nullable: true),
                    GooglePlacesDisplay = table.Column<string>(nullable: true),
                    IsOutdoors = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GooglePlaces", x => x.GooglePlacesId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<float>(nullable: false),
                    lng = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "NearbyPlaces",
                columns: table => new
                {
                    NearbyPlacesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    next_page_token = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NearbyPlaces", x => x.NearbyPlacesId);
                });

            migrationBuilder.CreateTable(
                name: "Northeast",
                columns: table => new
                {
                    NortheastId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<float>(nullable: false),
                    lng = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Northeast", x => x.NortheastId);
                });

            migrationBuilder.CreateTable(
                name: "Opening_Hours",
                columns: table => new
                {
                    Opening_HoursId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    open_now = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opening_Hours", x => x.Opening_HoursId);
                });

            migrationBuilder.CreateTable(
                name: "Plus_Code",
                columns: table => new
                {
                    Plus_CodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compound_code = table.Column<string>(nullable: true),
                    global_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plus_Code", x => x.Plus_CodeId);
                });

            migrationBuilder.CreateTable(
                name: "Southwest",
                columns: table => new
                {
                    SouthwestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<float>(nullable: false),
                    lng = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Southwest", x => x.SouthwestId);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    StateAbbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "TravelRadius",
                columns: table => new
                {
                    TravelRadiusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadiusMiles = table.Column<int>(nullable: false),
                    RadiumMeters = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelRadius", x => x.TravelRadiusId);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    WeatherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icon = table.Column<string>(nullable: true),
                    code = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.WeatherId);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    WeatherForecastId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_name = table.Column<string>(nullable: true),
                    lon = table.Column<string>(nullable: true),
                    timezone = table.Column<string>(nullable: true),
                    lat = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: true),
                    state_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.WeatherForecastId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viewers",
                columns: table => new
                {
                    ViewerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    HomeLocationId = table.Column<int>(nullable: true),
                    NotificationDay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewers", x => x.ViewerId);
                    table.ForeignKey(
                        name: "FK_Viewers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GooglePlacesAttitude",
                columns: table => new
                {
                    GooglePlacesAttitudeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GPAGooglePlacesId = table.Column<int>(nullable: false),
                    GPAAttitudeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GooglePlacesAttitude", x => x.GooglePlacesAttitudeId);
                    table.ForeignKey(
                        name: "FK_GooglePlacesAttitude_Attitude_GPAAttitudeId",
                        column: x => x.GPAAttitudeId,
                        principalTable: "Attitude",
                        principalColumn: "AttitudeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GooglePlacesAttitude_GooglePlaces_GPAGooglePlacesId",
                        column: x => x.GPAGooglePlacesId,
                        principalTable: "GooglePlaces",
                        principalColumn: "GooglePlacesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viewport",
                columns: table => new
                {
                    ViewPortId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NortheastId = table.Column<int>(nullable: true),
                    SouthwestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewport", x => x.ViewPortId);
                    table.ForeignKey(
                        name: "FK_Viewport_Northeast_NortheastId",
                        column: x => x.NortheastId,
                        principalTable: "Northeast",
                        principalColumn: "NortheastId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viewport_Southwest_SouthwestId",
                        column: x => x.SouthwestId,
                        principalTable: "Southwest",
                        principalColumn: "SouthwestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Datum",
                columns: table => new
                {
                    DatumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moonrise_ts = table.Column<int>(nullable: false),
                    wind_cdir = table.Column<string>(nullable: true),
                    rh = table.Column<int>(nullable: false),
                    pres = table.Column<float>(nullable: false),
                    high_temp = table.Column<float>(nullable: false),
                    sunset_ts = table.Column<int>(nullable: false),
                    ozone = table.Column<float>(nullable: false),
                    moon_phase = table.Column<float>(nullable: false),
                    wind_gust_spd = table.Column<float>(nullable: false),
                    snow_depth = table.Column<float>(nullable: false),
                    clouds = table.Column<int>(nullable: false),
                    ts = table.Column<int>(nullable: false),
                    sunrise_ts = table.Column<int>(nullable: false),
                    app_min_temp = table.Column<float>(nullable: false),
                    wind_spd = table.Column<float>(nullable: false),
                    pop = table.Column<int>(nullable: false),
                    wind_cdir_full = table.Column<string>(nullable: true),
                    slp = table.Column<float>(nullable: false),
                    moon_phase_lunation = table.Column<float>(nullable: false),
                    valid_date = table.Column<string>(nullable: true),
                    app_max_temp = table.Column<float>(nullable: false),
                    vis = table.Column<float>(nullable: false),
                    dewpt = table.Column<float>(nullable: false),
                    snow = table.Column<float>(nullable: false),
                    uv = table.Column<float>(nullable: false),
                    WeatherId = table.Column<int>(nullable: true),
                    wind_dir = table.Column<int>(nullable: false),
                    clouds_hi = table.Column<int>(nullable: false),
                    precip = table.Column<float>(nullable: false),
                    low_temp = table.Column<float>(nullable: false),
                    max_temp = table.Column<float>(nullable: false),
                    moonset_ts = table.Column<int>(nullable: false),
                    datetime = table.Column<string>(nullable: true),
                    temp = table.Column<float>(nullable: false),
                    min_temp = table.Column<float>(nullable: false),
                    clouds_mid = table.Column<int>(nullable: false),
                    clouds_low = table.Column<int>(nullable: false),
                    WeatherForecastId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datum", x => x.DatumId);
                    table.ForeignKey(
                        name: "FK_Datum_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "WeatherForecastId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Datum_Weather_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "Weather",
                        principalColumn: "WeatherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViewerLocation",
                columns: table => new
                {
                    ViewerLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewerLocationViewerId = table.Column<int>(nullable: false),
                    ViewerLocationName = table.Column<string>(nullable: true),
                    ViewerLocationAddress = table.Column<string>(nullable: true),
                    ViewerLocationCity = table.Column<string>(nullable: true),
                    ViewerLocationStateId = table.Column<int>(nullable: false),
                    ViewerLocationZip = table.Column<string>(nullable: true),
                    ViewerLocationLong = table.Column<string>(nullable: true),
                    ViewerLocationLat = table.Column<string>(nullable: true),
                    ViewerIsHomeLocation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewerLocation", x => x.ViewerLocationId);
                    table.ForeignKey(
                        name: "FK_ViewerLocation_State_ViewerLocationStateId",
                        column: x => x.ViewerLocationStateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewerLocation_Viewers_ViewerLocationViewerId",
                        column: x => x.ViewerLocationViewerId,
                        principalTable: "Viewers",
                        principalColumn: "ViewerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Geometry",
                columns: table => new
                {
                    GeometryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(nullable: true),
                    ViewPortId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geometry", x => x.GeometryId);
                    table.ForeignKey(
                        name: "FK_Geometry_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Geometry_Viewport_ViewPortId",
                        column: x => x.ViewPortId,
                        principalTable: "Viewport",
                        principalColumn: "ViewPortId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    GeometryId = table.Column<int>(nullable: true),
                    icon = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    place_id = table.Column<string>(nullable: true),
                    Plus_CodeId = table.Column<int>(nullable: true),
                    price_level = table.Column<int>(nullable: false),
                    rating = table.Column<float>(nullable: false),
                    reference = table.Column<string>(nullable: true),
                    scope = table.Column<string>(nullable: true),
                    user_ratings_total = table.Column<int>(nullable: false),
                    vicinity = table.Column<string>(nullable: true),
                    Opening_HoursId = table.Column<int>(nullable: true),
                    NearbyPlacesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.id);
                    table.ForeignKey(
                        name: "FK_Result_Geometry_GeometryId",
                        column: x => x.GeometryId,
                        principalTable: "Geometry",
                        principalColumn: "GeometryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_NearbyPlaces_NearbyPlacesId",
                        column: x => x.NearbyPlacesId,
                        principalTable: "NearbyPlaces",
                        principalColumn: "NearbyPlacesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_Opening_Hours_Opening_HoursId",
                        column: x => x.Opening_HoursId,
                        principalTable: "Opening_Hours",
                        principalColumn: "Opening_HoursId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_Plus_Code_Plus_CodeId",
                        column: x => x.Plus_CodeId,
                        principalTable: "Plus_Code",
                        principalColumn: "Plus_CodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    height = table.Column<int>(nullable: false),
                    photo_reference = table.Column<string>(nullable: true),
                    width = table.Column<int>(nullable: false),
                    Resultid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photo_Result_Resultid",
                        column: x => x.Resultid,
                        principalTable: "Result",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05883021-ba71-4973-a80b-d0af7a6b589d", "d0834130-e3b9-454b-a4c6-2f589a582883", "Admin", "ADMIN" },
                    { "77b8471d-5396-42aa-a9a5-c91b8c766c67", "b60f839d-c78b-4d90-a4ae-a3dc688955e0", "Viewer", "VIEWER" }
                });

            migrationBuilder.InsertData(
                table: "Attitude",
                columns: new[] { "AttitudeId", "AttitudeName" },
                values: new object[,]
                {
                    { 1, "Party" },
                    { 2, "Family" },
                    { 3, "Romantic" },
                    { 4, "Kids" },
                    { 5, "Sight See" },
                    { 6, "Culture" },
                    { 7, "Relax" }
                });

            migrationBuilder.InsertData(
                table: "GooglePlaces",
                columns: new[] { "GooglePlacesId", "GooglePlacesDisplay", "GooglePlacesType", "IsOutdoors" },
                values: new object[,]
                {
                    { 13, "Museum", "museum", false },
                    { 14, "Night Club", "night_club", false },
                    { 15, "Park", "park", true },
                    { 16, "Restaurant", "restaurant", false },
                    { 21, "Zoo", "zoo", true },
                    { 18, "Spa", "spa", false },
                    { 20, "Tourist Attraction", "tourist_attraction", false },
                    { 12, "Movie Theater", "movie_theater", false },
                    { 17, "Shopping Mall", "shopping_mall", false },
                    { 11, "Lodging", "lodging", false },
                    { 19, "Stadium", "stadium", true },
                    { 9, "Gym", "gym", false },
                    { 8, "Casino", "casino", false },
                    { 7, "Campground", "campground", true },
                    { 6, "Café", "café", false },
                    { 5, "Bowling Alley", "bowling_alley", false },
                    { 4, "Bar", "bar", false },
                    { 3, "Art Gallery", "art_gallery", false },
                    { 2, "Aquarium", "aquarium", false },
                    { 1, "Amusement Park", "amusement_park", true },
                    { 10, "Library", "library", false }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "StateId", "StateAbbreviation", "StateName" },
                values: new object[,]
                {
                    { 37, "OR", "Oregon" },
                    { 36, "OK", "Oklahoma" },
                    { 35, "OH", "Ohio" },
                    { 34, "ND", "North Dakota" },
                    { 30, "NJ", "New Jersey" },
                    { 32, "NY", "New York" },
                    { 31, "NM", "New Mexico" },
                    { 38, "PA", "Pennsylvania" },
                    { 29, "NH", "New Hampshire" },
                    { 33, "NC", "North Carolina" },
                    { 39, "RI", "Rhode Island" },
                    { 44, "UT", "Utah" },
                    { 41, "SD", "South Dakota" },
                    { 42, "TN", "Tennessee" },
                    { 43, "TX", "Texas" },
                    { 45, "VT", "Vermont" },
                    { 46, "VA", "Virginia" },
                    { 47, "WA", "Washington" },
                    { 48, "WV", "West Virginia" },
                    { 49, "WI", "Wisconsin" },
                    { 50, "WY", "Wyoming" },
                    { 51, "DC", "District of Columbia" },
                    { 28, "NV", "Nevada" },
                    { 40, "SC", "South Carolina" },
                    { 27, "NE", "Nebraska" },
                    { 13, "IL", "Illinois" },
                    { 25, "MO", "Missouri" },
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "FL", "Florida" },
                    { 10, "GA", "Georgia" },
                    { 26, "MT", "Montana" },
                    { 12, "ID", "Idaho" },
                    { 11, "HI", "Hawaii" },
                    { 14, "IN", "Indiana" },
                    { 15, "IA", "Iowa" },
                    { 16, "KS", "Kansas" },
                    { 17, "KY", "Kentucky" },
                    { 18, "LA", "Louisiana" },
                    { 19, "ME", "Maine" },
                    { 20, "MD", "Maryland" },
                    { 21, "MA", "Massachusetts" },
                    { 22, "MI", "Michigan" },
                    { 23, "MN", "Minnesota" },
                    { 24, "MS", "Mississippi" }
                });

            migrationBuilder.InsertData(
                table: "TravelRadius",
                columns: new[] { "TravelRadiusId", "RadiumMeters", "RadiusMiles" },
                values: new object[,]
                {
                    { 1, 1600, 1 },
                    { 2, 8000, 5 },
                    { 3, 16000, 10 },
                    { 4, 50000, 30 }
                });

            migrationBuilder.InsertData(
                table: "GooglePlacesAttitude",
                columns: new[] { "GooglePlacesAttitudeId", "GPAAttitudeId", "GPAGooglePlacesId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 56, 2, 16 },
                    { 55, 1, 16 },
                    { 54, 7, 15 },
                    { 53, 5, 15 },
                    { 52, 4, 15 },
                    { 51, 3, 15 },
                    { 50, 2, 15 },
                    { 49, 7, 14 },
                    { 48, 1, 14 },
                    { 47, 7, 13 },
                    { 46, 6, 13 },
                    { 45, 5, 13 },
                    { 44, 4, 13 },
                    { 43, 3, 13 },
                    { 42, 2, 13 },
                    { 41, 7, 12 },
                    { 40, 4, 12 },
                    { 57, 3, 16 },
                    { 58, 4, 16 },
                    { 59, 5, 16 },
                    { 60, 6, 16 },
                    { 78, 5, 20 },
                    { 77, 4, 20 },
                    { 76, 3, 20 },
                    { 75, 2, 20 },
                    { 74, 1, 20 },
                    { 73, 7, 19 },
                    { 72, 6, 19 },
                    { 71, 5, 19 },
                    { 39, 3, 12 },
                    { 70, 4, 19 },
                    { 68, 2, 19 },
                    { 67, 1, 19 },
                    { 66, 7, 18 },
                    { 65, 3, 18 },
                    { 64, 7, 17 },
                    { 63, 4, 17 },
                    { 62, 2, 17 },
                    { 61, 7, 16 },
                    { 69, 3, 19 },
                    { 79, 6, 20 },
                    { 38, 2, 12 },
                    { 36, 6, 10 },
                    { 13, 2, 3 },
                    { 12, 7, 2 },
                    { 11, 6, 2 },
                    { 10, 5, 2 },
                    { 9, 4, 2 },
                    { 8, 2, 2 },
                    { 85, 7, 1 },
                    { 84, 5, 1 },
                    { 83, 4, 1 },
                    { 82, 3, 1 },
                    { 81, 2, 1 },
                    { 7, 7, 1 },
                    { 6, 6, 1 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 14, 4, 3 },
                    { 15, 5, 3 },
                    { 16, 6, 3 },
                    { 17, 7, 3 },
                    { 35, 4, 10 },
                    { 34, 2, 10 },
                    { 33, 7, 9 },
                    { 32, 7, 8 },
                    { 31, 6, 8 },
                    { 30, 1, 8 },
                    { 29, 7, 7 },
                    { 28, 4, 7 },
                    { 37, 7, 10 },
                    { 27, 2, 7 },
                    { 25, 7, 6 },
                    { 24, 3, 6 },
                    { 23, 7, 5 },
                    { 22, 4, 5 },
                    { 21, 2, 5 },
                    { 20, 1, 5 },
                    { 19, 7, 4 },
                    { 18, 1, 4 },
                    { 26, 1, 7 },
                    { 80, 7, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_IdentityUserId",
                table: "Admins",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Datum_WeatherForecastId",
                table: "Datum",
                column: "WeatherForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Datum_WeatherId",
                table: "Datum",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Geometry_LocationId",
                table: "Geometry",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Geometry_ViewPortId",
                table: "Geometry",
                column: "ViewPortId");

            migrationBuilder.CreateIndex(
                name: "IX_GooglePlacesAttitude_GPAAttitudeId",
                table: "GooglePlacesAttitude",
                column: "GPAAttitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_GooglePlacesAttitude_GPAGooglePlacesId",
                table: "GooglePlacesAttitude",
                column: "GPAGooglePlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Resultid",
                table: "Photo",
                column: "Resultid");

            migrationBuilder.CreateIndex(
                name: "IX_Result_GeometryId",
                table: "Result",
                column: "GeometryId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_NearbyPlacesId",
                table: "Result",
                column: "NearbyPlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_Opening_HoursId",
                table: "Result",
                column: "Opening_HoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_Plus_CodeId",
                table: "Result",
                column: "Plus_CodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewerLocation_ViewerLocationStateId",
                table: "ViewerLocation",
                column: "ViewerLocationStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewerLocation_ViewerLocationViewerId",
                table: "ViewerLocation",
                column: "ViewerLocationViewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewers_IdentityUserId",
                table: "Viewers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_NortheastId",
                table: "Viewport",
                column: "NortheastId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_SouthwestId",
                table: "Viewport",
                column: "SouthwestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Datum");

            migrationBuilder.DropTable(
                name: "GooglePlacesAttitude");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "TravelRadius");

            migrationBuilder.DropTable(
                name: "ViewerLocation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Attitude");

            migrationBuilder.DropTable(
                name: "GooglePlaces");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Viewers");

            migrationBuilder.DropTable(
                name: "Geometry");

            migrationBuilder.DropTable(
                name: "NearbyPlaces");

            migrationBuilder.DropTable(
                name: "Opening_Hours");

            migrationBuilder.DropTable(
                name: "Plus_Code");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Viewport");

            migrationBuilder.DropTable(
                name: "Northeast");

            migrationBuilder.DropTable(
                name: "Southwest");
        }
    }
}
