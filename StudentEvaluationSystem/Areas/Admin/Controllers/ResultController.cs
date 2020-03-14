using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Extension;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using System.Linq;
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
        public IActionResult Index()
        {
            var StudentId = HttpContext.Session.Get<int>("Student_Fk_Existing");
            var sessionTermId = HttpContext.Session.Get<int>("SessionTerm_Fk_Existing");
            var classId = HttpContext.Session.Get<int>("Class_Fk_Existing");

            var results = _dataBaseQueries.GetResultsWithStudentByClassBySessionTerm(StudentId, classId, sessionTermId);

            return View(results);
        }

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
    }
}