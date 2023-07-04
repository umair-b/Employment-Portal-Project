using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEmployementPortal.Migrations
{
    /// <inheritdoc />
    public partial class migration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Students_UserId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Referees_UserId",
                table: "Referees");

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "JobPosts",
                keyColumn: "PostId",
                keyValue: 100);

            migrationBuilder.RenameColumn(
                name: "EmployerTitle",
                table: "Employers",
                newName: "TitleId");

            migrationBuilder.RenameColumn(
                name: "EmployerBusinessType",
                table: "Employers",
                newName: "BusinessTypeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BusinessTypes",
                newName: "BusinessName");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Referees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "CellNumber",
                table: "Referees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "StudentUserId",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Majors",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "TitleId", "TitleName" },
                values: new object[,]
                {
                    { 1, "Mr" },
                    { 2, "Mrs" },
                    { 3, "Miss" },
                    { 4, "Dr" },
                    { 5, "Prof" },
                    { 6, "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referees_StudentUserId",
                table: "Referees",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_BusinessTypeId",
                table: "Employers",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_TitleId",
                table: "Employers",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_BusinessTypes_BusinessTypeId",
                table: "Employers",
                column: "BusinessTypeId",
                principalTable: "BusinessTypes",
                principalColumn: "BusinessTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Titles_TitleId",
                table: "Employers",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referees_Students_StudentUserId",
                table: "Referees",
                column: "StudentUserId",
                principalTable: "Students",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_BusinessTypes_BusinessTypeId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Titles_TitleId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Referees_Students_StudentUserId",
                table: "Referees");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Referees_StudentUserId",
                table: "Referees");

            migrationBuilder.DropIndex(
                name: "IX_Employers_BusinessTypeId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_TitleId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "StudentUserId",
                table: "Referees");

            migrationBuilder.RenameColumn(
                name: "TitleId",
                table: "Employers",
                newName: "EmployerTitle");

            migrationBuilder.RenameColumn(
                name: "BusinessTypeId",
                table: "Employers",
                newName: "EmployerBusinessType");

            migrationBuilder.RenameColumn(
                name: "BusinessName",
                table: "BusinessTypes",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Referees",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CellNumber",
                table: "Referees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Majors",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "JobPosts",
                columns: new[] { "PostId", "ApplicationInstructions", "ApproverNote", "CitizensOnly", "ClosingDate", "ContactEmail", "ContactNumber", "ContactPerson", "DepartmentId", "EmployerId", "EndDate", "FacultyId", "FullTime", "HourlyRate", "Internal", "JobDescription", "JobLocation", "JobTitle", "KeyResponsibilities", "MinRequirements", "PartTimeHours", "PostStatus", "StartDate", "limitedToFirst", "limitedToHonours", "limitedToMasters", "limitedToPhD", "limitedToPostDoc", "limitedToSecond", "limitedToThird" },
                values: new object[,]
                {
                    { 51, "Amet dolor voluptatibus voluptas sint exercitationem totam eius voluptatem sequi. Repellat et porro cum expedita voluptatem a ipsam placeat. Sit voluptatum natus porro voluptatem facilis nostrum provident eos earum. Sit quidem accusamus tempora nisi tenetur nesciunt vero. Ipsa voluptas voluptatem est commodi rem quia molestiae doloremque porro.", null, false, new DateTime(2024, 1, 6, 21, 46, 14, 892, DateTimeKind.Local).AddTicks(8931), "Darrell52@gmail.com", "(876) 984-4397", "Darrell Schiller", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 5, 27, 23, 56, 34, 755, DateTimeKind.Local).AddTicks(9321), 1, true, 1.0, false, "Autem voluptatibus ipsum nihil. Laborum voluptas et quia nobis ea. Sequi libero voluptatibus pariatur. Enim nemo quibusdam praesentium eos et. Qui repellendus aliquid cum quia. Quas qui repellat rem ut.", "et", "Nisi reprehenderit quia impedit ea ea consequatur dolorum optio corrupti.\nVoluptatum porro voluptate ratione id non.\nSint aliquam quidem.\nSunt voluptas consequatur dolor quaerat.", "Magni sit voluptatem non reprehenderit delectus voluptate aliquam. Molestias saepe facilis neque. Consectetur pariatur saepe temporibus minus at id est.", "Ut veniam dicta corporis debitis ut dolor aspernatur deserunt. Similique sequi quia perspiciatis voluptas dignissimos quod atque omnis laborum. Est rem animi. Deleniti sint reprehenderit cupiditate commodi rerum occaecati quibusdam consequatur nam. Aut aut autem.", null, 2, new DateTime(2024, 6, 24, 21, 7, 57, 831, DateTimeKind.Local).AddTicks(333), false, false, false, false, false, false, false },
                    { 52, "Aut natus aut sed odio velit vero. Voluptatibus nemo ex atque nisi. Molestiae dolorem itaque consequuntur quaerat id perferendis minus accusantium totam. Iure odit est quas. Unde iure incidunt sunt ut id nihil neque ut.", null, false, new DateTime(2023, 10, 21, 5, 47, 37, 361, DateTimeKind.Local).AddTicks(9999), "Tim_Stark@yahoo.com", "892-555-9125 x2654", "Tim Stark", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 8, 24, 21, 50, 42, 9, DateTimeKind.Local).AddTicks(501), 1, true, 1.0, false, "Debitis voluptas sint est amet modi officia ipsam. Ut sit ipsa ut molestias quis provident. Nisi ab nemo dolorem quo non possimus. Aliquam aliquam aut consectetur maxime omnis qui in ab eos. Odit omnis consequatur dolorem sint quis earum incidunt non ut. Qui provident sed repudiandae qui.", "quos", "Harum nesciunt quisquam.\nDelectus et consequuntur illum voluptas et rerum pariatur consequatur deleniti.\nQui suscipit aut autem autem saepe.\nIncidunt dolorum molestiae tempore odio maiores eum tenetur explicabo pariatur.", "Quaerat rerum inventore. Sed eveniet dolore. Totam explicabo nihil. Numquam illo omnis amet atque est. Est ratione est non aut aut exercitationem dolor eos.", "Laboriosam temporibus voluptatem enim modi deleniti libero ut soluta. Unde est excepturi dolores repudiandae ducimus blanditiis iure non rerum. Corrupti sunt aut hic est sit. Inventore et quisquam odit dolores expedita possimus sint nesciunt rerum. Exercitationem sint eius molestiae eos dolor autem eos quibusdam. Error quo temporibus molestiae.", null, 2, new DateTime(2023, 12, 24, 15, 48, 38, 67, DateTimeKind.Local).AddTicks(1648), false, false, false, false, false, false, false },
                    { 53, "Suscipit vitae voluptatem labore velit ut saepe fugiat consectetur aut. Eius maxime optio ipsum natus incidunt et. Voluptas officiis beatae deserunt vero corporis dignissimos odio. Rerum maxime rerum velit quidem et. Molestiae ut pariatur debitis molestiae doloribus repudiandae tenetur iusto consequatur.", null, false, new DateTime(2024, 4, 13, 8, 28, 58, 319, DateTimeKind.Local).AddTicks(1780), "Cedric_Mraz67@yahoo.com", "1-881-954-5079", "Cedric Mraz", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 12, 22, 6, 47, 24, 763, DateTimeKind.Local).AddTicks(7734), 1, false, 1.0, false, "Unde sunt nostrum corporis at doloremque debitis sit quaerat quos. Recusandae delectus aut quam hic dignissimos. Ipsum culpa ipsam et et distinctio eum quod qui. A consequuntur sequi quos consequatur corrupti necessitatibus eum deserunt.", "dignissimos", "vel", "Quidem iusto odio repudiandae voluptates dolorem. Delectus molestias culpa velit repudiandae facilis placeat. Harum et aut non aut veritatis dolores laboriosam ut. Deleniti non aperiam. Alias voluptas temporibus qui ut. Aut eius totam fugiat.", "Doloribus et sunt exercitationem. Voluptas eos provident sapiente occaecati voluptatibus dolorem expedita ut quas. Totam temporibus molestiae. Provident laborum molestias illum voluptate explicabo quod. Quae velit qui ad numquam eveniet architecto. Voluptas cum tempora quidem quasi quas qui.", null, 2, new DateTime(2024, 1, 15, 2, 20, 44, 579, DateTimeKind.Local).AddTicks(2170), false, false, false, false, false, false, false },
                    { 54, "Repudiandae et voluptatem rerum nostrum quo quia sed culpa. Quia consequatur eos magnam accusantium aut consequatur. Delectus sed non voluptates magnam sapiente impedit.", null, false, new DateTime(2024, 3, 21, 21, 14, 33, 303, DateTimeKind.Local).AddTicks(2426), "Joy_Mraz30@gmail.com", "1-585-425-8243 x594", "Joy Mraz", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 8, 1, 19, 1, 38, 764, DateTimeKind.Local).AddTicks(1955), 1, false, 1.0, false, "Asperiores qui sed voluptas nostrum. Omnis fuga necessitatibus accusamus sapiente quia ut perspiciatis. Optio aspernatur ab rerum aut consequatur vel et autem. Facere voluptatibus nisi consequatur vel amet. Et officia magni hic.", "quae", "Quia officia et.", "Voluptate quos qui in. Non voluptatem repudiandae omnis nobis aut dolor tenetur. Vero sed cumque quia et molestias nobis repellendus.", "Velit repudiandae et nulla perferendis fuga iure id. Corrupti iure aut accusantium voluptate nobis autem tempora. Esse earum nihil hic repellat. Reprehenderit et fuga vel aut.", null, 2, new DateTime(2023, 8, 30, 22, 57, 14, 105, DateTimeKind.Local).AddTicks(3138), false, false, false, false, false, false, false },
                    { 55, "Odio deserunt repudiandae error quae qui. Commodi eaque sunt ut eum perferendis eum. Rerum non tempore sequi perspiciatis optio. Sint occaecati consequatur perspiciatis aut accusantium et doloribus ratione ea.", null, false, new DateTime(2023, 10, 16, 5, 36, 1, 757, DateTimeKind.Local).AddTicks(369), "Elijah_Predovic85@hotmail.com", "(304) 254-1428 x556", "Elijah Predovic", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 8, 21, 1, 43, 16, 210, DateTimeKind.Local).AddTicks(4101), 1, true, 1.0, true, "Explicabo ex deserunt nihil veniam enim mollitia maiores aut nesciunt. Facere est dignissimos aut et vero laudantium. Officiis omnis praesentium architecto.", "qui", "Natus exercitationem ab rerum perspiciatis labore. Nostrum quae ex. Iure rerum rerum. Ut ea ut illo vero nam modi neque. Nobis modi enim modi.", "Velit libero omnis autem aperiam. A numquam alias sint distinctio voluptatem possimus omnis. Architecto magnam non ab corrupti quo nihil cumque est. Laboriosam dolores repudiandae voluptatem quia delectus aut distinctio voluptas. Et laborum sunt voluptates.", "Ratione ut ut. Sint laudantium est vel. Aut nisi quia ratione similique omnis ut.", null, 2, new DateTime(2023, 11, 20, 0, 36, 19, 142, DateTimeKind.Local).AddTicks(2346), false, false, false, false, false, false, false },
                    { 56, "Quae aut iste molestias quis dolorem dolorem aut ad ea. Voluptatum quas provident exercitationem deleniti. Adipisci illo et et molestiae reprehenderit iusto praesentium eveniet. Et fugit ipsa tempore adipisci sed dolorem assumenda occaecati deserunt. Et nesciunt facilis similique. Esse porro doloremque autem quibusdam harum.", null, false, new DateTime(2023, 7, 9, 18, 31, 34, 648, DateTimeKind.Local).AddTicks(9790), "Alexander_West72@gmail.com", "1-205-779-2415", "Alexander West", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 4, 19, 22, 53, 14, 503, DateTimeKind.Local).AddTicks(5996), 1, true, 1.0, true, "Id sapiente quia dolor. Velit quia quae voluptatum non aut asperiores. Qui sed ad laboriosam. Omnis necessitatibus cum error eveniet consequatur incidunt sit aut. Molestiae aut nesciunt iusto consequatur et quasi incidunt.", "asperiores", "Rem sed sequi. Perspiciatis sunt quia est animi possimus blanditiis doloremque at vero. Ipsa et sed rerum animi odio.", "Autem ab libero et voluptas distinctio necessitatibus. Ut dolorum libero quam natus. Hic praesentium distinctio voluptas quis sed. Facilis consequuntur culpa molestias ducimus accusantium dolorem autem.", "Libero quasi et dolor saepe debitis rerum. Accusantium impedit voluptatum odit velit amet odio eveniet harum. Quod quis omnis.", null, 2, new DateTime(2024, 6, 25, 9, 34, 16, 684, DateTimeKind.Local).AddTicks(1323), false, false, false, false, false, false, false },
                    { 57, "Quis atque natus excepturi in dicta quibusdam. Accusantium officiis nihil numquam id quis non aut quo reprehenderit. Eveniet sit voluptatem et sint et eos possimus explicabo est. Voluptatem ipsam unde magnam ab cumque provident quia.", null, false, new DateTime(2024, 3, 4, 20, 4, 25, 264, DateTimeKind.Local).AddTicks(5159), "Angela44@hotmail.com", "(608) 758-1379 x4210", "Angela Wehner", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 9, 28, 6, 28, 19, 369, DateTimeKind.Local).AddTicks(1529), 1, true, 1.0, true, "Ea soluta quod sit ducimus sed blanditiis voluptas atque beatae. Nulla cum perspiciatis consequatur ut vero facilis. Porro sit cumque sed reprehenderit quisquam aut libero. Voluptatem excepturi dignissimos iure delectus accusantium.", "sed", "Totam ut voluptate repudiandae laborum eligendi perferendis.\nQuidem alias aut repellendus voluptas.\nEt quo rerum distinctio error aliquid exercitationem laboriosam accusamus ut.", "Harum incidunt aut et consequatur et maiores magnam quia odio. Esse sunt nihil autem esse. Nam id sed tempore natus est. Eum debitis itaque non enim. In odio qui rerum.", "Nihil voluptatibus repellat sit quibusdam deserunt impedit quia ea. Sunt eos aut aut. Quia consequatur voluptatibus ullam architecto blanditiis et ut magni.", null, 2, new DateTime(2023, 11, 1, 18, 3, 6, 706, DateTimeKind.Local).AddTicks(6859), false, false, false, false, false, false, false },
                    { 58, "Molestiae amet totam voluptatem a amet voluptatem sunt ut aut. Nostrum ipsum sed voluptas rem voluptatem est eaque. Facilis ratione debitis minima minus animi aut in quia optio. Id veniam dolore autem eaque iure praesentium.", null, false, new DateTime(2024, 4, 21, 5, 44, 6, 886, DateTimeKind.Local).AddTicks(5982), "Ramon.Mills23@yahoo.com", "(297) 817-4347 x804", "Ramon Mills", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 4, 10, 17, 47, 31, 898, DateTimeKind.Local).AddTicks(7026), 1, true, 1.0, true, "Aut cupiditate ut et velit molestias iusto asperiores. Autem ipsum neque omnis ut aliquid minima. Consectetur qui ea quia dolorum.", "qui", "Aut et quia est vitae natus praesentium in nulla sed. Aut vitae tempora neque. Temporibus voluptas non. Aut quod saepe sint qui velit.", "Laudantium corrupti architecto magni harum veniam dolores sint tempore. Impedit est nihil commodi optio ut aut suscipit aut ex. Neque eum quia ipsam. Earum enim accusantium aut repellat aut est libero recusandae. Ipsa ab nisi quibusdam minus. Nisi et dolorum sint id laborum quae distinctio.", "Sunt occaecati mollitia corporis expedita hic. Et nisi tempora quos et rerum dolorem et aperiam. Suscipit consectetur ab asperiores enim fuga. Illum molestiae quas qui explicabo voluptas modi.", null, 2, new DateTime(2023, 9, 11, 13, 11, 6, 859, DateTimeKind.Local).AddTicks(4629), false, false, false, false, false, false, false },
                    { 59, "Eum architecto consequatur unde hic molestiae omnis et. Eum minus perferendis voluptatem. Corrupti tempora ducimus vitae voluptatem atque recusandae expedita nam.", null, false, new DateTime(2024, 4, 6, 3, 6, 57, 948, DateTimeKind.Local).AddTicks(5479), "Jane.Emmerich17@hotmail.com", "959.241.7680", "Jane Emmerich", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 28, 0, 21, 17, 85, DateTimeKind.Local).AddTicks(213), 1, true, 1.0, false, "Et esse et commodi laboriosam ipsum hic dolorem facilis possimus. Provident deleniti magnam dicta dolores autem. Qui sint aut. Similique perferendis aut iste et quod possimus.", "consequatur", "Unde suscipit molestias nesciunt nostrum aut distinctio dolor pariatur tempore.\nQuae eligendi delectus.\nRecusandae maiores iste et cupiditate non adipisci aspernatur pariatur.\nIste repellendus sint non voluptate fugiat doloremque.", "Non sint in suscipit dicta adipisci deleniti. Tenetur nulla blanditiis delectus. Officia qui aut.", "Architecto aut reprehenderit ex ut. Iste minus voluptatem qui similique odio quo vitae. Dicta eaque repudiandae. Et rem praesentium ipsa reprehenderit. Aliquam qui quidem ducimus. Optio ea rerum culpa.", null, 2, new DateTime(2023, 7, 3, 19, 6, 17, 885, DateTimeKind.Local).AddTicks(876), false, false, false, false, false, false, false },
                    { 60, "Sequi explicabo soluta. Labore distinctio sit. Quia reprehenderit id et.", null, false, new DateTime(2024, 4, 2, 20, 43, 59, 104, DateTimeKind.Local).AddTicks(3002), "Candice67@hotmail.com", "1-749-961-8158 x876", "Candice Bernier", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 22, 9, 24, 6, 990, DateTimeKind.Local).AddTicks(9185), 1, false, 1.0, false, "Sit distinctio non enim praesentium autem perspiciatis et repellat. Temporibus voluptatem illo itaque vel nihil alias. Repellendus qui ut unde odit rerum.", "quis", "alias", "Quasi sapiente ea. Sed neque incidunt adipisci ducimus nostrum dignissimos. Quas explicabo voluptatem eius eius est qui.", "Reprehenderit et praesentium expedita mollitia harum iste ut voluptatibus. Temporibus consequatur laborum non error. Voluptate at est culpa incidunt omnis. Laboriosam aperiam voluptas blanditiis.", null, 2, new DateTime(2023, 11, 27, 3, 23, 38, 921, DateTimeKind.Local).AddTicks(4563), false, false, false, false, false, false, false },
                    { 61, "Eum omnis dolorem. Tempore natus repudiandae quod reprehenderit ea. Autem fugiat modi facere aut iusto est. Necessitatibus ut et et accusantium adipisci in similique velit dolorem.", null, false, new DateTime(2024, 4, 10, 11, 33, 16, 908, DateTimeKind.Local).AddTicks(6837), "Leon.Strosin@gmail.com", "740.285.2512", "Leon Strosin", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 1, 1, 10, 22, 599, DateTimeKind.Local).AddTicks(3362), 1, false, 1.0, false, "Voluptatum eveniet fugiat. Provident quasi non dolor ipsam autem fuga et ut ut. Minima ut dicta officiis iure natus vel. Quo minus ut qui minima enim. Quas in assumenda ut doloremque deleniti repellat corporis eius id.", "modi", "Laborum sequi placeat possimus culpa sed accusantium.\nExercitationem ut error distinctio iusto.\nSit harum molestiae recusandae et quia officiis ab qui nam.\nDolores minima labore et.\nNeque delectus ipsum rerum.", "Voluptatem eum optio sequi delectus dolor minima. Tempore quis ipsa alias sed officia vel. Nobis quia facilis natus nihil.", "Ducimus voluptas temporibus blanditiis nesciunt architecto mollitia. Quos est id deleniti ut ut. Ex eligendi assumenda consectetur asperiores et sunt minima sed.", null, 2, new DateTime(2024, 4, 28, 22, 17, 7, 614, DateTimeKind.Local).AddTicks(7962), false, false, false, false, false, false, false },
                    { 62, "Saepe maxime molestias ut. Quaerat omnis ut commodi fugit. Eligendi deserunt architecto. Temporibus reiciendis qui molestias quia libero. Excepturi et perferendis repellendus reprehenderit sapiente omnis fugiat labore. Odio voluptatum dicta optio libero molestiae commodi.", null, false, new DateTime(2024, 6, 3, 14, 18, 16, 119, DateTimeKind.Local).AddTicks(8527), "Abel.Hirthe38@hotmail.com", "(292) 849-4144 x93894", "Abel Hirthe", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 5, 17, 12, 24, 28, 577, DateTimeKind.Local).AddTicks(3609), 1, false, 1.0, true, "Facere ipsum recusandae ut. Praesentium id et sunt autem minus. Et provident architecto ut odio non. Accusamus et rem non debitis provident magnam.", "fugit", "Unde omnis eaque. Sint est in. Ut quia et aspernatur libero praesentium quas. Rerum rerum aut. Incidunt ut eos mollitia ex minima. Inventore aut eius ut placeat architecto ut dolorem.", "Dolor laborum molestiae expedita repudiandae. Dolor eius nihil et quasi quis esse laborum ipsum aut. Necessitatibus est repudiandae dignissimos nam. Consequatur occaecati sint voluptatem reiciendis ut voluptatem cumque. Omnis maxime eos sit qui aut ipsam repudiandae. Autem et deleniti sunt nobis deserunt est quia.", "Vitae quia eaque non fugit reiciendis nihil dolores. Libero sed voluptatem soluta aut et. Tempore placeat voluptas reprehenderit cupiditate sunt id incidunt et. Nesciunt et quo. Impedit et consequuntur ad et laudantium excepturi vel placeat aliquid. Libero et dolore deleniti.", null, 2, new DateTime(2023, 11, 9, 0, 9, 5, 372, DateTimeKind.Local).AddTicks(475), false, false, false, false, false, false, false },
                    { 63, "Aperiam impedit quia. Aut itaque ducimus ex autem earum. Voluptates ut hic quasi atque sed sed. Qui deleniti saepe aut nihil recusandae voluptatibus laborum. Soluta magnam architecto facilis explicabo animi quas. Quae aut quia eos esse non.", null, false, new DateTime(2023, 7, 24, 8, 10, 31, 121, DateTimeKind.Local).AddTicks(1658), "Lynn_Wintheiser@yahoo.com", "655-290-1625 x6831", "Lynn Wintheiser", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 6, 14, 3, 26, 7, 225, DateTimeKind.Local).AddTicks(2196), 1, false, 1.0, true, "Rerum nesciunt sint eveniet. Necessitatibus et maxime. Quo sunt eos animi eveniet ut. Quia pariatur cum quia. Sapiente vel placeat ducimus et iusto tempora accusantium provident.", "est", "Debitis deleniti omnis totam porro cupiditate.", "Sit quaerat eum accusantium commodi vero ratione. Ab vel similique sed reprehenderit consequatur. Nisi assumenda qui blanditiis qui nihil porro vero maiores ullam. Quisquam quam omnis distinctio est voluptas aut cupiditate sed. Et quisquam vitae omnis nostrum autem reiciendis porro. Id maiores molestias quos.", "Voluptatem et laboriosam quia laborum in qui qui. Dolores est tempore iure quia et et. Eum veniam repudiandae quae consequatur optio neque harum id. Eum natus est numquam.", null, 2, new DateTime(2024, 5, 11, 12, 31, 18, 205, DateTimeKind.Local).AddTicks(9655), false, false, false, false, false, false, false },
                    { 64, "Est ipsum et recusandae reiciendis animi omnis tempora quidem. Consequatur exercitationem culpa doloremque qui harum et. Quia iure beatae provident odit ea sunt maxime. At rerum velit modi labore consequatur fugiat id. Reiciendis reiciendis et illo possimus dolores quia porro ducimus deserunt.", null, false, new DateTime(2024, 2, 26, 9, 36, 54, 394, DateTimeKind.Local).AddTicks(666), "Margaret.Larkin14@yahoo.com", "597.838.0960 x572", "Margaret Larkin", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 5, 1, 7, 50, 5, 345, DateTimeKind.Local).AddTicks(4627), 1, false, 1.0, true, "Voluptatem voluptate illum eos deleniti voluptatem est et veritatis. Nulla incidunt saepe et. Tempora quis assumenda non placeat. Facere expedita tempore consectetur quia. Culpa ex reprehenderit a dolores delectus non sed. Deserunt dicta omnis ab qui dolores repudiandae.", "qui", "ut", "Numquam rerum ut soluta nam doloremque corrupti similique placeat. Rerum ex nobis odit. Tempore nostrum ut voluptatem delectus iure maxime quidem quis consequatur.", "Quibusdam quo molestiae ut molestiae sapiente quibusdam. Velit ipsa ad fugiat recusandae. Ut repellendus ducimus eos ea commodi. Est et odio. Alias adipisci ducimus rem enim inventore tempore repellendus nihil. Qui dolorem id voluptatem qui necessitatibus quod voluptatum.", null, 2, new DateTime(2023, 12, 21, 15, 20, 27, 56, DateTimeKind.Local).AddTicks(4814), false, false, false, false, false, false, false },
                    { 65, "Et deleniti dolore explicabo ipsam eum ut architecto provident repellendus. Labore aut fuga asperiores perferendis autem molestiae qui. Ut consequatur consequatur vero saepe at occaecati repellendus officiis.", null, false, new DateTime(2023, 10, 11, 10, 2, 31, 68, DateTimeKind.Local).AddTicks(5621), "Willie_Bashirian@yahoo.com", "(952) 317-4084 x0967", "Willie Bashirian", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 7, 19, 17, 6, 12, 24, DateTimeKind.Local).AddTicks(4729), 1, false, 1.0, true, "Culpa ducimus ratione enim. At provident incidunt praesentium voluptate. Aut soluta nesciunt ut et consequatur ut. Modi sed qui.", "corporis", "veritatis", "Sed praesentium eos sit sed et. Beatae temporibus sapiente ex dolorum nesciunt voluptas. Asperiores nisi ea quia consequuntur optio aliquid temporibus. Odio at et aut. Qui dolores non cumque laudantium sit assumenda animi modi.", "Sed vitae placeat aut perferendis qui eos vel nihil. Sapiente est itaque perspiciatis eligendi pariatur tempore impedit maxime. Qui laudantium quia facilis eum. Sint eligendi excepturi molestiae.", null, 2, new DateTime(2024, 2, 7, 10, 27, 27, 406, DateTimeKind.Local).AddTicks(8950), false, false, false, false, false, false, false },
                    { 66, "Ut fugit voluptatem dignissimos expedita eaque accusamus commodi. Aut asperiores illo magnam quo libero non velit. Voluptatem dolor eius maxime sunt ullam eos. Sapiente id ut quia ut incidunt dolores. Autem quo amet velit.", null, false, new DateTime(2024, 2, 23, 10, 30, 25, 546, DateTimeKind.Local).AddTicks(1549), "Flora.McCullough29@hotmail.com", "847-971-8613", "Flora McCullough", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 6, 15, 19, 28, 26, 506, DateTimeKind.Local).AddTicks(1795), 1, false, 1.0, true, "Corrupti quos eos odio minima. Error nesciunt molestias natus qui in quia dignissimos voluptatum. Ut sit corporis sed beatae voluptatem. Sint fuga voluptas et doloremque ipsa.", "a", "Quae est qui aut.\nSit exercitationem aut aut.\nNisi reiciendis hic.\nEst maxime corporis ipsum dolorem saepe et adipisci tempora doloremque.\nIllum sint et sed fugit.\nIllum qui non minima possimus placeat est.", "Aut qui ad. Sed ut cum vero. Veniam quod repellendus in. Rerum at laudantium.", "Voluptatem et quis odio est perspiciatis non. Id fuga recusandae repellat optio voluptas neque rerum aut. Inventore repudiandae aut eos distinctio est magnam autem voluptas labore. Voluptatem molestiae nostrum. Quasi dicta quas.", null, 2, new DateTime(2023, 11, 5, 0, 49, 1, 222, DateTimeKind.Local).AddTicks(2159), false, false, false, false, false, false, false },
                    { 67, "Ut ducimus deserunt delectus praesentium quidem reiciendis esse exercitationem. Maiores aperiam blanditiis aut. Nihil possimus tempore. Assumenda asperiores ullam aut quasi.", null, false, new DateTime(2023, 12, 1, 15, 52, 13, 724, DateTimeKind.Local).AddTicks(2684), "Angela.Welch@yahoo.com", "795-571-2031 x4690", "Angela Welch", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 6, 6, 40, 3, 570, DateTimeKind.Local).AddTicks(1361), 1, true, 1.0, true, "Consectetur id reprehenderit. Et sint in beatae pariatur ut ut sint. Optio non magnam distinctio nostrum veniam aut pariatur recusandae. Sit ut tempore sed sunt possimus. Similique cupiditate quis dignissimos ducimus et accusantium natus.", "est", "quidem", "Vitae et quo. Mollitia voluptas maxime rerum officia temporibus temporibus ipsum aliquam. Inventore eum rerum quibusdam dolorem. Dolor in vel perspiciatis consequatur.", "Tempora aspernatur soluta numquam ipsum totam consequatur sit. Et aut occaecati minus aut doloremque voluptatibus. Qui enim consectetur sint delectus minus nam enim.", null, 2, new DateTime(2024, 2, 28, 16, 34, 32, 111, DateTimeKind.Local).AddTicks(5060), false, false, false, false, false, false, false },
                    { 68, "In ut molestiae asperiores fugiat. Excepturi dolorem distinctio. Atque doloribus occaecati nemo nulla. In dolores hic facilis libero quasi iure quia odio.", null, false, new DateTime(2024, 2, 19, 1, 59, 18, 412, DateTimeKind.Local).AddTicks(206), "Milton.Ledner24@gmail.com", "1-631-435-2492", "Milton Ledner", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 5, 22, 8, 16, 58, 272, DateTimeKind.Local).AddTicks(5866), 1, false, 1.0, false, "Sed tempora ipsam amet non quo minima ipsum culpa consequatur. Eligendi saepe sed sint dolores sint ullam nisi rerum voluptatibus. Iusto omnis reprehenderit nobis est fuga molestias. Odit iste non modi enim animi nisi nesciunt a minima. Eos ut qui molestiae. Inventore odio placeat recusandae totam voluptatem explicabo perferendis eveniet.", "nam", "Nulla aut expedita distinctio dolorum ut esse omnis libero. Voluptatem autem possimus nisi et facilis nulla enim et ut. Et ipsum debitis sunt quos vitae praesentium. Voluptas facilis aut aut ea aut quia qui voluptatum facilis. Perferendis ipsa iure perspiciatis molestiae qui quo soluta doloremque quis.", "Quia consectetur non eius recusandae dolor. Magni illum tenetur. Laboriosam magnam excepturi maiores in incidunt necessitatibus inventore consequatur.", "Sit perspiciatis labore fuga ducimus molestiae omnis in. Perspiciatis ad magnam et laborum voluptatem. Et aut iure sint aspernatur inventore velit quae exercitationem repudiandae. Ipsam qui eos enim. Assumenda deleniti eos nam reiciendis nemo sit distinctio.", null, 2, new DateTime(2023, 9, 5, 4, 13, 38, 569, DateTimeKind.Local).AddTicks(8335), false, false, false, false, false, false, false },
                    { 69, "Dignissimos quia eaque quas corrupti in fugiat et. Saepe vel ut dolorem. Magni tenetur tempore suscipit. Numquam corporis fugiat excepturi assumenda. Neque nemo optio est enim. Qui delectus nulla officiis culpa earum.", null, false, new DateTime(2024, 6, 10, 3, 33, 23, 797, DateTimeKind.Local).AddTicks(2108), "Ed66@hotmail.com", "(584) 965-4624", "Ed Walter", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 10, 5, 0, 19, 22, 232, DateTimeKind.Local).AddTicks(4677), 1, false, 1.0, true, "Corrupti harum molestiae necessitatibus in quo laudantium qui deserunt nostrum. Aut et et nihil iusto laborum eligendi enim quia. Sunt eos accusantium et ducimus. Corporis quia exercitationem.", "unde", "vel", "Culpa officiis rerum recusandae inventore fugiat impedit porro ea. Neque cupiditate architecto. Velit voluptatem rerum libero sunt. Qui dolores ea voluptatibus magni fuga neque.", "Quod placeat qui atque vero. Natus nam possimus. Quis et autem minus.", null, 2, new DateTime(2024, 4, 14, 23, 48, 24, 292, DateTimeKind.Local).AddTicks(4735), false, false, false, false, false, false, false },
                    { 70, "Quia vitae quisquam id illum unde. Nesciunt culpa at doloribus quam. Aut omnis necessitatibus quia tempore sit et et nobis. Molestiae ipsam illum tempora voluptatem dolorem perspiciatis occaecati. Quo architecto quo consequatur voluptatibus ut delectus voluptatem libero. Quos eveniet quia rem aperiam quibusdam corporis unde ea.", null, false, new DateTime(2024, 1, 28, 11, 28, 58, 643, DateTimeKind.Local).AddTicks(4900), "Virginia.Keeling67@gmail.com", "(716) 502-0997", "Virginia Keeling", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 5, 22, 6, 8, 8, 35, DateTimeKind.Local).AddTicks(4850), 1, true, 1.0, false, "Maiores ipsam quidem dignissimos quibusdam quis alias. Numquam suscipit eaque suscipit consequuntur. Est iure possimus et dolorem impedit et aliquam.", "ut", "quod", "Dolor molestiae pariatur ad sit nemo ipsam qui possimus. Natus amet inventore. Fugiat qui laudantium blanditiis natus adipisci voluptas nisi velit unde. Sed molestias nobis qui quae dignissimos nihil adipisci. Eius necessitatibus consequatur inventore at accusantium.", "Recusandae enim adipisci quisquam voluptas maxime aperiam aut aut quod. Voluptate beatae iusto sit. Harum est et et repellat. Harum vero asperiores et quod earum vitae ea. Sed eum temporibus velit aspernatur aliquid et. Omnis et molestiae et nihil cupiditate repellendus consequatur repellendus.", null, 2, new DateTime(2024, 1, 14, 21, 32, 17, 418, DateTimeKind.Local).AddTicks(6364), false, false, false, false, false, false, false },
                    { 71, "Ipsa voluptatem impedit nihil quod suscipit qui atque fugiat et. Excepturi aliquam minima esse et dolorum ea qui dignissimos ipsum. Sed saepe aliquam et. Doloribus eveniet et. Consequatur cum quisquam porro ut dolores quam dolorem.", null, false, new DateTime(2023, 7, 5, 6, 17, 46, 196, DateTimeKind.Local).AddTicks(5539), "Doreen.Glover@hotmail.com", "1-222-988-1582 x25299", "Doreen Glover", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 4, 3, 2, 22, 28, 984, DateTimeKind.Local).AddTicks(4049), 1, false, 1.0, false, "Deserunt non qui amet non beatae voluptates autem ipsa dolores. Omnis architecto qui nulla ut vel. Cum non eum officia. Fugiat non quo provident natus officiis. Sed sed voluptates et culpa.", "enim", "Doloribus numquam adipisci.\nExercitationem ad qui animi doloribus officiis rerum nobis dolore.\nSuscipit aut consequatur non.\nQuaerat quis perspiciatis ut et tempore recusandae.\nFacilis sunt ratione sunt incidunt odit consequuntur est repellat.", "Aut iste voluptatum ut perspiciatis nobis ut est. Iure in reprehenderit in quod quae qui tempore ducimus et. Sit commodi nihil consequatur accusantium. Ullam voluptate in sed praesentium suscipit voluptatum ad nihil. Repellendus eos repellat.", "Voluptatibus reiciendis laudantium quasi sit sunt eum sit. Blanditiis et magni ea unde quod magni nam. Cumque iure eum aut. Non labore repudiandae corporis voluptatem voluptatibus nam provident ducimus. Deserunt velit eum a.", null, 2, new DateTime(2024, 4, 5, 3, 7, 35, 436, DateTimeKind.Local).AddTicks(302), false, false, false, false, false, false, false },
                    { 72, "Qui quibusdam voluptatum optio aut sequi odio voluptatem est alias. Voluptatem fugit facere. Autem et sapiente. Quaerat et exercitationem omnis dignissimos sed corporis. Commodi ipsa minima sunt deleniti.", null, false, new DateTime(2023, 10, 3, 15, 17, 7, 721, DateTimeKind.Local).AddTicks(1209), "Leona1@gmail.com", "227.834.9123 x689", "Leona Dietrich", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 10, 13, 39, 42, 472, DateTimeKind.Local).AddTicks(5974), 1, false, 1.0, true, "Id odit explicabo corporis architecto. Quos nihil est ad voluptatem aliquid numquam consequatur neque. Iusto qui tempore nihil ut cupiditate eaque aperiam dolores. Eos beatae ad quis et omnis vel. Ratione sint cumque magni necessitatibus quo assumenda consequatur cupiditate.", "atque", "pariatur", "Velit enim voluptas dolor consequatur. Qui beatae et veritatis. Dolores consequatur velit ratione in nulla assumenda ut quis.", "Quasi corporis quas a. Sed alias iste repudiandae facilis corrupti culpa debitis. Provident aliquam quod. Fugit quasi at quidem. Reprehenderit nihil ex vero quia. Aliquid debitis quisquam nihil a sed sed tempore.", null, 2, new DateTime(2024, 5, 16, 2, 28, 40, 264, DateTimeKind.Local).AddTicks(3278), false, false, false, false, false, false, false },
                    { 73, "Aut qui quia laboriosam quibusdam ab earum illum minus aut. Sapiente harum et et optio corporis. Ex accusantium iusto voluptatem quis nisi in. Quod ut assumenda eos aut numquam quis autem eaque.", null, false, new DateTime(2024, 2, 11, 1, 37, 0, 929, DateTimeKind.Local).AddTicks(8613), "Cary77@hotmail.com", "(322) 879-4761", "Cary Cole", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 10, 9, 18, 32, 25, 401, DateTimeKind.Local).AddTicks(3227), 1, false, 1.0, false, "Consequuntur fugiat sint eum quod dolorem et dolor iste. Minus nisi optio earum maxime aliquam ipsam. Maiores at et itaque repellat enim.", "ipsa", "mollitia", "Deserunt aliquam dolorem veritatis fugiat. Eligendi voluptas velit optio. Distinctio natus voluptas ut. Iste quasi adipisci. Sapiente illo recusandae ab voluptas. Amet fugiat quia temporibus eligendi incidunt nam occaecati delectus nemo.", "Et omnis ab velit sed. Temporibus consectetur corporis aspernatur voluptas ullam atque reiciendis. Optio corporis ut quia est id. Doloribus eos quidem voluptate alias delectus repellat ipsa debitis. Aut ad sed et numquam unde recusandae amet quaerat dolores. Sunt et et corporis porro eum delectus numquam.", null, 2, new DateTime(2023, 9, 30, 4, 18, 57, 749, DateTimeKind.Local).AddTicks(9023), false, false, false, false, false, false, false },
                    { 74, "Nobis neque iusto assumenda necessitatibus incidunt. Animi nemo qui voluptatibus eum est. Nam quo doloremque. Accusantium consequatur ut ad unde consequatur et. Ut autem veniam.", null, false, new DateTime(2023, 7, 19, 9, 27, 46, 115, DateTimeKind.Local).AddTicks(2389), "Terrence.Harris38@gmail.com", "901-998-7585 x1554", "Terrence Harris", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 22, 22, 36, 44, 966, DateTimeKind.Local).AddTicks(359), 1, false, 1.0, true, "Qui laborum doloribus facere omnis asperiores aspernatur nisi. Dolorum nisi iste doloremque deleniti iusto. Perspiciatis ad dolor quo. Sit animi aut velit laborum quasi eos temporibus aut. Ipsam sint vel aliquam assumenda cumque quia rerum. Non eius omnis eum consequatur quisquam sint rerum.", "adipisci", "Odit hic consequatur impedit aut aut nisi. Et sapiente iste officia. Accusantium ipsa eius tempora libero praesentium eius reprehenderit praesentium et. Laudantium eius odit eligendi explicabo sit rerum. Architecto neque quia error alias perspiciatis possimus illum voluptatibus. Autem ut distinctio delectus dignissimos reiciendis cum ullam.", "Deleniti officia consequuntur facilis quae velit et. Omnis et quasi id perferendis nihil excepturi omnis illum. Numquam soluta voluptates rerum ut tempore. Recusandae hic et est consequuntur perferendis quibusdam cupiditate. Quis corrupti eaque natus occaecati aut.", "Ipsa sit est inventore a a qui nam nesciunt velit. Reiciendis et quo. Qui voluptatibus aut dolore maxime. Est quidem ad.", null, 2, new DateTime(2024, 5, 16, 12, 40, 8, 285, DateTimeKind.Local).AddTicks(5087), false, false, false, false, false, false, false },
                    { 75, "Fuga sit et sunt aperiam. Magni exercitationem soluta nesciunt non minima ullam eos aperiam quo. Aut dolor in fugiat provident est tempora optio dolorem. Tempore eaque et est id occaecati eveniet quasi qui. Magnam provident quo expedita et numquam asperiores.", null, false, new DateTime(2024, 4, 8, 15, 6, 44, 902, DateTimeKind.Local).AddTicks(1184), "Tommie_Weimann11@gmail.com", "911.567.9314", "Tommie Weimann", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 2, 27, 8, 43, 21, 98, DateTimeKind.Local).AddTicks(5369), 1, true, 1.0, true, "Omnis sapiente delectus quos suscipit. Officia aperiam non explicabo velit quo debitis non amet. Quaerat iusto iure est possimus ea. Nemo aspernatur dolorum ad laudantium et sit voluptatem omnis.", "voluptas", "Aut nihil perspiciatis et molestiae.", "Consequatur aut ipsam omnis autem voluptatem. Velit et omnis est at molestias voluptatem. Distinctio qui porro sunt.", "Adipisci omnis quidem. Qui earum vel. Quo non laudantium mollitia enim aperiam illum doloribus voluptatem.", null, 2, new DateTime(2023, 9, 16, 23, 52, 39, 452, DateTimeKind.Local).AddTicks(8052), false, false, false, false, false, false, false },
                    { 76, "Sapiente numquam ut. Iste in id ut et aperiam. Nisi quaerat qui commodi praesentium sequi eaque. Fugit unde earum dignissimos sint at. Laudantium sit corrupti fuga quis alias voluptates autem expedita. Beatae molestiae sit.", null, false, new DateTime(2024, 3, 16, 17, 56, 29, 470, DateTimeKind.Local).AddTicks(9813), "Marty.Rippin@hotmail.com", "793.777.1043 x640", "Marty Rippin", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 28, 21, 0, 12, 278, DateTimeKind.Local).AddTicks(3070), 1, true, 1.0, true, "Officia iure maiores aspernatur sit quod omnis. Laborum natus optio. Accusamus sint voluptatem assumenda voluptatem. Minus recusandae ea atque minima nam omnis.", "iusto", "Ut eum tempora.", "In sapiente omnis blanditiis esse cupiditate vitae voluptates voluptatem officiis. Tempore est ipsa. Quidem quia illo iure quis.", "Aut odit quia perspiciatis. Enim deleniti maxime tempora sit cum voluptatem nostrum iste rem. Est perferendis est accusantium dicta. Eius doloribus et reprehenderit adipisci odio earum.", null, 2, new DateTime(2024, 3, 20, 22, 35, 20, 187, DateTimeKind.Local).AddTicks(3209), false, false, false, false, false, false, false },
                    { 77, "Eveniet voluptatem dolores fugiat quo voluptatibus quibusdam. Sed sed ea nisi amet et id voluptas accusamus. Accusantium voluptas nobis.", null, false, new DateTime(2023, 9, 27, 21, 5, 18, 204, DateTimeKind.Local).AddTicks(4652), "Dennis.Upton48@yahoo.com", "(962) 819-6887", "Dennis Upton", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 4, 2, 9, 9, 44, 924, DateTimeKind.Local).AddTicks(8650), 1, true, 1.0, false, "Voluptatum eum perspiciatis enim odit. Quod non magnam recusandae. Quod qui qui aspernatur quia atque corporis quaerat vero eum. Qui alias magnam consequuntur.", "fuga", "Eius saepe odio est. Ducimus dolorem quo est quidem quibusdam quia sequi. Enim quia voluptatem fuga assumenda quo. Sed molestiae id quas voluptas non ut. Reiciendis culpa quo.", "Quo sit corporis. Atque est aut est et dolorum inventore quas repellat. Minus magni reiciendis. Dolores et libero.", "Quo sit sit sint fuga eligendi. Inventore a pariatur fugit optio magnam qui eum. Sed dolorem assumenda sint. Perspiciatis alias sit saepe consequatur necessitatibus alias in nihil. Consequatur doloremque omnis laudantium qui sequi dolores.", null, 2, new DateTime(2024, 4, 10, 13, 35, 29, 858, DateTimeKind.Local).AddTicks(9449), false, false, false, false, false, false, false },
                    { 78, "Rerum quia possimus. At quo omnis architecto corrupti eius. Assumenda natus autem ad ea. Amet in eum deleniti accusamus esse consequatur nesciunt deserunt. Ipsam officiis perspiciatis harum laborum fugiat nam pariatur voluptatem molestias. Ipsam error id et vitae inventore.", null, false, new DateTime(2024, 4, 17, 22, 7, 55, 641, DateTimeKind.Local).AddTicks(8275), "Jasmine.Hegmann95@gmail.com", "529.997.4180", "Jasmine Hegmann", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 6, 15, 0, 27, 38, 16, DateTimeKind.Local).AddTicks(9640), 1, false, 1.0, false, "Quis culpa eos ad aut. Reprehenderit ab unde est autem rerum voluptatem quaerat et. Velit rerum officia est. Eveniet earum perferendis saepe suscipit accusamus quo modi quae repellendus. Voluptates voluptas nemo reprehenderit qui. Similique et modi repellendus sed beatae rem.", "natus", "illo", "Incidunt eos rem non eum. Rerum pariatur vel quidem saepe iste. Et maiores odio aperiam nihil tenetur rem repellendus animi. Quisquam laudantium voluptatem omnis eos ut. Magni vel eos vero vel.", "Cumque blanditiis et facere id eius non aut libero a. Explicabo aperiam cupiditate repellendus aut tempora qui. Omnis facere maxime ut est omnis nemo quae. Beatae quam delectus est nisi iste suscipit. Aperiam quisquam dolor vel dignissimos maxime quibusdam consectetur neque assumenda.", null, 2, new DateTime(2024, 4, 14, 11, 21, 6, 68, DateTimeKind.Local).AddTicks(9701), false, false, false, false, false, false, false },
                    { 79, "Et recusandae quaerat cupiditate quod exercitationem quam nostrum ab consequatur. Ut omnis non. Exercitationem voluptatem in. Numquam asperiores voluptas fuga et qui odit dolorem culpa. Corporis vel sunt vero dolor autem ad omnis sit consequatur. Vel est voluptatibus consequatur laudantium nostrum rerum laboriosam debitis enim.", null, false, new DateTime(2023, 9, 5, 11, 21, 24, 390, DateTimeKind.Local).AddTicks(968), "Frankie72@hotmail.com", "741.736.2531", "Frankie Jaskolski", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 7, 4, 5, 16, 33, 254, DateTimeKind.Local).AddTicks(1479), 1, false, 1.0, true, "Sit est ut id nemo et quibusdam. Rem voluptas qui maxime et et corrupti reiciendis. Est provident qui deserunt. In ut repellendus illum dolorem iusto totam corrupti cumque fuga. Omnis labore non vel rerum. Magni provident quia et ut sit labore vel delectus et.", "distinctio", "odit", "Aut iure dolore cumque. Quos laudantium commodi neque maiores eos est voluptate et quaerat. Dolorem excepturi aut in nostrum. Excepturi et itaque perspiciatis odio sed. Consequatur ullam mollitia rerum amet voluptas pariatur sapiente.", "Voluptatum libero ipsum perferendis ducimus fugiat natus eum. Nihil occaecati dolores cum ullam laboriosam vero deserunt. Illum omnis voluptate ab quaerat qui ex nobis perspiciatis rerum.", null, 2, new DateTime(2023, 8, 16, 15, 21, 30, 828, DateTimeKind.Local).AddTicks(3967), false, false, false, false, false, false, false },
                    { 80, "Voluptates officiis est sit. Mollitia maiores neque et delectus deserunt sunt est dolorem et. Ipsa voluptas porro quia et accusantium quod nemo. Nostrum inventore odio. Voluptates cum culpa blanditiis natus impedit dolorem. Repudiandae voluptate exercitationem qui enim.", null, false, new DateTime(2023, 8, 11, 19, 56, 25, 864, DateTimeKind.Local).AddTicks(9369), "Dianna_Erdman64@hotmail.com", "(527) 242-6633 x17556", "Dianna Erdman", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 18, 1, 7, 16, 608, DateTimeKind.Local).AddTicks(3208), 1, true, 1.0, false, "Tenetur consequatur tempore at magni animi ut vel. Possimus suscipit aut dolores laudantium voluptatem. Sed perspiciatis est perferendis nostrum aut quidem dicta. Qui voluptate magni.", "sint", "Deserunt est alias ex aliquam dolorum.", "Voluptates facilis exercitationem consectetur optio. Eum aperiam eum et. Possimus sit dolorum labore dignissimos earum quia qui id.", "Eos praesentium ut commodi. Odit magni odit aut voluptatem sit ut quod. Asperiores qui itaque eos quis. Culpa voluptatum voluptatem nam non ut. Natus velit vitae eaque rem harum porro.", null, 2, new DateTime(2023, 10, 24, 6, 6, 11, 558, DateTimeKind.Local).AddTicks(5641), false, false, false, false, false, false, false },
                    { 81, "Cupiditate et nisi aut placeat. Dolorem et quasi necessitatibus soluta voluptates laudantium voluptate vitae. Quo incidunt sint perferendis harum nobis nihil libero.", null, false, new DateTime(2024, 5, 11, 11, 45, 18, 623, DateTimeKind.Local).AddTicks(1622), "Dominick.Wilderman58@yahoo.com", "481-983-6353 x62262", "Dominick Wilderman", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 7, 5, 49, 7, 585, DateTimeKind.Local).AddTicks(6597), 1, false, 1.0, true, "Fugiat sed rerum libero. Ut est qui voluptas numquam ut qui dolorum ex voluptatem. Nulla nostrum doloremque et accusamus dolorum harum. Qui fugit itaque.", "repellat", "Cum laudantium error sint.\nVoluptatem in reiciendis ducimus quaerat rerum rerum accusamus.\nEligendi laborum error doloribus perferendis voluptas magni quidem.\nIpsam numquam corrupti unde.\nQuibusdam exercitationem est dolorem non consequatur nostrum soluta illo odio.\nEa ducimus ipsam qui voluptatibus.", "Voluptas reprehenderit eaque quas autem aut rerum asperiores beatae ipsa. Magnam cumque modi quo praesentium. Voluptatem laborum voluptatum impedit.", "Perferendis iste consequuntur cum et qui. Illo consectetur dicta ut quisquam nesciunt ut exercitationem sint. Cupiditate recusandae non magnam iure et id explicabo. Maiores eos et quis facere enim ut voluptatibus. Rerum magnam sit. Animi voluptatem doloribus aspernatur dolorem totam et iste natus aut.", null, 2, new DateTime(2024, 1, 26, 7, 55, 46, 713, DateTimeKind.Local).AddTicks(4648), false, false, false, false, false, false, false },
                    { 82, "Aliquid voluptatum neque aut natus iste eos vitae eveniet. Aut voluptas repudiandae. Maxime est harum id eum quae nihil non. Architecto maxime possimus.", null, false, new DateTime(2024, 1, 13, 18, 21, 40, 739, DateTimeKind.Local).AddTicks(3057), "Tabitha.Herman17@gmail.com", "(676) 932-1215 x90119", "Tabitha Herman", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 12, 4, 20, 24, 53, 315, DateTimeKind.Local).AddTicks(1837), 1, false, 1.0, true, "Neque earum at ullam. Fugiat accusantium quia. Omnis aut vero nemo amet.", "repellat", "Aliquid architecto sed ut optio.", "Ratione nihil qui nihil velit dicta inventore aut. Molestiae sint tenetur nesciunt quas id. Nobis sed ex. Quidem non quod occaecati non id omnis reprehenderit soluta. Reiciendis totam sequi dolorem sequi id eligendi id quibusdam. Cumque ullam commodi vel ut.", "Aut et asperiores occaecati. Nisi sint illo dolorum soluta dolorum quos cum. Libero quia rerum hic qui.", null, 2, new DateTime(2023, 12, 4, 18, 54, 40, 520, DateTimeKind.Local).AddTicks(3999), false, false, false, false, false, false, false },
                    { 83, "Quos in architecto id nihil quas perferendis culpa eos. Nihil omnis quos nobis corporis quidem veniam quis. Laboriosam voluptatem id iste perferendis iure. Ut porro officiis est aliquid ea ut voluptatum architecto voluptatum.", null, false, new DateTime(2024, 5, 26, 23, 26, 43, 257, DateTimeKind.Local).AddTicks(8313), "Austin65@hotmail.com", "659.476.7659 x073", "Austin Bergnaum", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 8, 2, 3, 55, 57, 396, DateTimeKind.Local).AddTicks(8521), 1, true, 1.0, true, "Laborum laudantium id ut alias quam sit. Rerum tenetur dicta et. Quibusdam molestiae reiciendis. Rerum voluptas veritatis numquam est provident exercitationem nihil. Iure voluptatem esse sit laborum dolorem necessitatibus.", "soluta", "Est animi dolores repellat modi maiores sit harum.\nId iste aut.", "Amet quidem nobis iure quo non enim fugiat rem. Repellat facere non. Voluptatem aut quia quia quam. Explicabo veniam nihil veritatis.", "Sint nam optio molestiae fugiat quae ipsa dolore nihil. Quia nostrum quo beatae. Omnis magni odit repellat totam inventore. Consequatur eaque minima et iste consequuntur cum ut. Dolorum reprehenderit ab esse est eos unde velit hic impedit. Sint architecto voluptas aperiam quis nisi qui voluptatem.", null, 2, new DateTime(2023, 10, 15, 18, 30, 36, 126, DateTimeKind.Local).AddTicks(7528), false, false, false, false, false, false, false },
                    { 84, "Doloremque aperiam laudantium dicta quam sequi nobis odit officia delectus. Ea deleniti sunt fugit facilis. Magnam cum quia harum ut explicabo delectus. Ex explicabo dolores unde sit quia. Dolorum debitis ratione aspernatur eaque deserunt harum cupiditate rerum officia. Aut explicabo est occaecati exercitationem quis.", null, false, new DateTime(2023, 9, 17, 2, 45, 30, 119, DateTimeKind.Local).AddTicks(3442), "Helen_Funk@gmail.com", "214.910.3677 x17210", "Helen Funk", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 2, 13, 18, 40, 18, 326, DateTimeKind.Local).AddTicks(9625), 1, true, 1.0, true, "Commodi non animi corporis quos itaque dolores deserunt. Veritatis consectetur natus. Autem ex id id rerum sit. Itaque dolorum voluptatem quis quae aut nostrum. Voluptas quo quibusdam quia earum odio consequatur autem sit.", "in", "Alias similique laudantium optio accusantium voluptatem aut.\nDoloribus repudiandae aliquid enim repellat aut maxime vel.", "Vel est dolorum eum tempora. Maiores et delectus maiores reiciendis. Accusantium nostrum vero quasi itaque ab est deserunt. Dicta minima dolores.", "Dignissimos recusandae rerum quidem veritatis repellat nihil voluptatem ad excepturi. Ipsum nisi velit quo voluptate inventore accusantium omnis enim necessitatibus. Esse molestiae et. Est est ut exercitationem consequatur corrupti illo nemo. Illo tempore sit et reiciendis aut nihil sit ut. Assumenda impedit quos debitis.", null, 2, new DateTime(2023, 10, 12, 11, 49, 48, 150, DateTimeKind.Local).AddTicks(248), false, false, false, false, false, false, false },
                    { 85, "Voluptas recusandae quia vitae dolorem iste sed. Natus aut et illo. Enim vitae fuga facere delectus ut. Corporis quam odit dicta velit necessitatibus dolorem.", null, false, new DateTime(2023, 7, 12, 16, 4, 48, 966, DateTimeKind.Local).AddTicks(7283), "Sherry.Kilback@hotmail.com", "(962) 415-5787", "Sherry Kilback", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 19, 16, 45, 9, 26, DateTimeKind.Local).AddTicks(628), 1, true, 1.0, false, "Neque quia dolor voluptate architecto voluptates sit aspernatur autem dolores. Totam perferendis quis voluptas qui consectetur modi. Doloremque sint nihil. Illo repellendus ut nisi dolorem aperiam libero minima. Natus laboriosam in nobis est facilis.", "quis", "Cupiditate a eum vel inventore nostrum dolores dolor quas modi.", "Cupiditate autem blanditiis. Quia fuga consequatur similique ex veritatis consequuntur. Sed et tempore necessitatibus rerum eveniet perspiciatis pariatur cum. Doloribus placeat sint cum. Reiciendis non quae provident dignissimos laborum exercitationem eaque.", "Odit error voluptatem error eum perspiciatis laudantium fugiat aut quia. Et et eos id. Vel esse reprehenderit iure impedit distinctio dignissimos eveniet. Ea enim non soluta labore voluptates accusamus quo rerum. Sit occaecati veniam nulla deserunt non sint. Et sunt commodi delectus et non voluptas et debitis est.", null, 2, new DateTime(2023, 12, 17, 15, 43, 17, 289, DateTimeKind.Local).AddTicks(8866), false, false, false, false, false, false, false },
                    { 86, "Voluptas officia sint. Assumenda voluptatibus velit. Ut doloremque sint quo aperiam consequatur.", null, false, new DateTime(2023, 10, 18, 11, 2, 6, 386, DateTimeKind.Local).AddTicks(7256), "Shane_Shanahan27@yahoo.com", "407-457-9872", "Shane Shanahan", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 9, 28, 0, 55, 31, 269, DateTimeKind.Local).AddTicks(7741), 1, false, 1.0, false, "Earum enim ipsum. Quis quam voluptatem commodi aperiam officia ad exercitationem. Quaerat cupiditate repudiandae asperiores tempora eligendi beatae. Deserunt fugiat quis odit voluptate ducimus esse non praesentium. Ut aliquid minus reprehenderit molestiae quia excepturi est ut.", "voluptas", "accusantium", "Ut repudiandae aut quas id quisquam aut enim. Ipsam aliquid deleniti aut et delectus ut nulla. In illum aut rerum.", "Animi temporibus deleniti ut ut facere harum error est. Sed quos odio repudiandae est quod delectus. Nihil esse ipsa dignissimos labore saepe quisquam autem deleniti repellat. Commodi eligendi a sed qui et. Labore ut delectus eveniet soluta repellendus eum ullam velit. Provident recusandae unde fugiat pariatur inventore.", null, 2, new DateTime(2023, 11, 2, 14, 19, 23, 63, DateTimeKind.Local).AddTicks(2638), false, false, false, false, false, false, false },
                    { 87, "Quos assumenda aliquam provident. Reiciendis aliquam cupiditate at magnam asperiores sit eligendi. Quasi non ipsam eos est dolorum optio. Consequatur natus minima aut placeat. Distinctio unde debitis et.", null, false, new DateTime(2023, 8, 19, 5, 28, 14, 44, DateTimeKind.Local).AddTicks(887), "Erin_Blanda@gmail.com", "(897) 896-1327", "Erin Blanda", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 1, 27, 23, 51, 17, 234, DateTimeKind.Local).AddTicks(4843), 1, false, 1.0, true, "Dolor omnis nesciunt harum deleniti quaerat libero tempora voluptatum. Vitae magnam hic maiores rem beatae temporibus et cupiditate aut. Sed ea eligendi aliquam non tempora. Et nemo autem. Veniam eum voluptate nostrum. Nobis distinctio ut hic totam.", "illum", "Accusantium sequi voluptas quod culpa possimus.", "Autem autem reiciendis quis totam. Hic doloremque fuga commodi ipsum occaecati. Delectus sed in dolor impedit aut est quia sequi perferendis. Recusandae non tempora autem laudantium nemo.", "Non repellendus quos qui et et et. Impedit voluptatem voluptas odit facilis. Non veritatis aperiam amet natus officiis expedita tempore ipsum rerum. Deserunt odio aliquam ratione in.", null, 2, new DateTime(2023, 8, 10, 6, 31, 58, 19, DateTimeKind.Local).AddTicks(1236), false, false, false, false, false, false, false },
                    { 88, "Qui debitis porro. Quia qui ut ut dignissimos ut doloremque. Corporis aperiam rerum doloribus voluptatem architecto dolor saepe. Et quis exercitationem doloremque consequatur tenetur. Qui cupiditate repudiandae incidunt cum non asperiores in dolores. Magnam qui enim illo magni enim cumque soluta magnam.", null, false, new DateTime(2024, 2, 19, 0, 42, 4, 15, DateTimeKind.Local).AddTicks(5216), "Sean50@hotmail.com", "471-865-4439 x53742", "Sean VonRueden", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 8, 28, 16, 39, 50, 257, DateTimeKind.Local).AddTicks(4188), 1, true, 1.0, false, "Voluptatem possimus beatae qui eaque rerum iure quas quam officia. Et ipsum molestias et iusto quibusdam aut. Ipsa veritatis at. Dolorem dolor fuga ea. Inventore mollitia aliquid natus commodi.", "et", "Fugiat dolor rerum similique id quasi porro dolore quod.", "Unde non debitis. Impedit nesciunt unde accusamus laudantium in aliquam libero velit labore. Ducimus dolorem labore. Voluptatem corporis explicabo sequi id sit sit occaecati odio asperiores. Recusandae dicta perferendis cupiditate. Sunt sit eligendi rerum ea vel repellat rerum amet.", "Tempora sit occaecati. Saepe consequatur temporibus quas quibusdam qui illo. Necessitatibus autem rerum aut officiis. Facilis ipsum expedita necessitatibus vel. Voluptatem dolores animi unde qui corporis voluptatem ut accusantium et.", null, 2, new DateTime(2024, 4, 13, 1, 5, 32, 882, DateTimeKind.Local).AddTicks(4721), false, false, false, false, false, false, false },
                    { 89, "Dolorum sed dolorem provident enim ipsum reiciendis. Consequatur molestiae architecto blanditiis nemo ipsam voluptas. Harum sed et eius et dolores deserunt sed. Eligendi itaque officiis consequatur optio excepturi laboriosam voluptatum ut.", null, false, new DateTime(2024, 7, 1, 0, 28, 30, 359, DateTimeKind.Local).AddTicks(2094), "Kelly83@gmail.com", "1-643-463-7509", "Kelly Gutmann", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 4, 27, 23, 37, 23, 487, DateTimeKind.Local).AddTicks(8923), 1, true, 1.0, false, "Mollitia vitae eos animi quaerat dolorem alias inventore dignissimos mollitia. Voluptates suscipit quis accusantium. Quos sunt quo consequuntur earum. Impedit dolorum incidunt aut natus enim sint. Reiciendis architecto possimus assumenda et unde qui ut.", "a", "Possimus tempora perspiciatis accusantium sed quisquam libero. Nulla eum cupiditate et. Aut autem occaecati. Sequi voluptatem eligendi qui impedit.", "Sequi similique modi. Necessitatibus deserunt dolores id harum voluptate. Atque architecto sed error voluptas rerum eligendi necessitatibus deserunt. Quia impedit sunt quia debitis provident aut. Quibusdam qui ab est rem officiis ut dolores.", "Aliquam magnam repellendus quibusdam et. Necessitatibus dignissimos neque. Nihil ab ducimus illum accusantium cupiditate eum.", null, 2, new DateTime(2024, 2, 29, 4, 26, 49, 785, DateTimeKind.Local).AddTicks(9389), false, false, false, false, false, false, false },
                    { 90, "Error aperiam odio quam consequatur error esse est enim deserunt. Eius non qui vero ab eveniet consectetur. Nemo numquam et quod molestias aut voluptatem officiis. Quo porro amet iste molestias aspernatur eaque.", null, false, new DateTime(2023, 10, 13, 21, 28, 26, 531, DateTimeKind.Local).AddTicks(7708), "Sandy_Block@hotmail.com", "964-586-9434 x082", "Sandy Block", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 2, 27, 14, 28, 26, 177, DateTimeKind.Local).AddTicks(4791), 1, true, 1.0, true, "Voluptatem facere id eum laudantium facere maiores sequi. Non rerum quia provident qui laudantium sed dolor voluptas optio. Recusandae laborum voluptatibus est voluptas.", "aut", "Quo aut odit aut nemo quidem odio consequatur molestiae facere.\nPossimus aliquid voluptates.\nNon quis dolor voluptatem quisquam sit.\nSuscipit nisi possimus consequatur et.", "Perspiciatis corrupti velit. Quia sit quam voluptas in tempora omnis. Non aliquam perferendis. Ut qui cumque corrupti omnis rem quibusdam. Nobis sapiente eum est. Quae dolores voluptatibus libero a vel voluptatem repudiandae quia.", "Beatae dicta ut hic iste optio quos architecto. Omnis eius tempora hic veniam. Architecto eligendi ut saepe numquam.", null, 2, new DateTime(2023, 10, 19, 5, 3, 48, 606, DateTimeKind.Local).AddTicks(9215), false, false, false, false, false, false, false },
                    { 91, "Fuga eveniet facilis perspiciatis odit aut voluptates ut ducimus veritatis. Illo minus est et quis non et. Recusandae aspernatur facere aperiam. Accusantium quidem qui consequatur est consequatur. Saepe hic optio eius qui ut sed iure nemo dolorem.", null, false, new DateTime(2024, 6, 24, 17, 42, 44, 518, DateTimeKind.Local).AddTicks(3369), "Lynette_Smitham32@gmail.com", "(768) 534-4576", "Lynette Smitham", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 7, 21, 9, 16, 35, 138, DateTimeKind.Local).AddTicks(6903), 1, true, 1.0, false, "Soluta qui voluptas. Qui quasi quo et et id minus dolor officiis. Voluptatem occaecati totam corrupti perspiciatis velit beatae qui fuga. Aperiam molestias aliquam. Consequatur ipsa recusandae.", "assumenda", "Non sit et earum exercitationem.\nConsequuntur corporis nesciunt.\nSint ut provident alias.\nEt qui dolorum ex itaque ut eum id.\nEarum vel est ut in et delectus ut eos.", "Laboriosam libero perspiciatis dolore eos. Quo laudantium rerum sed neque est aut voluptas quia fugit. Consectetur quibusdam vel aut. Alias alias atque ducimus saepe qui. Aliquam soluta quia voluptatem nam.", "Ad autem numquam maiores cumque. Pariatur soluta dolor sunt molestias. Qui est illum quae laboriosam optio ut necessitatibus nam perspiciatis. Eligendi veritatis aut odit harum odio tenetur nihil odio.", null, 2, new DateTime(2023, 12, 14, 23, 36, 37, 646, DateTimeKind.Local).AddTicks(6685), false, false, false, false, false, false, false },
                    { 92, "Officiis inventore est. Iure error laboriosam id non nesciunt et voluptate et. Nulla facere illum sit odio quod consequatur inventore reprehenderit. Maxime rerum et quidem veritatis.", null, false, new DateTime(2023, 7, 31, 11, 13, 28, 185, DateTimeKind.Local).AddTicks(2610), "Luke_Ratke@yahoo.com", "759-273-8256 x207", "Luke Ratke", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 11, 19, 19, 50, 34, 286, DateTimeKind.Local).AddTicks(9939), 1, true, 1.0, true, "Ut itaque ea officiis sit ratione dolorum consequatur et maxime. Vitae quis aperiam cumque sint soluta quae assumenda. Commodi rerum est consequatur illum nam eum architecto.", "et", "Voluptates dolore reiciendis totam aut eveniet eum id. Quia adipisci repellat commodi. Voluptatem enim quae delectus itaque deserunt nostrum ex unde fuga. Ex illo aliquid omnis unde. Ullam ipsa delectus ipsum consequuntur.", "Eaque dolor numquam neque. Sequi dignissimos est rerum nulla facilis. Accusantium provident consequatur.", "Iste cumque aliquid dolor cupiditate nulla. Voluptas et ut eveniet tenetur in. Eveniet numquam illum non nesciunt autem consequuntur necessitatibus reprehenderit.", null, 2, new DateTime(2023, 12, 25, 22, 19, 40, 722, DateTimeKind.Local).AddTicks(9614), false, false, false, false, false, false, false },
                    { 93, "Cumque corporis delectus consequuntur cum consequuntur earum. Nihil pariatur minima iure ducimus amet fuga aspernatur. Qui quia sed mollitia nisi praesentium. Ducimus dolorem a neque dolorem et et ea voluptatibus. Quisquam sint libero soluta in.", null, false, new DateTime(2023, 8, 12, 23, 17, 27, 829, DateTimeKind.Local).AddTicks(3422), "Alfonso.Nicolas53@hotmail.com", "1-626-582-6457", "Alfonso Nicolas", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 6, 14, 5, 14, 33, 924, DateTimeKind.Local).AddTicks(6021), 1, false, 1.0, true, "Ut ipsa quia cum commodi eos maiores illum. Et commodi itaque. Sint ex voluptas voluptatem soluta at ipsum dolor at et.", "id", "Laudantium impedit et omnis. Dolorem quo sit ullam. Eos vitae delectus ut. Qui quidem debitis nihil maiores.", "Beatae sint repellat unde quo. Esse quia quisquam omnis a nam occaecati aut nam sunt. Assumenda nesciunt qui illo. Perferendis mollitia rerum velit iusto quia quis est.", "Vero aut et repudiandae omnis quidem. Et sint dolor esse vel. Ullam qui incidunt veritatis. Optio expedita dolorem facere enim quis quas.", null, 2, new DateTime(2023, 10, 27, 10, 36, 22, 276, DateTimeKind.Local).AddTicks(2479), false, false, false, false, false, false, false },
                    { 94, "Ipsa provident et cupiditate debitis sunt porro blanditiis placeat. Officiis dolorum alias accusantium ex quia ut. Eveniet vel ipsum qui dolore praesentium. Et quibusdam ea non delectus exercitationem culpa deleniti. Eaque ut modi nisi inventore voluptatibus ipsum illum deleniti.", null, false, new DateTime(2024, 1, 28, 8, 35, 45, 996, DateTimeKind.Local).AddTicks(6286), "Lynn23@yahoo.com", "1-638-737-3026", "Lynn Russel", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 6, 10, 21, 10, 18, 423, DateTimeKind.Local).AddTicks(5496), 1, true, 1.0, false, "Consequatur itaque tempore. Ab et quas tempore molestiae. Est veniam ea voluptas modi exercitationem ipsam. Dolor quia exercitationem eos quia maiores qui tenetur velit vel. Facilis aliquid repudiandae est quis officiis porro quia magni voluptatum.", "dolorem", "Quia reprehenderit dolorum illum et fugiat est. Necessitatibus optio reprehenderit autem libero minus nobis qui aspernatur. Quia omnis veniam ad minus harum doloremque. Molestias quia amet qui et velit iure qui doloremque mollitia. Dolores optio perspiciatis tempora temporibus praesentium eius quaerat in. Voluptatibus iusto nemo autem.", "Ratione enim ut expedita maiores repellendus provident voluptas. Libero odio beatae voluptatibus voluptate vitae cumque. Doloribus delectus voluptates. Provident dolores vel excepturi autem blanditiis omnis. Id debitis architecto illo quod et ipsam.", "Pariatur ut neque eius quo sed voluptatem eos minima ipsum. Minima nisi voluptatem. Et sunt et est sunt qui.", null, 2, new DateTime(2023, 11, 5, 7, 28, 54, 822, DateTimeKind.Local).AddTicks(36), false, false, false, false, false, false, false },
                    { 95, "Commodi ut animi ex rerum aut ab. Quaerat inventore minima veniam. Velit vel et et et eum ratione.", null, false, new DateTime(2024, 1, 15, 9, 31, 2, 192, DateTimeKind.Local).AddTicks(9781), "Peggy14@hotmail.com", "1-496-269-7060 x48605", "Peggy Funk", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 2, 3, 20, 20, 43, 602, DateTimeKind.Local).AddTicks(5202), 1, true, 1.0, false, "Quisquam ut quaerat. Unde explicabo a dolores ducimus totam dolores dolorem eum. Velit omnis dolor repudiandae ut. Molestias praesentium assumenda at. Amet pariatur fugiat.", "quia", "Quibusdam laboriosam sit.\nAspernatur dicta sit tenetur dolor voluptas est consequatur.\nQuis quis odit libero.\nEos repudiandae quibusdam qui sint voluptatem sed voluptate voluptas commodi.\nConsequuntur autem dolor voluptas.", "Quos explicabo similique qui optio. Qui voluptatibus quod pariatur sapiente nihil facilis. Maxime neque quia non temporibus minima non qui sint.", "Et ut impedit ab reprehenderit dolorem quae dicta. Debitis perferendis aspernatur. Dignissimos sit ea animi est velit. Cumque velit perspiciatis et.", null, 2, new DateTime(2024, 2, 14, 18, 25, 28, 452, DateTimeKind.Local).AddTicks(6176), false, false, false, false, false, false, false },
                    { 96, "Est saepe aut rerum sunt id nesciunt earum fuga. Eos ut quos. Iusto adipisci libero voluptate iste in ullam deserunt dolorem. Tenetur deserunt sed incidunt eum voluptatem earum deleniti est facere.", null, false, new DateTime(2024, 5, 6, 17, 1, 49, 619, DateTimeKind.Local).AddTicks(4687), "Horace_Mitchell@gmail.com", "246-620-4893", "Horace Mitchell", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 12, 14, 5, 7, 35, 571, DateTimeKind.Local).AddTicks(1426), 1, true, 1.0, false, "Repellendus in beatae omnis placeat id asperiores iste explicabo. Voluptates consequatur quae facilis corrupti ipsa quis voluptates quas. Qui fugit asperiores dolores. Molestiae fugit commodi quia. Magni quod recusandae error velit explicabo. Omnis et optio mollitia est.", "ut", "nobis", "Amet omnis eveniet adipisci. Magnam maxime qui tempore culpa culpa in qui corrupti. Vel porro maxime ipsum et atque ut qui.", "Quaerat consequatur sed quia non repudiandae vel. Quod molestiae officia. Amet ut corrupti consectetur quam. Sint maxime sed fugiat quia delectus tempora amet. Sint minus nihil hic vel.", null, 2, new DateTime(2023, 8, 29, 21, 31, 46, 968, DateTimeKind.Local).AddTicks(3932), false, false, false, false, false, false, false },
                    { 97, "Ipsa qui quo aut. Illum quidem voluptatem. Eius aperiam doloribus est tempore a est assumenda. Quisquam totam vel in occaecati.", null, false, new DateTime(2023, 8, 4, 2, 43, 9, 626, DateTimeKind.Local).AddTicks(4908), "Vicky64@hotmail.com", "1-333-685-6976 x2111", "Vicky Blick", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2023, 12, 9, 6, 1, 23, 352, DateTimeKind.Local).AddTicks(6496), 1, false, 1.0, true, "Sed atque sed ut ut voluptas omnis excepturi quam impedit. Vitae fugit et. Adipisci tempora ut. Totam tempora minus quas. Maiores ea et commodi repellat molestiae rerum et dolores consequuntur.", "voluptates", "Sint in autem ad voluptatum tempora.", "Similique et id soluta enim qui et veniam ut et. Voluptatibus voluptatem ea voluptates est qui. Doloribus et asperiores hic doloribus quisquam impedit. Enim similique vero adipisci facere quas sed voluptatibus quam. Sit nobis qui voluptas non dolor ut rem. Ut sed iste quos id aut sapiente.", "Voluptates et nam perferendis aut excepturi ad eos nihil eaque. Aut dignissimos suscipit itaque sed dignissimos impedit repellendus voluptatem vero. Quae sint sed commodi.", null, 2, new DateTime(2023, 8, 18, 18, 10, 39, 595, DateTimeKind.Local).AddTicks(6792), false, false, false, false, false, false, false },
                    { 98, "Error amet dolores. Accusantium aspernatur sint atque quia aperiam. Est quas provident voluptas. Quia magnam ratione consequatur iure asperiores.", null, false, new DateTime(2023, 8, 9, 8, 57, 57, 67, DateTimeKind.Local).AddTicks(5293), "Andy13@gmail.com", "1-874-632-8808 x46374", "Andy Harber", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 1, 2, 19, 32, 38, 823, DateTimeKind.Local).AddTicks(9745), 1, false, 1.0, false, "Et et sed necessitatibus et ad fuga. Eius provident earum libero illo corrupti provident consequatur ut est. Inventore reiciendis consequatur cum quasi provident pariatur nobis.", "magnam", "Sunt aut iste a mollitia saepe fuga culpa. Velit enim reprehenderit ut officia ipsum voluptas quisquam porro. Distinctio id quia perferendis id quos possimus magni ex. Deserunt autem earum.", "Quis natus dolores non itaque rem quisquam quasi qui. Nihil et nihil deleniti commodi occaecati delectus provident. Nobis et dolore aspernatur. Totam voluptas omnis ut cupiditate aliquam eaque sit sint aspernatur. Laborum eum consectetur dolor. Itaque nam quas consequatur eveniet.", "Et asperiores provident. Voluptas voluptas amet hic consequuntur praesentium perspiciatis veritatis. Impedit qui unde. Laborum autem aspernatur id ut facere est. Placeat accusamus maxime quaerat quod minus illo deserunt temporibus. Ad doloribus et.", null, 2, new DateTime(2024, 5, 23, 13, 23, 39, 316, DateTimeKind.Local).AddTicks(1275), false, false, false, false, false, false, false },
                    { 99, "Fuga sit iste. Facere a expedita sapiente officiis qui velit. Enim dolores aut consequatur.", null, false, new DateTime(2023, 12, 10, 11, 28, 49, 757, DateTimeKind.Local).AddTicks(3969), "Francis_Berge90@yahoo.com", "437-510-9084 x33978", "Francis Berge", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 2, 22, 0, 46, 6, 941, DateTimeKind.Local).AddTicks(2385), 1, true, 1.0, false, "Est voluptatibus est ut. In et quidem illum aut ea occaecati qui impedit error. Ab nihil eveniet. Libero voluptas consequatur.", "esse", "ipsum", "Doloremque qui consequuntur reiciendis qui praesentium eum incidunt suscipit. Ut reiciendis omnis fugit eos. Id aliquid maxime cumque deserunt ut dicta dolor aut.", "Assumenda reiciendis ad eos omnis molestiae a. Ut cum vel temporibus recusandae debitis suscipit. Eligendi totam et nisi omnis cumque sequi consequatur. Nihil ducimus magnam autem dolores hic accusamus vel rerum.", null, 2, new DateTime(2023, 9, 16, 8, 42, 22, 333, DateTimeKind.Local).AddTicks(281), false, false, false, false, false, false, false },
                    { 100, "Ad nulla aut qui quod ex quo sint harum dolores. Ipsa alias qui expedita vitae laborum et quibusdam voluptate. Et ut officiis et temporibus. Illum deleniti sit provident eos rerum quasi.", null, false, new DateTime(2024, 4, 27, 10, 42, 46, 983, DateTimeKind.Local).AddTicks(8151), "Clara17@yahoo.com", "619-340-0015 x474", "Clara Dicki", 1, "c5001fdc-36ad-4846-99cf-cd4852e281eb", new DateTime(2024, 3, 16, 0, 44, 24, 82, DateTimeKind.Local).AddTicks(8220), 1, false, 1.0, true, "Porro porro commodi eius ea quia sed. Aut aut qui amet occaecati id nemo quibusdam voluptatem architecto. Facilis corporis consequatur architecto tenetur quod eveniet. Ducimus sapiente ut. Non aut quasi commodi.", "saepe", "Quia sunt deserunt.\nA ut molestiae exercitationem quod debitis id voluptas consequatur quas.\nMinima impedit rerum.\nDeleniti quas eos sunt maiores repudiandae.", "Dicta ducimus autem esse aliquam odio quasi reprehenderit iste quo. Sed maiores enim. Exercitationem sunt modi consequuntur nisi molestiae doloremque. Et magnam dolores aut quas eaque alias id architecto. Beatae nisi nulla. Laudantium deleniti ea quod fugit.", "Est cupiditate nihil dolorem ut voluptas sint. Temporibus laborum laudantium inventore expedita quisquam neque quia laboriosam. Aliquid omnis aut rerum sed et delectus. Non aut quod est animi ipsam molestias tempora delectus. Impedit recusandae animi velit atque voluptas veniam iure.", null, 2, new DateTime(2024, 6, 3, 16, 36, 46, 319, DateTimeKind.Local).AddTicks(6366), false, false, false, false, false, false, false }
                });

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
    }
}
