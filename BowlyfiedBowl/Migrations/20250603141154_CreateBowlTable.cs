using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BowlyfiedBowl.Migrations
{
    /// <inheritdoc />
    public partial class CreateBowlTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorOptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MicrowaveSafe = table.Column<bool>(type: "bit", nullable: false),
                    DishwasherSafe = table.Column<bool>(type: "bit", nullable: false),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowls");
        }
    }
}
