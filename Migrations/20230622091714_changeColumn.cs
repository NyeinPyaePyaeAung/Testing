using Microsoft.EntityFrameworkCore.Migrations;

namespace vindly.Migrations
{
    public partial class changeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Category",
                newName: "Total");

            migrationBuilder.AddColumn<string>(
                name: "Add",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OT",
                table: "Category",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PM",
                table: "Category",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RD",
                table: "Category",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UT",
                table: "Category",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PM = table.Column<double>(type: "float", nullable: false),
                    RD = table.Column<double>(type: "float", nullable: false),
                    UT = table.Column<double>(type: "float", nullable: false),
                    OT = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Add = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropColumn(
                name: "Add",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "OT",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "PM",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "RD",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UT",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Category",
                newName: "DisplayOrder");
        }
    }
}
