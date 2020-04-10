using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class jones2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bee2adb-d93e-4733-b1e9-660fcc3db564");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5fa242c-be37-4c5f-ad6e-42a5a7ccb9b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd1cbfdf-0d01-40f5-9338-5ca1d92dfc1d", "ddbb0a15-8693-46bb-9a6b-0d1850d70f74", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75717de4-33fc-4f84-b3cb-e5d5a878622e", "93d965d8-d955-45b9-a597-1440cd22b5db", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75717de4-33fc-4f84-b3cb-e5d5a878622e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd1cbfdf-0d01-40f5-9338-5ca1d92dfc1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bee2adb-d93e-4733-b1e9-660fcc3db564", "c25a5528-78b6-41ff-bc68-416a9b02655e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5fa242c-be37-4c5f-ad6e-42a5a7ccb9b2", "1e1779d1-14ba-4b26-a94a-8cdc1aa1e965", "Viewer", "VIEWER" });
        }
    }
}
