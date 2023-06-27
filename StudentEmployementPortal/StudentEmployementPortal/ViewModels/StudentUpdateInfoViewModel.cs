using StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.ViewModels
{
    public class StudentUpdateInfoViewModel
    {
        //AppUser properties
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Cellphone Number")]
        public string CellNumber { get; set; }
        [DisplayName("Telephone Number")]
        public string TelNumber { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }

        //Student Properties
        [DisplayName("ID/Passport Number")]
        public string StudentIdNumber { get; set; }
        [DisplayName("Career Objective")]
        public string? CareerObjective { get; set; }
        [DisplayName("Skills")]
        public string? Skills { get; set; }
        [DisplayName("Achievements")]
        public string? Achievements { get; set; }
        [DisplayName("Interests")]
        public string? Interests { get; set; }
        [DisplayName("Are you a South African Citizen?")]
        public bool Citizen { get; set; }

        //Education
        public IEnumerable<Education> Education { get; set; }

        //Work Experience
        public IEnumerable<WorkExperience> WorkExperience { get; set; }

        //Referee
        public IEnumerable<Referee> Referee { get; set; }

        //Faculty
        public Faculty Faculty { get; set; }
        [ForeignKey(nameof(FacultyId))]
        public int FacultyId { get; set; }
        public IEnumerable<Faculty> FacultyList { get; set; }

        //Department
        public Department Department { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public int DepartmentId { get; set; }
        public IEnumerable<Department> DepartmentList { get; set; }

        //License
        public DriversLicense License { get; set; }
        [ForeignKey(nameof(LicenseId))]
        public int LicenseId { get; set; }
        public IEnumerable<DriversLicense> LicenseList { get; set; }

        //Race
        public Race Race { get; set; }
        [ForeignKey(nameof(RaceId))]
        public int RaceId { get; set; }
        public IEnumerable<Race> RaceList { get; set; }

        //Gender
        public Gender Gender { get; set; }
        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }
        public IEnumerable<Gender> GenderList { get; set; }

        //Year of Study
        public YearOfStudy YearOfStudy { get; set; }
        [ForeignKey(nameof(YearOfStudyId))]
        public int YearOfStudyId { get; set; }
        public IEnumerable<YearOfStudy> YearOfStudyList { get; set; }


    }
}
