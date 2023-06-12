using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Employer)]
    public class ManagePostController : Controller
    {
        private readonly AppDbContext _db;

        public ManagePostController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //IEnumerable<JobPost> jobPosts = _db.JobPosts;
            var jobPosts = _db.JobPosts
                .Include(j => j.Department)
                .Include(j => j.Faculty)
                .ToList();
            
            if (jobPosts == null)
            {
                return NotFound();
            }
            

            return View(jobPosts);
        }

       public IActionResult CreatePost()
        {
            var CreatePostViewModel = new CreateJobPostViewModel
            {
                FacultyList = _db.Faculties.ToList(),
                DepartmentList = _db.Departments.ToList()
            };

            return View(CreatePostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(CreateJobPostViewModel obj)
        {

            if (!ModelState.IsValid)
            {

                var jobPost = new JobPost()
                {
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
                    limitedToDepartment = obj.limitedToDepartment,
                    limitedToFaculty = obj.limitedToFaculty,
                    MinRequirements = obj.MinRequirements,
                    StartDate = obj.StartDate

                };

                _db.JobPosts.Add(jobPost);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            obj.FacultyList = _db.Faculties.ToList();
            obj.DepartmentList = _db.Departments.ToList();

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
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
                StartDate   = obj.StartDate,
                limitedToFirst = obj.limitedToFirst,
                limitedToSecond = obj.limitedToSecond,
                limitedToThird = obj.limitedToThird,
                limitedToHonours = obj.limitedToHonours,
                limitedToMasters = obj.limitedToMasters,
                limitedToPhD = obj.limitedToPhD,
                limitedToPostDoc = obj.limitedToPostDoc,
                limitedToDepartment = obj.limitedToDepartment,
                /*FacultyList = _db.Faculties.ToList(),
                DepartmentList = _db.Departments.ToList(),*/
            };

            UpdatePostViewModel.FacultyList = _db.Faculties.ToList();
            UpdatePostViewModel.DepartmentList = _db.Departments.ToList();

            return View(UpdatePostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UpdateJobPostViewModel obj)
        {

            if (ModelState.IsValid)
            {

                var jobPost = _db.JobPosts.Find(obj.PostId);

                if (jobPost != null)
                {
                    //jobPost.PostId = obj.PostId;
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
                    jobPost.limitedToDepartment = obj.limitedToDepartment;
                    jobPost.MinRequirements = obj.MinRequirements;
                    jobPost.StartDate = obj.StartDate;

                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                return View(obj);

            }

            obj.FacultyList = _db.Faculties.ToList();
            obj.DepartmentList = _db.Departments.ToList();

            return View(obj);
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
