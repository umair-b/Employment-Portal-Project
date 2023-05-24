using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }
        [NotMapped]
        public IFormFile ApplicationFile { get; set; }
    }
}
