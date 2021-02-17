using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddedFields2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "BorrowedBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "BorrowedBooks");
        }
    }
}
