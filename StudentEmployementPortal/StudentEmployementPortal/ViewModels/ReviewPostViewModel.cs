using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using StudentEmployementPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;

namespace StudentEmployementPortal.ViewModels
{
    public class ReviewPostViewModel
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
        public string KeyResponsibilities { get; set; }
        [Required]
        [DisplayName("Fulltime")]
        public bool FullTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [DisplayName("Hourly Rate")]
        [Range(0, double.MaxValue, ErrorMessage = "The {0} field must be a positive number.")]
        public double HourlyRate { get; set; }

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
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayName("Closing Date")]
        public DateTime ClosingDate { get; set; }

        [Required]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        [Required]
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [DisplayName("Contact " +
            "Email")]
        public string ContactEmail { get; set; }

        public Enums.JobPostStatus SelectedStatus { get; set; } = Enums.JobPostStatus.Pending;

        public List<SelectListItem> StatusNames { get; set; }

        public string? ApproverNote { get; set; }

    }
}
