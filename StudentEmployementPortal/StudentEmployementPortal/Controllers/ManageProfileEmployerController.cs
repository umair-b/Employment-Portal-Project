using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Employer)]
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
                    EmployerSurname = appUser.LastName,
                    EmployerBusinessType = employer.EmployerBusinessType,
                    EmployerTitle = employer.EmployerTitle
                };
                return View(vm);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmployerUpdateInfoViewModel vm)
        {
            var userId = _userManager.GetUserId(User);
            var employer = _appDbContext.Employers.Find(userId);
            var appUser = _appDbContext.AppUsers.Find(userId);

            
                if (employer == null)
                {
                    var newEmployer = new Employer
                    {
                        RegisteredAddress = vm.RegisteredAddress,
                        RegistrationName = vm.RegistrationName,
                        RegistrationNumber = vm.RegistrationNumber,
                        EmployerBusinessType = vm.EmployerBusinessType,
                        EmployerTitle = vm.EmployerTitle,
                        JobTitle = vm.JobTitle,
                        TradingName= vm.TradingName,
                        TrueInfo = vm.TrueInfo,
                        UserId = userId,
                        User = appUser
                    };
                    _appDbContext.Employers.Add(newEmployer);

                    appUser.TelNumber = vm.EmployerPhone;
                    appUser.FirstName = vm.EmployerFirstName;
                    appUser.LastName = vm.EmployerSurname;
                    appUser.Email = vm.EmployerEmail;
                    appUser.CellNumber = vm.EmployerCell;

                    _appDbContext.SaveChanges();
                }
                else
                {
                    employer.RegisteredAddress = vm.RegisteredAddress;
                    employer.RegistrationName = vm.RegistrationName;
                    employer.RegistrationNumber = vm.RegistrationNumber;
                    employer.EmployerBusinessType = vm.EmployerBusinessType;
                    employer.EmployerTitle = vm.EmployerTitle;
                    employer.JobTitle = vm.JobTitle;
                    employer.TradingName = vm.TradingName;
                    employer.TrueInfo = vm.TrueInfo;
                    appUser.TelNumber = vm.EmployerPhone;
                    appUser.FirstName = vm.EmployerFirstName;
                    appUser.LastName = vm.EmployerSurname;
                    appUser.Email = vm.EmployerEmail;
                    appUser.CellNumber = vm.EmployerCell;

                    _appDbContext.SaveChanges();
                }

            

            return RedirectToAction("Index", "Home");
        }
    }
}
