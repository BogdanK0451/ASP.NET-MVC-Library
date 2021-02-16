using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AdjustedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnBy",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "TakenOn",
                table: "BorrowedBooks");

            migrationBuilder.RenameColumn(
                name: "ReservationApproved",
                table: "Orders",
                newName: "ReturnBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnBy",
                table: "Orders",
                newName: "ReservationApproved");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnBy",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TakenOn",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
