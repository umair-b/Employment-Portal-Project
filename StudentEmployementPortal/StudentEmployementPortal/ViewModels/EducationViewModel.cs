using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentEmployementPortal.ViewModels
{
    public class EducationViewModel
    {
        [Key]
        public int EducationId { get; set; }
        [DisplayName("Institution Name")]
        [Required]
        public string Institution { get; set; }
        [DisplayName("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date (Leave blank if not applicable)")]
        public DateTime? EndDate { get; set; }
        [DisplayName("Qualification")]
        [Required]
        public string Qualification { get; set; }
        [DisplayName("Subjects")]
        public string? Subjects { get; set; }
        [DisplayName("Majors")]
        public string? Majors { get; set; }
        [DisplayName("Sub-majors")]
        public string? SubMajors { get; set; }
        [DisplayName("Research")]
        public string? Research { get; set; }
    }
}
