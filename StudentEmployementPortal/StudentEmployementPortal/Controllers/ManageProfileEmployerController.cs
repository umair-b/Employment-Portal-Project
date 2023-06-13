using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    public class ManageProfileEmployerController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageProfileEmployerController(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //var user = _userManager.GetUserAsync(User);
            var userId = _userManager.GetUserId(User);
            var employer = _appDbContext.Employers.Find(userId);
            var appUser = _appDbContext.AppUsers.Find(userId);

            if (employer == null)
            {
                var vm = new EmployerUpdateInfoViewModel
                {
                    JobTitle = string.Empty,
                    EmployerCell = appUser.CellNumber,
                    EmployerPhone = appUser.TelNumber,
                    EmployerEmail = appUser.Email,
                    RegisteredAddress = string.Empty,
                    RegistrationName = string.Empty,
                    RegistrationNumber = string.Empty,
                    TradingName = string.Empty,
                    EmployerFirstName = appUser.FirstName,
                    EmployerSurname = appUser.LastName
                };

                return View(vm);
            }
            else
            {
                var vm = new EmployerUpdateInfoViewModel
                {
                    JobTitle = employer.JobTitle,
                    EmployerCell = appUser.CellNumber,
                    EmployerPhone = appUser.TelNumber,
                    EmployerEmail = appUser.Email,
                    RegisteredAddress = employer.RegisteredAddress,
                    RegistrationName = employer.RegistrationName,
                    RegistrationNumber = employer.RegistrationNumber,
                    TradingName = employer.TradingName,
                    EmployerFirstName = appUser.FirstName,
                    EmployerSurname = appUser.LastName
                };
                return View(vm);
            }
        }

        public IActionResult update(EmployerUpdateInfoViewModel vm)
        {
            var userId = _userManager.GetUserId(User);
            var employer = _appDbContext.Employers.Find(userId);
            var appUser = _appDbContext.AppUsers.Find(userId);

            if (ModelState.IsValid)
            {
                if (employer == null)
                {
                    
                }

            }

            return View();
        }
    }
}
