using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class addedlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8816c962-7826-4f66-a236-31591f5e0f17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9b55c5-84b2-4664-9c98-19b3d2b49664");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "848a93a2-757b-4cf5-b7dc-e1c3a362f71a", "6852edef-f354-48af-8035-dbd092998f6d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79cac252-2b5b-49f0-96bf-7ec82605a43a", "2f7290bf-aefc-443f-9249-98276eeabfdb", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8816c962-7826-4f66-a236-31591f5e0f17", "ea7fb3df-d0d1-4218-a798-b7bcd0f9710f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca9b55c5-84b2-4664-9c98-19b3d2b49664", "a0d94bc4-f3ce-4226-ab6b-aee0a7513771", "Viewer", "VIEWER" });
        }
    }
}
