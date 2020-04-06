using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class viewerchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c28fba6-a8c7-4017-8eaa-497ffdea9f6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a14cdcae-0311-4006-9c98-6ece601a14ef");

            migrationBuilder.DropColumn(
                name: "ViewerAddress",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerCity",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerState",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerZip",
                table: "Viewers");

            migrationBuilder.AddColumn<int>(
                name: "HomeLocationId",
                table: "Viewers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NotificationDay",
                table: "Viewers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31b8cae7-daec-465d-9001-95916bf1b048", "9428ae5b-36b0-449d-b499-5176dcbe2398", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5aca918-5055-4f52-bc55-e735952e0a5e", "b71a7187-37c3-4c7f-ae13-950697b43ffc", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b8cae7-daec-465d-9001-95916bf1b048");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5aca918-5055-4f52-bc55-e735952e0a5e");

            migrationBuilder.DropColumn(
                name: "HomeLocationId",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "NotificationDay",
                table: "Viewers");

            migrationBuilder.AddColumn<string>(
                name: "ViewerAddress",
                table: "Viewers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerCity",
                table: "Viewers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerState",
                table: "Viewers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerZip",
                table: "Viewers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c28fba6-a8c7-4017-8eaa-497ffdea9f6a", "e075d6c1-9c50-4339-87f7-ae75935ad261", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a14cdcae-0311-4006-9c98-6ece601a14ef", "2b526ab9-4e23-4a99-b039-f8a0976be6d3", "Viewer", "VIEWER" });
        }
    }
}
