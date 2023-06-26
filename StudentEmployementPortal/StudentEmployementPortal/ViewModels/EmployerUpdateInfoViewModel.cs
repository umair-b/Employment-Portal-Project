using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.ViewModels
{
    public class EmployerUpdateInfoViewModel
    {
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Business Registered Name")]
        public string RegistrationName { get; set; }
        [Display(Name = "Business Trading Name")]
        public string TradingName { get; set; }
        [Display(Name = "Business Registered Address")]
        public string RegisteredAddress { get; set; }
        public bool TrueInfo { get; set; } = false;
        public Enums.Title EmployerTitle { get; set; } // = Enums.Title.Other;
        public Enums.BusniessType EmployerBusinessType { get; set; } //= Enums.BusniessType.PtyLtd;

        [Display(Name = "Email")]
        public string EmployerEmail { get; set; }
        [Display(Name = "Telephone Number")]
        public string EmployerPhone { get; set; }
        [Display(Name = "Cellphone Number")]
        public string? EmployerCell { get; set; }
        [Display(Name = "First Name")]
        public string EmployerFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string EmployerSurname { get; set; }

        //Get Enums
        
        public IEnumerable<SelectListItem> EmployerTitles { get => Enums.GetEnumList<Enums.Title>(); set { } }
        public IEnumerable<SelectListItem> EmployerBusinessTypes { get => Enums.GetEnumList<Enums.BusniessType>(); set { } }
    }
}
