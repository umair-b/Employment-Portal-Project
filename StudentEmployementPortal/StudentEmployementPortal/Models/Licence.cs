using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Licence
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LicenceName { get; set; }
    }
}
