using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Data;

namespace StudentEmployementPortal.Controllers
{
    public class ViewApplicantsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public ViewApplicantsController(AppDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // GET: ViewApplicantsController
        public IActionResult Index(int id)
        {
            var applications = _db.Application.Where(a => a.PostId == id)
                .Include(a => a.Post)
                .Include(a => a.User)
                .ToList();

            return View(applications);
        }

        // GET: ViewApplicantsController/Details/5
        public IActionResult ApplicantDetails(int id)
        {
            var documents = _db.Documents
                .Where(d => d.ApplicationId == id)
                .ToList();

            var application = _db.Application
                .Include(a => a.Post)
                .Include(a => a.User)
                .SingleOrDefault(a => a.ApplicationId == id);

            if (application == null || documents == null) 
            {
                return NotFound();
            }

            application.Documents = documents;

            return View(application);
        }

        public IActionResult DownloadDocument(int docId)
        {
            var document = _db.Documents.Find(docId);

            if(document == null)
            {
                return NotFound();
            }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", document.FileName);
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            return File(fileStream, "application/octet-stream", document.FileName);

        }
        // GET: ViewApplicantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewApplicantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViewApplicantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewApplicantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViewApplicantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewApplicantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
