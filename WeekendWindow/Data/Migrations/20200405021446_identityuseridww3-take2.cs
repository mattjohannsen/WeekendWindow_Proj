using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class identityuseridww3take2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e561532-3e4d-4c7d-a794-6236d11fd944");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93019a65-1059-49b3-88a8-a969e0dffdae");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Viewers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c28fba6-a8c7-4017-8eaa-497ffdea9f6a", "e075d6c1-9c50-4339-87f7-ae75935ad261", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a14cdcae-0311-4006-9c98-6ece601a14ef", "2b526ab9-4e23-4a99-b039-f8a0976be6d3", "Viewer", "VIEWER" });

            migrationBuilder.CreateIndex(
                name: "IX_Viewers_IdentityUserId",
                table: "Viewers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Viewers_AspNetUsers_IdentityUserId",
                table: "Viewers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Viewers_AspNetUsers_IdentityUserId",
                table: "Viewers");

            migrationBuilder.DropIndex(
                name: "IX_Viewers_IdentityUserId",
                table: "Viewers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c28fba6-a8c7-4017-8eaa-497ffdea9f6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a14cdcae-0311-4006-9c98-6ece601a14ef");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Viewers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93019a65-1059-49b3-88a8-a969e0dffdae", "104c4c6d-9952-4ba0-a3fa-056ddf823799", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e561532-3e4d-4c7d-a794-6236d11fd944", "d6b247db-a92f-4237-bb21-fac7ddfc3fc6", "Viewer", "VIEWER" });
        }
    }
}
