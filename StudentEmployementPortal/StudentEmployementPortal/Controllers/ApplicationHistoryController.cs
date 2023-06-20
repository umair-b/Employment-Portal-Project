using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Data;

namespace StudentEmployementPortal.Controllers
{
    public class ApplicationHistoryController : Controller
    {
        private AppDbContext _db;

        public ApplicationHistoryController(AppDbContext db)
        {
            _db = db;
        }
        // GET: ApplicationHistoryController
        public ActionResult Index()
        {
            var application = _db.Application.Include(a => a.Post).Include(a => a.Post.Department).ToList();

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: ApplicationHistoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationHistoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationHistoryController/Create
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

        // GET: ApplicationHistoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationHistoryController/Edit/5
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

        // GET: ApplicationHistoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationHistoryController/Delete/5
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
