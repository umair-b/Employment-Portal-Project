using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;


namespace StudentEmployementPortal.Controllers
{
    public class StudentProfileController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public StudentProfileController(AppDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // GET: StudentProfileController
        public ActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var student = _db.Students.Find(userId);
            var appUser = _db.AppUsers.Find(userId);

            if (student == null)
            {
                var viewModel = new UpdateStudentProfileViewModel
                {
                    StudentFirstName = appUser.FirstName,
                    StudentLastName = appUser.LastName,
                    StudentCel = appUser.CellNumber,
                    StudentTel = appUser.TelNumber,
                    StudentEmail = appUser.Email,
                    Address = string.Empty,
                    IdentityNumber = string.Empty,
                    DriversLicense = string.Empty,
                    CareerObjective = string.Empty,
                    Nationality = string.Empty,
                    YearOfStudy = string.Empty,
                    FacultyList = _db.Faculties.ToList(),
                    DepartmentList = _db.Departments.ToList(),
                };
                return View(viewModel);
            }
            else
            {
                var viewModel = new UpdateStudentProfileViewModel
                {
                    StudentFirstName = appUser.FirstName,
                    StudentLastName = appUser.LastName,
                    StudentCel = appUser.CellNumber,
                    StudentTel = appUser.TelNumber,
                    StudentEmail = appUser.Email,
                    Address = student.Address,
                    IdentityNumber = student.IdentityNumber,
                    DriversLicense = student.DriversLicense,
                    CareerObjective = student.CareerObjective,
                    Nationality = student.Nationality,
                    YearOfStudy = student.Nationality,
                    FacultyList = _db.Faculties.ToList(),
                    DepartmentList = _db.Departments.ToList(),
                };
                return View(viewModel);
            }

        }

        // GET: StudentProfileController/Details/5
        public ActionResult Details(int? id)
        {
           
            return View();
        }

        // GET: StudentProfileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentProfileController/Create
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

        // GET: StudentProfileController/Edit/5
        public ActionResult EditProfile()
        {
            
            
            return View();
        }

        // POST: StudentProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateStudentProfileViewModel obj)
        {
            
            return View();
        }

        // GET: StudentProfileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentProfileController/Delete/5
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

        public IActionResult GetDepartmentsByFaculty(int facultyId)
        {
            IEnumerable<Department> Departments = _db.Departments.Where(f => f.FacultyId == facultyId);

            string options = "<option value='' selected disabled>Select Department</option>";
            foreach (var department in Departments)
            {
                options += $"<option value='{department.DepartmentId}'>{department.DepartmentName}</option>";
            }

            return Content(options, "text/html");
        }
    }
}
