﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace StudentEmployementPortal.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CellNumber { get; set; }
        
        public string TelNumber { get; set; }
    }
}