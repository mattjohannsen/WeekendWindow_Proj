using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class travelradiusgpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39d0c271-5065-4c60-9043-48f2f957b20d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb35f5b5-fb79-4aba-8253-2b5285a00f24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b286130f-9e0d-4671-97d4-f7ded38cb7dc", "ff218d8a-bf9c-48e1-8f4d-51839f4e7e64", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "204776c0-54f4-40dd-aefa-47ad70539127", "46281ad6-4cab-4360-a445-8b016be898f1", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "204776c0-54f4-40dd-aefa-47ad70539127");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b286130f-9e0d-4671-97d4-f7ded38cb7dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39d0c271-5065-4c60-9043-48f2f957b20d", "b1cf686a-d464-4e6b-b380-e5d89bcb901f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb35f5b5-fb79-4aba-8253-2b5285a00f24", "6bb768c2-cf58-4834-85f3-6d616f1df80a", "Viewer", "VIEWER" });
        }
    }
}
