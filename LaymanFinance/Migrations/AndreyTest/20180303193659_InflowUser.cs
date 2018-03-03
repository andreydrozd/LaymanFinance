using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class InflowUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inflow_AspNetUsers_ApplicationUserId",
                table: "Inflow");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Inflow",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Inflow_ApplicationUserId",
                table: "Inflow",
                newName: "IX_Inflow_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Memo",
                table: "Inflow",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inflow_User",
                table: "Inflow",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inflow_User",
                table: "Inflow");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Inflow",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Inflow_UserId",
                table: "Inflow",
                newName: "IX_Inflow_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Memo",
                table: "Inflow",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160);

            migrationBuilder.AddForeignKey(
                name: "FK_Inflow_AspNetUsers_ApplicationUserId",
                table: "Inflow",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
