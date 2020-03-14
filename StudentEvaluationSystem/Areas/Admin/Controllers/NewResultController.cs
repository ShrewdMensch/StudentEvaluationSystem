using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using StudentEvaluationSystem.Extension;
using StudentEvaluationSystem.Models.Utility;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class NewResultController : Controller
    {
        private readonly DataBaseQueries _dataBaseQueries;

        public NewResultController(ApplicationDbContext context)
        {
            _dataBaseQueries = new DataBaseQueries(context);
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = new List<Subject>();

            var teacherId = _dataBaseQueries.GetTeacherByUserId(
                 HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                 .Value)?.Id;

            if (_dataBaseQueries.IsCurrentSessionTermSet())
                subjects = _dataBaseQueries.GetSubjectsByTeacherId(teacherId.GetValueOrDefault());


            return View(subjects);
        }

        public IActionResult Classes(int id)
        {
            var subjectName = _dataBaseQueries.GetSubject(id).Name;
            HttpContext.Session.Set<int>("Subject_Fk_New", id);
            HttpContext.Session.Set<string>("Subject_Name", subjectName);

            var classes = _dataBaseQueries.GetClassesOfferingSubject(id);

            return View(classes);
        }

        public IActionResult Students(int id)
        {
            HttpContext.Session.Set("Class_Fk_New", id);

            //var classes = _dataBaseQueries.GetStudentsCurrentlyInClass(id);

            return RedirectToAction("StudentsAvailable");
        }


        [SessionTimeOut]
        public IActionResult StudentsAvailable()
        {
            var classId = HttpContext.Session.Get<int>("Class_Fk_New");
            var subjectId = HttpContext.Session.Get<int>("Subject_Fk_New");
            var currentSessionId = _dataBaseQueries.GetCurrentSessionTerm().Id;

            var students = _dataBaseQueries
                .GetStudentsCurrentlyInClassWithoutSubjectResultUploadedForSessionTerm(
                classId, subjectId, currentSessionId);

            return View("Students", students);
        }


        [SessionTimeOut]
        public IActionResult Upload(int id)
        {
            HttpContext.Session.Set("Student_Fk_New", id);

            var result = new ResultEntry
            {
                StudentId = id,
                SubjectId = HttpContext.Session.Get<int>("Subject_Fk_New"),
                SessionTermId = _dataBaseQueries.GetCurrentSessionTerm().Id,
                ClassId = HttpContext.Session.Get<int>("Class_Fk_New"),
                SubjectName = _dataBaseQueries.GetSubject(HttpContext.Session.Get<int>("Subject_Fk_New")).Name,
                StudentName = _dataBaseQueries.GetStudent(id).FullName,
                ClassName = _dataBaseQueries.GetClass(HttpContext.Session.Get<int>("Class_Fk_New")).Name
            };

            return View(result);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(ResultEntry resultEntry)
        {
            if (ModelState.IsValid)
            {
                var result = new Result()
                {
                    StudentId = resultEntry.StudentId,
                    SubjectId = resultEntry.SubjectId,
                    ClassId = resultEntry.ClassId,
                    SessionTermId = resultEntry.SessionTermId,
                    TestScore = resultEntry.TestScore,
                    ExamScore = resultEntry.ExamScore
                };

                await _dataBaseQueries.AddResultToDataBase(result);

                TempData["ResultSaved"] = Constant.Uploaded;

                return RedirectToAction("StudentsAvailable");
            }

            return BadRequest();
        }
        public IActionResult Create()
        {
            return View();
        }


    }
}