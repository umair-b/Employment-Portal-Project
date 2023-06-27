using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.ViewModels;
using System.Data;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Approver)]
    public class ApproverEmployerController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public ApproverEmployerController (AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            IEnumerable<Employer> Employers = _appDbContext.Employers.Where(e => e.EmployerStatus == Utils.Enums.EmployerStatus.Pending).Include(e => e.User);
            
            if (Employers == null)
            {
                return NotFound();
            }

            return View(Employers);
        }

        [HttpGet]
        public IActionResult ReviewEmployer(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employer = _appDbContext.Employers.Find(id);

            if (Employer == null)
            {
                return NotFound();
            }

            var EmployerCred = _appDbContext.AppUsers.Find(id);

            var ApproveEmployerVm = new ApproveEmployerViewModel
            {
                Id = Employer.UserId,
                ApproverNote = Employer.ApproverNote,
                RegisteredAddress = Employer.RegisteredAddress,
                CelNumber = EmployerCred.CellNumber,
                TelNumber = EmployerCred.TelNumber,
                Email = EmployerCred.Email,
                EmployerBusinessType = Employer.EmployerBusinessType,
                EmployerStatus = Employer.EmployerStatus,
                FirstName = EmployerCred.FirstName,
                LastName = EmployerCred.LastName,
                JobTitle = Employer.JobTitle,
                RegistrationName = Employer.RegistrationName,
                RegistrationNumber = Employer.RegistrationNumber,
                TradingName = Employer.TradingName
            };

            return View(ApproveEmployerVm);
        }

        [HttpPost]
        public IActionResult ReviewEmployer(ApproveEmployerViewModel ApproveEmployerVm)
        {
            if (ApproveEmployerVm == null)
            {
                return NotFound();
            }

            var Employer = _appDbContext.Employers.Find(ApproveEmployerVm.Id);

            if (Employer == null)
            {
                Employer.ApproverNote = ApproveEmployerVm.ApproverNote;
                Employer.EmployerStatus = ApproveEmployerVm.EmployerStatus;

                _appDbContext.SaveChanges();
            }

            return View(nameof(Index));
        }
    }
}
