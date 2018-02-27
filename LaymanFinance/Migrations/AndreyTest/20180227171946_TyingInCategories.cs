using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaymanFinance.Migrations.AndreyTest
{
    public partial class TyingInCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutlayEntry");
        }
    }
}
