using StudentEmployementPortal.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.ViewModels
{
    public class DocumentUploadViewModel
    {
        public int ApplicationId { get; set; }

        [Display(Name = "Job Post")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Upload a Document")]
        public IFormFile File { get; set; }
        public string FileDescription { get; set; }
        public IEnumerable<Document> UploadedDocuments { get; set; }
    }
}
