
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

        [DisplayName("1st Years")]
        public bool limitedToFirst { get; set; }
        [DisplayName("2nd Years")]
        public bool limitedToSecond { get; set; }
        [DisplayName("3rd Years")]
        public bool limitedToThird { get; set; }
        [DisplayName("Honours")]
        public bool limitedToHonours { get; set; }
        [DisplayName("Masters")]
        public bool limitedToMasters { get; set; }
        [DisplayName("PhD")]
        public bool limitedToPhD { get; set; }
        [DisplayName("PostDoc")]
        public bool limitedToPostDoc { get; set; }
        [DisplayName("Department")]
        public bool limitedToDepartment { get; set; }
        [DisplayName("Faculty")]
        public bool limitedToFaculty { get; set; }

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

    }
}
