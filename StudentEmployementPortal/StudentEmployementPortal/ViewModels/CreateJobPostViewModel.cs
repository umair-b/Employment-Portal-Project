﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentEmployementPortal.ViewModels
{
    public class CreateJobPostViewModel
    {
        [Key]
        [HiddenInput]
        public int PostId { get; set; }

        public int? EmployerId { get; set; }

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
        public List<Faculty> FacultyList { get; set;  }
        public List<Department> DepartmentList { get; set; }
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
        [DataType(DataType.DateTime)]
        [Column(TypeName = "Date")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
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
        [DataType(DataType.DateTime)]
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
    }
}