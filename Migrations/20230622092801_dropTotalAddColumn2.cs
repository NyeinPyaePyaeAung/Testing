using Microsoft.EntityFrameworkCore.Migrations;

namespace vindly.Migrations
{
    public partial class dropTotalAddColumn2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Add",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Add",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
