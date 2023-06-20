using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.ViewModels;

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

            if (Student == null)
            {
                var StudentVM = new StudentUpdateInfoViewModel
                {
                    FirstName = AppUser.FirstName,
                    LastName = AppUser.LastName,
                    CellNumber = AppUser.CellNumber,
                    TelNumber = AppUser.TelNumber,
                    Email = AppUser.Email,
                    FacultyList = _appDbContext.Faculties.ToList(),
                    DepartmentList = _appDbContext.Departments.ToList(),
                    GenderList = _appDbContext.Genders.ToList(),
                    RaceList = _appDbContext.Races.ToList(),
                    LicenseList = _appDbContext.Licences.ToList()

                };

                return View(StudentVM);
            }
            else
            {
                var StudentVM = new StudentUpdateInfoViewModel
                {
                    FirstName = AppUser.FirstName,
                    LastName = AppUser.LastName,
                    CellNumber = AppUser.CellNumber,
                    TelNumber = AppUser.TelNumber,
                    Email = AppUser.Email,
                    FacultyList = _appDbContext.Faculties.ToList(),
                    DepartmentList = _appDbContext.Departments.ToList(),
                    GenderList = _appDbContext.Genders.ToList(),
                    RaceList = _appDbContext.Races.ToList(),
                    LicenseList = _appDbContext.Licences.ToList(),
                    FacultyId = Student.FacultyId,
                    DepartmentId = Student.DepartmentId,
                    GenderId = Student.GenderId,
                    RaceId = Student.RaceId,
                    LicenseId = Student.LicenseId,
                    CareerObjective = Student.CareerObjective,
                    Achievements = Student.Achievements,
                    Citizen = Student.Citizen,
                    Interests = Student.Interests,
                    Skills = Student.Skills
                };

                return View(StudentVM); 
            }
        }
    }
}
