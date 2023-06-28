using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Student)]
    [ServiceFilter(typeof(StudentProfileFilterAttribute))]
    public class ManageRefereeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageRefereeController(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddReferee(Referee Referee)
        {
            string UserId = _userManager.GetUserId(User);
            var Student = _appDbContext.Students.Find(UserId);

            if (Student == null)
            {
                return RedirectToAction("Index", "ManageStudentProfile");
            }

            var NewReferee = new Referee
            {
                Name = Referee.Name,
                CellNumber = Referee.CellNumber,
                Email = Referee.Email,
                Institution = Referee.Institution,
                JobTitle = Referee.JobTitle,
                UserId = UserId,
                Student = Student
            };

            _appDbContext.Referees.Add(NewReferee);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index", "ManageStudentProfile");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Referee = _appDbContext.Referees.Find(id);

            if (Referee == null)
            {
                return NotFound();
            }

            var RefereeVm = new RefereeViewModel
            {
                CellNumber = Referee.CellNumber,
                Email = Referee.Email,
                Institution = Referee.Institution,
                JobTitle = Referee.JobTitle,
                Name = Referee.Name,
                RefereeId = Referee.RefereeId
            };

            return View(RefereeVm);
        }

        [HttpPost]
        public IActionResult Edit(RefereeViewModel RefereeVm)
        {
            if (RefereeVm != null)
            {
                var Referee = _appDbContext.Referees.Find(RefereeVm.RefereeId);

                if (Referee != null)
                {
                    if (Referee.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }

                    Referee.Institution = RefereeVm.Institution;
                    Referee.Email       = RefereeVm.Email;
                    Referee.CellNumber  = RefereeVm.CellNumber;
                    Referee.JobTitle    = RefereeVm.JobTitle;
                    Referee.Name        = RefereeVm.Name;

                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index", "ManageStudentProfile");

                }
            }
            
            return View(RefereeVm);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Referee = _appDbContext.Referees.Find(id);

            if (Referee == null)
            {
                return NotFound();
            }

            var RefereeVm = new RefereeViewModel
            {
                CellNumber = Referee.CellNumber,
                Email = Referee.Email,
                Institution = Referee.Institution,
                JobTitle = Referee.JobTitle,
                Name = Referee.Name,
                RefereeId = Referee.RefereeId
            };

            return View(RefereeVm);
        }

        [HttpPost]
        public IActionResult DeleteReferee(RefereeViewModel RefereeVm)
        {
            if (RefereeVm != null)
            {
                var Referee = _appDbContext.Referees.Find(RefereeVm.RefereeId);

                if (Referee != null)
                {
                    if (Referee.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }

                    _appDbContext.Referees.Remove(Referee);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index", "ManageStudentProfile");

                }
            }

            return View(RefereeVm);
        }
    }
}
