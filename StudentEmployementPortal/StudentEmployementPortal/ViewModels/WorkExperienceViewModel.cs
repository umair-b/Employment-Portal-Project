using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentEmployementPortal.ViewModels
{
    public class WorkExperienceViewModel
    {
        [Key]
        public int WorkExperienceId { get; set; }

        [DisplayName("Employer Name")]
        [Required]
        public string EmployerName { get; set; }

        [DisplayName("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date (Leave blank if not applicable")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Job Title")]
        [Required]
        public string JobTitle { get; set; }

        [DisplayName("Tasks and Responsibilities")]
        [Required]
        public string TasksAndResponsibilities { get; set; }
    }
}
