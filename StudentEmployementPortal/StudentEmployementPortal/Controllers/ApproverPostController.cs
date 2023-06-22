using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    public class ApproverPostController : Controller
    {
        private AppDbContext _db;

        public ApproverPostController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<JobPost> JobPosts = _db.JobPosts.Where(x => x.PostStatus == Enums.JobPostStatus.Pending);
            if (JobPosts == null)
            {
                return NotFound();
            }

            return View(JobPosts);
        }

        [HttpGet]
        public IActionResult ReviewPost(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var JobPost = _db.JobPosts.Find(id);

            if (JobPost == null)
            {
                return NotFound();
            }

            var ReviewJobPostVm = new ReviewPostViewModel()
            {
                ApplicationInstructions = JobPost.ApplicationInstructions,
                ApproverNote = JobPost.ApproverNote,
                CitizensOnly = JobPost.CitizensOnly,
                ClosingDate = JobPost.ClosingDate,
                ContactEmail = JobPost.ContactEmail,
                ContactNumber = JobPost.ContactNumber,
                ContactPerson = JobPost.ContactPerson,
                //Department = JobPost.Department,
                EndDate = JobPost.EndDate,
                //Faculty = JobPost.Faculty,
                FullTime = JobPost.FullTime,
                HourlyRate = JobPost.HourlyRate,
                JobDescription = JobPost.JobDescription,
                JobLocation = JobPost.JobLocation,
                JobTitle = JobPost.JobTitle,
                Internal = JobPost.Internal,
                KeyResponsibilities = JobPost.KeyResponsibilities,
                MinRequirements = JobPost.MinRequirements,
                PostId = JobPost.PostId,
                SelectedStatus = JobPost.PostStatus,
                StartDate = JobPost.StartDate,
                limitedToFirst = JobPost.limitedToFirst,
                limitedToSecond = JobPost.limitedToSecond,
                limitedToThird = JobPost.limitedToThird,
                limitedToHonours = JobPost.limitedToHonours,
                limitedToMasters = JobPost.limitedToMasters,
                limitedToPhD = JobPost.limitedToPhD,
                limitedToPostDoc = JobPost.limitedToPostDoc,
                limitedToDepartment = JobPost.limitedToDepartment,
            };
            
           

            return View(ReviewJobPostVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReviewPost (ReviewPostViewModel ReviewPostVm)
        {

            if (ModelState.IsValid)
            {
                var JobPost = _db.JobPosts.Find(ReviewPostVm.PostId);

                if (JobPost != null)
                {
                    JobPost.ApproverNote = ReviewPostVm.ApproverNote;
                    JobPost.PostStatus = ReviewPostVm.SelectedStatus;

                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(ReviewPostVm);
            }

            return View(ReviewPostVm);
        }
    }
}
