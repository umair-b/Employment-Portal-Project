using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migrationTest01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Departments_DepartmentId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Faculties_FacultyId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_DepartmentId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_FacultyId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "JobPosts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "JobPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "JobPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_DepartmentId",
                table: "JobPosts",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_FacultyId",
                table: "JobPosts",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Departments_DepartmentId",
                table: "JobPosts",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Faculties_FacultyId",
                table: "JobPosts",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
