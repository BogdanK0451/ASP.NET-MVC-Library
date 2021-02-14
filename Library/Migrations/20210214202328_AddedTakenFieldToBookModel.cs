﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddedTakenFieldToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Taken",
                table: "Book",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Taken",
                table: "Book");
        }
    }
}
