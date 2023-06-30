using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentEmployementPortal.ViewModels
{
    public class RefereeViewModel
    {
        [Key]
        public int RefereeId { get; set; }

        [DisplayName("Name and Surname")]
        public string Name { get; set; }

        [DisplayName("Job Title")]
        public string JobTitle { get; set; }

        [DisplayName("Institution")]
        public string Institution { get; set; }

        [DisplayName("Cellphone Number")]
        public string CellNumber { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }
    }
}
