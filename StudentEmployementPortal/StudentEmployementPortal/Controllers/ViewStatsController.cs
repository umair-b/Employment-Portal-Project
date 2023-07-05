using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    public class ViewStatsController : Controller
    {
        private readonly AppDbContext _db;

        public ViewStatsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: ViewStatsController
        public ActionResult Index()
        {
            var departmentChartData = _db.JobPosts
            .Where(p => p.HourlyRate.HasValue && p.DepartmentId.HasValue)
            .GroupBy(p => p.DepartmentId)
            .Select(g => new ChartData
            {
                Label = g.First().Department.DepartmentName ?? "",
                Value = g.Average(p => p.HourlyRate.Value)
            })
            .ToList();

            // Query for the second chart: Distinct non-null PartTimeHours and average HourlyRate
            var partTimeHoursChartData = _db.JobPosts
                .Where(p => !p.FullTime.HasValue || !p.FullTime.Value)
                .Where(p => p.HourlyRate.HasValue && !string.IsNullOrEmpty(p.PartTimeHours))
                .GroupBy(p => p.PartTimeHours)
                .Select(g => new ChartData
                {
                    Label = g.Key,
                    Value = g.Average(p => p.HourlyRate.Value)
                })
                .ToList();


            var viewModel = new ChartViewModel
            {
                DepartmentChartData = departmentChartData,
                PartTimeHoursChartData = partTimeHoursChartData
            };



            return View(viewModel);
        }

        
    }
}
