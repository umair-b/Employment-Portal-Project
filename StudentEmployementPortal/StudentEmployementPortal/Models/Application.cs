namespace StudentEmployementPortal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        
        public int StudentId { get; set; }

        public int PostId { get; set; }

        public string status { get; set; } = "PENDING";
    }

