using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Models.Utility;
using StudentEvaluationSystem.Utility;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =Constant.AdminUser)]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var classes = await _context.Classes.ToListAsync();

            return View(classes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClassTeacherEdit classTeacherEdit)
        {
            if (ModelState.IsValid)
            {
                await AddClassToDatabase(classTeacherEdit);

                TempData["ClassSaved"] = Constant.Saved;

                return RedirectToAction("Index");

            }

            return View(classTeacherEdit);
        }

        public IActionResult CreateClassTeacher()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClassTeacher(ClassTeacherEdit classTeacherEdit)
        {
            if (ModelState.IsValid)
            {
                var newClassTeacher = new ClassTeacher
                {
                    ClassId = classTeacherEdit.ClassId,
                    TeacherId = classTeacherEdit.TeacherId,
                };
                await _context.ClassTeachers.AddAsync(newClassTeacher);

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return View(classTeacherEdit);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var classTeacherInDb = await _context.ClassTeachers.SingleOrDefaultAsync(c => c.ClassId == id);
            var classInDb = await _context.Classes.FindAsync(id);


            if (classInDb != null)
            {
                var classTeacherEdit = new ClassTeacherEdit
                {
                    ClassTeacherId = classTeacherInDb.Id,
                    ClassId = id,
                    CategoryId = classInDb.CategoryId,
                    Name = classInDb.Name,
                    TeacherId = classTeacherInDb.TeacherId
                };

                return View(classTeacherEdit);
            }

            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ClassTeacherEdit classTeacherEdit)
        {
            if (ModelState.IsValid)
            {
                var classInDb = await _context.Classes.FindAsync(classTeacherEdit.ClassId);
                var classTeacherInDb = await _context.ClassTeachers
                    .FindAsync(classTeacherEdit.ClassTeacherId);

                classInDb.Name = classTeacherEdit.Name;
                classInDb.CategoryId = classTeacherEdit.CategoryId;

                classTeacherInDb.ClassId = classTeacherEdit.ClassId;
                classTeacherInDb.TeacherId = classTeacherEdit.TeacherId;

                await _context.SaveChangesAsync();

                TempData["ClassSaved"] = Constant.Updated;

                return RedirectToAction("Index");
            }

            return View(classTeacherEdit);
        }

        private async Task AddClassToDatabase(ClassTeacherEdit classTeacherEdit)
        {
            var newClass = new Class
            {
                Name = classTeacherEdit.Name,
                CategoryId = classTeacherEdit.CategoryId,
            };

            await _context.Classes.AddAsync(newClass);

            await _context.SaveChangesAsync();

            classTeacherEdit.ClassId = newClass.Id;

            await AddClassTeacherToDatabase(classTeacherEdit);
        }
        private async Task AddClassTeacherToDatabase(ClassTeacherEdit classTeacherEdit)
        {
            var newClassTeacher = new ClassTeacher
            {
                ClassId = classTeacherEdit.ClassId,
                TeacherId = classTeacherEdit.TeacherId,
            };
            await _context.ClassTeachers.AddAsync(newClassTeacher);

            await _context.SaveChangesAsync();
        }
    }
}