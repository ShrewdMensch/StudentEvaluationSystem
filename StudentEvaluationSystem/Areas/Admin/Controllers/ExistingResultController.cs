using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using StudentEvaluationSystem.Extension;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ExistingResultController : Controller
    {
        private readonly DataBaseQueries _dataBaseQueries;

        public ExistingResultController(ApplicationDbContext context)
        {
            _dataBaseQueries = new DataBaseQueries(context);
        }

        public IActionResult Index()
        {
            var sessionTerms = _dataBaseQueries.GetAllSessionTerms();

            return View(sessionTerms);
        }

         public IActionResult Sessions()
        {
            var sessions = _dataBaseQueries.GetAllSessions();

            return View(sessions);
        }

        public IActionResult Classes(int id)
        {
            HttpContext.Session.Set<int>("SessionTerm_Fk_Existing", id);

            var classes = _dataBaseQueries.GetAllClasses();

            return View(classes);
        }

        public IActionResult All_Classes()
        {
            var classes = _dataBaseQueries.GetAllClasses();

            return View(classes);
        }

        [SessionTimeOut]
        public IActionResult Students(int id)
        {
            HttpContext.Session.Set<int>("Class_Fk_Existing", id);
            var sessionTermId = HttpContext.Session.Get<int>("SessionTerm_Fk_Existing");

            var classes = _dataBaseQueries.GetStudentsWithResultByClassBySessionTerm(id, sessionTermId);

            ViewData["SessionName"] = _dataBaseQueries.GetSessionBySessionTermId(
                HttpContext.Session.Get<int>("SessionTerm_Fk_Existing")).Name;

            ViewData["TermName"] = _dataBaseQueries.GetTermBySessionTermId(
                HttpContext.Session.Get<int>("SessionTerm_Fk_Existing")).Name;

            ViewData["ClassName"] = _dataBaseQueries.GetClass(id).Name;

            return View(classes);
        }

         public IActionResult AllStudents(int id)
        {
            var classes = _dataBaseQueries.GetAllStudentsInClass(id);

            return View(classes);
        }


        [SessionTimeOut]
        public IActionResult Results(int id)
        {
            HttpContext.Session.Set("Student_Fk_Existing", id);

            var sessionTermId = HttpContext.Session.Get<int>("SessionTerm_Fk_Existing");
            var classId = HttpContext.Session.Get<int>("Class_Fk_Existing");

            var results = _dataBaseQueries.GetResultsWithStudentByClassBySessionTerm(id, classId, sessionTermId);

            return View(results);
        }


        public IActionResult StudentResult(int id)
        {
            var student = _dataBaseQueries.GetStudent(id);

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        
    }
}