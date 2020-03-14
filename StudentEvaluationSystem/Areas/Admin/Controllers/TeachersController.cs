using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeachersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var teachers = _context.Teachers.ToList();

            return View(teachers);
        }

        //Edit Get
        public IActionResult Edit(int id)
        {
            var teacher = _context.Teachers.Find(id);

            if (teacher != null)
            {
                return View(teacher);
            }

            return BadRequest();
        }

        //Edit Post
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Teacher teacher)
        {
            var teacherInDB = await _context.Teachers.FindAsync(id);

            teacherInDB.FirstName = teacher.FirstName;
            teacherInDB.LastName = teacher.LastName;
            teacherInDB.PhoneNumber = teacher.PhoneNumber;
            teacherInDB.Address = teacher.Address;
            teacherInDB.Bio = teacher.Bio;

           await  _context.SaveChangesAsync();
            @TempData["TeacherSaved"] = Constant.Updated;
            return RedirectToAction("Index");
        }
    }
}