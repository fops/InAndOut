using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class persons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Maksmine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lisainfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrituseIdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Yritused_UrituseIdId",
                        column: x => x.UrituseIdId,
                        principalTable: "Yritused",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UrituseIdId",
                table: "Persons",
                column: "UrituseIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
