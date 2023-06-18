using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.ViewModels
{
    public class DocumentUploadViewModel
    {
        [Display(Name = "Job Post")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Upload a Document")]
        public IFormFile? File { get; set; }
    }
}
