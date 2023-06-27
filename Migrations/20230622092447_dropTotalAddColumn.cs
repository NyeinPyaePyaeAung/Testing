using Microsoft.EntityFrameworkCore.Migrations;

namespace vindly.Migrations
{
    public partial class dropTotalAddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Add",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Add",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
