using LinqKit;
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
    [ServiceFilter(typeof(StudentProfileFilterAttribute))]
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
            var student = _db.Students.Find(userId);

            if (student == null)
            {
                return NotFound();
            }

            var applications = _db.Application
                .Where(a => a.StudentId == userId)
                .Select(a => a.PostId) .ToList();

            //Predicate
            var Pred = PredicateBuilder.New<JobPost>();

            Pred = Pred.And(p => p.PostStatus == Enums.JobPostStatus.Approved);
            
            if (student.Citizen == false)
            {
                Pred = Pred.And(p => p.CitizensOnly == false);
            }

            int YearOfStudy = student.YearOfStudyId;
            switch (YearOfStudy)
            {
                case 1:
                    Pred = Pred.And(p => p.limitedToFirst);
                    break;
                case 2:
                    Pred = Pred.And(p => p.limitedToSecond);
                    break;
                case 3:
                    Pred = Pred.And(p => p.limitedToThird);
                    break;
                case 4:
                    Pred = Pred.And(p => p.limitedToHonours);
                    break;
                case 5:
                    Pred = Pred.And(p => p.limitedToMasters);
                    break;
                case 6:
                    Pred = Pred.And(p => p.limitedToPhD);
                    break;
                case 7:
                    Pred = Pred.And(p => p.limitedToPostDoc);
                    break;
            }

            Pred = Pred.Or(p => p.PostStatus == Enums.JobPostStatus.Approved && !p.limitedToFirst && !p.limitedToSecond && !p.limitedToThird && !p.limitedToHonours && !p.limitedToMasters && !p.limitedToPhD && !p.limitedToPostDoc);

            IEnumerable<JobPost> JobPosts = _db.JobPosts.Where(Pred)
                .Include(x => x.Faculty)
                .Include(x => x.Department);

            JobPosts = JobPosts.Where(x => !applications.Contains(x.PostId));

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
                .Include(j => j.Department)
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

            var documents = _db.Documents.Where(d => d.ApplicationId == id).ToList();

            viewModel.ApplicationId = id;
            viewModel.UploadedDocuments = documents;

            var file = viewModel.File;

            var fileName = Path.GetFileName(file.FileName);
            var fileExtension = Path.GetExtension(file.FileName).ToLower();

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_db.Documents == null)
            {
                return Problem("Entity set 'AppDbContext.Documents'  is null.");
            }

            var document = _db.Documents.SingleOrDefault(j => j.DocumentId == id);

            if (document == null)
            {
                return NotFound();
            }

            var appId = document.ApplicationId;

            appId = document.ApplicationId;
            _db.Documents.Remove(document);

            _db.SaveChanges();
            return RedirectToAction("Upload", new {id = appId});
        }

    }
}
