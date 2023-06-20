using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.ViewModels
{
    public class UpdateStudentProfileViewModel
    {
        [Key]
        public int StudentId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string StudentFirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string StudentLastName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "Telephone (optional)")]
        public string StudentTel { get; set; }
        [Display(Name = "Cellphone")]
        [Required]
        public string StudentCel { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string StudentEmail { get; set; }
        [Display(Name = "ID/Passport No (optional)")]
        public string IdentityNumber { get; set; }
        [Display(Name = "Driver's License")]
        [Required]
        public string DriversLicense { get; set; }
        [Display(Name = "Career Objective")]
        [Required]
        public string CareerObjective { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public Enums.Gender Gender { get; set; }
        [Display(Name = "Race")]
        [Required]
        public Enums.Race Race { get; set; }
        [Display(Name = "South African Citizen?")]
        [Required]
        public bool Citizen { get; set; }
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Display(Name = "Current Year of Study")]
        [Required]
        public string YearOfStudy { get; set; }

        [Display(Name = "Faculty")]
        [Required]
        public int FacultyId { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Required]
        public IEnumerable<Faculty> FacultyList { get; set; }
        public IEnumerable<Department> DepartmentList { get; set; }

        public IEnumerable<SelectListItem> Genderlist = Enums.GetEnumList<Enums.Gender>();
        public IEnumerable<SelectListItem> RaceLList = Enums.GetEnumList<Enums.Race>();
        /*public string Skills { get; set; }

        public string Achievements { get; set; }

        public string Interests { get; set; }*/
        
    }
}
