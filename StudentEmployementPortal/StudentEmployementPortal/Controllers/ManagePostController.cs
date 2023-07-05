using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Employer)]
    [ServiceFilter(typeof(EmployerProfileAttribute))]
    [ServiceFilter(typeof(EmployerStatusAttribute))]
    public class ManagePostController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly INotyfService _toastNotification;

        public ManagePostController(AppDbContext db, UserManager<IdentityUser> userManager, INotyfService toastNotification)
        {
            _db = db;
            _userManager = userManager;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);

            var jobPosts = _db.JobPosts
                .Where(j => j.EmployerId == userId)
                .Include(j => j.Department)
                .Include(j => j.Employer)
                .ToList();


            if (jobPosts == null)
            {
                return NotFound();
            }

            var dateNow = DateTime.Now;

            foreach (var post in jobPosts)
            {
                if (post.ClosingDate < dateNow)
                {
                    post.PostStatus = Utils.Enums.JobPostStatus.Closed;
                    _db.Update(post);
                    _db.SaveChanges();
                }
            }

            return View(jobPosts);
        }

        public IActionResult CreatePost()
        {
            var userId = _userManager.GetUserId(User);

            var CreatePostViewModel = new CreateJobPostViewModel
            {
                FacultyList = _db.Faculties.ToList(),
                DepartmentList = _db.Departments.ToList(),
                EmployerId = userId,
            };

            return View(CreatePostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(CreateJobPostViewModel obj)
        {
            var userId = _userManager.GetUserId(User);

            if (!ModelState.IsValid)
            {

                var jobPost = new JobPost()
                {
                    EmployerId = userId,
                    PostId = obj.PostId,
                    ApplicationInstructions = obj.ApplicationInstructions,
                    CitizensOnly = obj.CitizensOnly,
                    ClosingDate = obj.ClosingDate,
                    ContactEmail = obj.ContactEmail,
                    ContactNumber = obj.ContactNumber,
                    ContactPerson = obj.ContactPerson,
                    FacultyId = obj.FacultyId,
                    DepartmentId = obj.DepartmentId,
                    EndDate = obj.EndDate,
                    FullTime = obj.FullTime,
                    PartTimeHours = obj.PartTimeHours,
                    HourlyRate = obj.HourlyRate,
                    Internal = obj.Internal,
                    JobDescription = obj.JobDescription,
                    JobLocation = obj.JobLocation,
                    JobTitle = obj.JobTitle,
                    KeyResponsibilities = obj.KeyResponsibilities,
                    limitedToFirst = obj.limitedToFirst,
                    limitedToSecond = obj.limitedToSecond,
                    limitedToThird = obj.limitedToThird,
                    limitedToHonours = obj.limitedToHonours,
                    limitedToMasters = obj.limitedToMasters,
                    limitedToPhD = obj.limitedToPhD,
                    limitedToPostDoc = obj.limitedToPostDoc,
                    MinRequirements = obj.MinRequirements,
                    StartDate = obj.StartDate

                };

                _db.JobPosts.Add(jobPost);
                _db.SaveChanges();

                _toastNotification.Success("Post created successfully!");
                _toastNotification.Warning("Post is under review");
                return RedirectToAction(nameof(Index));
            }


            obj.FacultyList = _db.Faculties.ToList();
            obj.DepartmentList = _db.Departments.ToList();

            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var obj = _db.JobPosts.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            var UpdatePostViewModel = new UpdateJobPostViewModel()
            {
                EmployerId = obj.EmployerId,
                PostId = obj.PostId,
                ApplicationInstructions = obj.ApplicationInstructions,
                ApproverNote = obj.ApproverNote,
                CitizensOnly = obj.CitizensOnly,
                ClosingDate = obj.ClosingDate,
                ContactEmail = obj.ContactEmail,
                ContactNumber = obj.ContactNumber,
                ContactPerson = obj.ContactPerson,
                DepartmentId = obj.DepartmentId,
                FacultyId = obj.FacultyId,
                EndDate = obj.EndDate,
                FullTime = obj.FullTime,
                PartTimeHours = obj.PartTimeHours,
                HourlyRate = obj.HourlyRate,
                Internal = obj.Internal,
                JobDescription = obj.JobDescription,
                JobLocation = obj.JobLocation,
                JobTitle = obj.JobTitle,
                KeyResponsibilities = obj.KeyResponsibilities,
                MinRequirements = obj.MinRequirements,
                StartDate = obj.StartDate,
                limitedToFirst = obj.limitedToFirst,
                limitedToSecond = obj.limitedToSecond,
                limitedToThird = obj.limitedToThird,
                limitedToHonours = obj.limitedToHonours,
                limitedToMasters = obj.limitedToMasters,
                limitedToPhD = obj.limitedToPhD,
                limitedToPostDoc = obj.limitedToPostDoc,
                PostStatus = obj.PostStatus,
                FacultyList = _db.Faculties.ToList(),
                DepartmentList = _db.Departments.ToList(),
            };

            return View(UpdatePostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UpdateJobPostViewModel obj)
        {

            if (ModelState.IsValid)
            {

                var jobPost = _db.JobPosts.FirstOrDefault(d => d.PostId == obj.PostId);

                if (jobPost != null)
                {
                    jobPost.EmployerId = obj.EmployerId;
                    jobPost.PostId = obj.PostId;
                    jobPost.ApplicationInstructions = obj.ApplicationInstructions;
                    jobPost.ApproverNote = obj.ApproverNote;
                    jobPost.CitizensOnly = obj.CitizensOnly;
                    jobPost.ClosingDate = obj.ClosingDate;
                    jobPost.ContactEmail = obj.ContactEmail;
                    jobPost.ContactNumber = obj.ContactNumber;
                    jobPost.ContactPerson = obj.ContactPerson;
                    jobPost.DepartmentId = obj.DepartmentId;
                    jobPost.FacultyId = obj.FacultyId;
                    jobPost.EndDate = obj.EndDate;
                    jobPost.FullTime = obj.FullTime;
                    jobPost.PartTimeHours = obj.PartTimeHours;
                    jobPost.HourlyRate = obj.HourlyRate;
                    jobPost.Internal = obj.Internal;
                    jobPost.JobDescription = obj.JobDescription;
                    jobPost.JobLocation = obj.JobLocation;
                    jobPost.JobTitle = obj.JobTitle;
                    jobPost.KeyResponsibilities = obj.KeyResponsibilities;
                    jobPost.limitedToFirst = obj.limitedToFirst;
                    jobPost.limitedToSecond = obj.limitedToSecond;
                    jobPost.limitedToThird = obj.limitedToThird;
                    jobPost.limitedToHonours = obj.limitedToHonours;
                    jobPost.limitedToMasters = obj.limitedToMasters;
                    jobPost.limitedToPhD = obj.limitedToPhD;
                    jobPost.limitedToPostDoc = obj.limitedToPostDoc;
                    jobPost.MinRequirements = obj.MinRequirements;
                    jobPost.StartDate = obj.StartDate;
                    jobPost.PostStatus = Enums.JobPostStatus.Pending;

                    _db.Update(jobPost);
                    _db.SaveChanges();

                    _toastNotification.Success("Post updated successfully!");
                    _toastNotification.Warning("Post is under review");
                    return RedirectToAction(nameof(Index));
                }
            }
            

            obj.FacultyList = _db.Faculties.ToList();
            obj.DepartmentList = _db.Departments.ToList();
          

            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || _db.JobPosts == null)
            {
                return NotFound();
            }

            var jobPost = _db.JobPosts.SingleOrDefault(j => j.PostId == id);
            if (jobPost == null)
            {
                return NotFound();
            }

            return View(jobPost);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(UpdateJobPostViewModel obj)
        {
            if (_db.JobPosts == null)
            {
                return Problem("Entity set 'AppDbContext.JobPosts'  is null.");
            }

            var jobPost = _db.JobPosts.SingleOrDefault(j => j.PostId == obj.PostId);

            if (jobPost != null)
            {
                _db.JobPosts.Remove(jobPost);
            }

            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult GetDepartmentsByFaculty(int facultyId)
        {
            IEnumerable<Department> Departments = _db.Departments.Where(f => f.FacultyId == facultyId);

            string options = "<option value='' selected disabled>Select Department</option>";
            foreach (var department in Departments)
            {
                options += $"<option value='{department.DepartmentId}'>{department.DepartmentName}</option>";
            }

            return Content(options, "text/html");
        }

    }
}
