using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class initialww3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viewers",
                columns: table => new
                {
                    ViewerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ViewerAddress = table.Column<string>(nullable: true),
                    ViewerCity = table.Column<string>(nullable: true),
                    ViewerState = table.Column<string>(nullable: true),
                    ViewerZip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewers", x => x.ViewerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viewers");
        }
    }
}
