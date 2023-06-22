using Microsoft.AspNetCore.Mvc.Rendering;
using StudentEmployementPortal.Utils;

namespace StudentEmployementPortal.ViewModels
{
    public class ApproveEmployerViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string CelNumber { get; set; }
        public string JobTitle { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationName { get; set; }

        public string TradingName { get; set; }
        public string RegisteredAddress { get; set; }
        public string? ApproverNote { get; set; } = string.Empty;
        public Enums.EmployerStatus EmployerStatus { get; set; } = Enums.EmployerStatus.Pending;
        public Enums.BusniessType EmployerBusinessType { get; set; } = Enums.BusniessType.PtyLtd;

        private List<Enums.JobPostStatus> ExcludedVals = new List<Enums.JobPostStatus> { Enums.JobPostStatus.Withdraw, Enums.JobPostStatus.Pending };
        public IEnumerable<SelectListItem> StatusNames => Enums.GetEnumList<Enums.JobPostStatus>(ExcludedVals);
    }
}
