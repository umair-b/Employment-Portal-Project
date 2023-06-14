using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;

namespace StudentEmployementPortal.ViewModels
{
    
    public class UpdateJobPostViewModel
    {
        [Key]
        [HiddenInput]
        public int PostId { get; set; }

        public int? EmployerId { get; set; }

        [Required]
        [Display(Name = "Internal")]
        public bool? Internal { get; set; }

        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }
        
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public IEnumerable<Faculty>? FacultyList { get; set; }
        public IEnumerable<Department>? DepartmentList { get; set; }  

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }

        [Required]
        [Display(Name = "Job Location")]
        public string JobLocation { get; set; }

        [Required]
        [Display(Name = "Key Responsibilities")]
        public string KeyResponsibilities { get; set; }
        [Required]
        [Display(Name = "Fulltime")]
        public bool? FullTime { get; set; }

        [Display(Name = "Part-Time Hours")]
        public string? PartTimeHours { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "Hourly Rate")]
        [Range(0, double.MaxValue, ErrorMessage = "The {0} field must be a positive number.")]
        public double? HourlyRate { get; set; }

        [Display(Name = "1st Years")]
        public bool limitedToFirst { get; set; }
        [Display(Name = "2nd Years")]
        public bool limitedToSecond { get; set; }
        [Display(Name = "3rd Years")]
        public bool limitedToThird { get; set; }
        [Display(Name = "Honours")]
        public bool limitedToHonours { get; set; }
        [Display(Name = "Masters")]
        public bool limitedToMasters { get; set; }
        [Display(Name = "PhD")]
        public bool limitedToPhD { get; set; }
        [Display(Name = "PostDoc")]
        public bool limitedToPostDoc { get; set; }
        [Display(Name = "Department")]
        public bool limitedToDepartment { get; set; }
        [Display(Name = "Faculty")]
        public bool limitedToFaculty { get; set; }

        [Required]
        [Display(Name = "Limited to Citizens")]
        public bool? CitizensOnly { get; set; }

        [Required]
        [Display(Name = "Minimum Requirements")]
        public string MinRequirements { get; set; }

        [Required]
        [Display(Name = "Application Instructions")]
        public string ApplicationInstructions { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        [Display(Name = "Closing Date")]
        public DateTime? ClosingDate { get; set; }

        [Required]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Approver's Note")]
        public string? ApproverNote { get; set; }
    }
}
