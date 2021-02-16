using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AdjustedFieldNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Taken",
                table: "BorrowedBooks",
                newName: "TakenOn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TakenOn",
                table: "BorrowedBooks",
                newName: "Taken");
        }
    }
}
