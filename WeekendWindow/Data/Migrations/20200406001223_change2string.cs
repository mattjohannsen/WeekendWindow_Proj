using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class change2string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79f9d501-efb5-4e8b-a8e5-ceb186bc9ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf18f5c-f529-439c-8b0d-542a1a1a2df3");

            migrationBuilder.AlterColumn<string>(
                name: "NotificationDay",
                table: "Viewers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8816c962-7826-4f66-a236-31591f5e0f17", "ea7fb3df-d0d1-4218-a798-b7bcd0f9710f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca9b55c5-84b2-4664-9c98-19b3d2b49664", "a0d94bc4-f3ce-4226-ab6b-aee0a7513771", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8816c962-7826-4f66-a236-31591f5e0f17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9b55c5-84b2-4664-9c98-19b3d2b49664");

            migrationBuilder.AlterColumn<int>(
                name: "NotificationDay",
                table: "Viewers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaf18f5c-f529-439c-8b0d-542a1a1a2df3", "62527d61-7e13-4c4a-9bfa-5c62e5c52b7f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79f9d501-efb5-4e8b-a8e5-ceb186bc9ac3", "9eec3594-948a-4ea4-96f7-9826191ca04d", "Viewer", "VIEWER" });
        }
    }
}
