using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1cda75e-7305-4991-b37d-79a2c8f85cf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f499470c-26ed-4450-8ad5-966621f6fe85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "622e63a6-d921-4035-b1f8-2a97fe8d9140", "f8b689b2-fb02-4092-98c9-9e5fe9fc03d3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2361cd14-c657-4aa9-9528-a6f20e8dbc87", "fd3615d0-8a62-412f-b50a-2104bbb4197c", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2361cd14-c657-4aa9-9528-a6f20e8dbc87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "622e63a6-d921-4035-b1f8-2a97fe8d9140");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1cda75e-7305-4991-b37d-79a2c8f85cf2", "50c7e412-2ba1-4553-b5e5-0efa6bfa109a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f499470c-26ed-4450-8ad5-966621f6fe85", "c63155af-c4ec-4eac-b148-b560b300c47c", "Viewer", "VIEWER" });
        }
    }
}
