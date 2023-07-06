using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;
using System.Linq;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Approver)]
    public class ApproverPostController : Controller
    {
        private readonly AppDbContext _db;
        private readonly INotyfService _toastNotification;


        public ApproverPostController(AppDbContext db, INotyfService toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            var dateNow = DateTime.Now;

            IEnumerable<JobPost> JobPosts = _db.JobPosts.Where(x => x.PostStatus == Enums.JobPostStatus.Pending || x.PostStatus == Enums.JobPostStatus.Queried)
                .Include(x => x.Employer)
                .Include(x => x.Department)
                .Include(x => x.Faculty)
                .Include(x => x.Employer.User);

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
            var JobPost = _db.JobPosts
                .Include(j => j.Faculty)
                .Include(j => j.Department)
                .FirstOrDefault(j => j.PostId == id);

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
                DepartmentId = JobPost.Department.DepartmentName,
                FacultyId = JobPost.Faculty.FacultyName,
                EndDate = JobPost.EndDate,
                FullTime = JobPost.FullTime,
                PartTimeHours = JobPost.PartTimeHours,
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
                EmployerId = JobPost.EmployerId,
            };


            return View(ReviewJobPostVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReviewPost(ReviewPostViewModel ReviewPostVm)
        {
            var JobPost = _db.JobPosts.Find(ReviewPostVm.PostId);

            if (JobPost == null)
            {
                return NotFound();
            }

            JobPost.ApproverNote = ReviewPostVm.ApproverNote;
            JobPost.PostStatus = ReviewPostVm.SelectedStatus;

            _db.SaveChanges();

            _toastNotification.Success("Post status updated successfully.");
            return RedirectToAction("Index");
        }
    }
}
