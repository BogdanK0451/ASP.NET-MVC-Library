using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class RenamedFIelds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Reservations",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Orders",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "BorrowedBooks",
                newName: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Reservations",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Orders",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "BorrowedBooks",
                newName: "CustomerID");
        }
    }
}
