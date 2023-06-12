﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEmployementPortal.Data;

#nullable disable

namespace StudentEmployementPortal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Accountancy",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Business Sciences",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Economics and Finance",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Law",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Wits Business School",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 6,
                            DepartmentName = "Wits School of Governance",
                            FacultyId = 1
                        },
                        new
                        {
                            DepartmentId = 7,
                            DepartmentName = "Architecture and Planning",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 8,
                            DepartmentName = "Civil & Environmental Engineering",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 9,
                            DepartmentName = "Chemical & Metallurgical Engineering",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 10,
                            DepartmentName = "Construction Economics & Management",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 11,
                            DepartmentName = "Electrical & Information Engineeringg",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 12,
                            DepartmentName = "Mechanical, Industrial & Aeronautical Engineering",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 13,
                            DepartmentName = "Mining Engineering",
                            FacultyId = 2
                        },
                        new
                        {
                            DepartmentId = 14,
                            DepartmentName = "Anatomical Sciences",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 15,
                            DepartmentName = "Clinical Medicine",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 16,
                            DepartmentName = "Oral Health Sciences",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 17,
                            DepartmentName = "Pathology",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 18,
                            DepartmentName = "Physiology",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 19,
                            DepartmentName = "Public Health",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 20,
                            DepartmentName = "Therapeutic Sciences",
                            FacultyId = 3
                        },
                        new
                        {
                            DepartmentId = 21,
                            DepartmentName = "Wits School of Arts",
                            FacultyId = 4
                        },
                        new
                        {
                            DepartmentId = 22,
                            DepartmentName = "Wits School of Education",
                            FacultyId = 4
                        },
                        new
                        {
                            DepartmentId = 23,
                            DepartmentName = "Human and Community Development",
                            FacultyId = 4
                        },
                        new
                        {
                            DepartmentId = 24,
                            DepartmentName = "Literature, Language and Media",
                            FacultyId = 4
                        },
                        new
                        {
                            DepartmentId = 25,
                            DepartmentName = "Social Sciences",
                            FacultyId = 4
                        },
                        new
                        {
                            DepartmentId = 26,
                            DepartmentName = "Animal, Plant and Environmental Sciences",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 27,
                            DepartmentName = "Chemistry",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 28,
                            DepartmentName = "Computer Science and Applied Mathematics",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 29,
                            DepartmentName = "Geography, Archaeology and Environmental Sciences",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 30,
                            DepartmentName = "Geosciences",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 31,
                            DepartmentName = "Mathematics",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 32,
                            DepartmentName = "Molecular and Cell Biology",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 33,
                            DepartmentName = "Physics",
                            FacultyId = 5
                        },
                        new
                        {
                            DepartmentId = 34,
                            DepartmentName = "Statistics and Actuarial Science",
                            FacultyId = 5
                        });
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacultyId"));

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            FacultyId = 1,
                            FacultyName = "Faculty of Commerce, Law and Management"
                        },
                        new
                        {
                            FacultyId = 2,
                            FacultyName = "Faculty of Engineering and the Built Environment"
                        },
                        new
                        {
                            FacultyId = 3,
                            FacultyName = "Faculty of Health Sciences"
                        },
                        new
                        {
                            FacultyId = 4,
                            FacultyName = "Faculty of Humanities"
                        },
                        new
                        {
                            FacultyId = 5,
                            FacultyName = "Faculty of Science"
                        });
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.JobPost", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("ApplicationInstructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApproverNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CitizensOnly")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("Date");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<bool>("FullTime")
                        .HasColumnType("bit");

                    b.Property<double>("HourlyRate")
                        .HasColumnType("float");

                    b.Property<bool>("Internal")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyResponsibilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartTimeHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<bool>("limitedToDepartment")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToFaculty")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToFirst")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToHonours")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToMasters")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToPhD")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToPostDoc")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToSecond")
                        .HasColumnType("bit");

                    b.Property<bool>("limitedToThird")
                        .HasColumnType("bit");

                    b.HasKey("PostId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Majors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QualificationId")
                        .HasColumnType("int");

                    b.Property<string>("QualificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Research")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Submajors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefereesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("Employer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TasksAndResps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkExperienceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkExperience");
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentEmployementPortal.Models.JobPost", b =>
                {
                    b.HasOne("StudentEmployementPortal.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StudentEmployementPortal.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Faculty");
                });
#pragma warning restore 612, 618
        }
    }
}
