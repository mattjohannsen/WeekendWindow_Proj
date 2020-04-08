using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class AddedViewerAddressFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bc49e12-f887-40b3-945f-ecfcb8690dfe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aae96f0a-ac1c-43bd-9664-5cf26276331e");

            migrationBuilder.AddColumn<string>(
                name: "ViewerAddress",
                table: "Viewers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerCity",
                table: "Viewers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerLat",
                table: "Viewers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerLong",
                table: "Viewers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerState",
                table: "Viewers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewerZip",
                table: "Viewers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4b88c82-48c5-42a2-a431-b44cac067703", "844ba25d-9c7d-4727-9545-464d22d9f4a3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e866984-432b-4d58-b4d8-ee0ce12d7f1e", "70202937-7c13-4232-965b-84ff14af59c5", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e866984-432b-4d58-b4d8-ee0ce12d7f1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4b88c82-48c5-42a2-a431-b44cac067703");

            migrationBuilder.DropColumn(
                name: "ViewerAddress",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerCity",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerLat",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerLong",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerState",
                table: "Viewers");

            migrationBuilder.DropColumn(
                name: "ViewerZip",
                table: "Viewers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aae96f0a-ac1c-43bd-9664-5cf26276331e", "cc6e012b-f728-4c05-927c-6e2105828d04", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bc49e12-f887-40b3-945f-ecfcb8690dfe", "08433cf2-fc29-49ef-9867-8239d6f4d563", "Viewer", "VIEWER" });
        }
    }
}
