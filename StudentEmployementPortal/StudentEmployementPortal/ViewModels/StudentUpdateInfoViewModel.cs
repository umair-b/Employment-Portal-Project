using StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public bool? Citizen { get; set; } = null;

        //Education
        public IEnumerable<Education> Education { get; set; }

        //Work Experience
        public IEnumerable<WorkExperience> WorkExperience { get; set; }

        //Referee
        public IEnumerable<Referee> Referee { get; set; }

        //Faculty
        [Display(Name = "Faculty")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int FacultyId { get; set; }
        public IEnumerable<Faculty> FacultyList { get; set; }

        //Department
        [Display(Name = "Department")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int DepartmentId { get; set; }
        public IEnumerable<Department> DepartmentList { get; set; }

        //License
        [Display(Name = "Driving License")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int LicenseId { get; set; }
        public IEnumerable<DriversLicense> LicenseList { get; set; }

        //Race
        [Display(Name = "Race")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int RaceId { get; set; }
        public IEnumerable<Race> RaceList { get; set; }

        //Gender
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int GenderId { get; set; }
        public IEnumerable<Gender> GenderList { get; set; }

        //Year of Study
        [Display(Name = "Current Year of Study")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int YearOfStudyId { get; set; }
        public IEnumerable<YearOfStudy> YearOfStudyList { get; set; }


    }
}
