using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Models.Utility;
using StudentEvaluationSystem.Models.ViewModels;
using StudentEvaluationSystem.Utility;

namespace StudentEvaluationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = Constant.AdminUser)]
    public class RegistrationController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<ApplicationUser> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;
        private readonly DataBaseQueries _dataBaseQueries;

        public RegistrationController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<ApplicationUser> logger,
            IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
            _dataBaseQueries = new DataBaseQueries(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Teacher()
        {
            return View();
        }
        public IActionResult Student()
        {
            var registrationViewModel = new StudentRegistrationViewModel
            {
                AvailableClasses = _dataBaseQueries.GetAvailableClasses()
        };

            return View(registrationViewModel);
        }

        public IActionResult TeacherStudent()
        {
            var teacherStudentRegistrationViewModel = new TeacherStudentRegistrationViewModel
            {
                StudentRegistrationViewModel = new StudentRegistrationViewModel
                {
                    AvailableClasses = _dataBaseQueries.GetAvailableClasses()
                }


            };

            return View(teacherStudentRegistrationViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Teacher(TeacherRegistration registration)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {
                    UserName = registration.Email,
                    Email = registration.Email,
                    PhoneNumber = registration.PhoneNumber,
                    
                };

                var result = await _userManager.CreateAsync(user, registration.Password);

                if (result.Succeeded)
                {
                    await AssignRoleToTeacherAsync(user, registration);
                    await SaveTeacherToDataBaseAsync(user, registration);

                    TempData["TeacherSaved"] = Constant.Saved;

                    return RedirectToAction("Index", "Teachers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(registration);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Student(StudentRegistrationViewModel registrationViewModel)
        {
                var user = new ApplicationUser
                {
                    UserName = registrationViewModel.StudentRegistration.Email,
                    Email = registrationViewModel.StudentRegistration.Email,
                    PhoneNumber = registrationViewModel.StudentRegistration.PhoneNumber,

                };

                var result = await _userManager.CreateAsync(user, 
                    registrationViewModel.StudentRegistration.Password);

                if (result.Succeeded)
                {
                    await SaveStudentToDataBaseAsync(user, registrationViewModel.StudentRegistration);

                    TempData["StudentSaved"] = Constant.Saved;

                    return RedirectToAction("Index", "Students");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                
            return View(registrationViewModel);
        }

        public async Task AssignRoleToStudentAsync(ApplicationUser user, StudentRegistration registration)
        {
            if (!await _roleManager.RoleExistsAsync(Constant.AdminUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(Constant.AdminUser));
            }

            if (!await _roleManager.RoleExistsAsync(Constant.RegularUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(Constant.RegularUser));
            }

            if (registration.IsAdmin)
            {
                await _userManager.AddToRoleAsync(user, Constant.AdminUser);
            }

            else
            {
                await _userManager.AddToRoleAsync(user, Constant.RegularUser);
            }
        }

        public async Task SaveStudentToDataBaseAsync(ApplicationUser user, StudentRegistration registration)
        {
            var student = new Student
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                DateOfBirth = registration.DateOfBirth,
                Sex = registration.Sex,
                StateOfOrigin = registration.StateOfOrigin,
                PhoneNumber = registration.PhoneNumber,
                Religion = registration.Religion,
                NameOfGuardianOrParent= registration.NameOfGuardianOrParent,
                PermanentAddress = registration.PermanentAddress,
                YearOfEntry = DateTime.Now.Year.ToString(),
                ClassOfEntryId = registration.ClassOfEntryId,
                CurrentClassId = registration.ClassOfEntryId,
                UserId = user.Id
            };

            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();

        }

        public async Task AssignRoleToTeacherAsync(ApplicationUser user, TeacherRegistration registration)
        {
            if (!await _roleManager.RoleExistsAsync(Constant.AdminUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(Constant.AdminUser));
            }

            if (!await _roleManager.RoleExistsAsync(Constant.RegularUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(Constant.RegularUser));
            }

            if (registration.IsAdmin)
            {
                await _userManager.AddToRoleAsync(user, Constant.AdminUser);
            }

            else
            {
                await _userManager.AddToRoleAsync(user, Constant.RegularUser);
            }
        }

        public async Task SaveTeacherToDataBaseAsync(ApplicationUser user, TeacherRegistration registration)
        {
            var teacher = new Teacher
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                Bio = registration.Bio,
                Address = registration.Address,
                UserId = user.Id,
                PhoneNumber = registration.PhoneNumber
            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

        }
    }
}