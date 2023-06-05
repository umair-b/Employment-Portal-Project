namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Nationality
{
    [Key]
    public int NationalityID { get; set; }
    [Required]
    public string NationalityName { get; set; }
}
