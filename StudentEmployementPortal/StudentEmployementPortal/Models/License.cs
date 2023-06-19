using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class License
    {
        [Key]
        public int LicenseId { get; set; }
        [Required]
        public string LicenceName { get; set; }
    }
}
