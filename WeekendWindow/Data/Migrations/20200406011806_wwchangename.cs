using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class wwchangename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b15cbb-7a24-40fe-8a0a-d6fbb1445f84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43b3c832-7e0d-460c-a40d-fb0514e36b5f");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationViewerId = table.Column<int>(nullable: false),
                    ViewerId = table.Column<int>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    LocationAddress = table.Column<string>(nullable: true),
                    LocationCity = table.Column<string>(nullable: true),
                    LocationStateId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    LocationZip = table.Column<string>(nullable: true),
                    LocationLong = table.Column<string>(nullable: true),
                    LocationLat = table.Column<string>(nullable: true),
                    IsHomeLocation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e096e24f-dc64-41a6-a7ec-c47ed39ba81d", "2f7d53ee-44d6-4ca4-8198-63329170c802", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34bb96f8-1a8a-4138-bec4-e8c7463f10f0", "e1657350-139f-474c-914f-4eaf2cbebd13", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34bb96f8-1a8a-4138-bec4-e8c7463f10f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e096e24f-dc64-41a6-a7ec-c47ed39ba81d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43b3c832-7e0d-460c-a40d-fb0514e36b5f", "1545172a-9676-4c29-9455-4f4dd461bc05", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00b15cbb-7a24-40fe-8a0a-d6fbb1445f84", "be1592d2-4be8-4980-adbe-54933ba9f156", "Viewer", "VIEWER" });
        }
    }
}
