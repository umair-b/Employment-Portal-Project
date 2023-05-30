namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BusinessType
{
    [Key]
    public int BusinessTypeId { get; set; }
    [Required]
    public string BusinessTypeName { get; set; }
}
