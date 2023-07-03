using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;

namespace StudentEmployementPortal.Utils
{
    public class EmployerStatusAttribute : ActionFilterAttribute
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public EmployerStatusAttribute(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var EmployerProfile = _appDbContext.Employers.Find(_userManager.GetUserId(context.HttpContext.User));

            if (EmployerProfile != null)
            {
                if (EmployerProfile.EmployerStatus == Enums.EmployerStatus.Rejected)
                {
                    context.Result = new RedirectToActionResult("Index", "Home", null);
                }

                if (EmployerProfile.EmployerStatus == Enums.EmployerStatus.Pending)
                {
                    context.Result = new RedirectToActionResult("Index", "Home", null);
                }
            }


        }

    }
}
