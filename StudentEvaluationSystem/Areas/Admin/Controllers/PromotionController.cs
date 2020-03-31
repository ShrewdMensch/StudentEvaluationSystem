using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using StudentEvaluationSystem.Extension;
using System.Collections.Generic;
using System.Security.Claims;
using System;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Constant.AdminAndRegularUser)]
    public class PromotionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly DataBaseQueries _dataBaseQueries;

        public PromotionController(ApplicationDbContext context)
        {
            _context = context;
            _dataBaseQueries = new DataBaseQueries(context);
        }


        public IActionResult Index()
        {
            var classes = new List<Class>();

            if (User.IsInRole(Constant.AdminUser))
            {
                classes = _dataBaseQueries.GetAllClasses();
            }

            else
            {
                var teacherId = _dataBaseQueries.GetTeacherByUserId(
                 HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                 .Value)?.Id;

                classes = _dataBaseQueries.GetTeacherClass(teacherId.GetValueOrDefault());
            }

            return View("Index", classes);
        }

        public IActionResult AllStudents(int id)
        {
            var students = _dataBaseQueries.GetAllNonPromotedStudentsInClass(id);

            HttpContext.Session.Set<int>("Class_FK_Promotion", id);

            return View(students);
        }

        public IActionResult Promote(int studentId)
        {
            var studentInDB = _dataBaseQueries.GetStudent(studentId);
            var currentClassId = studentInDB.CurrentClassId;
            var currentTermId = _dataBaseQueries.GetCurrentSessionTerm().Id;

            var studentCurrentResults = _dataBaseQueries.GetStudentResultsByClassBySessionTerm(
                studentInDB.Id, currentClassId, currentTermId);

            //If student is in Final Class (i.e Jss3, for the current Project Scope) 
            //No need to promote, graduate Student if pass criteria is met
            if (currentClassId == Constant.JuniorFinalClassId)
            {
                if (GradingSystem.DoStudentMeetPassCriteria(studentCurrentResults))
                {
                    TempData["StudentPromoted"] = Constant.Graduated;
                    studentInDB.Promoted = true;
                    studentInDB.Graduated = true;
                    studentInDB.YearOfGraduation = DateTime.Now.Year.ToString();
                }

                else
                {
                    TempData["StudentPromoted"] = Constant.NotGraduated;
                }

                TempData.Keep();

                return RedirectToAction("AllStudents", new { id = currentClassId });
            }


            //else (student not in Final class), Check if student fulfil promotion criteria, if yes, promote
            if (GradingSystem.DoStudentMeetPassCriteria(studentCurrentResults))
            {
                studentInDB.CurrentClassId++;
                studentInDB.Promoted = true;

                TempData["StudentPromoted"] = Constant.Promoted;
            }

            else
            {
                studentInDB.Promoted = false;
                TempData["StudentPromoted"] = Constant.NotPromoted;
            }

            _context.SaveChangesAsync().GetAwaiter().GetResult();

            TempData.Keep();

            return RedirectToAction("AllStudents", new { id = currentClassId });
        }

        [SessionTimeOut]
        public IActionResult PromoteAll()
        {
            var classId = HttpContext.Session.Get<int>("Class_FK_Promotion");
            var currentTermId = _dataBaseQueries.GetCurrentSessionTerm().Id;

            var studentToPromote = _dataBaseQueries.GetAllNonPromotedStudentsInClass(classId);

            foreach (var student in studentToPromote)
            {

                var studentCurrentResults = _dataBaseQueries.GetStudentResultsByClassBySessionTerm(
                    student.Id, classId, currentTermId);

                //If student is in Final Class (i.e Jss3, for the current Project Scope) 
                //No need to promote, graduate Student if pass criteria is met
                if (classId == Constant.JuniorFinalClassId)
                {
                    if (GradingSystem.DoStudentMeetPassCriteria(studentCurrentResults))
                    {
                        TempData["AllStudentsPromoted"] = Constant.Graduated;
                        student.Promoted = true;
                        student.Graduated = true;
                        student.YearOfGraduation = DateTime.Now.Year.ToString();
                    }

                    else
                    {
                        TempData["AllStudentsPromoted"] = Constant.NotGraduated;
                    }

                }

                else
                {
                    //else (student not in Final class), Check if student fulfil promotion criteria, if yes, promote
                    if (GradingSystem.DoStudentMeetPassCriteria(studentCurrentResults))
                    {
                        student.CurrentClassId++;
                        student.Promoted = true;

                        TempData["AllStudentsPromoted"] = Constant.Promoted;
                    }

                    else
                    {
                        student.Promoted = false;
                        TempData["AllStudentsPromoted"] = Constant.NotPromoted;
                    }
                }

            }

            _context.SaveChangesAsync().GetAwaiter().GetResult();

            TempData.Keep();

            return RedirectToAction("AllStudents", new { id = classId });
        }
    }
}