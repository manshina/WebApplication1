using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImgSource = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    BasePrice = table.Column<int>(type: "INTEGER", nullable: false),
                    Tomato = table.Column<bool>(type: "INTEGER", nullable: false),
                    Cheese = table.Column<bool>(type: "INTEGER", nullable: false),
                    Pepper = table.Column<bool>(type: "INTEGER", nullable: false),
                    Mushroom = table.Column<bool>(type: "INTEGER", nullable: false),
                    Salat = table.Column<bool>(type: "INTEGER", nullable: false),
                    FinalPrice = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pizzas");
        }
    }
}
