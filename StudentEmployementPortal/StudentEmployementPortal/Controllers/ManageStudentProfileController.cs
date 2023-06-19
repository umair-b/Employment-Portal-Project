using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;

namespace StudentEmployementPortal.Controllers
{
    public class ManageStudentProfileController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageStudentProfileController (AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            string UserId = _userManager.GetUserId(User);
            var Student = _appDbContext.Students.Find(UserId);
            var AppUser = _appDbContext.AppUsers.Find(UserId);



            return View();
        }
    }
}
