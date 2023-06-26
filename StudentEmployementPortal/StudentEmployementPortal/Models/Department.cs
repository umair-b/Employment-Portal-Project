using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Department
    {
        internal object FullName { get; set; }

        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public int FacultyId { get; set; }
    }
}
