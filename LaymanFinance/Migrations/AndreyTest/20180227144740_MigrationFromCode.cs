using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class MigrationFromCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescriptionTwo",
                table: "Service",
                maxLength: 280,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionThree",
                table: "Service",
                maxLength: 280,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionOne",
                table: "Service",
                maxLength: 280,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 160);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionFour",
                table: "Service",
                maxLength: 280,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Order_PromoId",
                table: "Order",
                column: "PromoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Promo_PromoId",
                table: "Order",
                column: "PromoId",
                principalTable: "Promo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Promo_PromoId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_PromoId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DescriptionFour",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "PromoId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionTwo",
                table: "Service",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 280,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionThree",
                table: "Service",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 280,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionOne",
                table: "Service",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 280);
        }
    }
}
