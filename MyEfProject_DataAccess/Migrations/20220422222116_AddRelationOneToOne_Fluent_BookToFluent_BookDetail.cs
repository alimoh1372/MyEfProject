using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddRelationOneToOne_Fluent_BookToFluent_BookDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Fluent_Categories_Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_books_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_BookDetails_BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Categories_CategoryId",
                table: "Fluent_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Publishers_Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_CategoryId",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_books_Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Fluent_PublisherPublisher_Id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "Fluent_CategoryId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "books");

            migrationBuilder.AddColumn<int>(
                name: "FluentBookDetail_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_FluentBookDetail_Id",
                table: "Fluent_Books",
                column: "FluentBookDetail_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetails_FluentBookDetail_Id",
                table: "Fluent_Books",
                column: "FluentBookDetail_Id",
                principalTable: "Fluent_BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetails_FluentBookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_FluentBookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "FluentBookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id");

            migrationBuilder.CreateIndex(
                name: "IX_books_Fluent_CategoryId",
                table: "books",
                column: "Fluent_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_books_Fluent_PublisherPublisher_Id",
                table: "books",
                column: "Fluent_PublisherPublisher_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_books_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                principalTable: "books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_BookDetails_BookDetail_Id",
                table: "Fluent_Books",
                column: "BookDetail_Id",
                principalTable: "BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Categories_CategoryId",
                table: "Fluent_Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Publishers_Publisher_Id",
                table: "Fluent_Books",
                column: "Publisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
