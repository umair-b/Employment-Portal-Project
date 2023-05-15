namespace StudentEmployementPortal.Models
{
    public class WorkExperience
    {
        public int WorkExperienceId { get; set; }
        public string Employer { get; set; }
        public DateOnly Date { get; set; }
        public string JobTitle { get; set; }
        public string TasksAndResps { get; set; }
    }
}
