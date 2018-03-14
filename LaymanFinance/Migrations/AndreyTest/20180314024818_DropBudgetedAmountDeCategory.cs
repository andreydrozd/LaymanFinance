using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class DropBudgetedAmountDeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetedAmount",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BudgetedAmount",
                table: "Category",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
