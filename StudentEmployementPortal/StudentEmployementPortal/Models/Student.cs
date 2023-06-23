using StudentEmployementPortal.Utils;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string DriversLicense { get; set; }
        public string CareerObjective { get; set; }
        public Enums.Gender Gender { get; set; } = Enums.Gender.Male;
        public Enums.Race Race { get; set; } = Enums.Race.Other;
        public string Nationality { get; set; }
        public string YearOfStudy { get; set; }

        [ForeignKey(nameof(Faculty))]
        public int FacultyId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Faculty Faculty { get; set; }
        public Department Department { get; set; }
        public AppUser User { get; set; }
        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }
        //public DriversLicence StudentLicence { get; set; }
        //public Nationality StudentNationality { get; set; }
        //public Race StudentRace { get; set; }
        //public Gender StudentGender { get; set; }
        //public YearOfStudy StudentYos { get; set; }

    }
}
