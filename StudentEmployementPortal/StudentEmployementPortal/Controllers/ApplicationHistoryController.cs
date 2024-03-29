﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class ApplicationHistoryController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly INotyfService _toastNotification;

        public ApplicationHistoryController(AppDbContext db, UserManager<IdentityUser> userManager, INotyfService toastNotification)
        {
            _db = db;
            _userManager = userManager;
            _toastNotification = toastNotification;
        }
        // GET: ApplicationHistoryController
        public ActionResult Index()
        {
            var userId = _userManager.GetUserId(User);

            var application = _db.Application
                .Where(a => a.StudentId == userId)
                .Include(a => a.Post)
                .Include(a => a.Post.Department)
                .ToList();

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: ApplicationHistoryController/Details/5
        public ActionResult ApplicationDetails(int id)
        {
            var userId = _userManager.GetUserId(User);

            var documents = _db.Documents
                .Where(d => d.ApplicationId == id)
                .ToList();

            var application = _db.Application
                .Where(a => a.StudentId == userId)
                .Include(a => a.Post)
                .Include(a => a.Post.Department)
                .FirstOrDefault(a => a.ApplicationId == id);

            if (application == null)
            {
                return NotFound();
            }

            var viewModel = new ApplicationDetailsViewModel
            {
                ApplicationId = id,
                Application = application
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(int id, ApplicationDetailsViewModel viewModel)
        {
            
            var userId = _userManager.GetUserId(User);

            var documents = _db.Documents.Where(d => d.ApplicationId == id).ToList();

            var application = _db.Application
                .Where(a => a.StudentId == userId)
                .Include(a => a.Post)
                .Include(a => a.Post.Department)
                .FirstOrDefault(a => a.ApplicationId == id);

            if (application == null)
            {
                return NotFound();
            }

            viewModel.ApplicationId = id;
            viewModel.Application = application;
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

            _toastNotification.Success("Document uploaded successfully!");
            return RedirectToAction("ApplicationDetails", new { id = application.ApplicationId });
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

            _toastNotification.Error("Document deleted");
            return RedirectToAction("ApplicationDetails", new {id = appId});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Withdraw(int id)
        {
            var application = _db.Application.Find(id);

            if (application == null)
            {
                return NotFound();
            }

            application.ApplicationStatus = Enums.ApplicationStatus.Withdrawn;

            _db.SaveChanges();

            _toastNotification.Warning("Application withdrawn");
            return RedirectToAction("Index");
        }
    }
}
