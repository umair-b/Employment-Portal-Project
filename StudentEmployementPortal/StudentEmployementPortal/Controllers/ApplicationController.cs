using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Student)]
    public class ApplicationController : Controller
    {
        private AppDbContext _db;

        public ApplicationController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<JobPost> JobPosts = _db.JobPosts.Where(x => x.PostStatus == Enums.JobPostStatus.Approved)
                .Include(x => x.Faculty)
                .Include(x => x.Department);

            if (JobPosts == null)
            {
                return NotFound();
            }

            return View(JobPosts);
        }

        public IActionResult PostDetails(int? id)
        {
            if (id == null || _db.JobPosts == null)
            {
                return NotFound();
            }

            var jobPost = _db.JobPosts
                .FirstOrDefault(j => j.PostId == id);

            if (jobPost == null)
            {
                return NotFound();
            }

            return View(jobPost);
        }

        public IActionResult Upload(int id)
        {
            var obj = _db.JobPosts.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            var UploadViewModel = new DocumentUploadViewModel()
            {
                JobTitle = obj.JobTitle
            };

            return View(UploadViewModel);
        }

        [HttpPost]
        public ActionResult Upload(DocumentUploadViewModel UploadViewModel)
        {
            if (ModelState.IsValid)
            {

                var file = UploadViewModel.File;

                return RedirectToAction(nameof(Index));
            }

            // If the model is not valid, return the view with validation errors
            return View(UploadViewModel);
        }
    }
}
