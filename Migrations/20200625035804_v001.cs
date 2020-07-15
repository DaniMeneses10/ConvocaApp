using Microsoft.EntityFrameworkCore.Migrations;

namespace ConvocaApp.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    cellphone = table.Column<int>(nullable: false),
                    country = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
