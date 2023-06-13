using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }
        public string JobTitle { get; set; }
        public string RegistrationNumber { get; set;}
        public string RegistrationName { get; set; }

        public string TradingName { get; set; }
        public string RegisteredAddress { get; set;}
        public bool TrueInfo { get; set; } = false;
        public string? ApproverNote { get; set; } = string.Empty;
        public Enums.EmployerStatus EmployerStatus { get; set; } = Enums.EmployerStatus.Pending;
        public Enums.Title EmployerTitle { get; set; } = Enums.Title.Other;
        public Enums.BusniessType EmployerBusinessType { get; set; } = Enums.BusniessType.PtyLtd;

        //Get Enums
        public IEnumerable<SelectListItem> EmployerStatuses { get => Enums.GetEnumList<Enums.EmployerStatus>(); set { }}
        public IEnumerable<SelectListItem> EmployerTitles { get => Enums.GetEnumList<Enums.Title>(); set { }}
        public IEnumerable<SelectListItem> EmployerBusinessTypes { get => Enums.GetEnumList<Enums.BusniessType>(); set { } }

        //public BusinessType EmployerBusinessType { get; set; }


        //Navigation Property
        public AppUser User { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }

    }
}
