using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class addnotificationlisttoviewermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dd857d8-eff7-4141-9175-e180fd5aa8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d548549-a5df-427a-bcd0-abb65d21ce27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8c06ba2-9923-40d6-8474-de15a510f0ae", "ed3fdbad-4ca5-4638-b53d-df541dd0ce9f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be748548-df38-4e48-be0a-aa0db979503d", "203c5d9f-5ebe-4ed7-b11e-eeaa1d9cc051", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be748548-df38-4e48-be0a-aa0db979503d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c06ba2-9923-40d6-8474-de15a510f0ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d548549-a5df-427a-bcd0-abb65d21ce27", "26391df3-d99e-492b-9030-674ecab84481", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dd857d8-eff7-4141-9175-e180fd5aa8b2", "1a590f56-6ee0-42b4-ad66-820103dc94ce", "Viewer", "VIEWER" });
        }
    }
}
