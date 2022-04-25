using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class RalationChangeFluentBook_Fluent_BookDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetails_FluentBookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherFkId",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Fluent_PublisherFkId",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_FluentBookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.RenameColumn(
                name: "FluentBookDetail_Id",
                table: "Fluent_Books",
                newName: "FkFluentBookDetail_Id");

            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FkFluentBookDetail_Id",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_FkFluentBookDetail_Id",
                table: "Fluent_BookDetails",
                column: "FkFluentBookDetail_Id",
                unique: true,
                filter: "[FkFluentBookDetail_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Books_FkFluentBookDetail_Id",
                table: "Fluent_BookDetails",
                column: "FkFluentBookDetail_Id",
                principalTable: "Fluent_Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books",
                column: "Fluent_PublisherPublisher_Id",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Books_FkFluentBookDetail_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_FkFluentBookDetail_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "FkFluentBookDetail_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.RenameColumn(
                name: "FkFluentBookDetail_Id",
                table: "Fluent_Books",
                newName: "FluentBookDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Fluent_PublisherFkId",
                table: "Fluent_Books",
                column: "Fluent_PublisherFkId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherFkId",
                table: "Fluent_Books",
                column: "Fluent_PublisherFkId",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
