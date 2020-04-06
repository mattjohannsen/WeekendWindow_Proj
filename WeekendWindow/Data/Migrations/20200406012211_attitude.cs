using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class attitude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34bb96f8-1a8a-4138-bec4-e8c7463f10f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e096e24f-dc64-41a6-a7ec-c47ed39ba81d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39d0c271-5065-4c60-9043-48f2f957b20d", "b1cf686a-d464-4e6b-b380-e5d89bcb901f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb35f5b5-fb79-4aba-8253-2b5285a00f24", "6bb768c2-cf58-4834-85f3-6d616f1df80a", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e096e24f-dc64-41a6-a7ec-c47ed39ba81d", "2f7d53ee-44d6-4ca4-8198-63329170c802", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34bb96f8-1a8a-4138-bec4-e8c7463f10f0", "e1657350-139f-474c-914f-4eaf2cbebd13", "Viewer", "VIEWER" });
        }
    }
}
