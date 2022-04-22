using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddNewFluentModelsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fluent_CategoryId",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fluent_Books",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    BookDetail_Id = table.Column<int>(type: "int", nullable: true),
                    Publisher_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Books", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_Fluent_Books_BookDetails_BookDetail_Id",
                        column: x => x.BookDetail_Id,
                        principalTable: "BookDetails",
                        principalColumn: "BookDetail_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fluent_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fluent_Books_Publishers_Publisher_Id",
                        column: x => x.Publisher_Id,
                        principalTable: "Publishers",
                        principalColumn: "Publisher_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_Publishers",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Publishers", x => x.Publisher_Id);
                });

            migrationBuilder.CreateTable(
                name: "FluentAutorTable",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAutorTable", x => x.Author_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_Fluent_CategoryId",
                table: "books",
                column: "Fluent_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_books_Fluent_PublisherPublisher_Id",
                table: "books",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_BookDetail_Id",
                table: "Fluent_Books",
                column: "BookDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_CategoryId",
                table: "Fluent_Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Publisher_Id",
                table: "Fluent_Books",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_Fluent_Categories_Fluent_CategoryId",
                table: "books",
                column: "Fluent_CategoryId",
                principalTable: "Fluent_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "books",
                column: "Fluent_PublisherPublisher_Id",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Fluent_Categories_Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "books");

            migrationBuilder.DropTable(
                name: "Fluent_Books");

            migrationBuilder.DropTable(
                name: "Fluent_Categories");

            migrationBuilder.DropTable(
                name: "Fluent_Publishers");

            migrationBuilder.DropTable(
                name: "FluentAutorTable");

            migrationBuilder.DropIndex(
                name: "IX_books_Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Fluent_PublisherPublisher_Id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "books");
        }
    }
}
