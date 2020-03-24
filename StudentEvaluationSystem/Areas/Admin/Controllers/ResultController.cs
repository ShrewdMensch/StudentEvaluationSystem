using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Extension;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly DataBaseQueries _dataBaseQueries;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
            _dataBaseQueries = new DataBaseQueries(context);
        }


        [SessionTimeOut]
        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult Index()
        {
            var StudentId = HttpContext.Session.Get<int>("Student_Fk_Existing");
            var sessionTermId = HttpContext.Session.Get<int>("SessionTerm_Fk_Existing");
            var classId = HttpContext.Session.Get<int>("Class_Fk_Existing");

            var results = _dataBaseQueries.GetResultsWithStudentByClassBySessionTerm(StudentId, classId, sessionTermId);

            return View(results);
        }


        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult Edit(int id)
        {
            var result = (from r in _context.Results
                          where r.Id == id select r)
                .Include(r=>r.Class)
                .Include(r=>r.Student)
                .Include(r=>r.Subject)
                .Include(r=>r.SessionTerm)
                .Include(r=>r.SessionTerm.Session)
                .Include(r=>r.SessionTerm.Term)
                .Single();

            if (result == null)
                return NotFound();

            return View(result);
        }

        [HttpPost,AutoValidateAntiforgeryToken]
        public IActionResult Edit(int id, Result result)
        {
            if (ModelState.IsValid)
            {
                var resultInDb = _context.Results.Find(id);

                resultInDb.TestScore = result.TestScore;
                resultInDb.ExamScore = result.ExamScore;

                _context.SaveChanges();

                return RedirectToAction("Results", "ExistingResult", new { id = result.StudentId });
            }

            return View(result);
        }

        [Authorize(Roles = Constant.AdminUser)]
        public IActionResult EditSessional(int id)
        {
            var result = (from r in _context.Results
                          where r.Id == id
                          select r)
                .Include(r => r.Class)
                .Include(r => r.Student)
                .Include(r => r.Subject)
                .Include(r => r.SessionTerm)
                .Include(r => r.SessionTerm.Session)
                .Include(r => r.SessionTerm.Term)
                .Single();

            if (result == null)
                return NotFound();

            return View(result);
        }

        [HttpPost,AutoValidateAntiforgeryToken]
        public IActionResult EditSessional(int id, Result result)
        {
            if (ModelState.IsValid)
            {
                var resultInDb = _context.Results.Find(id);

                resultInDb.TestScore = result.TestScore;
                resultInDb.ExamScore = result.ExamScore;

                _context.SaveChanges();

                return RedirectToAction("Sessional");
            }

            return View(result);
        }

        [SessionTimeOut]
        public IActionResult Sessional()
        {
            var studentId = HttpContext.Session.Get<int>("Student_Fk_Existing");
            var academicSessionId = HttpContext.Session.Get<int>("Session_Fk_Existing");

            if (!_dataBaseQueries.DoesStudentExist(studentId))
                return RedirectToAction("AccessDenied", "Account", new { area = "Identity" });

                var resultsGroup = _dataBaseQueries.GetResultsByStudentIdBySessionId(studentId, academicSessionId);

                return View(resultsGroup);
        }


        [Authorize(Roles = Constant.StudentUser)]
        public IActionResult MyResult()
        {
            var studentId = _dataBaseQueries.GetStudentByUserId(
                 HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                 .Value)?.Id;

            return RedirectToAction("Session_Term", "ExistingResult", new { id = studentId });
        }
    }
}