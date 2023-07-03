using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.TestData;
using System;
using static StudentEmployementPortal.Utils.Enums;

namespace StudentEmployementPortal.Data
{
    public class AppDbContext : IdentityDbContext
    {
        private readonly Fakers _fakers;

        public AppDbContext(DbContextOptions<AppDbContext> options, Fakers fakers) : base(options)
        {
            _fakers = fakers;
        }

        public DbSet<Application> Application { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        //public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<Referee> Referees { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<DriversLicense> Licences { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Race> Races { get; set; }

        public DbSet<YearOfStudy> YearOfStudies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<JobPost>()
            .HasOne(j => j.Department)
            .WithMany()
            .HasForeignKey(j => j.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobPost>()
            .HasOne(j => j.Faculty)
            .WithMany()
            .HasForeignKey(j => j.FacultyId)
            .OnDelete(DeleteBehavior.Restrict);*/

            modelBuilder.Entity<YearOfStudy>().HasData(
                new YearOfStudy { YearOfStudyId = 1, YearOfStudyName="First Year"},
                new YearOfStudy { YearOfStudyId = 2, YearOfStudyName = "Second Year"},
                new YearOfStudy { YearOfStudyId = 3, YearOfStudyName = "Third Year"},
                new YearOfStudy { YearOfStudyId = 4, YearOfStudyName = "Honours"},
                new YearOfStudy { YearOfStudyId = 5, YearOfStudyName = "Masters"},
                new YearOfStudy { YearOfStudyId = 6, YearOfStudyName = "PhD"},
                new YearOfStudy { YearOfStudyId = 7, YearOfStudyName = "PostDoc"}
                );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { GenderId = 1, GenderName = "Male" },
                new Gender { GenderId = 2, GenderName = "Female" },
                new Gender { GenderId = 3, GenderName = "Non-binary" },
                new Gender { GenderId = 4, GenderName = "Other" },
                new Gender { GenderId = 5, GenderName = "Prefer not to say." }
                );

            modelBuilder.Entity<Race>().HasData(
                new Race { RaceId = 1, RaceName = "Black" },
                new Race { RaceId = 2, RaceName = "White" },
                new Race { RaceId = 3, RaceName = "Coloured" },
                new Race { RaceId = 4, RaceName = "Indian" },
                new Race { RaceId = 5, RaceName = "Other" }
                );

            modelBuilder.Entity<DriversLicense>().HasData(
                new DriversLicense { LicenseId = 1, LicenceName = "Code A1 driver's license" },
                new DriversLicense { LicenseId = 2, LicenceName = "Code A driver's license" },
                new DriversLicense { LicenseId = 3, LicenceName = "Code B driver's license" },
                new DriversLicense { LicenseId = 4, LicenceName = "Code B5 driver's license" },
                new DriversLicense { LicenseId = 5, LicenceName = "Code B7 driver's license" },
                new DriversLicense { LicenseId = 6, LicenceName = "Code C driver's license" },
                new DriversLicense { LicenseId = 7, LicenceName = "Code C1 driver's license" },
                new DriversLicense { LicenseId = 8, LicenceName = "Code EB driver's license" },
                new DriversLicense { LicenseId = 9, LicenceName = "Code EC driver's license" },
                new DriversLicense { LicenseId = 10, LicenceName = "Code EC1 driver's license" },
                new DriversLicense { LicenseId = 11, LicenceName = "Code EC1-8 driver's license" },
                new DriversLicense { LicenseId = 12, LicenceName = "None" }
                );



            modelBuilder.Entity<Employer>()
                .Ignore(e => e.EmployerBusinessTypes)
                .Ignore(e => e.EmployerTitles)
            .Ignore(e => e.EmployerStatuses);
            modelBuilder.Entity<BusinessType>().HasData(
                new BusinessType { BusinessTypeId = 1, Name = "Sole Proprietorship" },
                new BusinessType { BusinessTypeId = 2, Name = "Partnership" },
                new BusinessType { BusinessTypeId = 3, Name = "Private Limited Company (Pty Ltd)" },
                new BusinessType { BusinessTypeId = 4, Name = "Public Limited Company (Ltd)" },
                new BusinessType { BusinessTypeId = 5, Name = "Close Corporation (CC)" },
                new BusinessType { BusinessTypeId = 6, Name = "Nonprofit Organization (NPO)" },
                new BusinessType { BusinessTypeId = 7, Name = "State Owned Entity (SOE)" },
                new BusinessType { BusinessTypeId = 8, Name = "Other" }
                );

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { FacultyId = 1, FacultyName = "Faculty of Commerce, Law and Management" },
                new Faculty { FacultyId = 2, FacultyName = "Faculty of Engineering and the Built Environment" },
                new Faculty { FacultyId = 3, FacultyName = "Faculty of Health Sciences" },
                new Faculty { FacultyId = 4, FacultyName = "Faculty of Humanities" },
                new Faculty { FacultyId = 5, FacultyName = "Faculty of Science" }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Accountancy", FacultyId = 1 },
                new Department { DepartmentId = 2, DepartmentName = "Business Sciences", FacultyId = 1 },
                new Department { DepartmentId = 3, DepartmentName = "Economics and Finance", FacultyId = 1 },
                new Department { DepartmentId = 4, DepartmentName = "Law", FacultyId = 1 },
                new Department { DepartmentId = 5, DepartmentName = "Wits Business School", FacultyId = 1 },
                new Department { DepartmentId = 6, DepartmentName = "Wits School of Governance", FacultyId = 1 },

                new Department { DepartmentId = 7, DepartmentName = "Architecture and Planning", FacultyId = 2 },
                new Department { DepartmentId = 8, DepartmentName = "Civil & Environmental Engineering", FacultyId = 2 },
                new Department { DepartmentId = 9, DepartmentName = "Chemical & Metallurgical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 10, DepartmentName = "Construction Economics & Management", FacultyId = 2 },
                new Department { DepartmentId = 11, DepartmentName = "Electrical & Information Engineeringg", FacultyId = 2 },
                new Department { DepartmentId = 12, DepartmentName = "Mechanical, Industrial & Aeronautical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 13, DepartmentName = "Mining Engineering", FacultyId = 2 },

                new Department { DepartmentId = 14, DepartmentName = "Anatomical Sciences", FacultyId = 3 },
                new Department { DepartmentId = 15, DepartmentName = "Clinical Medicine", FacultyId = 3 },
                new Department { DepartmentId = 16, DepartmentName = "Oral Health Sciences", FacultyId = 3 },
                new Department { DepartmentId = 17, DepartmentName = "Pathology", FacultyId = 3 },
                new Department { DepartmentId = 18, DepartmentName = "Physiology", FacultyId = 3 },
                new Department { DepartmentId = 19, DepartmentName = "Public Health", FacultyId = 3 },
                new Department { DepartmentId = 20, DepartmentName = "Therapeutic Sciences", FacultyId = 3 },

                new Department { DepartmentId = 21, DepartmentName = "Wits School of Arts", FacultyId = 4 },
                new Department { DepartmentId = 22, DepartmentName = "Wits School of Education", FacultyId = 4 },
                new Department { DepartmentId = 23, DepartmentName = "Human and Community Development", FacultyId = 4 },
                new Department { DepartmentId = 24, DepartmentName = "Literature, Language and Media", FacultyId = 4 },
                new Department { DepartmentId = 25, DepartmentName = "Social Sciences", FacultyId = 4 },

                new Department { DepartmentId = 26, DepartmentName = "Animal, Plant and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 27, DepartmentName = "Chemistry", FacultyId = 5 },
                new Department { DepartmentId = 28, DepartmentName = "Computer Science and Applied Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 29, DepartmentName = "Geography, Archaeology and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 30, DepartmentName = "Geosciences", FacultyId = 5 },
                new Department { DepartmentId = 31, DepartmentName = "Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 32, DepartmentName = "Molecular and Cell Biology", FacultyId = 5 },
                new Department { DepartmentId = 33, DepartmentName = "Physics", FacultyId = 5 },
                new Department { DepartmentId = 34, DepartmentName = "Statistics and Actuarial Science", FacultyId = 5 }
            );

            /*var posts = _fakers.GetPostGenerator().Generate(50);

            modelBuilder.Entity<JobPost>()
                .HasData(posts);*/
        }
    }
}