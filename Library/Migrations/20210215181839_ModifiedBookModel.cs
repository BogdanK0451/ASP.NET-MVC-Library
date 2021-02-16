using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class ModifiedBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimesBorrowed",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimesBorrowed",
                table: "Books");
        }
    }
}
