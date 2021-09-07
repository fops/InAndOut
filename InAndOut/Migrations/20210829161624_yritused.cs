using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class yritused : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "ExpenseName",
                table: "Expense",
                newName: "YritusName");

            migrationBuilder.AddColumn<DateTime>(
                name: "Aeg",
                table: "Expense",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Expense",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aeg",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "YritusName",
                table: "Expense",
                newName: "ExpenseName");

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "Expense",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });
        }
    }
}
