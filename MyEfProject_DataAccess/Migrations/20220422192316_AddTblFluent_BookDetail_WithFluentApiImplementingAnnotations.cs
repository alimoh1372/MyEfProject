﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddTblFluent_BookDetail_WithFluentApiImplementingAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_BookDetails",
                columns: table => new
                {
                    BookDetail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfChapters = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Book_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookDetails", x => x.BookDetail_Id);
                    table.ForeignKey(
                        name: "FK_Fluent_BookDetails_books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_BookDetails");
        }
    }
}
