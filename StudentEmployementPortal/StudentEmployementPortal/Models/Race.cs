namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Race
{
    [Key]
    public int RaceId { get; set; }
    [Required]
    public string RaceName { get; set;}
}
