namespace StudentEmployementPortal.Models
{
    public class Employer
    {
        public string? JobTitle { get; set; }
        public string? RegistrationNumber { get; set;}
        public string? RegistrationName { get; set; }

        public string? TradingName { get; set; }
        public string? RegisteredAddress { get; set;}
        public bool? TrueInfo { get; set; } = false;
        public bool? Approved { get; set; } = false;
        //public BusinessType EmployerBusinessType { get; set; }


    }
}
