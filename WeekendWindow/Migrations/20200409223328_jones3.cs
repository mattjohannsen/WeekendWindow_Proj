using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Migrations
{
    public partial class jones3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c7ba52f-55e3-4b9d-94a6-51414074cc3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2f4b1ae-b38a-485d-885e-8c8de532af1f");

            migrationBuilder.CreateTable(
                name: "WWindow",
                columns: table => new
                {
                    WWindowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WWViewerId = table.Column<int>(nullable: false),
                    WeekendLocationId = table.Column<int>(nullable: false),
                    SaturdayDate = table.Column<DateTime>(nullable: true),
                    SundayDate = table.Column<DateTime>(nullable: true),
                    SaturdayWeatherId = table.Column<int>(nullable: false),
                    SundayWeatherId = table.Column<int>(nullable: false),
                    WeekendAttitudeId = table.Column<int>(nullable: false),
                    WantLodging = table.Column<bool>(nullable: false),
                    WeekendLodgingId = table.Column<int>(nullable: false),
                    TravelRadiusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WWindow", x => x.WWindowId);
                    table.ForeignKey(
                        name: "FK_WWindow_Viewers_WWViewerId",
                        column: x => x.WWViewerId,
                        principalTable: "Viewers",
                        principalColumn: "ViewerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WWindow_ViewerLocation_WeekendLocationId",
                        column: x => x.WeekendLocationId,
                        principalTable: "ViewerLocation",
                        principalColumn: "ViewerLocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "685edd05-3817-40e5-81d8-2f7805fb0761", "d9af8a67-dc4d-430e-94ca-3c9e83b31a8a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a872ffc7-7dac-4bff-98d1-c56f808b84e1", "b666976b-1bfe-46e0-81ac-5958f30b2e31", "Viewer", "VIEWER" });

            migrationBuilder.CreateIndex(
                name: "IX_WWindow_WWViewerId",
                table: "WWindow",
                column: "WWViewerId");

            migrationBuilder.CreateIndex(
                name: "IX_WWindow_WeekendLocationId",
                table: "WWindow",
                column: "WeekendLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WWindow");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "685edd05-3817-40e5-81d8-2f7805fb0761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a872ffc7-7dac-4bff-98d1-c56f808b84e1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2f4b1ae-b38a-485d-885e-8c8de532af1f", "c2fd9788-f95f-4fca-84c8-3b2b33546b73", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c7ba52f-55e3-4b9d-94a6-51414074cc3d", "f1aad935-348e-497e-971c-787852e7e80f", "Viewer", "VIEWER" });
        }
    }
}
