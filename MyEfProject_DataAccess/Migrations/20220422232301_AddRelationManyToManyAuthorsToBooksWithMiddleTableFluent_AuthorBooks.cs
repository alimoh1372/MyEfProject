using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddRelationManyToManyAuthorsToBooksWithMiddleTableFluent_AuthorBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_AuthorBooks",
                columns: table => new
                {
                    FkBook_Id = table.Column<int>(type: "int", nullable: false),
                    FkAuthor_Id = table.Column<int>(type: "int", nullable: false),
                    Book_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_AuthorBooks", x => new { x.FkAuthor_Id, x.FkBook_Id });
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorBooks_books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorBooks_Fluent_Books_FkBook_Id",
                        column: x => x.FkBook_Id,
                        principalTable: "Fluent_Books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fluent_AuthorBooks_FluentAutorTable_FkAuthor_Id",
                        column: x => x.FkAuthor_Id,
                        principalTable: "FluentAutorTable",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorBooks_Book_Id",
                table: "Fluent_AuthorBooks",
                column: "Book_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_AuthorBooks_FkBook_Id",
                table: "Fluent_AuthorBooks",
                column: "FkBook_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_AuthorBooks");
        }
    }
}
