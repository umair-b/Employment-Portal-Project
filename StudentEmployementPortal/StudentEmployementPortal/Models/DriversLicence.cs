namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DriversLicence
{
    [Key]
    public int LicenceId { get; set; }
    [Required]
    public string LicenceName { get; set; }
}
