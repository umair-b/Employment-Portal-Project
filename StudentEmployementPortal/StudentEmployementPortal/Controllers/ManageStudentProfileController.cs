using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;
using static StudentEmployementPortal.Utils.Enums;
using System.ComponentModel;

namespace StudentEmployementPortal.Controllers
{
    public class ManageStudentProfileController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageStudentProfileController (AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager  = userManager;
        }

        public IActionResult Index()
        {
            string UserId = _userManager.GetUserId(User);
            var Student   = _appDbContext.Students.Find(UserId);
            var AppUser   = _appDbContext.AppUsers.Find(UserId);

            if (Student == null)
            {
                var StudentVm = new StudentUpdateInfoViewModel
                {
                    FirstName      = AppUser.FirstName,
                    LastName       = AppUser.LastName,
                    CellNumber     = AppUser.CellNumber,
                    TelNumber      = AppUser.TelNumber,
                    Email          = AppUser.Email,
                    FacultyList    = _appDbContext.Faculties.ToList(),
                    DepartmentList = _appDbContext.Departments.ToList(),
                    GenderList     = _appDbContext.Genders.ToList(),
                    RaceList       = _appDbContext.Races.ToList(),
                    LicenseList    = _appDbContext.Licences.ToList()

                };

                return View(StudentVm);
            }
            else
            {
                var StudentVm = new StudentUpdateInfoViewModel
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
                    Skills = Student.Skills,
                    StudentIdNumber = Student.StudentIdNumber,
                    Education = _appDbContext.Educations.Where(e => e.UserId == UserId),
                    Referee = _appDbContext.Referees.Where(r => r.UserId == UserId),
                    WorkExperience = _appDbContext.WorkExperience.Where(w => w.UserId == UserId)
                };

                return View(StudentVm); 
            }
        }

        public IActionResult UpdateProfile(StudentUpdateInfoViewModel StudentVm)
        {
            string UserId = _userManager.GetUserId(User);
            var Student   = _appDbContext.Students.Find(UserId);
            var AppUser   = _appDbContext.AppUsers.Find(UserId);

            if (Student == null)
            {
                var NewStudent = new Student
                {
                    UserId          = UserId,
                    Achievements    = StudentVm.Achievements,
                    CareerObjective = StudentVm.CareerObjective,
                    Citizen         = StudentVm.Citizen,
                    DepartmentId    = StudentVm.DepartmentId,
                    FacultyId       = StudentVm.FacultyId,
                    GenderId        = StudentVm.GenderId,
                    Interests       = StudentVm.Interests,
                    Skills          = StudentVm.Skills,
                    RaceId          = StudentVm.RaceId,
                    LicenseId       = StudentVm.LicenseId,
                    StudentIdNumber = StudentVm.StudentIdNumber
                };

                _appDbContext.Students.Add(NewStudent);

                AppUser.Email      = StudentVm.Email;
                AppUser.TelNumber  = StudentVm.TelNumber;
                AppUser.CellNumber = StudentVm.CellNumber;
                AppUser.FirstName  = StudentVm.FirstName;
                AppUser.LastName   = StudentVm.LastName;

                _appDbContext.SaveChanges();
            }
            else
            {
                AppUser.Email      = StudentVm.Email;
                AppUser.TelNumber  = StudentVm.TelNumber;
                AppUser.CellNumber = StudentVm.CellNumber;
                AppUser.FirstName  = StudentVm.FirstName;
                AppUser.LastName   = StudentVm.LastName;

                Student.UserId          = UserId;
                Student.Achievements    = StudentVm.Achievements;
                Student.CareerObjective = StudentVm.CareerObjective;
                Student.Citizen         = StudentVm.Citizen;
                Student.DepartmentId    = StudentVm.DepartmentId;
                Student.FacultyId       = StudentVm.FacultyId;
                Student.GenderId        = StudentVm.GenderId;
                Student.Interests       = StudentVm.Interests;
                Student.Skills          = StudentVm.Skills;
                Student.RaceId          = StudentVm.RaceId;
                Student.LicenseId       = StudentVm.LicenseId;
                Student.StudentIdNumber = StudentVm.StudentIdNumber;

                _appDbContext.SaveChanges();
            }

            return View("Index");
        }
    }
}
