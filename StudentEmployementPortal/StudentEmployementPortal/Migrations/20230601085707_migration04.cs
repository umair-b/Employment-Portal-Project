using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migration04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "LimitedTo",
                table: "JobPosts");

            migrationBuilder.AlterColumn<int>(
                name: "PostStatus",
                table: "JobPosts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "JobPosts",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingDate",
                table: "JobPosts",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ApproverNote",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddColumn<bool>(
                name: "limitedToDepartment",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToFaculty",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToFirst",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToHonours",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToMasters",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToPhD",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToPostDoc",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToSecond",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "limitedToThird",
                table: "JobPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "FacultyId" },
                values: new object[,]
                {
                    { 1, "Accountancy", 1 },
                    { 2, "Business Sciences", 1 },
                    { 3, "Economics and Finance", 1 },
                    { 4, "Law", 1 },
                    { 5, "Wits Business School", 1 },
                    { 6, "Wits School of Governance", 1 },
                    { 7, "Architecture and Planning", 2 },
                    { 8, "Civil & Environmental Engineering", 2 },
                    { 9, "Chemical & Metallurgical Engineering", 2 },
                    { 10, "Construction Economics & Management", 2 },
                    { 11, "Electrical & Information Engineeringg", 2 },
                    { 12, "Mechanical, Industrial & Aeronautical Engineering", 2 },
                    { 13, "Mining Engineering", 2 },
                    { 14, "Anatomical Sciences", 3 },
                    { 15, "Clinical Medicine", 3 },
                    { 16, "Oral Health Sciences", 3 },
                    { 17, "Pathology", 3 },
                    { 18, "Physiology", 3 },
                    { 19, "Public Health", 3 },
                    { 20, "Therapeutic Sciences", 3 },
                    { 21, "Wits School of Arts", 4 },
                    { 22, "Wits School of Education", 4 },
                    { 23, "Human and Community Development", 4 },
                    { 24, "Literature, Language and Media", 4 },
                    { 25, "Social Sciences", 4 },
                    { 26, "Animal, Plant and Environmental Sciences", 5 },
                    { 27, "Chemistry", 5 },
                    { 28, "Computer Science and Applied Mathematics", 5 },
                    { 29, "Geography, Archaeology and Environmental Sciences", 5 },
                    { 30, "Geosciences", 5 },
                    { 31, "Mathematics", 5 },
                    { 32, "Molecular and Cell Biology", 5 },
                    { 33, "Physics", 5 },
                    { 34, "Statistics and Actuarial Science", 5 }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "FacultyName" },
                values: new object[,]
                {
                    { 1, "Faculty of Commerce, Law and Management" },
                    { 2, "Faculty of Engineering and the Built Environment" },
                    { 3, "Faculty of Health Sciences" },
                    { 4, "Faculty of Humanities" },
                    { 5, "Faculty of Science" }
                });

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

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");

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

            migrationBuilder.DropColumn(
                name: "limitedToDepartment",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToFaculty",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToFirst",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToHonours",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToMasters",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToPhD",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToPostDoc",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToSecond",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "limitedToThird",
                table: "JobPosts");

            migrationBuilder.AlterColumn<string>(
                name: "PostStatus",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "JobPosts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClosingDate",
                table: "JobPosts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "ApproverNote",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LimitedTo",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
