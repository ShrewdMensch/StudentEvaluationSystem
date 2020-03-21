using System;
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
    [Authorize(Roles=Constant.AdminUser)]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _context.ApplicationUsers.ToListAsync();

            return View(users);
        }

        public async Task<IActionResult> Lock(string id)
        {
            var userInDb = await _context.ApplicationUsers.SingleOrDefaultAsync(u => u.Id == id);

            if (userInDb != null)
            {
                userInDb.LockoutEnd = DateTime.Now.AddYears(1000);

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return NotFound();
        }
        public async Task<IActionResult> Unlock(string id)
        {
            var userInDb = await _context.ApplicationUsers.SingleOrDefaultAsync(u => u.Id == id);

            if (userInDb != null)
            {
                userInDb.LockoutEnd = DateTime.Now;

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return NotFound();
        }
       
    }
}