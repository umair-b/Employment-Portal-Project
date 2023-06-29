using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StudentEmployementPortal.Data;
using System.Security.Claims;

namespace StudentEmployementPortal.Utils
{
    public class StudentProfileFilterAttribute : ActionFilterAttribute
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public StudentProfileFilterAttribute(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var StudentProfile = _appDbContext.Students.Find(_userManager.GetUserId(context.HttpContext.User));

            if (StudentProfile == null)
            {
                context.Result = new RedirectToActionResult("Index", "ManageStudentProfile", null);
            }

        }
    }
}