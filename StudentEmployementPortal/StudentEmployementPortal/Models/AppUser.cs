using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class AppUser : IdentityUser
    {
        internal object FullName;

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CellNumber { get; set; }
        
        public string TelNumber { get; set; }
    }
}
