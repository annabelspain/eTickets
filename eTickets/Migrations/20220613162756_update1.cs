﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePicture");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePicture");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
