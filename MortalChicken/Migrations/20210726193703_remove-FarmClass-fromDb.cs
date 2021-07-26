using Microsoft.EntityFrameworkCore.Migrations;

namespace MortalChicken.Migrations
{
    public partial class removeFarmClassfromDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chickens_Farms_FarmId",
                table: "Chickens");

            migrationBuilder.AlterColumn<int>(
                name: "FarmId",
                table: "Chickens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chickens_Farms_FarmId",
                table: "Chickens",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chickens_Farms_FarmId",
                table: "Chickens");

            migrationBuilder.AlterColumn<int>(
                name: "FarmId",
                table: "Chickens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Chickens_Farms_FarmId",
                table: "Chickens",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
