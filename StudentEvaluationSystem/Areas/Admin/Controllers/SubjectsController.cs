using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Subjects
                .Include(s=>s.Teacher)
                .Include(s=>s.SubjectType)
                .ToListAsync();

            return View(students);
        }

        //Get Create
        public IActionResult Create()
        {
            var subject = new Subject();
            return View("CreateEdit",subject);
        }

        
        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                await _context.Subjects.AddAsync(subject);
                await _context.SaveChangesAsync();

                TempData["SubjectSaved"] = Constant.Saved;

                return RedirectToAction("Index");
            }

            return View(subject);
        }

        //Get Edit
        public async Task<IActionResult> Edit(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View("CreateEdit", subject);
        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Subject subject)
        {
            if (ModelState.IsValid)
            {
                var subjectInDb = await _context.Subjects.FindAsync(id);

                subjectInDb.Name = subject.Name;
                subjectInDb.SubjectTypeId = subject.SubjectTypeId;
                subjectInDb.TeacherId = subject.TeacherId;

                await _context.SaveChangesAsync();

                TempData["SubjectSaved"] = Constant.Updated;

                return RedirectToAction("Index");

            }

            return View(subject);
        }
    }
}