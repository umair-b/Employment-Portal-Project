using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StudentEmployementPortal.Data;
using System.Security.Claims;

namespace StudentEmployementPortal.Utils
{
    public class EmployerProfileAttribute : ActionFilterAttribute
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public EmployerProfileAttribute(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var EmployerProfile = _appDbContext.Employers.Find(_userManager.GetUserId(context.HttpContext.User));

            if (EmployerProfile == null)
            {
                context.Result = new RedirectToActionResult("Index", "ManageProfileEmployer", null);
            }

            /*if (EmployerProfile.EmployerStatus == Enums.EmployerStatus.Rejected)
            {
                context.Result = new RedirectToActionResult("EmployerError", "Home", null);
            }

            if (EmployerProfile.EmployerStatus == Enums.EmployerStatus.Pending)
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }*/


        }
    }
}