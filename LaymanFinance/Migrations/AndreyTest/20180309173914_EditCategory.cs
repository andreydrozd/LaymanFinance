using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class EditCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDiscretionary",
                table: "Category",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDiscretionary",
                table: "Category",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
