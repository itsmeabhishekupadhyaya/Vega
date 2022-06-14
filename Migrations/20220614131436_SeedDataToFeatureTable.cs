using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDataToFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Features values ('Feature1')");
            migrationBuilder.Sql("Insert into Features values ('Feature2')");
            migrationBuilder.Sql("Insert into Features values ('Feature3')");
            migrationBuilder.Sql("Insert into Features values ('Feature4')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Features where Name in('Feature1','Feature2','Feature3','Feature4')");
        }
    }
}
