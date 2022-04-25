using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEfProject_DataAccess.Migrations
{
    public partial class somethingAddingToCategoryTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories values('Category 1');");
            migrationBuilder.Sql("Insert into Categories values('Category 2');");
            migrationBuilder.Sql("Insert into Categories values('Category 3');");
            migrationBuilder.Sql("Insert into Categories values('Category 4');");
            migrationBuilder.Sql("Insert into Categories values('Category 5');");
            migrationBuilder.Sql("Insert into Categories values('Category 6');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
