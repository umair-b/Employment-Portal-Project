using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class DriversLicense
    {
        [Key]
        public int LicenseId { get; set; }
        [Required]
        public string LicenceName { get; set; }
    }
}
