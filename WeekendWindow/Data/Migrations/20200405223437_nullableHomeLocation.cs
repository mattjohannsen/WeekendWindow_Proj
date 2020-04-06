using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class nullableHomeLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b8cae7-daec-465d-9001-95916bf1b048");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5aca918-5055-4f52-bc55-e735952e0a5e");

            migrationBuilder.AlterColumn<int>(
                name: "HomeLocationId",
                table: "Viewers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d548549-a5df-427a-bcd0-abb65d21ce27", "26391df3-d99e-492b-9030-674ecab84481", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dd857d8-eff7-4141-9175-e180fd5aa8b2", "1a590f56-6ee0-42b4-ad66-820103dc94ce", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dd857d8-eff7-4141-9175-e180fd5aa8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d548549-a5df-427a-bcd0-abb65d21ce27");

            migrationBuilder.AlterColumn<int>(
                name: "HomeLocationId",
                table: "Viewers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31b8cae7-daec-465d-9001-95916bf1b048", "9428ae5b-36b0-449d-b499-5176dcbe2398", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5aca918-5055-4f52-bc55-e735952e0a5e", "b71a7187-37c3-4c7f-ae13-950697b43ffc", "Viewer", "VIEWER" });
        }
    }
}
