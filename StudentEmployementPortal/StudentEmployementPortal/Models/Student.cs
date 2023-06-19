using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentEmployementPortal.Models
{
    public class Student
    {

        [DisplayName("Career Objective")]
        public string? CareerObjective { get; set; }
        [DisplayName("Skills")]
        public string? Skills { get; set; }
        [DisplayName("Achievements")]
        public string? Achievements { get; set; }
        [DisplayName("Interests")]
        public string? Interests { get; set;}
        [DisplayName("Are you a South African Citizen?")]
        public bool Citizen { get; set; }

        //Education
        public IEnumerable<Education> Educations { get; set; }
        
        //Work Experience
        public IEnumerable<WorkExperience> WorkExperience { get; set; }

        //Referee
        public IEnumerable<Referee> Referee { get; set; }
        
        //Faculty
        public Faculty faculty { get; set; }
        [ForeignKey(nameof(FacultyId))]
        public int FacultyId { get; set; }

        //Department
        public Department department { get; set; }
        [ForeignKey(nameof (DepartmentId))]
        public int DepartmentId { get; set; }

        //License
        public License license { get; set; }
        [ForeignKey(nameof(LicenseId))]
        public int LicenseId { get; set; }

        //Race
        public Race race { get; set; }
        [ForeignKey(nameof(RaceId))]
        public int RaceId { get; set; }

        //Gender
        public Gender gender { get; set; }
        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }

        //Navigation Property 
        [Key]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public AppUser User { get; set; }

    }
}
