using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class changeddayofweek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be748548-df38-4e48-be0a-aa0db979503d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c06ba2-9923-40d6-8474-de15a510f0ae");

            migrationBuilder.AlterColumn<int>(
                name: "NotificationDay",
                table: "Viewers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "671ddde5-a4ba-4298-b4d4-fad43405cbdb", "30cabfa9-5663-4f7a-af9a-95182706698d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d859fd2-de27-435a-9af4-c0f636951609", "6b1a8ade-c688-44ef-b2d2-27cf7e302839", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d859fd2-de27-435a-9af4-c0f636951609");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "671ddde5-a4ba-4298-b4d4-fad43405cbdb");

            migrationBuilder.AlterColumn<string>(
                name: "NotificationDay",
                table: "Viewers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8c06ba2-9923-40d6-8474-de15a510f0ae", "ed3fdbad-4ca5-4638-b53d-df541dd0ce9f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be748548-df38-4e48-be0a-aa0db979503d", "203c5d9f-5ebe-4ed7-b11e-eeaa1d9cc051", "Viewer", "VIEWER" });
        }
    }
}
