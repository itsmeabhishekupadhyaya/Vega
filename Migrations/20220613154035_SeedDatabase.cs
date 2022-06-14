using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE1')");
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE2')");
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE3')");

            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL1_MAKE1',(SELECT ID FROM Makes WHERE NAME = 'MAKE1'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL2_MAKE1',(SELECT ID FROM Makes WHERE NAME = 'MAKE1'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL3_MAKE1',(SELECT ID FROM Makes WHERE NAME = 'MAKE1'))");

            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL1_MAKE2',(SELECT ID FROM Makes WHERE NAME = 'MAKE2'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL2_MAKE2',(SELECT ID FROM Makes WHERE NAME = 'MAKE2'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL3_MAKE2',(SELECT ID FROM Makes WHERE NAME = 'MAKE2'))");

            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL1_MAKE3',(SELECT ID FROM Makes WHERE NAME = 'MAKE3'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL2_MAKE3',(SELECT ID FROM Makes WHERE NAME = 'MAKE3'))");
            migrationBuilder.Sql( "INSERT INTO Models VALUES('MODEL3_MAKE3',(SELECT ID FROM Makes WHERE NAME = 'MAKE3'))");
      
         }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MAKES");

        }
    }
}
