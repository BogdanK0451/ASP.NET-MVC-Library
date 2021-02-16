using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AdjustedFields2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationID",
                table: "Orders");
        }
    }
}
