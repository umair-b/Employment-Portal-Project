using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;

namespace StudentEmployementPortal.ViewModels
{
    public class EmployerUpdateInfoViewModel
    {
        public string JobTitle { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationName { get; set; }

        public string TradingName { get; set; }
        public string RegisteredAddress { get; set; }
        public bool TrueInfo { get; set; } = false;
        public Enums.Title EmployerTitle { get; set; } // = Enums.Title.Other;
        public Enums.BusniessType EmployerBusinessType { get; set; } //= Enums.BusniessType.PtyLtd;

        public string EmployerEmail { get; set; }
        public string EmployerPhone { get; set; }
        public string EmployerCell { get; set; }
        public string EmployerFirstName { get; set; }
        public string EmployerSurname { get; set; }

        //Get Enums
        
        public IEnumerable<SelectListItem> EmployerTitles => Enums.GetEnumList<Enums.Title>();
        public IEnumerable<SelectListItem> EmployerBusinessTypes => Enums.GetEnumList<Enums.BusniessType>();
    }
}
