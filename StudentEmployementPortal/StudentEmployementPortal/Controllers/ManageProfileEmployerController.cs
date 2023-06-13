using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
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
            var vm = new EmployerUpdateInfoViewModel
            {
                JobTitle = string.Empty,
                EmployerCell = string.Empty,
                EmployerPhone = string.Empty,
                EmployerEmail = string.Empty,
                RegisteredAddress = string.Empty,
                RegistrationName = string.Empty,
                RegistrationNumber = string.Empty,
                TradingName = string.Empty,
                EmployerFirstName = string.Empty,
                EmployerSurname = string.Empty
            };
            return View(vm);
        }
    }
}
