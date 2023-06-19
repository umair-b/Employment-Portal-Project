using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Student
    {
        public string? CareerObjective { get; set; }

        public string? Skills { get; set; }

        public string? Achievements { get; set; }

        public string? Interests { get; set;}

        public bool Citizen { get; set; }

        //Education
        public ICollection<Education> Educations { get; set; }
        
        //Work Experience
        public ICollection<WorkExperience> WorkExperience { get; set; }

        //Referee
        public ICollection<Referee> Referee { get; set; }
        
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
