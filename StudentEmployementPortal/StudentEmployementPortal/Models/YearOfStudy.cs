namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class YearOfStudy
{
    [Key]
    public int YearOfStudyId { get; set; }
    [Required]
    public string YearOfStudyDescription { get; set; }
}
