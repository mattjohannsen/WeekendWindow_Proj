using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class jones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8399ae4-fcbc-4e49-abd1-c7ba1b74c37e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb29f724-3f6e-4793-a7a3-27b018e375fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d99df21-16c8-43ee-ba13-a14634d420ed", "ec12fddf-8246-47cd-b8c0-e2dbed85dcb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8218d932-83fb-45b4-bfcb-b569e128ea44", "db764147-3802-44de-ae3a-c6aa25677b5e", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cb29f724-3f6e-4793-a7a3-27b018e375fe", "6cc950f6-9878-4562-92c6-86c7d265cc18", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8399ae4-fcbc-4e49-abd1-c7ba1b74c37e", "1cb43aed-a0c8-44f1-8d79-b539b0778733", "Viewer", "VIEWER" });
        }
    }
}
