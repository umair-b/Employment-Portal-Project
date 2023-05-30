namespace StudentEmployementPortal.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class Gender
    {
    [Key]
    public int GenderId { get; set; }

    [Required]
    public string GenderName { get; set;}

    }

