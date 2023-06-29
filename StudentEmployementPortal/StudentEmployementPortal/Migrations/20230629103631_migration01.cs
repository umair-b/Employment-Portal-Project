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
            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Students_StudentUserId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_StudentUserId",
                table: "Referees");

            migrationBuilder.DropColumn(
                name: "StudentUserId",
                table: "Referees");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_UserId",
                table: "Referees",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Students_UserId",
                table: "Referees",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Students_UserId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_UserId",
                table: "Referees");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Referees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StudentUserId",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_StudentUserId",
                table: "Referees",
                column: "StudentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Students_StudentUserId",
                table: "Referees",
                column: "StudentUserId",
                principalTable: "Students",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
