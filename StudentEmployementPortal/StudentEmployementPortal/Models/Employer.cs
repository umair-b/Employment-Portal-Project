﻿using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentEmployementPortal.Utils.Enums;

namespace StudentEmployementPortal.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }
        public string JobTitle { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationName { get; set; }

        public string TradingName { get; set; }
        public string RegisteredAddress { get; set; }
        public bool TrueInfo { get; set; } = false;
        public string? ApproverNote { get; set; } = string.Empty;

        //Business Type
        public BusinessType BusinessType { get; set; }
        [ForeignKey(nameof(BusinessTypeId))]
        public int BusinessTypeId { get; set; }

        //Employer Title
        public Title Title { get; set; }
        [ForeignKey(nameof(TitleId))]
        public int TitleId { get; set; }

        //public Enums.Title EmployerTitle { get; set; }
        //public Enums.BusniessType EmployerBusinessType { get; set; }

        //Employer Status
        public Enums.EmployerStatus EmployerStatus { get; set; } = Enums.EmployerStatus.Pending;
        [NotMapped]
        public IEnumerable<SelectListItem> EmployerStatuses { get => Enums.GetEnumList<Enums.EmployerStatus>(); set { } }
        /* [NotMapped]
         public IEnumerable<SelectListItem> EmployerTitles { get => Enums.GetEnumList<Enums.Title>(); set { } }
         [NotMapped]
         public IEnumerable<SelectListItem> EmployerBusinessTypes { get => Enums.GetEnumList<Enums.BusniessType>(); set { } }

         //public BusinessType EmployerBusinessType { get; set; }*/


        //Navigation Property

        [Key]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public AppUser User { get; set; }

    }
}