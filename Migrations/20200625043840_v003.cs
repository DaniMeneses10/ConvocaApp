using Microsoft.EntityFrameworkCore.Migrations;

namespace ConvocaApp.Migrations
{
    public partial class v003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    reserve = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    hour = table.Column<int>(nullable: false),
                    cost = table.Column<int>(nullable: false),
                    paymment = table.Column<string>(nullable: true),
                    place_id = table.Column<int>(nullable: false),
                    sport_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
