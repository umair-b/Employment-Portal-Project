using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Student)]
    [ServiceFilter(typeof(StudentProfileFilterAttribute))]
    public class ManageWorkExperienceController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly INotyfService _toastNotification;


        public ManageWorkExperienceController(AppDbContext appDbContext, UserManager<IdentityUser> userManager, INotyfService toastNotification)
        {
            _appDbContext = appDbContext;
            _userManager  = userManager;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddWorkExperience(WorkExperience WorkExperience)
        {
            string UserId = _userManager.GetUserId(User);
            var Student   = _appDbContext.Students.Find(UserId);

            if (Student == null)
            {
                return RedirectToAction("Index", "ManageStudentProfile");
            }

            var NewWorkExperience = new WorkExperience
            {
                TasksAndResponsibilities = WorkExperience.TasksAndResponsibilities,
                EmployerName             = WorkExperience.EmployerName,
                EndDate                  = WorkExperience.EndDate,
                StartDate                = WorkExperience.StartDate,
                JobTitle                 = WorkExperience.JobTitle,
                UserId                   = UserId,
                Student                  = Student
            };

            _appDbContext.WorkExperience.Add(NewWorkExperience);
            _appDbContext.SaveChanges();

            _toastNotification.Success("Work experience added successfully!");
            return RedirectToAction("Index", "ManageStudentProfile");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var WorkExperience = _appDbContext.WorkExperience.Find(id);

            if (WorkExperience == null)
            {
                return NotFound();
            }

            var WorkExperienceVm = new WorkExperienceViewModel
            {
                EmployerName             = WorkExperience.EmployerName,
                StartDate                = WorkExperience.StartDate,
                EndDate                  = WorkExperience.EndDate,
                JobTitle                 = WorkExperience.JobTitle,
                TasksAndResponsibilities = WorkExperience.TasksAndResponsibilities,
                WorkExperienceId         = WorkExperience.WorkExperienceId
            };

            return View(WorkExperienceVm);
        }

        [HttpPost]
        public IActionResult Edit(WorkExperienceViewModel WorkExperienceVm)
        {
            if (WorkExperienceVm != null)
            {
                var WorkExperience = _appDbContext.WorkExperience.Find(WorkExperienceVm.WorkExperienceId);

                if (WorkExperience != null)
                {
                    if (WorkExperience.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }

                    WorkExperience.EmployerName             = WorkExperienceVm.EmployerName;
                    WorkExperience.StartDate                = WorkExperienceVm.StartDate;
                    WorkExperience.EndDate                  = WorkExperienceVm.EndDate;
                    WorkExperience.JobTitle                 = WorkExperienceVm.JobTitle;
                    WorkExperience.TasksAndResponsibilities = WorkExperienceVm.TasksAndResponsibilities;

                    _appDbContext.SaveChanges();

                    _toastNotification.Success("Work experience changes saved successfully!");
                    return RedirectToAction("Index", "ManageStudentProfile");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var WorkExperience = _appDbContext.WorkExperience.Find(id);

            if (WorkExperience == null)
            {
                return NotFound();
            }

            var WorkExperienceVm = new WorkExperienceViewModel
            {
                EmployerName = WorkExperience.EmployerName,
                StartDate = WorkExperience.StartDate,
                EndDate = WorkExperience.EndDate,
                JobTitle = WorkExperience.JobTitle,
                TasksAndResponsibilities = WorkExperience.TasksAndResponsibilities,
                WorkExperienceId = WorkExperience.WorkExperienceId
            };

            return View(WorkExperienceVm);
        }

        [HttpPost]
        public IActionResult DeleteWorkExperience(WorkExperienceViewModel WorkExperienceVm)
        {
            var Id = WorkExperienceVm.WorkExperienceId;
            {
                var WorkExperience = _appDbContext.WorkExperience.Find(Id);

                if (WorkExperience != null)
                {
                    if (WorkExperience.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }

                    _appDbContext.WorkExperience.Remove(WorkExperience);
                    _appDbContext.SaveChanges();

                    _toastNotification.Error("Work experience deleted!");
                    return RedirectToAction("Index", "ManageStudentProfile");
                }
            }

            return NotFound();
        }

    }
}
