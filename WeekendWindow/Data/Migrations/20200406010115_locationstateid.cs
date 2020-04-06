using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class locationstateid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7140fe1b-93c6-4f42-80f6-c7067e45fbc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff10f7fd-64fd-42bd-ac86-e4d5277a3eb8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43b3c832-7e0d-460c-a40d-fb0514e36b5f", "1545172a-9676-4c29-9455-4f4dd461bc05", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00b15cbb-7a24-40fe-8a0a-d6fbb1445f84", "be1592d2-4be8-4980-adbe-54933ba9f156", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b15cbb-7a24-40fe-8a0a-d6fbb1445f84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43b3c832-7e0d-460c-a40d-fb0514e36b5f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff10f7fd-64fd-42bd-ac86-e4d5277a3eb8", "f392b9b5-a677-4eda-89e6-9d06b7795000", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7140fe1b-93c6-4f42-80f6-c7067e45fbc1", "7c8b7e01-da77-46a5-a976-de394534ca9e", "Viewer", "VIEWER" });
        }
    }
}
