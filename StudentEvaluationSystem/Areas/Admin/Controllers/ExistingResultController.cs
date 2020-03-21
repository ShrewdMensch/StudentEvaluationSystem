using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using StudentEvaluationSystem.Extension;
using Microsoft.AspNetCore.Http;

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

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult Index()
        {
            var sessionTerms = _dataBaseQueries.GetAllSessionTerms();

            return View(sessionTerms);
        }

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult Sessions()
        {
            var sessions = _dataBaseQueries.GetAllSessions();

            return View(sessions);
        }

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult Classes(int id)
        {
            HttpContext.Session.Set<int>("SessionTerm_Fk_Existing", id);

            var classes = _dataBaseQueries.GetAllClasses();

            return View(classes);
        }

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult All_Classes()
        {
            var classes = _dataBaseQueries.GetAllClasses();

            return View(classes);
        }

        [SessionTimeOut]
        [Authorize(Roles = Constant.AdminUser)]
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

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult AllStudents(int id)
        {
            var students = _dataBaseQueries.GetAllStudentsInClass(id);

            return View(students);
        }


        [SessionTimeOut]
        [Authorize(Roles = Constant.AdminUser)]
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


        public IActionResult Session_Term(int id)
        {
            HttpContext.Session.Set<int>("Student_Fk_Existing", id);
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken,
            ActionName("Session_Term")]
        [SessionTimeOut]
        public IActionResult Session_TermPost(SessionTerm sessionTerm)
        {

            var studentId = HttpContext.Session.Get<int>("Student_Fk_Existing");

            if (!_dataBaseQueries.DoesStudentExist(studentId))
                return RedirectToAction("AccessDenied", "Account", new { area = "Identity" });

            var results = _dataBaseQueries.GetResultsByStudentIdBySessionTermId(studentId,sessionTerm.Id);

            if(sessionTerm.Id == 0)
            {
                var resultsGroup = _dataBaseQueries.GetResultsByStudentIdBySessionId(studentId, sessionTerm.SessionId);
                return View("AllResults", resultsGroup);
            }

            return View("Results", results);
        }



        public JsonResult GetSubTerms(int sessionId)
        {
            return new JsonResult(_dataBaseQueries.GetSessionTermBySessionId(sessionId));
        }

    }
}