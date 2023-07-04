using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.ViewModels
{
    public class EmployerUpdateInfoViewModel
    {
        //Employer Properties
        [Display(Name = "Job Title")]
        [Required]
        public string JobTitle { get; set; }
        [Display(Name = "Registration Number")]
        [Required]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Registration Name")]
        [Required]
        public string RegistrationName { get; set; }
        [Display(Name = "Trading Name ")]
        [Required]
        public string TradingName { get; set; }
        [Display(Name = "Registered Address")]
        [Required]
        public string RegisteredAddress { get; set; }
        [Display(Name = "I confirm that the information provided above is true to the best of my knowledge ")]
        public bool TrueInfo { get; set; } = false;

        //Employer Title
        [Display(Name = "Title")]
        [Required]
        public Title EmployerTitle { get; set; }

        [ForeignKey(nameof(TitleId))]
        [Display(Name = "Title")]
        public int TitleId { get; set; }
        public IEnumerable<Title> TitleList { get; set; }

        //Employer Business Type
        [Display(Name = "Business Type")]
        [Required]
        public BusinessType EmployerBusinessType { get; set; }

        [ForeignKey(nameof(BusinessTypeId))]
        [Display(Name = "Business Type")]
        public int BusinessTypeId { get; set; }

        public IEnumerable<BusinessType> BusinessTypeList { get; set; }


        //AppUser Properties
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmployerEmail { get; set; }
        [Display(Name = "Telephone Number")]
        [Required]
        public string EmployerPhone { get; set; }
        [Display(Name = "Cellphone Number")]
        public string? EmployerCell { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string EmployerFirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string EmployerSurname { get; set; }
    }
}
