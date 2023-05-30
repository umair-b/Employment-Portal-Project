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

       public IActionResult CreatePost()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(JobPost obj)
        {

            if (ModelState.IsValid)
            {
                _db.JobPosts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
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
                Department = obj.Department,
                EndDate = obj.EndDate,
                Faculty = obj.Faculty,
                FullTime = obj.FullTime,
                HourlyRate = obj.HourlyRate,
                Internal = obj.Internal,
                JobDescription = obj.JobDescription,
                JobLocation = obj.JobLocation,
                JobTitle = obj.JobTitle,
                KeyResponsibilities = obj.KeyResponsibilities,
                LimitedTo = obj.LimitedTo,
                MinRequirements = obj.MinRequirements,
                StartDate   = obj.StartDate
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
                    jobPost.Department = obj.Department;
                    jobPost.EndDate = obj.EndDate;
                    jobPost.Faculty = obj.Faculty;
                    jobPost.FullTime = obj.FullTime;
                    jobPost.HourlyRate = obj.HourlyRate;
                    jobPost.Internal = obj.Internal;
                    jobPost.JobDescription = obj.JobDescription;
                    jobPost.JobLocation = obj.JobLocation;
                    jobPost.JobTitle = obj.JobTitle;
                    jobPost.KeyResponsibilities = obj.KeyResponsibilities;
                    jobPost.LimitedTo = obj.LimitedTo;
                    jobPost.MinRequirements = obj.MinRequirements;
                    jobPost.StartDate = obj.StartDate;

                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(obj);

            }
            return View(obj);

        }

    }
}
