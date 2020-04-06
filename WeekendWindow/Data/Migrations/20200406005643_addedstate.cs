using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class addedstate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79cac252-2b5b-49f0-96bf-7ec82605a43a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848a93a2-757b-4cf5-b7dc-e1c3a362f71a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff10f7fd-64fd-42bd-ac86-e4d5277a3eb8", "f392b9b5-a677-4eda-89e6-9d06b7795000", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7140fe1b-93c6-4f42-80f6-c7067e45fbc1", "7c8b7e01-da77-46a5-a976-de394534ca9e", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "848a93a2-757b-4cf5-b7dc-e1c3a362f71a", "6852edef-f354-48af-8035-dbd092998f6d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79cac252-2b5b-49f0-96bf-7ec82605a43a", "2f7290bf-aefc-443f-9249-98276eeabfdb", "Viewer", "VIEWER" });
        }
    }
}
