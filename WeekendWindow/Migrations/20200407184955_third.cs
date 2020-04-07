using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2361cd14-c657-4aa9-9528-a6f20e8dbc87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "622e63a6-d921-4035-b1f8-2a97fe8d9140");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Viewers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f1c963e-b106-4ebf-9b7a-89e292db46c9", "7146a617-d92e-4f84-b6f8-bede15307650", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc65a000-41d3-4e51-b784-8d9d458ee62a", "f7e212fe-289e-4829-9915-ad0929594230", "Viewer", "VIEWER" });

            migrationBuilder.CreateIndex(
                name: "IX_Viewers_AdminId",
                table: "Viewers",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viewers_Admins_AdminId",
                table: "Viewers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viewers_Admins_AdminId",
                table: "Viewers");

            migrationBuilder.DropIndex(
                name: "IX_Viewers_AdminId",
                table: "Viewers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1c963e-b106-4ebf-9b7a-89e292db46c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc65a000-41d3-4e51-b784-8d9d458ee62a");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Viewers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "622e63a6-d921-4035-b1f8-2a97fe8d9140", "f8b689b2-fb02-4092-98c9-9e5fe9fc03d3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2361cd14-c657-4aa9-9528-a6f20e8dbc87", "fd3615d0-8a62-412f-b50a-2104bbb4197c", "Viewer", "VIEWER" });
        }
    }
}
