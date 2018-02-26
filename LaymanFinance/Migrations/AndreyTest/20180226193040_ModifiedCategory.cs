using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class ModifiedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityAmount",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "AvailableAmount",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ActivityAmount",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AvailableAmount",
                table: "Category",
                nullable: true);
        }
    }
}
