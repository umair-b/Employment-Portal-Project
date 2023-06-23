using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using StudentEmployementPortal.Models;

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
        public string? Interests { get; set;}
        [DisplayName("Are you a South African Citizen?")]
        public bool Citizen { get; set; }

        //Year of Study
        /*[DisplayName("1st Years")]
        public bool limitedToFirst { get; set; }
        [DisplayName("2nd Years")]
        public bool limitedToSecond { get; set; }
        [DisplayName("3rd Years")]
        public bool limitedToThird { get; set; }
        [DisplayName("Honours")]
        public bool limitedToHonours { get; set; }
        [DisplayName("Masters")]
        public bool limitedToMasters { get; set; }
        [DisplayName("PhD")]
        public bool limitedToPhD { get; set; }
        [DisplayName("PostDoc")]
        public bool limitedToPostDoc { get; set; }
        [DisplayName("Department")]
        public bool limitedToDepartment { get; set; }
        [DisplayName("Faculty")]
        public bool limitedToFaculty { get; set; }*/

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

        //Department
        public Department Department { get; set; }
        [ForeignKey(nameof (DepartmentId))]
        public int DepartmentId { get; set; }

        //License
        public DriversLicense License { get; set; }
        [ForeignKey(nameof(LicenseId))]
        public int LicenseId { get; set; }

        //Race
        public Race Race { get; set; }
        [ForeignKey(nameof(RaceId))]
        public int RaceId { get; set; }

        //Gender
        public Gender Gender { get; set; }
        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }

        //Navigation Property 
        [Key]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public AppUser User { get; set; }

    }
}
