using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RESTExercises.Migrations
{
    public partial class AddingColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "LogEntries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "LogEntries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endpoint",
                table: "LogEntries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "Endpoint",
                table: "LogEntries");
        }
    }
}
