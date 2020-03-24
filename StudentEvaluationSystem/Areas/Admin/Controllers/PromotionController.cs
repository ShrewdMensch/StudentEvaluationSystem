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

            var teacherId = _dataBaseQueries.GetTeacherByUserId(
                 HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                 .Value)?.Id;

            classes = _dataBaseQueries.GetTeacherClass(teacherId.GetValueOrDefault());


            return View("Index",classes);
        }

        public IActionResult AllStudents(int id)
        {
            var students = _dataBaseQueries.GetAllStudentsInClass(id);

            return View(students);
        }
    }
}