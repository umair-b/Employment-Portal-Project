using StudentEmployementPortal.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.ViewModels
{
    public class CreateStudentProfile
    {
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string CareerObjective { get; set; }

        [ForeignKey(nameof(Faculty))]
        public int FacultyId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public string Skills { get; set; }

        public string Achievements { get; set; }

        public string Interests { get; set; }

        public bool Citizen { get; set; }
        public string Nationality { get; set; }
        public string DriversLicense { get; set; }
        public string YearOfStudy { get; set; }
    }
}
