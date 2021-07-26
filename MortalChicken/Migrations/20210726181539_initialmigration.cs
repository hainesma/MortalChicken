using Microsoft.EntityFrameworkCore.Migrations;

namespace MortalChicken.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seeds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chickens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Smarts = table.Column<double>(type: "float", nullable: false),
                    Strength = table.Column<double>(type: "float", nullable: false),
                    Speed = table.Column<double>(type: "float", nullable: false),
                    Luck = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FarmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chickens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chickens_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chickens_FarmId",
                table: "Chickens",
                column: "FarmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chickens");

            migrationBuilder.DropTable(
                name: "Farms");
        }
    }
}
