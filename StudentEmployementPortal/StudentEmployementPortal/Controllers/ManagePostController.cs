using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;

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
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.JobPosts.Find(id);

            if (obj == null)
            {
                return NotFound();
            }


            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JobPost obj)
        {

            //if (ModelState.IsValid)
            //{
            //    _db.JobPosts.Update(obj);
            //    _db.SaveChanges();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(obj);

            _db.JobPosts.Update(obj);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
