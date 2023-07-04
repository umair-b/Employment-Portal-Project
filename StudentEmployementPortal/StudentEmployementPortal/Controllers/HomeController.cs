using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;
using System.Data.Entity;
using StudentEmployementPortal.Utils;
using System.Diagnostics;

namespace StudentEmployementPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (User != null && User.Identity != null && User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    if (await _userManager.IsInRoleAsync(user, Utils.DefineRole.Role_Employer))
                    {
                        var employer = _appDbContext.Employers.Find(_userManager.GetUserId(User));

                        if (employer == null)
                        {
                            return RedirectToAction("Index", "ManageProfileEmployer");
                        }

                        ViewData["Name"] = employer.User.FirstName + " " + employer.User.LastName;
                        if (employer != null)
                        {
                            if (employer.EmployerStatus == Utils.Enums.EmployerStatus.Rejected || employer.EmployerStatus == Utils.Enums.EmployerStatus.Pending)
                            {
                                var Status = new EmployerStatus
                                {
                                    Status = employer.EmployerStatus
                                };
                                return View(Status);
                            }
                        }

                        return View();
                    }

                    if (await _userManager.IsInRoleAsync(user, Utils.DefineRole.Role_Student))
                    {
                        var student = _appDbContext.Students.Find(_userManager.GetUserId(User));

                        if (student == null)
                        {
                            return RedirectToAction("Index", "ManageStudentProfile");
                        }

                        ViewData["Name"] = student.User.FirstName + " " + student.User.LastName;

                        return View();
                    }
                }
                
            }

            return View();
        }

        public async Task<IActionResult> Index(EmployerStatus EmployerStatus)
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        /*public IActionResult EmployerError()
        {
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}