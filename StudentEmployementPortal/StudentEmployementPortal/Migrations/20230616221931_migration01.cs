using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Application");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationStatus",
                table: "Application",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationStatus",
                table: "Application");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
