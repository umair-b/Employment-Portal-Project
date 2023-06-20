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
            migrationBuilder.AddColumn<string>(
                name: "FileDescription",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Application_PostId",
                table: "Application",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_JobPosts_PostId",
                table: "Application",
                column: "PostId",
                principalTable: "JobPosts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_JobPosts_PostId",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_PostId",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "FileDescription",
                table: "Documents");
        }
    }
}
