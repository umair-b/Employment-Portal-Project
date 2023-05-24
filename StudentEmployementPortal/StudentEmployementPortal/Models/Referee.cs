using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Referee
    {
        [Key]
        public int Id { get; set; }
        public int RefereesId { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Institution { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
    }
}
