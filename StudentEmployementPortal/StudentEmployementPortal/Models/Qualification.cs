using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }
        public int QualificationId { get; set; }
        public string Institution { get; set; }
        public string QualificationType { get; set; }
        public string Majors { get; set; }
        public string Submajors { get; set; }
        public string Research { get; set; }
    }
}
