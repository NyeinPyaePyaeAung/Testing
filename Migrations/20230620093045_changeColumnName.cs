using Microsoft.EntityFrameworkCore.Migrations;

namespace vindly.Migrations
{
    public partial class changeColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Category",
                newName: "Id"); 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "MyProperty");
        }
    }
}
