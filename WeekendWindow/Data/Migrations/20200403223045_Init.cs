using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef65f9b7-eb1e-4654-b9d4-d03f1935f6fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3de88a67-3e8a-41d2-90a0-4d0957aa10b7", "235cac5b-c228-4936-9ef8-bf3d518c8606", "Warrior", "WARRIOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3de88a67-3e8a-41d2-90a0-4d0957aa10b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef65f9b7-eb1e-4654-b9d4-d03f1935f6fc", "32f3c07b-9664-4c72-8109-b7c3cf22f4a9", "Warrior", "WARRIOR" });
        }
    }
}
