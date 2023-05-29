using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimitedTo",
                table: "JobPosts");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "LimitedTo",
                table: "JobPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
