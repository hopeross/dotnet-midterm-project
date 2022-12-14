using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetName = table.Column<string>(type: "TEXT", nullable: false),
                    PetURL = table.Column<string>(type: "TEXT", nullable: false),
                    PetDescription = table.Column<string>(type: "TEXT", nullable: false),
                    PetColor = table.Column<string>(type: "TEXT", nullable: false),
                    PetAge = table.Column<int>(type: "INTEGER", nullable: false),
                    PetBreed = table.Column<string>(type: "TEXT", nullable: false),
                    PetSize = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
