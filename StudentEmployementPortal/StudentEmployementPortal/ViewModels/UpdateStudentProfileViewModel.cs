using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.ViewModels
{
    public class UpdateStudentProfileViewModel
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string Address { get; set; }
        public string StudentTel { get; set; }
        public string StudentCel { get; set; }
        public string StudentEmail { get; set; }
        public string IdentityNumber { get; set; }
        public string DriversLicense { get; set; }
        public string CareerObjective { get; set; }
        public Enums.Gender? Gender { get; set; }
        public Enums.Race? Race { get; set; }
        public bool Citizen { get; set; }
        public string Nationality { get; set; }
        public string YearOfStudy { get; set; }

        [ForeignKey(nameof(Faculty))]
        public int FacultyId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public IEnumerable<Faculty> FacultyList { get; set; }
        public IEnumerable<Department> DepartmentList { get; set; }
        /*public string Skills { get; set; }

        public string Achievements { get; set; }

        public string Interests { get; set; }*/
        
    }
}
