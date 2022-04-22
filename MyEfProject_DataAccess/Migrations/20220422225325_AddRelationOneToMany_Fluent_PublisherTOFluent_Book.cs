using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class AddRelationOneToMany_Fluent_PublisherTOFluent_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherFkId",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Fluent_PublisherFkId",
                table: "Fluent_Books",
                column: "Fluent_PublisherFkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherFkId",
                table: "Fluent_Books",
                column: "Fluent_PublisherFkId",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_Publishers_Fluent_PublisherFkId",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Fluent_PublisherFkId",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherFkId",
                table: "Fluent_Books");
        }
    }
}
