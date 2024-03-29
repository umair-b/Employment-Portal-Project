﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using StudentEmployementPortal.Data;
using StudentEmployementPortal.Models;
using StudentEmployementPortal.Utils;
using StudentEmployementPortal.ViewModels;
using System.Data;
using System.Linq.Expressions;

namespace StudentEmployementPortal.Controllers
{
    [Authorize(Roles = Utils.DefineRole.Role_Student)]
    [ServiceFilter(typeof(StudentProfileFilterAttribute))]
    public class ManageEducationController : Controller
    {

        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly INotyfService _toastNotification;

        public ManageEducationController(AppDbContext appDbContext, UserManager<IdentityUser> userManager, INotyfService toastNotification)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEducation(Education Education)
        {

            string UserId = _userManager.GetUserId(User);
            var Student = _appDbContext.Students.Find(UserId);

            if (Student == null)
            {
                return RedirectToAction("Index", "ManageStudentProfile");
            }

            var NewEducation = new Education
            {
                Institution   = Education.Institution,
                StartDate     = Education.StartDate,
                EndDate       = Education.EndDate,
                Majors        = Education.Majors,
                SubMajors     = Education.SubMajors,
                Qualification = Education.Qualification,
                Research      = Education.Research,
                UserId        = Student.UserId,
                Student       = Student
            };
            
            _appDbContext.Educations.Add(NewEducation);
            _appDbContext.SaveChanges();

            _toastNotification.Success("Education added successfully!");
            return RedirectToAction("Index", "ManageStudentProfile");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
            var EducationRecord = _appDbContext.Educations.Find(id);

            if (EducationRecord == null)
            {
                return NotFound();
            }

            
            var Education = new EducationViewModel
            {
                EducationId  = EducationRecord.EducationId,
                Institution  = EducationRecord.Institution,
                StartDate    = EducationRecord.StartDate,
                EndDate      = EducationRecord.EndDate,
                Majors       = EducationRecord.Majors,
                SubMajors    = EducationRecord.SubMajors,
                Qualification= EducationRecord.Qualification,
                Research     = EducationRecord.Research
            };
            
            return View(Education);
        }

        [HttpPost]
        public IActionResult Edit(EducationViewModel Education)
        {

            if (Education != null)
            {
                var EducationRecord = _appDbContext.Educations.Find(Education.EducationId);

                

                if (EducationRecord != null )
                {
                    if (EducationRecord.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }

                    EducationRecord.SubMajors = Education.SubMajors;
                    EducationRecord.StartDate = Education.StartDate;
                    EducationRecord.EndDate = Education.EndDate;
                    EducationRecord.Majors = Education.Majors;
                    EducationRecord.Research = Education.Research;
                    EducationRecord.Institution = Education.Institution;
                    EducationRecord.Qualification = Education.Qualification;

                    _appDbContext.SaveChanges();

                    _toastNotification.Success("Education changes saved successfully!");
                    return RedirectToAction("Index", "ManageStudentProfile");
                }
                else
                {
                    return View(Education);
                }
            }

            return View(Education);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var EducationRecord = _appDbContext.Educations.Find(id);

            if (EducationRecord == null)
            {
                return NotFound();
            }


            var Education = new EducationViewModel
            {
                EducationId = EducationRecord.EducationId,
                Institution = EducationRecord.Institution,
                StartDate = EducationRecord.StartDate,
                EndDate = EducationRecord.EndDate,
                Majors = EducationRecord.Majors,
                SubMajors = EducationRecord.SubMajors,
                Qualification = EducationRecord.Qualification,
                Research = EducationRecord.Research
            };

            return View(Education);
        }

        [HttpPost]
        public IActionResult DeleteEducation(EducationViewModel Education)
        {

            if (Education != null)
            {
                var EducationRecord = _appDbContext.Educations.Find(Education.EducationId);



                if (EducationRecord != null)
                {
                    if (EducationRecord.UserId != _userManager.GetUserId(User))
                    {
                        return NotFound();
                    }


                    _appDbContext.Educations.Remove(EducationRecord);
                    _appDbContext.SaveChanges();

                    _toastNotification.Error("Education deleted!");
                    return RedirectToAction("Index", "ManageStudentProfile");
                }
                else
                {
                    return NotFound();
                }
            }

            return NotFound();
        }
    }
}
