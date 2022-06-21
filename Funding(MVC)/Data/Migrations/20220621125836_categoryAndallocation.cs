using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Funding_MVC_.Data.Migrations
{
    public partial class categoryAndallocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultAmount = table.Column<int>(type: "int", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundAmount = table.Column<int>(type: "int", nullable: false),
                    FundCategoryId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundAllocations_FundCategories_FundCategoryId",
                        column: x => x.FundCategoryId,
                        principalTable: "FundCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FundAllocations_FundCategoryId",
                table: "FundAllocations",
                column: "FundCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FundAllocations");

            migrationBuilder.DropTable(
                name: "FundCategories");
        }
    }
}
