using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class dropdowndow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d859fd2-de27-435a-9af4-c0f636951609");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "671ddde5-a4ba-4298-b4d4-fad43405cbdb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaf18f5c-f529-439c-8b0d-542a1a1a2df3", "62527d61-7e13-4c4a-9bfa-5c62e5c52b7f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79f9d501-efb5-4e8b-a8e5-ceb186bc9ac3", "9eec3594-948a-4ea4-96f7-9826191ca04d", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79f9d501-efb5-4e8b-a8e5-ceb186bc9ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf18f5c-f529-439c-8b0d-542a1a1a2df3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "671ddde5-a4ba-4298-b4d4-fad43405cbdb", "30cabfa9-5663-4f7a-af9a-95182706698d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d859fd2-de27-435a-9af4-c0f636951609", "6b1a8ade-c688-44ef-b2d2-27cf7e302839", "Viewer", "VIEWER" });
        }
    }
}
