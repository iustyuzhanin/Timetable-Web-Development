using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Timetable.DataAccessLayer;
using Timetable.Models;
using Twilio;

namespace Timetable.Controllers
{
    //[Authorize(Roles = "Admin")]
    //[Authorize]
    public class AdminController : Controller
    {
        private UserManager<AppUserModel> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        public List<IdentityRole> listRole()
        {
            List<IdentityRole> positions = new List<IdentityRole>();

            foreach (var role in _roleManager.Roles)
            {
                positions.Add(role);
            }

            return positions;
        }

        public AdminController(UserManager<AppUserModel> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        public IActionResult Create()
        {
            ViewBag.Positions = new SelectList(listRole());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AppUserCreateModel model)
        {
            if (ModelState.IsValid)
            {
                AppUserModel user = new AppUserModel()
                {
                    UserName = model.Name,
                    Email = model.Email,
                    Position = model.Position,
                    FullName = model.FullName
                };

                IdentityResult resultCreate = await _userManager.CreateAsync(user, model.Password);
                IdentityResult resultAddToRole = await _userManager.AddToRoleAsync(user, model.Position);
                if (resultCreate.Succeeded && resultAddToRole.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in resultCreate.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    foreach (var error in resultAddToRole.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            ViewBag.Positions = new SelectList(listRole());

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AppUserModel model)
        {
            ViewBag.Positions = new SelectList(listRole());
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);

                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Position = model.Position;
                user.FullName = model.FullName;

                IdentityResult resultEdit = await _userManager.UpdateAsync(user);
                IdentityResult resultAddToRole = await _userManager.AddToRoleAsync(user, model.Position);
                await _context.SaveChangesAsync();

                if (resultEdit.Succeeded && resultAddToRole.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in resultEdit.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id!=null)
            {
                AppUserModel user = await _userManager.FindByIdAsync(id);
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Profile(string name)
        {
            AppUserModel user = await _userManager.FindByNameAsync(name);

            return View(user);
        }

    }
}
