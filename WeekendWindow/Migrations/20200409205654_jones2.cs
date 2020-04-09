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
                keyValue: "8218d932-83fb-45b4-bfcb-b569e128ea44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d99df21-16c8-43ee-ba13-a14634d420ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2f4b1ae-b38a-485d-885e-8c8de532af1f", "c2fd9788-f95f-4fca-84c8-3b2b33546b73", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c7ba52f-55e3-4b9d-94a6-51414074cc3d", "f1aad935-348e-497e-971c-787852e7e80f", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c7ba52f-55e3-4b9d-94a6-51414074cc3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2f4b1ae-b38a-485d-885e-8c8de532af1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d99df21-16c8-43ee-ba13-a14634d420ed", "ec12fddf-8246-47cd-b8c0-e2dbed85dcb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8218d932-83fb-45b4-bfcb-b569e128ea44", "db764147-3802-44de-ae3a-c6aa25677b5e", "Viewer", "VIEWER" });
        }
    }
}
