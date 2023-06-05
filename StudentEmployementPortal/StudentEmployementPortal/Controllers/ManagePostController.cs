using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    public class ManagePostController : Controller
    {
        private readonly AppDbContext _db;

        public ManagePostController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<JobPost> jobPosts = _db.JobPosts;
            if (jobPosts == null)
            {
                return NotFound();
            }

            return View(jobPosts);
        }


        // GET
        public IActionResult CreatePost()
        {
            var viewModel = new CreateJobPostViewModel()
            {
                FacultyList = _db.Faculties.ToList(),
                DepartmentList = _db.Departments.ToList(), 
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(CreateJobPostViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var jobPost = new JobPost()
                {
                    PostId = obj.PostId,
                    ApplicationInstructions = obj.ApplicationInstructions,
                    //ApproverNote = obj.ApproverNote,
                    CitizensOnly = obj.CitizensOnly,
                    ClosingDate = obj.ClosingDate,
                    ContactEmail = obj.ContactEmail,
                    ContactNumber = obj.ContactNumber,
                    ContactPerson = obj.ContactPerson,
                    FacultyId = obj.FacultyId,
                    //Faculty = _db.Faculties.Find(obj.FacultyId),
                    DepartmentId = obj.DepartmentId,
                    //Department = _db.Departments.Find(obj.DepartmentId),
                    FacultyList = obj.FacultyList,
                    DepartmentList = obj.DepartmentList,
                    EndDate = obj.EndDate,
                    FullTime = obj.FullTime,
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

            var updateJobPostViewModel = new UpdateJobPostViewModel()
            {
                PostId = obj.PostId,
                ApplicationInstructions = obj.ApplicationInstructions,
                ApproverNote = obj.ApproverNote,
                CitizensOnly = obj.CitizensOnly,
                ClosingDate = obj.ClosingDate,
                ContactEmail = obj.ContactEmail,
                ContactNumber = obj.ContactNumber,
                ContactPerson = obj.ContactPerson,
                FacultyId = obj.FacultyId,
                FacultyList = obj.FacultyList,
                //Faculty = _db.Faculties.Find(obj.FacultyId),
                DepartmentId = obj.DepartmentId,
                DepartmentList = obj.DepartmentList,
                //Department = _db.Departments.Find(obj.DepartmentId),
                EndDate = obj.EndDate,
                FullTime = obj.FullTime,
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

            return View(updateJobPostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UpdateJobPostViewModel obj)
        {
            //

            //int Id = obj.PostId;
            //ModelState.Remove("PostId");

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
                    jobPost.EndDate = obj.EndDate;
                    jobPost.FacultyId = obj.FacultyId;
                    jobPost.FullTime = obj.FullTime;
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
                    jobPost.limitedToFaculty = obj.limitedToFaculty;
                    jobPost.MinRequirements = obj.MinRequirements;
                    jobPost.StartDate = obj.StartDate;

                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                obj.FacultyList = _db.Faculties.ToList();
                obj.DepartmentList = _db.Departments.ToList();

                return View(obj);
            }
            return View(obj);

        }

    }
}