using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }
        public int WorkExperienceId { get; set; }
        public string Employer { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public string JobTitle { get; set; }
        public string TasksAndResps { get; set; }
    }
}
