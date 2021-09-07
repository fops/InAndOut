using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class personuri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yritused_Persons_PersonId",
                table: "Yritused");

            migrationBuilder.DropIndex(
                name: "IX_Yritused_PersonId",
                table: "Yritused");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Yritused");

            migrationBuilder.AddColumn<int>(
                name: "UrituseIdId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UrituseIdId",
                table: "Persons",
                column: "UrituseIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Yritused_UrituseIdId",
                table: "Persons",
                column: "UrituseIdId",
                principalTable: "Yritused",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Yritused_UrituseIdId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_UrituseIdId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UrituseIdId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Yritused",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yritused_PersonId",
                table: "Yritused",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yritused_Persons_PersonId",
                table: "Yritused",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
