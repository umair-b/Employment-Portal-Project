using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        [Required]
        public string FacultyName { get; set; }
    }
}
