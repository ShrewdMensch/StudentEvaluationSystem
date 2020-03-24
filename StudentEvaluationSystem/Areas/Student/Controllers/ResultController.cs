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

namespace StudentEvaluationSystem.Controllers
{
    [Area("Student")]
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly DataBaseQueries _dataBaseQueries;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
            _dataBaseQueries = new DataBaseQueries(context);
        }


        [Authorize(Roles = Constant.StudentUser)]
        public IActionResult MyResult()
        {
            var studentId = _dataBaseQueries.GetStudentByUserId(
                 HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                 .Value)?.Id;

            return RedirectToAction("Session_Term", "ExistingResult", new { id = studentId});
        }
    }
}