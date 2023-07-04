using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.ViewModels
{
    public class ApproveEmployerViewModel
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Telephone Number")]
        public string TelNumber { get; set; }
        [Display(Name = "Cellphone Number")]
        public string CelNumber { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Registered Name")]
        public string RegistrationName { get; set; }
        [Display(Name = "Trading Name")]
        public string TradingName { get; set; }
        [Display(Name = "Business Address")]
        public string RegisteredAddress { get; set; }
        [Display(Name = "Approver's Note")]
        public string? ApproverNote { get; set; } = string.Empty;
        [Display(Name = "Select Approval Status")]
        public Enums.EmployerStatus EmployerStatus { get; set; } = Enums.EmployerStatus.Pending;
        [Display(Name = "Business Type")]
        public string BusinessType { get; set; }
        public IEnumerable<SelectListItem> StatusNames => Enums.GetEnumList<Enums.EmployerStatus>();
    }
}
