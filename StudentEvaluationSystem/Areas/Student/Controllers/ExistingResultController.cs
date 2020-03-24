using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using StudentEvaluationSystem.Extension;
using Microsoft.AspNetCore.Http;

namespace StudentEvaluationSystem.Controllers
{
    [Area("Student")]
    [Authorize(Roles = Constant.StudentUser)]
    public class ExistingResultController : Controller
    {
        private readonly DataBaseQueries _dataBaseQueries;

        public ExistingResultController(ApplicationDbContext context)
        {
            _dataBaseQueries = new DataBaseQueries(context);
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

            HttpContext.Session.Set<int>("Session_Fk_Existing", sessionTerm.SessionId);

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