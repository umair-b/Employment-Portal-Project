using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;

namespace StudentEmployementPortal.Controllers
{
    public class ApproverPostController : Controller
    {
        private AppDbContext _db; 

        public IActionResult Index()
        {
            IEnumerable<JobPost> JobPosts = _db.JobPosts;
            if (JobPosts == null)
            {
                return NotFound();
            }

            return View(JobPosts);
        }

        [HttpGet]
        private IActionResult ReviewPost(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var jobPost = _db.JobPosts.Find(id);
            return View(jobPost);
        }
    }
}
