using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class OutlayUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutlayEntry");

            migrationBuilder.DropColumn(
                name: "FavoriteColor",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Outlay",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Inflow",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Outlay_UserId",
                table: "Outlay",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Inflow_ApplicationUserId",
                table: "Inflow",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inflow_AspNetUsers_ApplicationUserId",
                table: "Inflow",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Outlay_User",
                table: "Outlay",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inflow_AspNetUsers_ApplicationUserId",
                table: "Inflow");

            migrationBuilder.DropForeignKey(
                name: "FK_Outlay_User",
                table: "Outlay");

            migrationBuilder.DropIndex(
                name: "IX_Outlay_UserId",
                table: "Outlay");

            migrationBuilder.DropIndex(
                name: "IX_Inflow_ApplicationUserId",
                table: "Inflow");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Outlay");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Inflow");

            migrationBuilder.AddColumn<string>(
                name: "FavoriteColor",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OutlayEntry",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: true),
                    OutlayId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutlayEntry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OutlayEntry_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutlayEntry_Outlay_OutlayId",
                        column: x => x.OutlayId,
                        principalTable: "Outlay",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutlayEntry_CategoryId",
                table: "OutlayEntry",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OutlayEntry_OutlayId",
                table: "OutlayEntry",
                column: "OutlayId");
        }
    }
}
