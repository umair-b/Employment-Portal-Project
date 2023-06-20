using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }
        [ForeignKey(nameof(Application))]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [NotMapped]
        public IFormFile ApplicationFile { get; set; }
        public string FileName { get; set; }
       
    }
}
