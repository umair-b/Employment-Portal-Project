using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class AppUser : IdentityUser
    {

        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cell number is already in use.")]
        [RegularExpression(@"^((\+27|0)[1-9]\d{8})$", ErrorMessage = "Invalid South African cell number.")]
        public string CellNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Telephone number is already in use.")]
        [RegularExpression(@"^((\+27|0)[1-9]\d{8})$", ErrorMessage = "Invalid South African telephone number.")]
        public string TelNumber { get; set; }

    }
}
