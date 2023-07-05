using StudentEmployementPortal.Models;

namespace StudentEmployementPortal.ViewModels
{
    public class ChartViewModel
    {
        public List<ChartData> DepartmentChartData { get; set; }
        public List<ChartData> PartTimeHoursChartData { get; set; }
    }
}
