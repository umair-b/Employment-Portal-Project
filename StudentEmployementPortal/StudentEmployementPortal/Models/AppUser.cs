using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Cellphone Number")]
        public string CellNumber { get; set; }

        [DisplayName("Telephone Number")]
        public string TelNumber { get; set; }

        //Navigation Properties
        public Employer Employer { get; set; }
        public Student Student { get; set; }
    }
}
