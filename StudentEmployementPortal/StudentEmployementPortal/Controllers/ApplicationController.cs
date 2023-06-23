using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public ApplicationController(AppDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            //var student = _db.Students.Find(userId);

            var applications = _db.Application
                .Where(a => a.StudentId == userId)
                .Select(a => a.PostId) .ToList();

            IEnumerable<JobPost> JobPosts = _db.JobPosts.Where(x => !applications.Contains(x.PostId) && x.PostStatus == Enums.JobPostStatus.Approved)
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
            var userId = _userManager.GetUserId(User);
            var jobPost = _db.JobPosts.Find(id);

            if (jobPost == null)
            {
                return NotFound();
            }

            var application = new Models.Application
            {
                PostId = id,
                StudentId = userId
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
        public ActionResult Upload(int id, DocumentUploadViewModel viewModel)
        {
            
               /* var maxFileSize = 5 * 1024 * 1024;
                var allowedFileType = new[] { ".pdf", ".doc", ".docx" };*/

                var documents = _db.Documents.Where(d => d.ApplicationId == id).ToList();

                viewModel.ApplicationId = id;
                viewModel.UploadedDocuments = documents;

                var file = viewModel.File;

                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", fileName);
                    /*var fileExtension = Path.GetExtension(file.FileName).ToLower();*/

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    /*if (allowedFileType.Contains(fileExtension))
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    else
                    {
                         ModelState.AddModelError("File", "Only PDF, Word documents are allowed.");
                    }*/
                    

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
        
        public IActionResult Cancel(int id)
        {
            var application = _db.Application.Find(id);

            if (application == null)
            {
                return NotFound();
            }

            _db.Application.Remove(application);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
           
    }
}
