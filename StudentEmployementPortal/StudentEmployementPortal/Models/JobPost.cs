namespace StudentEmployementPortal.Models
{
    public class JobPost
    {
        public int PostId { get; set; }
        public int EmployerId { get; set; }
        public bool Internal { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string KeyResponsibilities {get; set; } 

        public bool FullTime { get; set; }
        public DateOnly StartDate { get; set; } 
        public DateOnly DateOnly { get; set; }
        public string HourlyRate { get; set; }
        public List<string> LimitedTo { get; set;}
       
        public bool CitizensOnly { get; set; }

        public string MinRequirements { get; set; }
        public string ApplicationInstructions { get; set; }

        public DateOnly ClosingDate { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        public string Status { get; set; }
    }
}
