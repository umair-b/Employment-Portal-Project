using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentEmployementPortal.ViewModels
{
    public class RefereeViewModel
    {
        [Key]
        public int RefereeId { get; set; }

        [DisplayName("Name and Surname")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Job Title")]
        [Required]
        public string JobTitle { get; set; }

        [DisplayName("Institution")]
        [Required]
        public string Institution { get; set; }

        [DisplayName("Cellphone Number")]
        [Required]
        public int CellNumber { get; set; }

        [DisplayName("Email Address")]
        [Required]
        public string Email { get; set; }
    }
}
