﻿namespace StudentEmployementPortal.Models;

using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        
        public int StudentId { get; set; }

        public int PostId { get; set; }

        public Enums.ApplicationStatus ApplicationStatus { get; set; } = Enums.ApplicationStatus.Pending;

    }

