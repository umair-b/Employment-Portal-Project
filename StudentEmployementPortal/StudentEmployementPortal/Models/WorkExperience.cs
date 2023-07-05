using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class WorkExperience
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


        //Navigation Propperty
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public Student Student { get; set; }

    }
}
