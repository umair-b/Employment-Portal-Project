using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.ViewModels
{
    public class EmployerUpdateInfoViewModel
    {
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name= "Registration Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Registration Name")]
        public string RegistrationName { get; set; }
        [Display(Name = "Trading Name ")]
        public string TradingName { get; set; }
        [Display(Name = "Registered Address")]
        public string RegisteredAddress { get; set; }
        [Display(Name = "I confirm that the information provided above is true to the best of my knowledge ")]
        public bool TrueInfo { get; set; } = false;
        [Display(Name ="Title")]
        public Enums.Title EmployerTitle { get; set; } // = Enums.Title.Other;
        [Display(Name = "Business Type")]
        public Enums.BusniessType EmployerBusinessType { get; set; } //= Enums.BusniessType.PtyLtd;
        [Required]
        [EmailAddress]
        [Display(Name ="Email Address")]
        public string EmployerEmail { get; set; }
        [Display(Name ="Telephone Number")]
        public string EmployerPhone { get; set; }
        [Display(Name ="Cellphone Number")]
        public string? EmployerCell { get; set; }
        [Display(Name ="First Name")]
        public string EmployerFirstName { get; set; }
        [Display(Name ="Last Name")]
        public string EmployerSurname { get; set; }

        //Get Enums
        
        public IEnumerable<SelectListItem> EmployerTitles { get => Enums.GetEnumList<Enums.Title>(); set { } }
        public IEnumerable<SelectListItem> EmployerBusinessTypes { get => Enums.GetEnumList<Enums.BusniessType>(); set { } }
    }
}
