
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class JobPost
    {
        [Key]
        public int PostId { get; set; }
        public int? EmployerId { get; set; }
        [Required]
        [DisplayName("Internal")]
        public bool Internal { get; set; }
        public string? Faculty { get; set; } = string.Empty;
        public string? Department { get; set; } = string.Empty;
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
        [Required]
        [DisplayName("Job Location")]
        public string JobLocation { get; set; }
        [Required]
        [DisplayName("Key Responsibilities")]
        public string KeyResponsibilities {get; set; }
        [Required]
        [DisplayName("Fulltime")]
        public bool FullTime { get; set; }
        [Required]
        [Column(TypeName ="DateTime")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [DisplayName("Hourly Rate")]
        public string HourlyRate { get; set; }

        
        [DisplayName("Limited to: ")]
        //public string LimitedTo { get; set; }
        public Level LimitedTo { get; set; }

        [Required]
        [DisplayName("Limited to Citizens")]
        public bool CitizensOnly { get; set; }
        [Required]
        [DisplayName("Minimum Requirements")]
        public string MinRequirements { get; set; }
        [Required]
        [DisplayName("Application Instructions")]
        public string ApplicationInstructions { get; set; }
        [Required]
        [DisplayName("Closing Date")]
        public DateTime ClosingDate { get; set; }
        [Required]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }
        [Required]
        [DisplayName("Contact Email")]
        public string ContactEmail { get; set; }

        public Status PostStatus { get; set; } = Status.Pending;

        public string? ApproverNote { get; set; }

        
        public enum Status
        {
            Approved,
            Rejected,
            Pending,
            Withdraw
        }

        public enum Level
        {
            FirstYear,
            SecondYear,
            ThirdYear,
            Honours,
            Masters,
            PhD,
            Postdoc,
            /*Faculty,
            Department*/
        }
    }


}
