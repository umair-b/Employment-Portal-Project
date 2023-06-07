using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentEmployementPortal.ViewModels
{
    public class UpdateJobPostViewModel
    {
        [Key]
        [HiddenInput]
        public int PostId { get; set; }

        [Required]
        [DisplayName("Internal")]
        public bool Internal { get; set; }
        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }
        //public Faculty Faculty { get; set; }
        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        //public Department Department { get; set; }
        /*public List<Faculty> FacultyList { get; set; } = new List<Faculty>();
        public List<Department> DepartmentList { get; set; } = new List<Department>();*/
        public List<Faculty> FacultyList { get; set; } = new List<Faculty>()
        {
            new Faculty { FacultyId = 1, FacultyName = "Faculty of Commerce, Law and Management" },
            new Faculty { FacultyId = 2, FacultyName = "Faculty of Engineering and the Built Environment" },
            new Faculty { FacultyId = 3, FacultyName = "Faculty of Health Sciences" },
            new Faculty { FacultyId = 4, FacultyName = "Faculty of Humanities" },
            new Faculty { FacultyId = 5, FacultyName = "Faculty of Science" }
        };
        public List<Department> DepartmentList { get; set; } = new List<Department>()
        {
            new Department { DepartmentId = 1, DepartmentName = "Accountancy", FacultyId = 1 },
                new Department { DepartmentId = 2, DepartmentName = "Business Sciences", FacultyId = 1 },
                new Department { DepartmentId = 3, DepartmentName = "Economics and Finance", FacultyId = 1 },
                new Department { DepartmentId = 4, DepartmentName = "Law", FacultyId = 1 },
                new Department { DepartmentId = 5, DepartmentName = "Wits Business School", FacultyId = 1 },
                new Department { DepartmentId = 6, DepartmentName = "Wits School of Governance", FacultyId = 1 },

                new Department { DepartmentId = 7, DepartmentName = "Architecture and Planning", FacultyId = 2 },
                new Department { DepartmentId = 8, DepartmentName = "Civil & Environmental Engineering", FacultyId = 2 },
                new Department { DepartmentId = 9, DepartmentName = "Chemical & Metallurgical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 10, DepartmentName = "Construction Economics & Management", FacultyId = 2 },
                new Department { DepartmentId = 11, DepartmentName = "Electrical & Information Engineeringg", FacultyId = 2 },
                new Department { DepartmentId = 12, DepartmentName = "Mechanical, Industrial & Aeronautical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 13, DepartmentName = "Mining Engineering", FacultyId = 2 },

                new Department { DepartmentId = 14, DepartmentName = "Anatomical Sciences", FacultyId = 3 },
                new Department { DepartmentId = 15, DepartmentName = "Clinical Medicine", FacultyId = 3 },
                new Department { DepartmentId = 16, DepartmentName = "Oral Health Sciences", FacultyId = 3 },
                new Department { DepartmentId = 17, DepartmentName = "Pathology", FacultyId = 3 },
                new Department { DepartmentId = 18, DepartmentName = "Physiology", FacultyId = 3 },
                new Department { DepartmentId = 19, DepartmentName = "Public Health", FacultyId = 3 },
                new Department { DepartmentId = 20, DepartmentName = "Therapeutic Sciences", FacultyId = 3 },

                new Department { DepartmentId = 21, DepartmentName = "Wits School of Arts", FacultyId = 4 },
                new Department { DepartmentId = 22, DepartmentName = "Wits School of Education", FacultyId = 4 },
                new Department { DepartmentId = 23, DepartmentName = "Human and Community Development", FacultyId = 4 },
                new Department { DepartmentId = 24, DepartmentName = "Literature, Language and Media", FacultyId = 4 },
                new Department { DepartmentId = 25, DepartmentName = "Social Sciences", FacultyId = 4 },

                new Department { DepartmentId = 26, DepartmentName = "Animal, Plant and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 27, DepartmentName = "Chemistry", FacultyId = 5 },
                new Department { DepartmentId = 28, DepartmentName = "Computer Science and Applied Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 29, DepartmentName = "Geography, Archaeology and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 30, DepartmentName = "Geosciences", FacultyId = 5 },
                new Department { DepartmentId = 31, DepartmentName = "Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 32, DepartmentName = "Molecular and Cell Biology", FacultyId = 5 },
                new Department { DepartmentId = 33, DepartmentName = "Physics", FacultyId = 5 },
                new Department { DepartmentId = 34, DepartmentName = "Statistics and Actuarial Science", FacultyId = 5 }
        };

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
        public string PartTimeHours { get; set; }

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
        [DisplayName("Contact Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Approver's Note")]
        public string? ApproverNote { get; set; }
    }
}
