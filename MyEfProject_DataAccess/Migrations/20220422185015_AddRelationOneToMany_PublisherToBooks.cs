using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddRelationOneToMany_PublisherToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_books_Publisher_Id",
                table: "books",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_Publishers_Publisher_Id",
                table: "books",
                column: "Publisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Publishers_Publisher_Id",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_Publisher_Id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "books");
        }
    }
}
