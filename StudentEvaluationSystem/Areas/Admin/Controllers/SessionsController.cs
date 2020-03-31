using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Models.ViewModels;
using StudentEvaluationSystem.Utility;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Constant.AdminUser)]
    public class SessionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SessionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var academicSessions = await (from session in _context.Sessions
                        orderby session.Id ascending
                        select session
                )
                .ToListAsync();

            return View(academicSessions);
        }

        public async Task<IActionResult> Terms()
        {
            var academicSessionTerms = await _context.SessionTerms
                .Include(s=>s.Session)
                .Include(s=>s.Term)
                .ToListAsync();

            return View(academicSessionTerms);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Session session)
        {
            if (ModelState.IsValid)
            {
                await ResetPreviousSessions();
                await ResetStudentPromotions();
                session.IsCurrent = true;
                await _context.Sessions.AddAsync(session);
                await _context.SaveChangesAsync();

                TempData["SessionSaved"] = Constant.Saved;

                return RedirectToAction("Index");
            }

            return View(session);
        }

        public IActionResult Edit(int id)
        {
            var sessionInDb = _context.Sessions.Find(id);

            if (sessionInDb == null)
                return NotFound();

            return View(sessionInDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Session session)
        {
            var sessionInDb = await _context.Sessions.FindAsync(id);
            sessionInDb.Name = session.Name;

            await _context.SaveChangesAsync();

            TempData["SessionSaved"] = Constant.Updated;

            return RedirectToAction("Index");
        }
        public IActionResult EditTerm(int id)
        {
            var sessionTermInDb = _context.SessionTerms
                .Include(sessionTerm=>sessionTerm.Session)
                .Include(sessionTerm=>sessionTerm.Term)
                .SingleOrDefault(sessionTerm=> sessionTerm.Id == id);
            
            if (sessionTermInDb == null)
                return NotFound();

            var sessionTermViewModel = new SessionTermViewModel
            {
                Terms = _context.Terms.ToList(),
                Sessions = _context.Sessions.ToList(),
                SessionTerm = sessionTermInDb
            };


            return View(sessionTermViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTerm(int id, SessionTermViewModel sessionTermViewModel)
        {
            var sessionTermInDb = await _context.SessionTerms.FindAsync(id);
            sessionTermInDb.SessionId = sessionTermViewModel.SessionTerm.SessionId;
            sessionTermInDb.TermId = sessionTermViewModel.SessionTerm.TermId;

            await _context.SaveChangesAsync();

            TempData["SessionTermSaved"] = Constant.Updated;

            return RedirectToAction("Terms");
        }

        public IActionResult SetCurrentSessionTerm()
        {
            var sessionTermViewModel = new SessionTermViewModel
            {
                Terms = _context.Terms.ToList(),
                Sessions = _context.Sessions.ToList()
            };
            return View(sessionTermViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetCurrentSessionTerm(SessionTermViewModel sessionTermViewModel)
        {
            if (ModelState.IsValid)
            {
                await ResetPreviousSessionTerms();
                sessionTermViewModel.SessionTerm.IsCurrent = true;
                await _context.SessionTerms.AddAsync(sessionTermViewModel.SessionTerm);
                await _context.SaveChangesAsync();

                TempData["SessionTermSaved"] = Constant.Saved;

                return RedirectToAction("Terms");
            }

            return View(sessionTermViewModel);
        }

        private async Task ResetPreviousSessionTerms()
        {
            if (_context.SessionTerms.Any())
            {
                var sessionTerms = await _context.SessionTerms.ToListAsync();

                foreach (var sessionTerm in sessionTerms)
                {
                    sessionTerm.IsCurrent = false;
                }

               await  _context.SaveChangesAsync();
            }

        }
        private async Task ResetPreviousSessions()
        {
            if (_context.Sessions.Any())
            {
                var sessions = await _context.SessionTerms.ToListAsync();

                foreach (var session in sessions)
                {
                    session.IsCurrent = false;
                }

               await  _context.SaveChangesAsync();
            }

        }
        private async Task ResetStudentPromotions()
        {
            if (_context.Students.Any())
            {
                var students = await _context.Students
                    .Where(s=>s.Graduated == false)
                    .ToListAsync();

                foreach (var student in students)
                {
                    student.Promoted = false;
                }

               await  _context.SaveChangesAsync();
            }

        }
    }
}