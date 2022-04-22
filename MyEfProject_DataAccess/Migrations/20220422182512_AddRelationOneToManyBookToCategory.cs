using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddRelationOneToManyBookToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_books_Category_Id",
                table: "books",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_Categories_Category_Id",
                table: "books",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Categories_Category_Id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Category_Id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "books");
        }
    }
}
