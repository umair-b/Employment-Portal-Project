using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Referee
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
        public int CellNumber { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }

        //Navigation Property
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public Student Student { get; set; }
    }
}
