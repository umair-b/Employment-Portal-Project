using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEmployementPortal.Models
{
    public class Student
    {
        public string? CareerObjective { get; set; }
        public string? Faculty { get; set; }
        public string? Department { get; set;}

        public string? Skills { get; set; }

        public string? Achievements { get; set; }

        public string? Interests { get; set;}
        public DriversLicence StudentLicence { get; set; }
        public Nationality StudentNationality { get; set; }
        public Race StudentRace { get; set; }
        public Gender StudentGender { get; set; }
        public YearOfStudy StudentYos { get; set; }

    }
}
