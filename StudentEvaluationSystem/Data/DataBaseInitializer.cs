using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Utility;
using System;
using System.Linq;

namespace StudentEvaluationSystem.Data
{
    public class DataBaseInitializer : IDataBaseInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DataBaseInitializer(ApplicationDbContext context, 
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async void Initialize()
        {
            if (_context.Database.GetPendingMigrations().Count() > 0)
                _context.Database.Migrate();

            if (_context.Roles.Any(r => r.Name == Constant.AdminUser)) return;

            await _roleManager.CreateAsync(new IdentityRole(Constant.AdminUser));
            await _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            },"Admin123*");

            await _userManager.AddToRoleAsync(await _userManager.FindByEmailAsync("admin@gmail.com"), Constant.AdminUser);
        }
    }
}
