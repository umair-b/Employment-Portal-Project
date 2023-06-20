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

        [HttpGet]
        public IActionResult Apply(int id)
        {
            var jobPost = _db.JobPosts.Find(id);

            if (jobPost == null)
            {
                return NotFound();
            }

            var application = new Application
            {
                PostId = id
            };

            _db.Application.Add(application);
            _db.SaveChanges();

            return View(application);
        }

        public IActionResult Upload(int id)
        {
            var application = _db.Application.Find(id);

            if (application == null)
            {
                return NotFound();
            }

            var document = _db.Documents.Where(d => d.ApplicationId == application.ApplicationId).ToList();

            var UploadViewModel = new DocumentUploadViewModel()
            {
                ApplicationId = application.ApplicationId,
                UploadedDocuments = document
            };

            return View(UploadViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(DocumentUploadViewModel viewModel)
        {
            /*var application = _db.Application.Find(id);

            if (application == null)
            {
                return NotFound();
            }*/

            var file = viewModel.File;

            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                var document = new Document
                {
                    FileDescription = viewModel.FileDescription,
                    FileName = fileName,
                    ApplicationId = viewModel.ApplicationId,
                    ApplicationFile = file
                };

                _db.Documents.Add(document);
                _db.SaveChanges();
            }
            return RedirectToAction("Upload");
        }

       

        
           
    }
}
