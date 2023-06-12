using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
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

        public async Task<IActionResult> Index()
        {
            if (User != null && User.Identity != null && User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                if (await _userManager.IsInRoleAsync(user, Utils.DefineRole.Role_Employer))
                {
                    return View(nameof(Privacy));
                }
                
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}