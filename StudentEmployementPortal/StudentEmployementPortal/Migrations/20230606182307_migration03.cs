using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Faculties_FacultyId",
                table: "JobPosts",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
