using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Models
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        [Required]
        public string RaceName { get; set;}

    }
}
