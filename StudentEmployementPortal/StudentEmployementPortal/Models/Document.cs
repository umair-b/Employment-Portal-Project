namespace StudentEmployementPortal.Models
{
    public class Document
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }
        public IFormFile ApplicationFile { get; set; }
    }
}
