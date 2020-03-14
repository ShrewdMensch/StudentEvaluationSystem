using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models.ViewModels;
using StudentEvaluationSystem.Utility;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students
                .Include(s=>s.ClassOfEntry)
                .Include(s=>s.CurrentClass)
                .ToListAsync();

            return View(students);
        }

        //Edit Get
        public IActionResult Edit(int id)
        {
            var student = _context.Students
                .Include(s=>s.CurrentClass)
                .Include(s=>s.ClassOfEntry)
                .SingleOrDefault(s=>s.Id == id);

            if(student != null)
            {
                var studentViewModel = new StudentViewModel
                {
                    Student = student,
                    AvailableClasses = _context.Classes.Select(c => new SelectListItem()
                    {
                        Text = c.Name + " - " + c.Category,
                        Value = c.Id.ToString()
                    })
                };

                return View(studentViewModel);
            }
            

            return BadRequest();
        }
        
        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel studentViewModel)
        {
            var studentInDB = await _context.Students.FindAsync(id);

            studentInDB.FirstName = studentViewModel.Student.FirstName;
            studentInDB.LastName = studentViewModel.Student.LastName;
            studentInDB.ClassOfEntryId = studentViewModel.Student.ClassOfEntryId;
            studentInDB.DateOfBirth = studentViewModel.Student.DateOfBirth;
            studentInDB.PhoneNumber = studentViewModel.Student.PhoneNumber;
            studentInDB.PermanentAddress = studentViewModel.Student.PermanentAddress;
            studentInDB.Sex = studentViewModel.Student.Sex;
            studentInDB.StateOfOrigin = studentViewModel.Student.StateOfOrigin;
            studentInDB.Religion = studentViewModel.Student.Religion;
            studentInDB.NameOfGuardianOrParent = studentViewModel.Student.NameOfGuardianOrParent;

            await _context.SaveChangesAsync();

            TempData["StudentSaved"] = Constant.Updated;

            TempData.Keep();

            return RedirectToAction("Index");
        }
    }
}