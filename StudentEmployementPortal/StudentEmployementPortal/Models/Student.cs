using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using StudentEmployementPortal.Models;
using static StudentEmployementPortal.Utils.Enums;

namespace StudentEmployementPortal.Models
{
    public class Student
    {
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
        public bool? Citizen { get; set; }

        //Education
        public IEnumerable<Education>? Education { get; set; }

        //Work Experience
        public IEnumerable<WorkExperience>? WorkExperience { get; set; }

        //Referee
        public IEnumerable<Referee>? Referee { get; set; }

        //Faculty
        public Faculty Faculty { get; set; }
        [ForeignKey(nameof(FacultyId))]
        [Display(Name = "Faculty")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int FacultyId { get; set; }

        //Department
        public Department Department { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [Display(Name = "Department")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int DepartmentId { get; set; }

        //License
        public DriversLicense License { get; set; }
        [ForeignKey(nameof(LicenseId))]
        [Display(Name = "Driving License")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int LicenseId { get; set; }

        //Race
        public Race Race { get; set; }
        [ForeignKey(nameof(RaceId))]
        [Display(Name = "Race")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int RaceId { get; set; }

        //Gender
        public Gender Gender { get; set; }
        [ForeignKey(nameof(GenderId))]
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int GenderId { get; set; }

        //Year of Study
        public YearOfStudy YearOfStudy { get; set; }
        [ForeignKey("YearOfStudyId")]
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "You are required to select an option.")]
        public int YearOfStudyId { get; set;}

        //Navigation Property 
        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public AppUser User { get; set; }

    }
}